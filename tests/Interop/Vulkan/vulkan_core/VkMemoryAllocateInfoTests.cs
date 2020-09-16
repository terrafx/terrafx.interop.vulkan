// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkMemoryAllocateInfo" /> struct.</summary>
    public static unsafe class VkMemoryAllocateInfoTests
    {
        /// <summary>Validates that the <see cref="VkMemoryAllocateInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkMemoryAllocateInfo>(), Is.EqualTo(sizeof(VkMemoryAllocateInfo)));
        }

        /// <summary>Validates that the <see cref="VkMemoryAllocateInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkMemoryAllocateInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkMemoryAllocateInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkMemoryAllocateInfo), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkMemoryAllocateInfo), Is.EqualTo(24));
            }
        }
    }
}
