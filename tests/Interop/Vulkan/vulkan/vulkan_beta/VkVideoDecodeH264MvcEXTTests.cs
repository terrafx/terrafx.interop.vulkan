// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoDecodeH264MvcEXT" /> struct.</summary>
    public static unsafe class VkVideoDecodeH264MvcEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoDecodeH264MvcEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoDecodeH264MvcEXT>(), Is.EqualTo(sizeof(VkVideoDecodeH264MvcEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH264MvcEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoDecodeH264MvcEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoDecodeH264MvcEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoDecodeH264MvcEXT), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkVideoDecodeH264MvcEXT), Is.EqualTo(12));
            }
        }
    }
}
