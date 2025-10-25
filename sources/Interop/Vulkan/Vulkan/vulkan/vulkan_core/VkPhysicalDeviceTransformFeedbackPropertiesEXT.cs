// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackStreams;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBuffers;

    [NativeTypeName("VkDeviceSize")]
    public ulong maxTransformFeedbackBufferSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackStreamDataSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBufferDataSize;

    [NativeTypeName("uint32_t")]
    public uint maxTransformFeedbackBufferDataStride;

    [NativeTypeName("VkBool32")]
    public uint transformFeedbackQueries;

    [NativeTypeName("VkBool32")]
    public uint transformFeedbackStreamsLinesTriangles;

    [NativeTypeName("VkBool32")]
    public uint transformFeedbackRasterizationStreamSelect;

    [NativeTypeName("VkBool32")]
    public uint transformFeedbackDraw;
}
