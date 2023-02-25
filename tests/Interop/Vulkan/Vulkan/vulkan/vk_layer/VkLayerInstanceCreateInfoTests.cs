// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkLayerInstanceCreateInfo" /> struct.</summary>
public static unsafe partial class VkLayerInstanceCreateInfoTests
{
    /// <summary>Validates that the <see cref="VkLayerInstanceCreateInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkLayerInstanceCreateInfo>(), Is.EqualTo(sizeof(VkLayerInstanceCreateInfo)));
    }

    /// <summary>Validates that the <see cref="VkLayerInstanceCreateInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkLayerInstanceCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkLayerInstanceCreateInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkLayerInstanceCreateInfo), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(VkLayerInstanceCreateInfo), Is.EqualTo(20));
        }
    }
}
