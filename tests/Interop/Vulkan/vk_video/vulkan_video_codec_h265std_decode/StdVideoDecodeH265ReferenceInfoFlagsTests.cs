// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoDecodeH265ReferenceInfoFlags" /> struct.</summary>
    public static unsafe class StdVideoDecodeH265ReferenceInfoFlagsTests
    {
        /// <summary>Validates that the <see cref="StdVideoDecodeH265ReferenceInfoFlags" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoDecodeH265ReferenceInfoFlags>(), Is.EqualTo(sizeof(StdVideoDecodeH265ReferenceInfoFlags)));
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH265ReferenceInfoFlags" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoDecodeH265ReferenceInfoFlags).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH265ReferenceInfoFlags" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(StdVideoDecodeH265ReferenceInfoFlags), Is.EqualTo(4));
        }
    }
}
