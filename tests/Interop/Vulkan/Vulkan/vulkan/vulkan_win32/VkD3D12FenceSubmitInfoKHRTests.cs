// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkD3D12FenceSubmitInfoKHR" /> struct.</summary>
    public static unsafe partial class VkD3D12FenceSubmitInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkD3D12FenceSubmitInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkD3D12FenceSubmitInfoKHR>(), Is.EqualTo(sizeof(VkD3D12FenceSubmitInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkD3D12FenceSubmitInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkD3D12FenceSubmitInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkD3D12FenceSubmitInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkD3D12FenceSubmitInfoKHR), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkD3D12FenceSubmitInfoKHR), Is.EqualTo(24));
            }
        }
    }
}
