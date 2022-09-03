// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkRect2D" /> struct.</summary>
public static unsafe partial class VkRect2DTests
{
    /// <summary>Validates that the <see cref="VkRect2D" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkRect2D>(), Is.EqualTo(sizeof(VkRect2D)));
    }

    /// <summary>Validates that the <see cref="VkRect2D" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkRect2D).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkRect2D" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VkRect2D), Is.EqualTo(16));
    }
}
