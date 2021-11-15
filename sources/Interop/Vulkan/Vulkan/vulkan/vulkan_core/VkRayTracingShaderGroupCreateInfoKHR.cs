// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
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
