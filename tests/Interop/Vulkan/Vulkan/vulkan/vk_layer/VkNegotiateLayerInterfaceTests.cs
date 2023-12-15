// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkNegotiateLayerInterface" /> struct.</summary>
public static unsafe partial class VkNegotiateLayerInterfaceTests
{
    /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkNegotiateLayerInterface>(), Is.EqualTo(sizeof(VkNegotiateLayerInterface)));
    }

    /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkNegotiateLayerInterface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkNegotiateLayerInterface), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(VkNegotiateLayerInterface), Is.EqualTo(24));
        }
    }
}
