// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkCopyImageInfo2KHR" /> struct.</summary>
    public static unsafe class VkCopyImageInfo2KHRTests
    {
        /// <summary>Validates that the <see cref="VkCopyImageInfo2KHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkCopyImageInfo2KHR>(), Is.EqualTo(sizeof(VkCopyImageInfo2KHR)));
        }

        /// <summary>Validates that the <see cref="VkCopyImageInfo2KHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkCopyImageInfo2KHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkCopyImageInfo2KHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkCopyImageInfo2KHR), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(VkCopyImageInfo2KHR), Is.EqualTo(48));
            }
        }
    }
}
