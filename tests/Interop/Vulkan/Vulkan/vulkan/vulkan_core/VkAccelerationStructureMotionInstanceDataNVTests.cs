// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkAccelerationStructureMotionInstanceDataNV" /> struct.</summary>
    public static unsafe partial class VkAccelerationStructureMotionInstanceDataNVTests
    {
        /// <summary>Validates that the <see cref="VkAccelerationStructureMotionInstanceDataNV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkAccelerationStructureMotionInstanceDataNV>(), Is.EqualTo(sizeof(VkAccelerationStructureMotionInstanceDataNV)));
        }

        /// <summary>Validates that the <see cref="VkAccelerationStructureMotionInstanceDataNV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(VkAccelerationStructureMotionInstanceDataNV).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="VkAccelerationStructureMotionInstanceDataNV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkAccelerationStructureMotionInstanceDataNV), Is.EqualTo(144));
        }
    }
}
