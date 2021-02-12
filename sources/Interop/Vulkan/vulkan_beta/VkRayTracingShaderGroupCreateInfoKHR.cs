// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkRayTracingShaderGroupTypeKHR type;

        [NativeTypeName("uint32_t")]
        public uint generalShader;

        [NativeTypeName("uint32_t")]
        public uint closestHitShader;

        [NativeTypeName("uint32_t")]
        public uint anyHitShader;

        [NativeTypeName("uint32_t")]
        public uint intersectionShader;

        [NativeTypeName("const void *")]
        public void* pShaderGroupCaptureReplayHandle;
    }
}
