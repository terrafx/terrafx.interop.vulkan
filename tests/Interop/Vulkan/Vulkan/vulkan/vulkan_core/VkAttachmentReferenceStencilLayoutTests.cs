// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkAttachmentReferenceStencilLayout" /> struct.</summary>
    public static unsafe partial class VkAttachmentReferenceStencilLayoutTests
    {
        /// <summary>Validates that the <see cref="VkAttachmentReferenceStencilLayout" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkAttachmentReferenceStencilLayout>(), Is.EqualTo(sizeof(VkAttachmentReferenceStencilLayout)));
        }

        /// <summary>Validates that the <see cref="VkAttachmentReferenceStencilLayout" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkAttachmentReferenceStencilLayout).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkAttachmentReferenceStencilLayout" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkAttachmentReferenceStencilLayout), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkAttachmentReferenceStencilLayout), Is.EqualTo(12));
            }
        }
    }
}
