// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkImagePipeSurfaceCreateFlagsFUCHSIA")]
        public uint flags;

        [NativeTypeName("zx_handle_t")]
        public uint imagePipeHandle;
    }
}
