// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType;

        public void* pNext;

        public VkShaderFloatControlsIndependence denormBehaviorIndependence;

        public VkShaderFloatControlsIndependence roundingModeIndependence;

        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;

        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;

        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;

        public VkBool32 shaderDenormPreserveFloat16;

        public VkBool32 shaderDenormPreserveFloat32;

        public VkBool32 shaderDenormPreserveFloat64;

        public VkBool32 shaderDenormFlushToZeroFloat16;

        public VkBool32 shaderDenormFlushToZeroFloat32;

        public VkBool32 shaderDenormFlushToZeroFloat64;

        public VkBool32 shaderRoundingModeRTEFloat16;

        public VkBool32 shaderRoundingModeRTEFloat32;

        public VkBool32 shaderRoundingModeRTEFloat64;

        public VkBool32 shaderRoundingModeRTZFloat16;

        public VkBool32 shaderRoundingModeRTZFloat32;

        public VkBool32 shaderRoundingModeRTZFloat64;
    }
}
