// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkDrmFormatModifierPropertiesEXT
    {
        [NativeTypeName("uint64_t")]
        public ulong drmFormatModifier;

        [NativeTypeName("uint32_t")]
        public uint drmFormatModifierPlaneCount;

        [NativeTypeName("VkFormatFeatureFlags")]
        public uint drmFormatModifierTilingFeatures;
    }
}
