// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkEnumerateInstanceLayerPropertiesChain" /> struct.</summary>
    public static unsafe class VkEnumerateInstanceLayerPropertiesChainTests
    {
        /// <summary>Validates that the <see cref="VkEnumerateInstanceLayerPropertiesChain" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkEnumerateInstanceLayerPropertiesChain>(), Is.EqualTo(sizeof(VkEnumerateInstanceLayerPropertiesChain)));
        }

        /// <summary>Validates that the <see cref="VkEnumerateInstanceLayerPropertiesChain" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkEnumerateInstanceLayerPropertiesChain).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkEnumerateInstanceLayerPropertiesChain" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkEnumerateInstanceLayerPropertiesChain), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkEnumerateInstanceLayerPropertiesChain), Is.EqualTo(20));
            }
        }
    }
}
