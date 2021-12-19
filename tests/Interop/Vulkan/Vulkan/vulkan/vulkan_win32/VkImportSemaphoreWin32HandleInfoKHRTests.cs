// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImportSemaphoreWin32HandleInfoKHR" /> struct.</summary>
    public static unsafe partial class VkImportSemaphoreWin32HandleInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkImportSemaphoreWin32HandleInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImportSemaphoreWin32HandleInfoKHR>(), Is.EqualTo(sizeof(VkImportSemaphoreWin32HandleInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkImportSemaphoreWin32HandleInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImportSemaphoreWin32HandleInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImportSemaphoreWin32HandleInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImportSemaphoreWin32HandleInfoKHR), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkImportSemaphoreWin32HandleInfoKHR), Is.EqualTo(32));
            }
        }
    }
}
