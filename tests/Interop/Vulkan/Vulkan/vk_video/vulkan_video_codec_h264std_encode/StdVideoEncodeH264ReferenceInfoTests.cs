// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="StdVideoEncodeH264ReferenceInfo" /> struct.</summary>
public static unsafe partial class StdVideoEncodeH264ReferenceInfoTests
{
    /// <summary>Validates that the <see cref="StdVideoEncodeH264ReferenceInfo" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<StdVideoEncodeH264ReferenceInfo>(), Is.EqualTo(sizeof(StdVideoEncodeH264ReferenceInfo)));
    }

    /// <summary>Validates that the <see cref="StdVideoEncodeH264ReferenceInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoEncodeH264ReferenceInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="StdVideoEncodeH264ReferenceInfo" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoEncodeH264ReferenceInfo), Is.EqualTo(16));
    }
}
