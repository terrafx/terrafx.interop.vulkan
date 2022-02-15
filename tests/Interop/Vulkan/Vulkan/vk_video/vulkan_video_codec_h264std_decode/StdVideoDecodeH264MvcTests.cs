// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2019-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoDecodeH264Mvc" /> struct.</summary>
    public static unsafe partial class StdVideoDecodeH264MvcTests
    {
        /// <summary>Validates that the <see cref="StdVideoDecodeH264Mvc" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoDecodeH264Mvc>(), Is.EqualTo(sizeof(StdVideoDecodeH264Mvc)));
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH264Mvc" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoDecodeH264Mvc).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoDecodeH264Mvc" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(StdVideoDecodeH264Mvc), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(StdVideoDecodeH264Mvc), Is.EqualTo(12));
            }
        }
    }
}
