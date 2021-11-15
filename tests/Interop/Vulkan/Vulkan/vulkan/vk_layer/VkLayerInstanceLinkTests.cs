// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkLayerInstanceLink" /> struct.</summary>
    public static unsafe partial class VkLayerInstanceLinkTests
    {
        /// <summary>Validates that the <see cref="VkLayerInstanceLink" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkLayerInstanceLink>(), Is.EqualTo(sizeof(VkLayerInstanceLink)));
        }

        /// <summary>Validates that the <see cref="VkLayerInstanceLink" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkLayerInstanceLink).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkLayerInstanceLink" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkLayerInstanceLink), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkLayerInstanceLink), Is.EqualTo(12));
            }
        }
    }
}
