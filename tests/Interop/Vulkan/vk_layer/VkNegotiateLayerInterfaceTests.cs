// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkNegotiateLayerInterface" /> struct.</summary>
    public static unsafe class VkNegotiateLayerInterfaceTests
    {
        /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkNegotiateLayerInterface>(), Is.EqualTo(sizeof(VkNegotiateLayerInterface)));
        }

        /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkNegotiateLayerInterface).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkNegotiateLayerInterface" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkNegotiateLayerInterface), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(VkNegotiateLayerInterface), Is.EqualTo(24));
            }
        }
    }
}
