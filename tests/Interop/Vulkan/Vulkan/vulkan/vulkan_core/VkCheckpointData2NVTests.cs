// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkCheckpointData2NV" /> struct.</summary>
    public static unsafe partial class VkCheckpointData2NVTests
    {
        /// <summary>Validates that the <see cref="VkCheckpointData2NV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkCheckpointData2NV>(), Is.EqualTo(sizeof(VkCheckpointData2NV)));
        }

        /// <summary>Validates that the <see cref="VkCheckpointData2NV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkCheckpointData2NV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkCheckpointData2NV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkCheckpointData2NV), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkCheckpointData2NV), Is.EqualTo(24));
            }
        }
    }
}
