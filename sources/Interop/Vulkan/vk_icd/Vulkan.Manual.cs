// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_icd.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        public const int CURRENT_LOADER_ICD_INTERFACE_VERSION = 5;

        public const int MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION = 0;

        public const int MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION = 4;

        public const int ICD_LOADER_MAGIC = 0x01CDC0DE;

        public static void set_loader_magic_value([NativeTypeName("void *")] void* pNewObject)
        {
            var loader_info = (VK_LOADER_DATA*)pNewObject;
            loader_info->loaderMagic = (UIntPtr)ICD_LOADER_MAGIC;
        }

        public static bool valid_loader_magic_value([NativeTypeName("void *")] void* pNewObject)
        {
            var loader_info = (VK_LOADER_DATA*)pNewObject;
            return (uint)(void*)loader_info->loaderMagic == ICD_LOADER_MAGIC;
        }
    }
}
