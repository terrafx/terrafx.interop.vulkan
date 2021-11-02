// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkDebugMarkerObjectTagInfoEXT" /> struct.</summary>
    public static unsafe partial class VkDebugMarkerObjectTagInfoEXTTests
    {
        /// <summary>Validates that the <see cref="VkDebugMarkerObjectTagInfoEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkDebugMarkerObjectTagInfoEXT>(), Is.EqualTo(sizeof(VkDebugMarkerObjectTagInfoEXT)));
        }

        /// <summary>Validates that the <see cref="VkDebugMarkerObjectTagInfoEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkDebugMarkerObjectTagInfoEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkDebugMarkerObjectTagInfoEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkDebugMarkerObjectTagInfoEXT), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(VkDebugMarkerObjectTagInfoEXT), Is.EqualTo(40));
            }
        }
    }
}
