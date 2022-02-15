// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoEncodeH264SliceHeader" /> struct.</summary>
    public static unsafe partial class StdVideoEncodeH264SliceHeaderTests
    {
        /// <summary>Validates that the <see cref="StdVideoEncodeH264SliceHeader" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoEncodeH264SliceHeader>(), Is.EqualTo(sizeof(StdVideoEncodeH264SliceHeader)));
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH264SliceHeader" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoEncodeH264SliceHeader).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH264SliceHeader" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(StdVideoEncodeH264SliceHeader), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(StdVideoEncodeH264SliceHeader), Is.EqualTo(32));
            }
        }
    }
}
