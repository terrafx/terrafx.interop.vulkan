// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkIcdWsiPlatform
{
    VK_ICD_WSI_PLATFORM_MIR,
    VK_ICD_WSI_PLATFORM_WAYLAND,
    VK_ICD_WSI_PLATFORM_WIN32,
    VK_ICD_WSI_PLATFORM_XCB,
    VK_ICD_WSI_PLATFORM_XLIB,
    VK_ICD_WSI_PLATFORM_ANDROID,
    VK_ICD_WSI_PLATFORM_MACOS,
    VK_ICD_WSI_PLATFORM_IOS,
    VK_ICD_WSI_PLATFORM_DISPLAY,
    VK_ICD_WSI_PLATFORM_HEADLESS,
    VK_ICD_WSI_PLATFORM_METAL,
    VK_ICD_WSI_PLATFORM_DIRECTFB,
    VK_ICD_WSI_PLATFORM_VI,
    VK_ICD_WSI_PLATFORM_GGP,
    VK_ICD_WSI_PLATFORM_SCREEN,
    VK_ICD_WSI_PLATFORM_FUCHSIA,
}
