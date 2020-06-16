// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("VkResolveModeFlags")]
        public uint supportedDepthResolveModes;

        [NativeTypeName("VkResolveModeFlags")]
        public uint supportedStencilResolveModes;

        [NativeTypeName("VkBool32")]
        public uint independentResolveNone;

        [NativeTypeName("VkBool32")]
        public uint independentResolve;
    }
}