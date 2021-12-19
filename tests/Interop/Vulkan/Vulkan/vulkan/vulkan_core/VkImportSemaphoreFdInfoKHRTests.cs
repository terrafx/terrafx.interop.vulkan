// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImportSemaphoreFdInfoKHR" /> struct.</summary>
    public static unsafe partial class VkImportSemaphoreFdInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkImportSemaphoreFdInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImportSemaphoreFdInfoKHR>(), Is.EqualTo(sizeof(VkImportSemaphoreFdInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkImportSemaphoreFdInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImportSemaphoreFdInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImportSemaphoreFdInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImportSemaphoreFdInfoKHR), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkImportSemaphoreFdInfoKHR), Is.EqualTo(32));
            }
        }
    }
}
