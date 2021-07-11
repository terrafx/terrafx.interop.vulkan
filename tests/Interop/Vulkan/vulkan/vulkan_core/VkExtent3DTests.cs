// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkExtent3D" /> struct.</summary>
    public static unsafe class VkExtent3DTests
    {
        /// <summary>Validates that the <see cref="VkExtent3D" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkExtent3D>(), Is.EqualTo(sizeof(VkExtent3D)));
        }

        /// <summary>Validates that the <see cref="VkExtent3D" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkExtent3D).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkExtent3D" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkExtent3D), Is.EqualTo(12));
        }
    }
}
