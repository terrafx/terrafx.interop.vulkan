// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoH265SequenceParameterSetVui" /> struct.</summary>
    public static unsafe class StdVideoH265SequenceParameterSetVuiTests
    {
        /// <summary>Validates that the <see cref="StdVideoH265SequenceParameterSetVui" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoH265SequenceParameterSetVui>(), Is.EqualTo(sizeof(StdVideoH265SequenceParameterSetVui)));
        }

        /// <summary>Validates that the <see cref="StdVideoH265SequenceParameterSetVui" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoH265SequenceParameterSetVui).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoH265SequenceParameterSetVui" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(StdVideoH265SequenceParameterSetVui), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(StdVideoH265SequenceParameterSetVui), Is.EqualTo(48));
            }
        }
    }
}
