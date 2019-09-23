// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkLayerProperties
    {
        [NativeTypeName("char [256]")]
        public fixed sbyte layerName[256];

        [NativeTypeName("uint32_t")]
        public uint specVersion;

        [NativeTypeName("uint32_t")]
        public uint implementationVersion;

        [NativeTypeName("char [256]")]
        public fixed sbyte description[256];
    }
}
