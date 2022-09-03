// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoDecodeH264SessionParametersAddInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint spsStdCount;

    [NativeTypeName("const StdVideoH264SequenceParameterSet *")]
    public StdVideoH264SequenceParameterSet* pSpsStd;

    [NativeTypeName("uint32_t")]
    public uint ppsStdCount;

    [NativeTypeName("const StdVideoH264PictureParameterSet *")]
    public StdVideoH264PictureParameterSet* pPpsStd;
}
