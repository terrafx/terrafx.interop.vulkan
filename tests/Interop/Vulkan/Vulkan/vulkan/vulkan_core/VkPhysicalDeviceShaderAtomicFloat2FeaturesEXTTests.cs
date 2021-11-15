// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT" /> struct.</summary>
    public static unsafe partial class VkPhysicalDeviceShaderAtomicFloat2FeaturesEXTTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT>(), Is.EqualTo(sizeof(VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT), Is.EqualTo(56));
            }
        }
    }
}
