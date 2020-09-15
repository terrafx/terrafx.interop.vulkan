// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkSparseImageMemoryBind" /> struct.</summary>
    public static unsafe class VkSparseImageMemoryBindTests
    {
        /// <summary>Validates that the <see cref="VkSparseImageMemoryBind" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkSparseImageMemoryBind>(), Is.EqualTo(sizeof(VkSparseImageMemoryBind)));
        }

        /// <summary>Validates that the <see cref="VkSparseImageMemoryBind" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkSparseImageMemoryBind).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkSparseImageMemoryBind" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkSparseImageMemoryBind), Is.EqualTo(64));
        }
    }
}
