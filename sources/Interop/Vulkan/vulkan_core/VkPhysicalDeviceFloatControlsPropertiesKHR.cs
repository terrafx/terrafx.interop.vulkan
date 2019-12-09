// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPhysicalDeviceFloatControlsPropertiesKHR
    {
        public VkStructureType sType;

        [NativeTypeName("void *")]
        public void* pNext;

        public VkShaderFloatControlsIndependenceKHR denormBehaviorIndependence;

        public VkShaderFloatControlsIndependenceKHR roundingModeIndependence;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormPreserveFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderDenormFlushToZeroFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTEFloat64;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat16;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat32;

        [NativeTypeName("VkBool32")]
        public uint shaderRoundingModeRTZFloat64;
    }
}
