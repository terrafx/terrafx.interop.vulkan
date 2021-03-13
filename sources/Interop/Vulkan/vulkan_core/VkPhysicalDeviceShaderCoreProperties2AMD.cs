// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkShaderCorePropertiesFlagsAMD")]
        public uint shaderCoreFeatures;

        [NativeTypeName("uint32_t")]
        public uint activeComputeUnitCount;
    }
}
