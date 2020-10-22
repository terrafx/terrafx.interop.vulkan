// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImageResolve2KHR" /> struct.</summary>
    public static unsafe class VkImageResolve2KHRTests
    {
        /// <summary>Validates that the <see cref="VkImageResolve2KHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImageResolve2KHR>(), Is.EqualTo(sizeof(VkImageResolve2KHR)));
        }

        /// <summary>Validates that the <see cref="VkImageResolve2KHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImageResolve2KHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImageResolve2KHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImageResolve2KHR), Is.EqualTo(88));
            }
            else
            {
                Assert.That(sizeof(VkImageResolve2KHR), Is.EqualTo(76));
            }
        }
    }
}
