// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_ios.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkIOSSurfaceCreateInfoMVK" /> struct.</summary>
    public static unsafe class VkIOSSurfaceCreateInfoMVKTests
    {
        /// <summary>Validates that the <see cref="VkIOSSurfaceCreateInfoMVK" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkIOSSurfaceCreateInfoMVK>(), Is.EqualTo(sizeof(VkIOSSurfaceCreateInfoMVK)));
        }

        /// <summary>Validates that the <see cref="VkIOSSurfaceCreateInfoMVK" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkIOSSurfaceCreateInfoMVK).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkIOSSurfaceCreateInfoMVK" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkIOSSurfaceCreateInfoMVK), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkIOSSurfaceCreateInfoMVK), Is.EqualTo(16));
            }
        }
    }
}
