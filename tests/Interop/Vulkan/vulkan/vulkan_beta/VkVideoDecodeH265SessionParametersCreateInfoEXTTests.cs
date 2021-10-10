// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoDecodeH265SessionParametersCreateInfoEXT" /> struct.</summary>
    public static unsafe class VkVideoDecodeH265SessionParametersCreateInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersCreateInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoDecodeH265SessionParametersCreateInfoEXT>(), Is.EqualTo(sizeof(VkVideoDecodeH265SessionParametersCreateInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersCreateInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoDecodeH265SessionParametersCreateInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH265SessionParametersCreateInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoDecodeH265SessionParametersCreateInfoEXT), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkVideoDecodeH265SessionParametersCreateInfoEXT), Is.EqualTo(20));
            }
        }
    }
}
