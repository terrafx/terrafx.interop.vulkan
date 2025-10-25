// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkLatencyMarkerNV
{
    VK_LATENCY_MARKER_SIMULATION_START_NV = 0,
    VK_LATENCY_MARKER_SIMULATION_END_NV = 1,
    VK_LATENCY_MARKER_RENDERSUBMIT_START_NV = 2,
    VK_LATENCY_MARKER_RENDERSUBMIT_END_NV = 3,
    VK_LATENCY_MARKER_PRESENT_START_NV = 4,
    VK_LATENCY_MARKER_PRESENT_END_NV = 5,
    VK_LATENCY_MARKER_INPUT_SAMPLE_NV = 6,
    VK_LATENCY_MARKER_TRIGGER_FLASH_NV = 7,
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_START_NV = 8,
    VK_LATENCY_MARKER_OUT_OF_BAND_RENDERSUBMIT_END_NV = 9,
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_START_NV = 10,
    VK_LATENCY_MARKER_OUT_OF_BAND_PRESENT_END_NV = 11,
    VK_LATENCY_MARKER_MAX_ENUM_NV = 0x7FFFFFFF,
}
