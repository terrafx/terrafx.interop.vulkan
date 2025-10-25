// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    public static uint VK_MAKE_VERSION(uint major, uint minor, uint patch) => (major << 22) | (minor << 12) | patch;

    public static uint VK_VERSION_MAJOR(uint version) => version >> 22;

    public static uint VK_VERSION_MINOR(uint version) => (version >> 12) & 0x3FF;

    public static uint VK_VERSION_PATCH(uint version) => version & 0xFFF;

    [NativeTypeName("#define VK_NULL_HANDLE 0ULL")]
    public const ulong VK_NULL_HANDLE = 0UL;
}
