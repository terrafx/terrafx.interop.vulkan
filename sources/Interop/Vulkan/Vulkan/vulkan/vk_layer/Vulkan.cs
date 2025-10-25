// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_layer.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2017 The Khronos Group Inc. Copyright © 2015-2017 Valve Corporation. Copyright © 2015-2017 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public static partial class Vulkan
{
    [NativeTypeName("#define MAX_NUM_UNKNOWN_EXTS 250")]
    public const int MAX_NUM_UNKNOWN_EXTS = 250;

    [NativeTypeName("#define CURRENT_LOADER_LAYER_INTERFACE_VERSION 2")]
    public const int CURRENT_LOADER_LAYER_INTERFACE_VERSION = 2;

    [NativeTypeName("#define MIN_SUPPORTED_LOADER_LAYER_INTERFACE_VERSION 1")]
    public const int MIN_SUPPORTED_LOADER_LAYER_INTERFACE_VERSION = 1;

    [NativeTypeName("#define VK_CURRENT_CHAIN_VERSION 1")]
    public const int VK_CURRENT_CHAIN_VERSION = 1;
}
