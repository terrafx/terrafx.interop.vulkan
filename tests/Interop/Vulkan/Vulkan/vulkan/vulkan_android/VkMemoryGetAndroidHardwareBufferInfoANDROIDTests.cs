// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID" /> struct.</summary>
    public static unsafe partial class VkMemoryGetAndroidHardwareBufferInfoANDROIDTests
    {
        /// <summary>Validates that the <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkMemoryGetAndroidHardwareBufferInfoANDROID>(), Is.EqualTo(sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID)));
        }

        /// <summary>Validates that the <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkMemoryGetAndroidHardwareBufferInfoANDROID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkMemoryGetAndroidHardwareBufferInfoANDROID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkMemoryGetAndroidHardwareBufferInfoANDROID), Is.EqualTo(16));
            }
        }
    }
}
