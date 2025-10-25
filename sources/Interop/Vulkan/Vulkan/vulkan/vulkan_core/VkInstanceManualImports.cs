// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkInstanceManualImports
{
    public delegate* unmanaged<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> vkEnumeratePhysicalDeviceGroupsKHR;

    public delegate* unmanaged<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult> vkCreateDebugReportCallbackEXT;

    public delegate* unmanaged<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> vkDestroyDebugReportCallbackEXT;

    public delegate* unmanaged<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, sbyte*, sbyte*, void> vkDebugReportMessageEXT;

    public delegate* unmanaged<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> vkCreateDebugUtilsMessengerEXT;

    public delegate* unmanaged<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> vkDestroyDebugUtilsMessengerEXT;

    public delegate* unmanaged<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> vkSubmitDebugUtilsMessageEXT;

    public delegate* unmanaged<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateHeadlessSurfaceEXT;
}
