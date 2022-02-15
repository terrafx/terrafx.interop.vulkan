// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h265std_encode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="StdVideoEncodeH265ReferenceModificationFlags" /> struct.</summary>
    public static unsafe partial class StdVideoEncodeH265ReferenceModificationFlagsTests
    {
        /// <summary>Validates that the <see cref="StdVideoEncodeH265ReferenceModificationFlags" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<StdVideoEncodeH265ReferenceModificationFlags>(), Is.EqualTo(sizeof(StdVideoEncodeH265ReferenceModificationFlags)));
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH265ReferenceModificationFlags" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(StdVideoEncodeH265ReferenceModificationFlags).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="StdVideoEncodeH265ReferenceModificationFlags" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(StdVideoEncodeH265ReferenceModificationFlags), Is.EqualTo(4));
        }
    }
}
