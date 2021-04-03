// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkDebugReportFlagsEXT flags;

        [NativeTypeName("PFN_vkDebugReportCallbackEXT")]
        public delegate* unmanaged<VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, sbyte*, sbyte*, void*, uint> pfnCallback;

        public void* pUserData;
    }
}
