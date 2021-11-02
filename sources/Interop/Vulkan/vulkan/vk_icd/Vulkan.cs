// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vk_icdNegotiateLoaderICDInterfaceVersion([NativeTypeName("uint32_t *")] uint* pVersion);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern delegate* unmanaged<void> vk_icdGetInstanceProcAddr(VkInstance instance, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("vulkan", ExactSpelling = true)]
        [return: NativeTypeName("PFN_vkVoidFunction")]
        public static extern delegate* unmanaged<void> vk_icdGetPhysicalDeviceProcAddr(VkInstance isntance, [NativeTypeName("const char *")] sbyte* pName);

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

        [NativeTypeName("#define CURRENT_LOADER_ICD_INTERFACE_VERSION 6")]
        public const int CURRENT_LOADER_ICD_INTERFACE_VERSION = 6;

        [NativeTypeName("#define MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION 0")]
        public const int MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION = 0;

        [NativeTypeName("#define MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION 4")]
        public const int MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION = 4;

        [NativeTypeName("#define ICD_LOADER_MAGIC 0x01CDC0DE")]
        public const int ICD_LOADER_MAGIC = 0x01CDC0DE;
    }
}
