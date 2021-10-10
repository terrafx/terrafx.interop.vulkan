// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkLayerDeviceLink" /> struct.</summary>
    public static unsafe class VkLayerDeviceLinkTests
    {
        /// <summary>Validates that the <see cref="VkLayerDeviceLink" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkLayerDeviceLink>(), Is.EqualTo(sizeof(VkLayerDeviceLink)));
        }

        /// <summary>Validates that the <see cref="VkLayerDeviceLink" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkLayerDeviceLink).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkLayerDeviceLink" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkLayerDeviceLink), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkLayerDeviceLink), Is.EqualTo(12));
            }
        }
    }
}
