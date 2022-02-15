// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceIndexTypeUint8FeaturesEXT" /> struct.</summary>
    public static unsafe partial class VkPhysicalDeviceIndexTypeUint8FeaturesEXTTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceIndexTypeUint8FeaturesEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceIndexTypeUint8FeaturesEXT>(), Is.EqualTo(sizeof(VkPhysicalDeviceIndexTypeUint8FeaturesEXT)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceIndexTypeUint8FeaturesEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceIndexTypeUint8FeaturesEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceIndexTypeUint8FeaturesEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceIndexTypeUint8FeaturesEXT), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceIndexTypeUint8FeaturesEXT), Is.EqualTo(12));
            }
        }
    }
}
