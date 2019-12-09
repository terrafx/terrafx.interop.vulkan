// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

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
        public IntPtr pfnUserCallback;

        [NativeTypeName("void *")]
        public void* pUserData;
    }
}
