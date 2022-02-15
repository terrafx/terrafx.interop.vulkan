// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkWin32SurfaceCreateInfoKHR" /> struct.</summary>
    public static unsafe partial class VkWin32SurfaceCreateInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkWin32SurfaceCreateInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkWin32SurfaceCreateInfoKHR>(), Is.EqualTo(sizeof(VkWin32SurfaceCreateInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkWin32SurfaceCreateInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkWin32SurfaceCreateInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkWin32SurfaceCreateInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkWin32SurfaceCreateInfoKHR), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkWin32SurfaceCreateInfoKHR), Is.EqualTo(20));
            }
        }
    }
}
