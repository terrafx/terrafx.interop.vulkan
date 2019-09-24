// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vk_icd.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc.

namespace TerraFX.Interop
{
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
    }
}
