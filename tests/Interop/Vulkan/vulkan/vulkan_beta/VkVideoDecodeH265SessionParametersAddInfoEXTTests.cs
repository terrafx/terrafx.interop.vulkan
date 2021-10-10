// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoDecodeH265SessionParametersAddInfoEXT" /> struct.</summary>
    public static unsafe class VkVideoDecodeH265SessionParametersAddInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersAddInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoDecodeH265SessionParametersAddInfoEXT>(), Is.EqualTo(sizeof(VkVideoDecodeH265SessionParametersAddInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersAddInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoDecodeH265SessionParametersAddInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersAddInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoDecodeH265SessionParametersAddInfoEXT), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkVideoDecodeH265SessionParametersAddInfoEXT), Is.EqualTo(24));
            }
        }
    }
}
