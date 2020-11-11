// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkSamplerCreateInfo" /> struct.</summary>
    public static unsafe class VkSamplerCreateInfoTests
    {
        /// <summary>Validates that the <see cref="VkSamplerCreateInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkSamplerCreateInfo>(), Is.EqualTo(sizeof(VkSamplerCreateInfo)));
        }

        /// <summary>Validates that the <see cref="VkSamplerCreateInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkSamplerCreateInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkSamplerCreateInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkSamplerCreateInfo), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(VkSamplerCreateInfo), Is.EqualTo(72));
            }
        }
    }
}