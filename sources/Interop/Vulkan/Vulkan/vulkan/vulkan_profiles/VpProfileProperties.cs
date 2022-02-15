// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VpProfileProperties
    {
        [NativeTypeName("char [256]")]
        public fixed sbyte profileName[256];

        [NativeTypeName("uint32_t")]
        public uint specVersion;
    }
}