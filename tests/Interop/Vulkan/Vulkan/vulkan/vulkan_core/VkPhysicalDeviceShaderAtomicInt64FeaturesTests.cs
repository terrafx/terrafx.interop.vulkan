// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceShaderAtomicInt64Features" /> struct.</summary>
    public static unsafe partial class VkPhysicalDeviceShaderAtomicInt64FeaturesTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicInt64Features" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceShaderAtomicInt64Features>(), Is.EqualTo(sizeof(VkPhysicalDeviceShaderAtomicInt64Features)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicInt64Features" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceShaderAtomicInt64Features).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceShaderAtomicInt64Features" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceShaderAtomicInt64Features), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceShaderAtomicInt64Features), Is.EqualTo(16));
            }
        }
    }
}
