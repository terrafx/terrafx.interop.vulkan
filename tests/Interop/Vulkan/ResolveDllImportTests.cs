// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

#pragma warning disable IL2026
#pragma warning disable IL2072

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation that the <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
public static unsafe partial class ResolveDllImportTests
{
    /// <summary>Validates that thhe <see cref="DllImportAttribute" /> attributed methods can be resolved.</summary>
    [Test]
    [Platform("Linux")]
    [Platform("Win32")]
    public static void ResolveDllImportTest()
    {
        Assert.Multiple(() => {
            var assembly = typeof(Vulkan).Assembly;
            ProcessAssembly(assembly);
        });
    }

    private static void ProcessAssembly(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            ProcessType(type);
        }
    }

    private static void ProcessMethod(MethodInfo method)
    {
        if (!method.Attributes.HasFlag(MethodAttributes.PinvokeImpl))
        {
            return;
        }

        try
        {
            Marshal.Prelink(method);
        }
        catch (Exception exception)
        {
            if (OperatingSystem.IsWindows() && (Environment.GetEnvironmentVariable("GITHUB_RUN_ID") is not null))
            {
                // This isn't good practice, but current CI can't really install and have the Vulkan SDK be
                // available, so the tests fail. We want local testing to do the right thing still, however.
                Assert.Warn($"Warn: {exception.Message}");
            }
            else
            {
                Assert.Fail($"Fail: {exception.Message}");
            }

            throw;
        }
    }

    private static void ProcessType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods | DynamicallyAccessedMemberTypes.PublicNestedTypes | DynamicallyAccessedMemberTypes.NonPublicNestedTypes)] Type type)
    {
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            ProcessMethod(method);
        }

        foreach (var nestedType in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
        {
            ProcessType(nestedType);
        }
    }
}
