// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkDeviceOrHostAddressKHR" /> struct.</summary>
    public static unsafe class VkDeviceOrHostAddressKHRTests
    {
        /// <summary>Validates that the <see cref="VkDeviceOrHostAddressKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkDeviceOrHostAddressKHR>(), Is.EqualTo(sizeof(VkDeviceOrHostAddressKHR)));
        }

        /// <summary>Validates that the <see cref="VkDeviceOrHostAddressKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(VkDeviceOrHostAddressKHR).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="VkDeviceOrHostAddressKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkDeviceOrHostAddressKHR), Is.EqualTo(8));
        }
    }
}
