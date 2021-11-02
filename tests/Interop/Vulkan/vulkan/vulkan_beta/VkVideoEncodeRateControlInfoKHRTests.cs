// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkVideoEncodeRateControlInfoKHR" /> struct.</summary>
    public static unsafe partial class VkVideoEncodeRateControlInfoKHRTests
    {
        /// <summary>Validates that the <see cref="VkVideoEncodeRateControlInfoKHR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkVideoEncodeRateControlInfoKHR>(), Is.EqualTo(sizeof(VkVideoEncodeRateControlInfoKHR)));
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeRateControlInfoKHR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkVideoEncodeRateControlInfoKHR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkVideoEncodeRateControlInfoKHR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkVideoEncodeRateControlInfoKHR), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(VkVideoEncodeRateControlInfoKHR), Is.EqualTo(32));
            }
        }
    }
}
