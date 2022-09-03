// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="StdVideoEncodeH265SliceSegmentHeaderFlags" /> struct.</summary>
public static unsafe partial class StdVideoEncodeH265SliceSegmentHeaderFlagsTests
{
    /// <summary>Validates that the <see cref="StdVideoEncodeH265SliceSegmentHeaderFlags" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<StdVideoEncodeH265SliceSegmentHeaderFlags>(), Is.EqualTo(sizeof(StdVideoEncodeH265SliceSegmentHeaderFlags)));
    }

    /// <summary>Validates that the <see cref="StdVideoEncodeH265SliceSegmentHeaderFlags" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoEncodeH265SliceSegmentHeaderFlags).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="StdVideoEncodeH265SliceSegmentHeaderFlags" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoEncodeH265SliceSegmentHeaderFlags), Is.EqualTo(4));
    }
}
