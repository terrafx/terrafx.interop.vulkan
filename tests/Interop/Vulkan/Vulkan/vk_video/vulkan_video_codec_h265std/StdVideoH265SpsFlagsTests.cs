// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoH265SpsFlags" /> struct.</summary>
    public static unsafe partial class StdVideoH265SpsFlagsTests
    {
        /// <summary>Validates that the <see cref="StdVideoH265SpsFlags" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoH265SpsFlags>(), Is.EqualTo(sizeof(StdVideoH265SpsFlags)));
        }

        /// <summary>Validates that the <see cref="StdVideoH265SpsFlags" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoH265SpsFlags).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoH265SpsFlags" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(StdVideoH265SpsFlags), Is.EqualTo(4));
        }
    }
}
