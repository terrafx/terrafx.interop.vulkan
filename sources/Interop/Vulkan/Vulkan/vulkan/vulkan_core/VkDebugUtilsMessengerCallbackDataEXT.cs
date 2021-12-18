// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
        public uint flags;

        [NativeTypeName("const char *")]
        public sbyte* pMessageIdName;

        [NativeTypeName("int32_t")]
        public int messageIdNumber;

        [NativeTypeName("const char *")]
        public sbyte* pMessage;

        [NativeTypeName("uint32_t")]
        public uint queueLabelCount;

        [NativeTypeName("const VkDebugUtilsLabelEXT *")]
        public VkDebugUtilsLabelEXT* pQueueLabels;

        [NativeTypeName("uint32_t")]
        public uint cmdBufLabelCount;

        [NativeTypeName("const VkDebugUtilsLabelEXT *")]
        public VkDebugUtilsLabelEXT* pCmdBufLabels;

        [NativeTypeName("uint32_t")]
        public uint objectCount;

        [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
    }
}
