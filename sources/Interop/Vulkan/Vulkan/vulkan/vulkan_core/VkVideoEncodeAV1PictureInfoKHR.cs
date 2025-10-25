// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeAV1PictureInfoKHR
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkVideoEncodeAV1PredictionModeKHR predictionMode;

    public VkVideoEncodeAV1RateControlGroupKHR rateControlGroup;

    [NativeTypeName("uint32_t")]
    public uint constantQIndex;

    [NativeTypeName("const StdVideoEncodeAV1PictureInfo *")]
    public StdVideoEncodeAV1PictureInfo* pStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    public _referenceNameSlotIndices_e__FixedBuffer referenceNameSlotIndices;

    [NativeTypeName("VkBool32")]
    public uint primaryReferenceCdfOnly;

    [NativeTypeName("VkBool32")]
    public uint generateObuExtensionHeader;

    [InlineArray(7)]
    public partial struct _referenceNameSlotIndices_e__FixedBuffer
    {
        public int e0;
    }
}
