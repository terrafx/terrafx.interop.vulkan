// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkDeviceMemoryReportFlagsEXT flags;

    public VkDeviceMemoryReportEventTypeEXT type;

    [NativeTypeName("uint64_t")]
    public ulong memoryObjectId;

    [NativeTypeName("VkDeviceSize")]
    public ulong size;

    public VkObjectType objectType;

    [NativeTypeName("uint64_t")]
    public ulong objectHandle;

    [NativeTypeName("uint32_t")]
    public uint heapIndex;
}
