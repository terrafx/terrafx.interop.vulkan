// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2021-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[NativeTypeName("int")]
[Flags]
public enum VpDeviceCreateFlags : uint
{
    VP_DEVICE_CREATE_MERGE_EXTENSIONS_BIT = 0x00000001,
    VP_DEVICE_CREATE_OVERRIDE_EXTENSIONS_BIT = 0x00000002,
    VP_DEVICE_CREATE_OVERRIDE_FEATURES_BIT = 0x00000008,
    VP_DEVICE_CREATE_OVERRIDE_ALL_FEATURES_BIT = 0x00000010,
    VP_DEVICE_CREATE_DISABLE_ROBUST_BUFFER_ACCESS_BIT = 0x00000020,
    VP_DEVICE_CREATE_DISABLE_ROBUST_IMAGE_ACCESS_BIT = 0x00000040,
    VP_DEVICE_CREATE_DISABLE_ROBUST_ACCESS = VP_DEVICE_CREATE_DISABLE_ROBUST_BUFFER_ACCESS_BIT | VP_DEVICE_CREATE_DISABLE_ROBUST_IMAGE_ACCESS_BIT,
    VP_DEVICE_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
