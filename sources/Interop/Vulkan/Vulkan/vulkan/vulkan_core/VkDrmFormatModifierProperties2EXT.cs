// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkDrmFormatModifierProperties2EXT
    {
        [NativeTypeName("uint64_t")]
        public ulong drmFormatModifier;

        [NativeTypeName("uint32_t")]
        public uint drmFormatModifierPlaneCount;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong drmFormatModifierTilingFeatures;
    }
}
