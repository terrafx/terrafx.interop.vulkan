// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceTileShadingFeaturesQCOM
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("VkBool32")]
    public uint tileShading;

    [NativeTypeName("VkBool32")]
    public uint tileShadingFragmentStage;

    [NativeTypeName("VkBool32")]
    public uint tileShadingColorAttachments;

    [NativeTypeName("VkBool32")]
    public uint tileShadingDepthAttachments;

    [NativeTypeName("VkBool32")]
    public uint tileShadingStencilAttachments;

    [NativeTypeName("VkBool32")]
    public uint tileShadingInputAttachments;

    [NativeTypeName("VkBool32")]
    public uint tileShadingSampledAttachments;

    [NativeTypeName("VkBool32")]
    public uint tileShadingPerTileDraw;

    [NativeTypeName("VkBool32")]
    public uint tileShadingPerTileDispatch;

    [NativeTypeName("VkBool32")]
    public uint tileShadingDispatchTile;

    [NativeTypeName("VkBool32")]
    public uint tileShadingApron;

    [NativeTypeName("VkBool32")]
    public uint tileShadingAnisotropicApron;

    [NativeTypeName("VkBool32")]
    public uint tileShadingAtomicOps;

    [NativeTypeName("VkBool32")]
    public uint tileShadingImageProcessing;
}
