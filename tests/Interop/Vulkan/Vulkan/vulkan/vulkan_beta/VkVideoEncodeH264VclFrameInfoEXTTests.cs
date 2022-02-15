// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoEncodeH264VclFrameInfoEXT" /> struct.</summary>
    public static unsafe partial class VkVideoEncodeH264VclFrameInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoEncodeH264VclFrameInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoEncodeH264VclFrameInfoEXT>(), Is.EqualTo(sizeof(VkVideoEncodeH264VclFrameInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264VclFrameInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoEncodeH264VclFrameInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264VclFrameInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoEncodeH264VclFrameInfoEXT), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(VkVideoEncodeH264VclFrameInfoEXT), Is.EqualTo(36));
            }
        }
    }
}
