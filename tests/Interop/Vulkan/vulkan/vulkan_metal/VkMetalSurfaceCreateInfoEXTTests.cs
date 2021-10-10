// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_metal.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkMetalSurfaceCreateInfoEXT" /> struct.</summary>
    public static unsafe class VkMetalSurfaceCreateInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkMetalSurfaceCreateInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkMetalSurfaceCreateInfoEXT>(), Is.EqualTo(sizeof(VkMetalSurfaceCreateInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkMetalSurfaceCreateInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkMetalSurfaceCreateInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkMetalSurfaceCreateInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkMetalSurfaceCreateInfoEXT), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkMetalSurfaceCreateInfoEXT), Is.EqualTo(16));
            }
        }
    }
}
