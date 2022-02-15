// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkSurfaceCapabilitiesKHR" /> struct.</summary>
    public static unsafe partial class VkSurfaceCapabilitiesKHRTests
    {
        /// <summary>Validates that the <see cref="VkSurfaceCapabilitiesKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkSurfaceCapabilitiesKHR>(), Is.EqualTo(sizeof(VkSurfaceCapabilitiesKHR)));
        }

        /// <summary>Validates that the <see cref="VkSurfaceCapabilitiesKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkSurfaceCapabilitiesKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkSurfaceCapabilitiesKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkSurfaceCapabilitiesKHR), Is.EqualTo(52));
        }
    }
}
