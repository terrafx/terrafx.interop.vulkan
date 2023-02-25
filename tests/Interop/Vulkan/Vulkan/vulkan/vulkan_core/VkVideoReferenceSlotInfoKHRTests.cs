// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkVideoReferenceSlotInfoKHR" /> struct.</summary>
public static unsafe partial class VkVideoReferenceSlotInfoKHRTests
{
    /// <summary>Validates that the <see cref="VkVideoReferenceSlotInfoKHR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkVideoReferenceSlotInfoKHR>(), Is.EqualTo(sizeof(VkVideoReferenceSlotInfoKHR)));
    }

    /// <summary>Validates that the <see cref="VkVideoReferenceSlotInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkVideoReferenceSlotInfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkVideoReferenceSlotInfoKHR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkVideoReferenceSlotInfoKHR), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(VkVideoReferenceSlotInfoKHR), Is.EqualTo(16));
        }
    }
}
