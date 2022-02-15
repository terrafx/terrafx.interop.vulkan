// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan
{
    public static unsafe partial class Vulkan
    {
        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfiles([NativeTypeName("uint32_t *")] uint* pPropertyCount, VpProfileProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileFallbacks([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VpProfileProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetInstanceProfileSupport([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, VkBool32* pSupported);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpCreateInstance([NativeTypeName("const VpInstanceCreateInfo *")] VpInstanceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkInstance* pInstance);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetPhysicalDeviceProfileSupport(VkInstance instance, VkPhysicalDevice physicalDevice, [NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, VkBool32* pSupported);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpCreateDevice(VkPhysicalDevice physicalDevice, [NativeTypeName("const VpDeviceCreateInfo *")] VpDeviceCreateInfo* pCreateInfo, [NativeTypeName("const VkAllocationCallbacks *")] VkAllocationCallbacks* pAllocator, VkDevice* pDevice);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileInstanceExtensionProperties([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileDeviceExtensionProperties([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vpGetProfileFeatures([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, void* pNext);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileFeatureStructureTypes([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pStructureTypeCount, VkStructureType* pStructureTypes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vpGetProfileProperties([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, void* pNext);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfilePropertyStructureTypes([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pStructureTypeCount, VkStructureType* pStructureTypes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileQueueFamilyProperties([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pPropertyCount, [NativeTypeName("VkQueueFamilyProperties2KHR *")] VkQueueFamilyProperties2* pProperties);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileQueueFamilyStructureTypes([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pStructureTypeCount, VkStructureType* pStructureTypes);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileFormats([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pFormatCount, VkFormat* pFormats);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern void vpGetProfileFormatProperties([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, VkFormat format, void* pNext);

        [DllImport("vulkan", ExactSpelling = true)]
        public static extern VkResult vpGetProfileFormatStructureTypes([NativeTypeName("const VpProfileProperties *")] VpProfileProperties* pProfile, [NativeTypeName("uint32_t *")] uint* pStructureTypeCount, VkStructureType* pStructureTypes);

        [NativeTypeName("#define VP_KHR_roadmap_2022 1")]
        public const int VP_KHR_roadmap_2022 = 1;

        [NativeTypeName("#define VP_KHR_ROADMAP_2022_NAME \"VP_KHR_roadmap_2022\"")]
        public static ReadOnlySpan<byte> VP_KHR_ROADMAP_2022_NAME => new byte[] { 0x56, 0x50, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x72, 0x6F, 0x61, 0x64, 0x6D, 0x61, 0x70, 0x5F, 0x32, 0x30, 0x32, 0x32, 0x00 };

        [NativeTypeName("#define VP_KHR_ROADMAP_2022_SPEC_VERSION 1")]
        public const int VP_KHR_ROADMAP_2022_SPEC_VERSION = 1;

        [NativeTypeName("#define VP_KHR_ROADMAP_2022_MIN_API_VERSION VK_MAKE_VERSION(1, 3, 203)")]
        public const uint VP_KHR_ROADMAP_2022_MIN_API_VERSION = ((((uint)(1)) << 22) | (((uint)(3)) << 12) | ((uint)(203)));

        [NativeTypeName("#define VP_LUNARG_desktop_portability_2021 1")]
        public const int VP_LUNARG_desktop_portability_2021 = 1;

        [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2021_NAME \"VP_LUNARG_desktop_portability_2021\"")]
        public static ReadOnlySpan<byte> VP_LUNARG_DESKTOP_PORTABILITY_2021_NAME => new byte[] { 0x56, 0x50, 0x5F, 0x4C, 0x55, 0x4E, 0x41, 0x52, 0x47, 0x5F, 0x64, 0x65, 0x73, 0x6B, 0x74, 0x6F, 0x70, 0x5F, 0x70, 0x6F, 0x72, 0x74, 0x61, 0x62, 0x69, 0x6C, 0x69, 0x74, 0x79, 0x5F, 0x32, 0x30, 0x32, 0x31, 0x00 };

        [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2021_SPEC_VERSION 1")]
        public const int VP_LUNARG_DESKTOP_PORTABILITY_2021_SPEC_VERSION = 1;

        [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2021_MIN_API_VERSION VK_MAKE_VERSION(1, 1, 142)")]
        public const uint VP_LUNARG_DESKTOP_PORTABILITY_2021_MIN_API_VERSION = ((((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(142)));

        [NativeTypeName("#define VP_MAX_PROFILE_NAME_SIZE 256U")]
        public const uint VP_MAX_PROFILE_NAME_SIZE = 256U;
    }
}
