// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkIcdSurfaceHeadless" /> struct.</summary>
    public static unsafe class VkIcdSurfaceHeadlessTests
    {
        /// <summary>Validates that the <see cref="VkIcdSurfaceHeadless" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkIcdSurfaceHeadless>(), Is.EqualTo(sizeof(VkIcdSurfaceHeadless)));
        }

        /// <summary>Validates that the <see cref="VkIcdSurfaceHeadless" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkIcdSurfaceHeadless).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkIcdSurfaceHeadless" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkIcdSurfaceHeadless), Is.EqualTo(4));
        }
    }
}
