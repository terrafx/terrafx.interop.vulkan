// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public const int CURRENT_LOADER_ICD_INTERFACE_VERSION = 5;

        public const int MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION = 0;

        public const int MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION = 4;

        public const int ICD_LOADER_MAGIC = 0x01CDC0DE;
    }
}
