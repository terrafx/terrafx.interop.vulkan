// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("VkResolveModeFlagsKHR")]
        public uint supportedDepthResolveModes;

        [NativeTypeName("VkResolveModeFlagsKHR")]
        public uint supportedStencilResolveModes;

        [NativeTypeName("VkBool32")]
        public uint independentResolveNone;

        [NativeTypeName("VkBool32")]
        public uint independentResolve;
    }
}
