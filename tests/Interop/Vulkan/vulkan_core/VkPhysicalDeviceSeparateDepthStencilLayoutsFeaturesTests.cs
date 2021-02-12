// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures" /> struct.</summary>
    public static unsafe class VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures>(), Is.EqualTo(sizeof(VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures), Is.EqualTo(12));
            }
        }
    }
}
