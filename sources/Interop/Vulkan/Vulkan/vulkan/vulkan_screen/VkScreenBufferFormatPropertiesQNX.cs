// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_screen.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkScreenBufferFormatPropertiesQNX
{
    public VkStructureType sType;

    public void* pNext;

    public VkFormat format;

    [NativeTypeName("uint64_t")]
    public ulong externalFormat;

    [NativeTypeName("uint64_t")]
    public ulong screenUsage;

    public VkFormatFeatureFlags formatFeatures;

    public VkComponentMapping samplerYcbcrConversionComponents;

    public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

    public VkSamplerYcbcrRange suggestedYcbcrRange;

    public VkChromaLocation suggestedXChromaOffset;

    public VkChromaLocation suggestedYChromaOffset;
}
