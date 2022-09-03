// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2021-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan;

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
    public static ReadOnlySpan<byte> VP_KHR_ROADMAP_2022_NAME => "VP_KHR_roadmap_2022"u8;

    [NativeTypeName("#define VP_KHR_ROADMAP_2022_SPEC_VERSION 1")]
    public const int VP_KHR_ROADMAP_2022_SPEC_VERSION = 1;

    [NativeTypeName("#define VP_KHR_ROADMAP_2022_MIN_API_VERSION VK_MAKE_VERSION(1, 3, 204)")]
    public const uint VP_KHR_ROADMAP_2022_MIN_API_VERSION = ((((uint)(1)) << 22) | (((uint)(3)) << 12) | ((uint)(204)));

    [NativeTypeName("#define VP_LUNARG_desktop_baseline_2022 1")]
    public const int VP_LUNARG_desktop_baseline_2022 = 1;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_BASELINE_2022_NAME \"VP_LUNARG_desktop_baseline_2022\"")]
    public static ReadOnlySpan<byte> VP_LUNARG_DESKTOP_BASELINE_2022_NAME => "VP_LUNARG_desktop_baseline_2022"u8;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_BASELINE_2022_SPEC_VERSION 1")]
    public const int VP_LUNARG_DESKTOP_BASELINE_2022_SPEC_VERSION = 1;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_BASELINE_2022_MIN_API_VERSION VK_MAKE_VERSION(1, 1, 139)")]
    public const uint VP_LUNARG_DESKTOP_BASELINE_2022_MIN_API_VERSION = ((((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(139)));

    [NativeTypeName("#define VP_LUNARG_desktop_portability_2022 1")]
    public const int VP_LUNARG_desktop_portability_2022 = 1;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2022_NAME \"VP_LUNARG_desktop_portability_2022\"")]
    public static ReadOnlySpan<byte> VP_LUNARG_DESKTOP_PORTABILITY_2022_NAME => "VP_LUNARG_desktop_portability_2022"u8;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2022_SPEC_VERSION 1")]
    public const int VP_LUNARG_DESKTOP_PORTABILITY_2022_SPEC_VERSION = 1;

    [NativeTypeName("#define VP_LUNARG_DESKTOP_PORTABILITY_2022_MIN_API_VERSION VK_MAKE_VERSION(1, 1, 208)")]
    public const uint VP_LUNARG_DESKTOP_PORTABILITY_2022_MIN_API_VERSION = ((((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(208)));

    [NativeTypeName("#define VP_MAX_PROFILE_NAME_SIZE 256U")]
    public const uint VP_MAX_PROFILE_NAME_SIZE = 256U;
}
