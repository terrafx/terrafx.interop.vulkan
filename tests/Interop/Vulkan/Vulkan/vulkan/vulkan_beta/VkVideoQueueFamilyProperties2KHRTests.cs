// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkVideoQueueFamilyProperties2KHR" /> struct.</summary>
public static unsafe partial class VkVideoQueueFamilyProperties2KHRTests
{
    /// <summary>Validates that the <see cref="VkVideoQueueFamilyProperties2KHR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkVideoQueueFamilyProperties2KHR>(), Is.EqualTo(sizeof(VkVideoQueueFamilyProperties2KHR)));
    }

    /// <summary>Validates that the <see cref="VkVideoQueueFamilyProperties2KHR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkVideoQueueFamilyProperties2KHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkVideoQueueFamilyProperties2KHR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkVideoQueueFamilyProperties2KHR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(VkVideoQueueFamilyProperties2KHR), Is.EqualTo(12));
        }
    }
}
