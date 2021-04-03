// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkDeviceMemoryOverallocationCreateInfoAMD" /> struct.</summary>
    public static unsafe class VkDeviceMemoryOverallocationCreateInfoAMDTests
    {
        /// <summary>Validates that the <see cref="VkDeviceMemoryOverallocationCreateInfoAMD" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkDeviceMemoryOverallocationCreateInfoAMD>(), Is.EqualTo(sizeof(VkDeviceMemoryOverallocationCreateInfoAMD)));
        }

        /// <summary>Validates that the <see cref="VkDeviceMemoryOverallocationCreateInfoAMD" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkDeviceMemoryOverallocationCreateInfoAMD).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkDeviceMemoryOverallocationCreateInfoAMD" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkDeviceMemoryOverallocationCreateInfoAMD), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkDeviceMemoryOverallocationCreateInfoAMD), Is.EqualTo(12));
            }
        }
    }
}
