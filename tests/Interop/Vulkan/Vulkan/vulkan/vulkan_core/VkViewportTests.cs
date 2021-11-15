// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkViewport" /> struct.</summary>
    public static unsafe partial class VkViewportTests
    {
        /// <summary>Validates that the <see cref="VkViewport" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkViewport>(), Is.EqualTo(sizeof(VkViewport)));
        }

        /// <summary>Validates that the <see cref="VkViewport" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkViewport).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkViewport" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkViewport), Is.EqualTo(24));
        }
    }
}
