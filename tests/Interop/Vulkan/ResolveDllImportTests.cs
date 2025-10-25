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
    [Platform("Linux,Win32")]
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

#pragma warning disable CA1031 // Do not catch general exception types
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
                switch (method.Name)
                {
                    case "vkCmdBindDescriptorSets2":
                    case "vkCmdBindIndexBuffer2":
                    case "vkCmdPushConstants2":
                    case "vkCmdPushDescriptorSet":
                    case "vkCmdPushDescriptorSet2":
                    case "vkCmdPushDescriptorSetWithTemplate":
                    case "vkCmdPushDescriptorSetWithTemplate2":
                    case "vkCmdSetLineStipple":
                    case "vkCmdSetRenderingAttachmentLocations":
                    case "vkCmdSetRenderingInputAttachmentIndices":
                    case "vkCopyImageToImage":
                    case "vkCopyImageToMemory":
                    case "vkCopyMemoryToImage":
                    case "vkGetDeviceImageSubresourceLayout":
                    case "vkGetImageSubresourceLayout2":
                    case "vkGetRenderingAreaGranularity":
                    case "vkMapMemory2":
                    case "vkTransitionImageLayout":
                    case "vkUnmapMemory2":
                    {
                        // CI may not have Vulkan v1.4 yet
                        Assert.Warn($"Warn: {exception.Message}");
                        break;
                    }

                    default:
                    {
                        Assert.Fail($"Fail: {exception.Message}");
                        break;
                    }
                }
            }
        }
    }
#pragma warning restore CA1031 // Do not catch general exception types

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
