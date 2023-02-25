// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265EmitPictureParametersInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint8_t")]
    public byte vpsId;

    [NativeTypeName("uint8_t")]
    public byte spsId;

    public VkBool32 emitVpsEnable;

    public VkBool32 emitSpsEnable;

    [NativeTypeName("uint32_t")]
    public uint ppsIdEntryCount;

    [NativeTypeName("const uint8_t *")]
    public byte* ppsIdEntries;
}
