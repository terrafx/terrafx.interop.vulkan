// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2021-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public enum VpInstanceCreateFlags
    {
        VP_INSTANCE_CREATE_MERGE_EXTENSIONS_BIT = 0x00000001,
        VP_INSTANCE_CREATE_OVERRIDE_EXTENSIONS_BIT = 0x00000002,
        VP_INSTANCE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
