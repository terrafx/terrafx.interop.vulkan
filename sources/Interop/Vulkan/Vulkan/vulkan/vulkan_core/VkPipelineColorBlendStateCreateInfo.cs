// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPipelineColorBlendStateCreateInfo
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkPipelineColorBlendStateCreateFlags flags;

    [NativeTypeName("VkBool32")]
    public uint logicOpEnable;

    public VkLogicOp logicOp;

    [NativeTypeName("uint32_t")]
    public uint attachmentCount;

    [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
    public VkPipelineColorBlendAttachmentState* pAttachments;

    [NativeTypeName("float[4]")]
    public _blendConstants_e__FixedBuffer blendConstants;

    [InlineArray(4)]
    public partial struct _blendConstants_e__FixedBuffer
    {
        public float e0;
    }
}
