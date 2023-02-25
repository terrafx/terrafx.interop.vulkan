// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesEXT
{
    public VkStructureType sType;

    public void* pNext;

    public VkBool32 rectangularLines;

    public VkBool32 bresenhamLines;

    public VkBool32 smoothLines;

    public VkBool32 stippledRectangularLines;

    public VkBool32 stippledBresenhamLines;

    public VkBool32 stippledSmoothLines;
}
