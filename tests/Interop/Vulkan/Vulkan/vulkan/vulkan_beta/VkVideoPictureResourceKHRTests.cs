// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoPictureResourceKHR" /> struct.</summary>
    public static unsafe partial class VkVideoPictureResourceKHRTests
    {
        /// <summary>Validates that the <see cref="VkVideoPictureResourceKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoPictureResourceKHR>(), Is.EqualTo(sizeof(VkVideoPictureResourceKHR)));
        }

        /// <summary>Validates that the <see cref="VkVideoPictureResourceKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoPictureResourceKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoPictureResourceKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoPictureResourceKHR), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkVideoPictureResourceKHR), Is.EqualTo(40));
            }
        }
    }
}
