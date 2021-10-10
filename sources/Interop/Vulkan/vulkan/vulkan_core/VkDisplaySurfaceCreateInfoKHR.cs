// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkDisplaySurfaceCreateFlagsKHR")]
        public uint flags;

        [NativeTypeName("VkDisplayModeKHR")]
        public ulong displayMode;

        [NativeTypeName("uint32_t")]
        public uint planeIndex;

        [NativeTypeName("uint32_t")]
        public uint planeStackIndex;

        [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
        public VkSurfaceTransformFlagsKHR transform;

        public float globalAlpha;

        [NativeTypeName("VkDisplayPlaneAlphaFlagBitsKHR")]
        public VkDisplayPlaneAlphaFlagsKHR alphaMode;

        public VkExtent2D imageExtent;
    }
}
