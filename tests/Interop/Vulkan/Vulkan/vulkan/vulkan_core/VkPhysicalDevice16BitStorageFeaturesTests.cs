// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDevice16BitStorageFeatures" /> struct.</summary>
    public static unsafe partial class VkPhysicalDevice16BitStorageFeaturesTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDevice16BitStorageFeatures" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDevice16BitStorageFeatures>(), Is.EqualTo(sizeof(VkPhysicalDevice16BitStorageFeatures)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDevice16BitStorageFeatures" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDevice16BitStorageFeatures).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDevice16BitStorageFeatures" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDevice16BitStorageFeatures), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDevice16BitStorageFeatures), Is.EqualTo(24));
            }
        }
    }
}
