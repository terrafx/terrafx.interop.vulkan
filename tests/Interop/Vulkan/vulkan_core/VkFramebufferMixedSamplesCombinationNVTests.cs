// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkFramebufferMixedSamplesCombinationNV" /> struct.</summary>
    public static unsafe class VkFramebufferMixedSamplesCombinationNVTests
    {
        /// <summary>Validates that the <see cref="VkFramebufferMixedSamplesCombinationNV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkFramebufferMixedSamplesCombinationNV>(), Is.EqualTo(sizeof(VkFramebufferMixedSamplesCombinationNV)));
        }

        /// <summary>Validates that the <see cref="VkFramebufferMixedSamplesCombinationNV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkFramebufferMixedSamplesCombinationNV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkFramebufferMixedSamplesCombinationNV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkFramebufferMixedSamplesCombinationNV), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkFramebufferMixedSamplesCombinationNV), Is.EqualTo(24));
            }
        }
    }
}
