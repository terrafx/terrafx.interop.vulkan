// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2021-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VpProfileProperties" /> struct.</summary>
public static unsafe partial class VpProfilePropertiesTests
{
    /// <summary>Validates that the <see cref="VpProfileProperties" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VpProfileProperties>(), Is.EqualTo(sizeof(VpProfileProperties)));
    }

    /// <summary>Validates that the <see cref="VpProfileProperties" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VpProfileProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VpProfileProperties" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VpProfileProperties), Is.EqualTo(260));
    }
}
