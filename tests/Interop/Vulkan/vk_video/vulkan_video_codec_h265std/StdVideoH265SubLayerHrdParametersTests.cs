// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoH265SubLayerHrdParameters" /> struct.</summary>
    public static unsafe class StdVideoH265SubLayerHrdParametersTests
    {
        /// <summary>Validates that the <see cref="StdVideoH265SubLayerHrdParameters" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoH265SubLayerHrdParameters>(), Is.EqualTo(sizeof(StdVideoH265SubLayerHrdParameters)));
        }

        /// <summary>Validates that the <see cref="StdVideoH265SubLayerHrdParameters" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoH265SubLayerHrdParameters).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoH265SubLayerHrdParameters" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(StdVideoH265SubLayerHrdParameters), Is.EqualTo(516));
        }
    }
}
