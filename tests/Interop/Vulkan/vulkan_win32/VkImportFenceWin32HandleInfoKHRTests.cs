// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImportFenceWin32HandleInfoKHR" /> struct.</summary>
    public static unsafe class VkImportFenceWin32HandleInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkImportFenceWin32HandleInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImportFenceWin32HandleInfoKHR>(), Is.EqualTo(sizeof(VkImportFenceWin32HandleInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkImportFenceWin32HandleInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImportFenceWin32HandleInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImportFenceWin32HandleInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImportFenceWin32HandleInfoKHR), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkImportFenceWin32HandleInfoKHR), Is.EqualTo(32));
            }
        }
    }
}
