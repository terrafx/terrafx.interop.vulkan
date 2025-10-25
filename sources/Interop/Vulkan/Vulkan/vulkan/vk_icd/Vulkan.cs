// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static unsafe partial class Vulkan
{
    public static void set_loader_magic_value(void* pNewObject)
    {
        VK_LOADER_DATA* loader_info = (VK_LOADER_DATA*)(pNewObject);

        loader_info->loaderMagic = 0x01CDC0DE;
    }

    public static bool valid_loader_magic_value(void* pNewObject)
    {
        VK_LOADER_DATA* loader_info = (VK_LOADER_DATA*)(pNewObject);

        return (loader_info->loaderMagic & 0xffffffff) == 0x01CDC0DE;
    }

    [NativeTypeName("#define CURRENT_LOADER_ICD_INTERFACE_VERSION 7")]
    public const int CURRENT_LOADER_ICD_INTERFACE_VERSION = 7;

    [NativeTypeName("#define MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION 0")]
    public const int MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION = 0;

    [NativeTypeName("#define MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION 4")]
    public const int MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION = 4;

    [NativeTypeName("#define ICD_LOADER_MAGIC 0x01CDC0DE")]
    public const int ICD_LOADER_MAGIC = 0x01CDC0DE;
}
