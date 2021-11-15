// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceProperties
    {
        [NativeTypeName("uint32_t")]
        public uint apiVersion;

        [NativeTypeName("uint32_t")]
        public uint driverVersion;

        [NativeTypeName("uint32_t")]
        public uint vendorID;

        [NativeTypeName("uint32_t")]
        public uint deviceID;

        public VkPhysicalDeviceType deviceType;

        [NativeTypeName("char [256]")]
        public fixed sbyte deviceName[256];

        [NativeTypeName("uint8_t [16]")]
        public fixed byte pipelineCacheUUID[16];

        public VkPhysicalDeviceLimits limits;

        public VkPhysicalDeviceSparseProperties sparseProperties;
    }
}
