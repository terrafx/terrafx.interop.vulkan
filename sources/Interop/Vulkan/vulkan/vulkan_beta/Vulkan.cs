// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkVideoProfileKHR *")] VkVideoProfileKHR* pVideoProfile, VkVideoCapabilitiesKHR* pCapabilities);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR([NativeTypeName("VkPhysicalDevice")] IntPtr physicalDevice, [NativeTypeName("const VkPhysicalDeviceVideoFormatInfoKHR *")] VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfo, [NativeTypeName("uint32_t *")] uint* pVideoFormatPropertyCount, VkVideoFormatPropertiesKHR* pVideoFormatProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateVideoSessionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkVideoSessionCreateInfoKHR *")] VkVideoSessionCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkVideoSessionKHR *")] ulong* pVideoSession);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyVideoSessionKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkVideoSessionKHR")] ulong videoSession, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkGetVideoSessionMemoryRequirementsKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkVideoSessionKHR")] ulong videoSession, [NativeTypeName("uint32_t *")] uint* pVideoSessionMemoryRequirementsCount, VkVideoGetMemoryPropertiesKHR* pVideoSessionMemoryRequirements);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkBindVideoSessionMemoryKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkVideoSessionKHR")] ulong videoSession, [NativeTypeName("uint32_t")] uint videoSessionBindMemoryCount, [NativeTypeName("const VkVideoBindMemoryKHR *")] VkVideoBindMemoryKHR* pVideoSessionBindMemories);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkCreateVideoSessionParametersKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("const VkVideoSessionParametersCreateInfoKHR *")] VkVideoSessionParametersCreateInfoKHR* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, [NativeTypeName("VkVideoSessionParametersKHR *")] ulong* pVideoSessionParameters);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vkUpdateVideoSessionParametersKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkVideoSessionParametersKHR")] ulong videoSessionParameters, [NativeTypeName("const VkVideoSessionParametersUpdateInfoKHR *")] VkVideoSessionParametersUpdateInfoKHR* pUpdateInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkDestroyVideoSessionParametersKHR([NativeTypeName("VkDevice")] IntPtr device, [NativeTypeName("VkVideoSessionParametersKHR")] ulong videoSessionParameters, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdBeginVideoCodingKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkVideoBeginCodingInfoKHR *")] VkVideoBeginCodingInfoKHR* pBeginInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEndVideoCodingKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkVideoEndCodingInfoKHR *")] VkVideoEndCodingInfoKHR* pEndCodingInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdControlVideoCodingKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkVideoCodingControlInfoKHR *")] VkVideoCodingControlInfoKHR* pCodingControlInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdDecodeVideoKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkVideoDecodeInfoKHR *")] VkVideoDecodeInfoKHR* pFrameInfo);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vkCmdEncodeVideoKHR([NativeTypeName("VkCommandBuffer")] IntPtr commandBuffer, [NativeTypeName("const VkVideoEncodeInfoKHR *")] VkVideoEncodeInfoKHR* pEncodeInfo);

        [NativeTypeName("#define VK_KHR_video_queue 1")]
        public const int VK_KHR_video_queue = 1;

        [NativeTypeName("#define VK_KHR_VIDEO_QUEUE_SPEC_VERSION 2")]
        public const int VK_KHR_VIDEO_QUEUE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_VIDEO_QUEUE_EXTENSION_NAME \"VK_KHR_video_queue\"")]
        public static ReadOnlySpan<byte> VK_KHR_VIDEO_QUEUE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_video_decode_queue 1")]
        public const int VK_KHR_video_decode_queue = 1;

        [NativeTypeName("#define VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION 1")]
        public const int VK_KHR_VIDEO_DECODE_QUEUE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_decode_queue\"")]
        public static ReadOnlySpan<byte> VK_KHR_VIDEO_DECODE_QUEUE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x64, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x00 };

        [NativeTypeName("#define VK_KHR_portability_subset 1")]
        public const int VK_KHR_portability_subset = 1;

        [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION 1")]
        public const int VK_KHR_PORTABILITY_SUBSET_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME \"VK_KHR_portability_subset\"")]
        public static ReadOnlySpan<byte> VK_KHR_PORTABILITY_SUBSET_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x70, 0x6F, 0x72, 0x74, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x79, 0x5F, 0x73, 0x75, 0x62, 0x73, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define VK_KHR_video_encode_queue 1")]
        public const int VK_KHR_video_encode_queue = 1;

        [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION 2")]
        public const int VK_KHR_VIDEO_ENCODE_QUEUE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME \"VK_KHR_video_encode_queue\"")]
        public static ReadOnlySpan<byte> VK_KHR_VIDEO_ENCODE_QUEUE_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x65, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x00 };

        [NativeTypeName("#define VK_EXT_video_encode_h264 1")]
        public const int VK_EXT_video_encode_h264 = 1;

        [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION 2")]
        public const int VK_EXT_VIDEO_ENCODE_H264_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME \"VK_EXT_video_encode_h264\"")]
        public static ReadOnlySpan<byte> VK_EXT_VIDEO_ENCODE_H264_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x65, 0x6E, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x68, 0x32, 0x36, 0x34, 0x00 };

        [NativeTypeName("#define VK_EXT_video_decode_h264 1")]
        public const int VK_EXT_video_decode_h264 = 1;

        [NativeTypeName("#define VK_EXT_VIDEO_DECODE_H264_SPEC_VERSION 3")]
        public const int VK_EXT_VIDEO_DECODE_H264_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_VIDEO_DECODE_H264_EXTENSION_NAME \"VK_EXT_video_decode_h264\"")]
        public static ReadOnlySpan<byte> VK_EXT_VIDEO_DECODE_H264_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x64, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x68, 0x32, 0x36, 0x34, 0x00 };

        [NativeTypeName("#define VK_EXT_video_decode_h265 1")]
        public const int VK_EXT_video_decode_h265 = 1;

        [NativeTypeName("#define VK_EXT_VIDEO_DECODE_H265_SPEC_VERSION 1")]
        public const int VK_EXT_VIDEO_DECODE_H265_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME \"VK_EXT_video_decode_h265\"")]
        public static ReadOnlySpan<byte> VK_EXT_VIDEO_DECODE_H265_EXTENSION_NAME => new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x5F, 0x64, 0x65, 0x63, 0x6F, 0x64, 0x65, 0x5F, 0x68, 0x32, 0x36, 0x35, 0x00 };
    }
}
