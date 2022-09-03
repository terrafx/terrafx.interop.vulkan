// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkVertexInputBindingDescription" /> struct.</summary>
public static unsafe partial class VkVertexInputBindingDescriptionTests
{
    /// <summary>Validates that the <see cref="VkVertexInputBindingDescription" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkVertexInputBindingDescription>(), Is.EqualTo(sizeof(VkVertexInputBindingDescription)));
    }

    /// <summary>Validates that the <see cref="VkVertexInputBindingDescription" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkVertexInputBindingDescription).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkVertexInputBindingDescription" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VkVertexInputBindingDescription), Is.EqualTo(12));
    }
}
