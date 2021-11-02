// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_directfb.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkDirectFBSurfaceCreateInfoEXT" /> struct.</summary>
    public static unsafe partial class VkDirectFBSurfaceCreateInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkDirectFBSurfaceCreateInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkDirectFBSurfaceCreateInfoEXT>(), Is.EqualTo(sizeof(VkDirectFBSurfaceCreateInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkDirectFBSurfaceCreateInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkDirectFBSurfaceCreateInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkDirectFBSurfaceCreateInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkDirectFBSurfaceCreateInfoEXT), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkDirectFBSurfaceCreateInfoEXT), Is.EqualTo(20));
            }
        }
    }
}
