// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkLatencyTimingsFrameReportNV
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    [NativeTypeName("uint64_t")]
    public ulong presentID;

    [NativeTypeName("uint64_t")]
    public ulong inputSampleTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong simStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong simEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong renderSubmitStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong renderSubmitEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong presentStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong presentEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong driverStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong driverEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong osRenderQueueStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong osRenderQueueEndTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong gpuRenderStartTimeUs;

    [NativeTypeName("uint64_t")]
    public ulong gpuRenderEndTimeUs;
}
