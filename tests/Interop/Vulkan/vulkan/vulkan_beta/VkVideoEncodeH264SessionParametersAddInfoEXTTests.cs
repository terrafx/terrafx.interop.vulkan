// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoEncodeH264SessionParametersAddInfoEXT" /> struct.</summary>
    public static unsafe class VkVideoEncodeH264SessionParametersAddInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionParametersAddInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoEncodeH264SessionParametersAddInfoEXT>(), Is.EqualTo(sizeof(VkVideoEncodeH264SessionParametersAddInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionParametersAddInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoEncodeH264SessionParametersAddInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionParametersAddInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoEncodeH264SessionParametersAddInfoEXT), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkVideoEncodeH264SessionParametersAddInfoEXT), Is.EqualTo(24));
            }
        }
    }
}
