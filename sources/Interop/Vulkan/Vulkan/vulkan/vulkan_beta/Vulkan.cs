// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(VkPhysicalDevice physicalDevice, [NativeTypeName("const VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR *")] VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo, VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelProperties);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetEncodedVideoSessionParametersKHR(VkDevice device, [NativeTypeName("const VkVideoEncodeSessionParametersGetInfoKHR *")] VkVideoEncodeSessionParametersGetInfoKHR* pVideoSessionParametersInfo, VkVideoEncodeSessionParametersFeedbackInfoKHR* pFeedbackInfo, [NativeTypeName("size_t *")] nuint* pDataSize, void* pData);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkCreateExecutionGraphPipelinesAMDX(VkDevice device, VkPipelineCache pipelineCache, [NativeTypeName("uint32_t")] uint createInfoCount, [NativeTypeName("const VkExecutionGraphPipelineCreateInfoAMDX *")] VkExecutionGraphPipelineCreateInfoAMDX* pCreateInfos, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetExecutionGraphPipelineScratchSizeAMDX(VkDevice device, VkPipeline executionGraph, VkExecutionGraphPipelineScratchSizeAMDX* pSizeInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern VkResult vkGetExecutionGraphPipelineNodeIndexAMDX(VkDevice device, VkPipeline executionGraph, [NativeTypeName("const VkPipelineShaderStageNodeCreateInfoAMDX *")] VkPipelineShaderStageNodeCreateInfoAMDX* pNodeInfo, [NativeTypeName("uint32_t *")] uint* pNodeIndex);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdInitializeGraphScratchMemoryAMDX(VkCommandBuffer commandBuffer, [NativeTypeName("VkDeviceAddress")] ulong scratch);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatchGraphAMDX(VkCommandBuffer commandBuffer, [NativeTypeName("VkDeviceAddress")] ulong scratch, [NativeTypeName("const VkDispatchGraphCountInfoAMDX *")] VkDispatchGraphCountInfoAMDX* pCountInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatchGraphIndirectAMDX(VkCommandBuffer commandBuffer, [NativeTypeName("VkDeviceAddress")] ulong scratch, [NativeTypeName("const VkDispatchGraphCountInfoAMDX *")] VkDispatchGraphCountInfoAMDX* pCountInfo);

    [DllImport("vulkan", ExactSpelling = true)]
    public static extern void vkCmdDispatchGraphIndirectCountAMDX(VkCommandBuffer commandBuffer, [NativeTypeName("VkDeviceAddress")] ulong scratch, [NativeTypeName("VkDeviceAddress")] ulong countInfo);

    [NativeTypeName("#define VK_KHR_portability_subset 1")]
    public const int VK_KHR_portability_subset = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION 1")]
    public const int VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME \"VK_KHR_portability_subset\"")]
    public static ReadOnlySpan<byte> VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME => "VK_KHR_portability_subset"u8;

    [NativeTypeName("#define VK_KHR_video_encode_queue 1")]
    public const int VK_KHR_video_encode_queue = 1;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION 10")]
    public const int VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 10;

    [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_encode_queue\"")]
    public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME => "VK_KHR_video_encode_queue"u8;

    [NativeTypeName("#define VK_EXT_video_encode_h264 1")]
    public const int VK_EXT_video_encode_h264 = 1;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION 12")]
    public const int VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION = 12;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME \"VK_EXT_video_encode_h264\"")]
    public static ReadOnlySpan<byte> VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME => "VK_EXT_video_encode_h264"u8;

    [NativeTypeName("#define VK_EXT_video_encode_h265 1")]
    public const int VK_EXT_video_encode_h265 = 1;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H265_SPEC_VERSION 12")]
    public const int VK_EXT_VIDEO_ENCODE_H265_SPEC_VERSION = 12;

    [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H265_EXTENSION_NAME \"VK_EXT_video_encode_h265\"")]
    public static ReadOnlySpan<byte> VK_EXT_VIDEO_ENCODE_H265_EXTENSION_NAME => "VK_EXT_video_encode_h265"u8;

    [NativeTypeName("#define VK_AMDX_shader_enqueue 1")]
    public const int VK_AMDX_shader_enqueue = 1;

    [NativeTypeName("#define VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION 1")]
    public const int VK_AMDX_SHADER_ENQUEUE_SPEC_VERSION = 1;

    [NativeTypeName("#define VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME \"VK_AMDX_shader_enqueue\"")]
    public static ReadOnlySpan<byte> VK_AMDX_SHADER_ENQUEUE_EXTENSION_NAME => "VK_AMDX_shader_enqueue"u8;

    [NativeTypeName("#define VK_SHADER_INDEX_UNUSED_AMDX (~0U)")]
    public const uint VK_SHADER_INDEX_UNUSED_AMDX = (~0U);

    [NativeTypeName("#define VK_NV_displacement_micromap 1")]
    public const int VK_NV_displacement_micromap = 1;

    [NativeTypeName("#define VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION 2")]
    public const int VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION = 2;

    [NativeTypeName("#define VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME \"VK_NV_displacement_micromap\"")]
    public static ReadOnlySpan<byte> VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME => "VK_NV_displacement_micromap"u8;
}
