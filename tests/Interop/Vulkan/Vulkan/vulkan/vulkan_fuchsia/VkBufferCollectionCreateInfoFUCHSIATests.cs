// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkBufferCollectionCreateInfoFUCHSIA" /> struct.</summary>
    public static unsafe partial class VkBufferCollectionCreateInfoFUCHSIATests
    {
        /// <summary>Validates that the <see cref="VkBufferCollectionCreateInfoFUCHSIA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkBufferCollectionCreateInfoFUCHSIA>(), Is.EqualTo(sizeof(VkBufferCollectionCreateInfoFUCHSIA)));
        }

        /// <summary>Validates that the <see cref="VkBufferCollectionCreateInfoFUCHSIA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkBufferCollectionCreateInfoFUCHSIA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkBufferCollectionCreateInfoFUCHSIA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkBufferCollectionCreateInfoFUCHSIA), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkBufferCollectionCreateInfoFUCHSIA), Is.EqualTo(12));
            }
        }
    }
}
