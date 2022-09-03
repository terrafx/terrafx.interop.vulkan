// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoEXT
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint8_t")]
    public byte temporalId;

    public VkBool32 useInitialRcQp;

    public VkVideoEncodeH265QpEXT initialRcQp;

    public VkBool32 useMinQp;

    public VkVideoEncodeH265QpEXT minQp;

    public VkBool32 useMaxQp;

    public VkVideoEncodeH265QpEXT maxQp;

    public VkBool32 useMaxFrameSize;

    public VkVideoEncodeH265FrameSizeEXT maxFrameSize;
}
