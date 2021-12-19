// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkBindIndexBufferIndirectCommandNV" /> struct.</summary>
    public static unsafe partial class VkBindIndexBufferIndirectCommandNVTests
    {
        /// <summary>Validates that the <see cref="VkBindIndexBufferIndirectCommandNV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkBindIndexBufferIndirectCommandNV>(), Is.EqualTo(sizeof(VkBindIndexBufferIndirectCommandNV)));
        }

        /// <summary>Validates that the <see cref="VkBindIndexBufferIndirectCommandNV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkBindIndexBufferIndirectCommandNV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkBindIndexBufferIndirectCommandNV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkBindIndexBufferIndirectCommandNV), Is.EqualTo(16));
        }
    }
}
