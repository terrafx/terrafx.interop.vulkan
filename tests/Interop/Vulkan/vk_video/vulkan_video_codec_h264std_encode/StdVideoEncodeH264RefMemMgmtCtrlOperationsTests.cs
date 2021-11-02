// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoEncodeH264RefMemMgmtCtrlOperations" /> struct.</summary>
    public static unsafe partial class StdVideoEncodeH264RefMemMgmtCtrlOperationsTests
    {
        /// <summary>Validates that the <see cref="StdVideoEncodeH264RefMemMgmtCtrlOperations" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoEncodeH264RefMemMgmtCtrlOperations>(), Is.EqualTo(sizeof(StdVideoEncodeH264RefMemMgmtCtrlOperations)));
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH264RefMemMgmtCtrlOperations" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoEncodeH264RefMemMgmtCtrlOperations).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH264RefMemMgmtCtrlOperations" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(StdVideoEncodeH264RefMemMgmtCtrlOperations), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(StdVideoEncodeH264RefMemMgmtCtrlOperations), Is.EqualTo(28));
            }
        }
    }
}
