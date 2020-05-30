// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceRayTracingFeaturesKHR
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        [NativeTypeName("VkBool32")]
        public uint rayTracing;

        [NativeTypeName("VkBool32")]
        public uint rayTracingShaderGroupHandleCaptureReplay;

        [NativeTypeName("VkBool32")]
        public uint rayTracingShaderGroupHandleCaptureReplayMixed;

        [NativeTypeName("VkBool32")]
        public uint rayTracingAccelerationStructureCaptureReplay;

        [NativeTypeName("VkBool32")]
        public uint rayTracingIndirectTraceRays;

        [NativeTypeName("VkBool32")]
        public uint rayTracingIndirectAccelerationStructureBuild;

        [NativeTypeName("VkBool32")]
        public uint rayTracingHostAccelerationStructureCommands;

        [NativeTypeName("VkBool32")]
        public uint rayQuery;

        [NativeTypeName("VkBool32")]
        public uint rayTracingPrimitiveCulling;
    }
}
