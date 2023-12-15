// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_profiles.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2021-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public partial struct VpProfileProperties
{
    [NativeTypeName("char[256]")]
    public _profileName_e__FixedBuffer profileName;

    [NativeTypeName("uint32_t")]
    public uint specVersion;

    [InlineArray(256)]
    public partial struct _profileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
