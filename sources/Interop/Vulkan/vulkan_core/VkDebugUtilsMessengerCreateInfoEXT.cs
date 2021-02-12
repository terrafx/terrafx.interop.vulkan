// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDebugUtilsMessengerCreateFlagsEXT")]
        public uint flags;

        [NativeTypeName("VkDebugUtilsMessageSeverityFlagsEXT")]
        public uint messageSeverity;

        [NativeTypeName("VkDebugUtilsMessageTypeFlagsEXT")]
        public uint messageType;

        [NativeTypeName("PFN_vkDebugUtilsMessengerCallbackEXT")]
        public delegate* unmanaged<VkDebugUtilsMessageSeverityFlagBitsEXT, uint, VkDebugUtilsMessengerCallbackDataEXT*, void*, uint> pfnUserCallback;

        [NativeTypeName("void *")]
        public void* pUserData;
    }
}
