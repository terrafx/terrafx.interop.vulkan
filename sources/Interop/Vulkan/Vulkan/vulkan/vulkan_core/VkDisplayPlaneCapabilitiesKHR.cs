// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct VkDisplayPlaneCapabilitiesKHR
{
    public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;

    public VkOffset2D minSrcPosition;

    public VkOffset2D maxSrcPosition;

    public VkExtent2D minSrcExtent;

    public VkExtent2D maxSrcExtent;

    public VkOffset2D minDstPosition;

    public VkOffset2D maxDstPosition;

    public VkExtent2D minDstExtent;

    public VkExtent2D maxDstExtent;
}
