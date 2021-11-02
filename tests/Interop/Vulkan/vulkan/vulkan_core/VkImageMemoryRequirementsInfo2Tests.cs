// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImageMemoryRequirementsInfo2" /> struct.</summary>
    public static unsafe partial class VkImageMemoryRequirementsInfo2Tests
    {
        /// <summary>Validates that the <see cref="VkImageMemoryRequirementsInfo2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImageMemoryRequirementsInfo2>(), Is.EqualTo(sizeof(VkImageMemoryRequirementsInfo2)));
        }

        /// <summary>Validates that the <see cref="VkImageMemoryRequirementsInfo2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImageMemoryRequirementsInfo2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImageMemoryRequirementsInfo2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImageMemoryRequirementsInfo2), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkImageMemoryRequirementsInfo2), Is.EqualTo(16));
            }
        }
    }
}
