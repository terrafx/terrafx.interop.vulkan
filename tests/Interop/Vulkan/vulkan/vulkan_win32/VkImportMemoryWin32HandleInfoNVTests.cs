// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkImportMemoryWin32HandleInfoNV" /> struct.</summary>
    public static unsafe class VkImportMemoryWin32HandleInfoNVTests
    {
        /// <summary>Validates that the <see cref="VkImportMemoryWin32HandleInfoNV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkImportMemoryWin32HandleInfoNV>(), Is.EqualTo(sizeof(VkImportMemoryWin32HandleInfoNV)));
        }

        /// <summary>Validates that the <see cref="VkImportMemoryWin32HandleInfoNV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkImportMemoryWin32HandleInfoNV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkImportMemoryWin32HandleInfoNV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkImportMemoryWin32HandleInfoNV), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(VkImportMemoryWin32HandleInfoNV), Is.EqualTo(16));
            }
        }
    }
}
