// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImportAndroidHardwareBufferInfoANDROID" /> struct.</summary>
    public static unsafe partial class VkImportAndroidHardwareBufferInfoANDROIDTests
    {
        /// <summary>Validates that the <see cref="VkImportAndroidHardwareBufferInfoANDROID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImportAndroidHardwareBufferInfoANDROID>(), Is.EqualTo(sizeof(VkImportAndroidHardwareBufferInfoANDROID)));
        }

        /// <summary>Validates that the <see cref="VkImportAndroidHardwareBufferInfoANDROID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImportAndroidHardwareBufferInfoANDROID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImportAndroidHardwareBufferInfoANDROID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImportAndroidHardwareBufferInfoANDROID), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkImportAndroidHardwareBufferInfoANDROID), Is.EqualTo(12));
            }
        }
    }
}
