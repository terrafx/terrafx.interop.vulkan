// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoEncodeH264SessionCreateInfoEXT" /> struct.</summary>
    public static unsafe class VkVideoEncodeH264SessionCreateInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionCreateInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoEncodeH264SessionCreateInfoEXT>(), Is.EqualTo(sizeof(VkVideoEncodeH264SessionCreateInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionCreateInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoEncodeH264SessionCreateInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264SessionCreateInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoEncodeH264SessionCreateInfoEXT), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkVideoEncodeH264SessionCreateInfoEXT), Is.EqualTo(24));
            }
        }
    }
}
