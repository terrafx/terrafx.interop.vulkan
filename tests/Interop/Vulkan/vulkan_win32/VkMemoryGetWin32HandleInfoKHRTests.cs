// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkMemoryGetWin32HandleInfoKHR" /> struct.</summary>
    public static unsafe class VkMemoryGetWin32HandleInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkMemoryGetWin32HandleInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkMemoryGetWin32HandleInfoKHR>(), Is.EqualTo(sizeof(VkMemoryGetWin32HandleInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkMemoryGetWin32HandleInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkMemoryGetWin32HandleInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkMemoryGetWin32HandleInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkMemoryGetWin32HandleInfoKHR), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkMemoryGetWin32HandleInfoKHR), Is.EqualTo(24));
            }
        }
    }
}
