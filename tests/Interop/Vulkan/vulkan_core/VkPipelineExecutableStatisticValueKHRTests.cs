// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPipelineExecutableStatisticValueKHR" /> struct.</summary>
    public static unsafe class VkPipelineExecutableStatisticValueKHRTests
    {
        /// <summary>Validates that the <see cref="VkPipelineExecutableStatisticValueKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPipelineExecutableStatisticValueKHR>(), Is.EqualTo(sizeof(VkPipelineExecutableStatisticValueKHR)));
        }

        /// <summary>Validates that the <see cref="VkPipelineExecutableStatisticValueKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(VkPipelineExecutableStatisticValueKHR).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPipelineExecutableStatisticValueKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkPipelineExecutableStatisticValueKHR), Is.EqualTo(8));
        }
    }
}
