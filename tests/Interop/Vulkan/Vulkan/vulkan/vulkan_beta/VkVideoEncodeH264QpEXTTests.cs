// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoEncodeH264QpEXT" /> struct.</summary>
    public static unsafe partial class VkVideoEncodeH264QpEXTTests
    {
        /// <summary>Validates that the <see cref="VkVideoEncodeH264QpEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoEncodeH264QpEXT>(), Is.EqualTo(sizeof(VkVideoEncodeH264QpEXT)));
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264QpEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoEncodeH264QpEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeH264QpEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkVideoEncodeH264QpEXT), Is.EqualTo(12));
        }
    }
}
