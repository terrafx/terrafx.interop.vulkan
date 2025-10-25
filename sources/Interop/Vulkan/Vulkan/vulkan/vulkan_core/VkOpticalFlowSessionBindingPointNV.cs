// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkOpticalFlowSessionBindingPointNV
{
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV = 0,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV = 1,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV = 2,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV = 3,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV = 4,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV = 5,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV = 6,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV = 7,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV = 8,
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_MAX_ENUM_NV = 0x7FFFFFFF,
}
