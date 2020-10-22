// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPipelineTessellationDomainOriginStateCreateInfo" /> struct.</summary>
    public static unsafe class VkPipelineTessellationDomainOriginStateCreateInfoTests
    {
        /// <summary>Validates that the <see cref="VkPipelineTessellationDomainOriginStateCreateInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPipelineTessellationDomainOriginStateCreateInfo>(), Is.EqualTo(sizeof(VkPipelineTessellationDomainOriginStateCreateInfo)));
        }

        /// <summary>Validates that the <see cref="VkPipelineTessellationDomainOriginStateCreateInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPipelineTessellationDomainOriginStateCreateInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPipelineTessellationDomainOriginStateCreateInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPipelineTessellationDomainOriginStateCreateInfo), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPipelineTessellationDomainOriginStateCreateInfo), Is.EqualTo(12));
            }
        }
    }
}
