// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.4.328.1
// Original source is Copyright © 2015-2025 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceGroupProperties
{
    public VkStructureType sType;

    public void* pNext;

    [NativeTypeName("uint32_t")]
    public uint physicalDeviceCount;

    [NativeTypeName("VkPhysicalDevice[32]")]
    public _physicalDevices_e__FixedBuffer physicalDevices;

    [NativeTypeName("VkBool32")]
    public uint subsetAllocation;

    public unsafe partial struct _physicalDevices_e__FixedBuffer
    {
        public VkPhysicalDevice e0;
        public VkPhysicalDevice e1;
        public VkPhysicalDevice e2;
        public VkPhysicalDevice e3;
        public VkPhysicalDevice e4;
        public VkPhysicalDevice e5;
        public VkPhysicalDevice e6;
        public VkPhysicalDevice e7;
        public VkPhysicalDevice e8;
        public VkPhysicalDevice e9;
        public VkPhysicalDevice e10;
        public VkPhysicalDevice e11;
        public VkPhysicalDevice e12;
        public VkPhysicalDevice e13;
        public VkPhysicalDevice e14;
        public VkPhysicalDevice e15;
        public VkPhysicalDevice e16;
        public VkPhysicalDevice e17;
        public VkPhysicalDevice e18;
        public VkPhysicalDevice e19;
        public VkPhysicalDevice e20;
        public VkPhysicalDevice e21;
        public VkPhysicalDevice e22;
        public VkPhysicalDevice e23;
        public VkPhysicalDevice e24;
        public VkPhysicalDevice e25;
        public VkPhysicalDevice e26;
        public VkPhysicalDevice e27;
        public VkPhysicalDevice e28;
        public VkPhysicalDevice e29;
        public VkPhysicalDevice e30;
        public VkPhysicalDevice e31;

        public ref VkPhysicalDevice this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (VkPhysicalDevice* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
