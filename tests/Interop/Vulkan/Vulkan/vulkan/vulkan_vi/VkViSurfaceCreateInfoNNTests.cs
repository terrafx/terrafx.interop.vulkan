// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_vi.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkViSurfaceCreateInfoNN" /> struct.</summary>
    public static unsafe partial class VkViSurfaceCreateInfoNNTests
    {
        /// <summary>Validates that the <see cref="VkViSurfaceCreateInfoNN" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkViSurfaceCreateInfoNN>(), Is.EqualTo(sizeof(VkViSurfaceCreateInfoNN)));
        }

        /// <summary>Validates that the <see cref="VkViSurfaceCreateInfoNN" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkViSurfaceCreateInfoNN).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkViSurfaceCreateInfoNN" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkViSurfaceCreateInfoNN), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkViSurfaceCreateInfoNN), Is.EqualTo(16));
            }
        }
    }
}
