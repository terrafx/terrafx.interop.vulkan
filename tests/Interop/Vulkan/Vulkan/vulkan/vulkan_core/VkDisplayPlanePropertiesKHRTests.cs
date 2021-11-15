// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkDisplayPlanePropertiesKHR" /> struct.</summary>
    public static unsafe partial class VkDisplayPlanePropertiesKHRTests
    {
        /// <summary>Validates that the <see cref="VkDisplayPlanePropertiesKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkDisplayPlanePropertiesKHR>(), Is.EqualTo(sizeof(VkDisplayPlanePropertiesKHR)));
        }

        /// <summary>Validates that the <see cref="VkDisplayPlanePropertiesKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkDisplayPlanePropertiesKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkDisplayPlanePropertiesKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkDisplayPlanePropertiesKHR), Is.EqualTo(16));
        }
    }
}
