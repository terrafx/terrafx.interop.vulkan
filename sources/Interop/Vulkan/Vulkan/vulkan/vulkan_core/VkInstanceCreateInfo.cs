// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkInstanceCreateInfo
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkInstanceCreateFlags")]
        public uint flags;

        [NativeTypeName("const VkApplicationInfo *")]
        public VkApplicationInfo* pApplicationInfo;

        [NativeTypeName("uint32_t")]
        public uint enabledLayerCount;

        [NativeTypeName("const char *const *")]
        public sbyte** ppEnabledLayerNames;

        [NativeTypeName("uint32_t")]
        public uint enabledExtensionCount;

        [NativeTypeName("const char *const *")]
        public sbyte** ppEnabledExtensionNames;
    }
}
