// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkDisplayPropertiesKHR
    {
        [NativeTypeName("VkDisplayKHR")]
        public ulong display;

        [NativeTypeName("const char *")]
        public sbyte* displayName;

        public VkExtent2D physicalDimensions;

        public VkExtent2D physicalResolution;

        public VkSurfaceTransformFlagsKHR supportedTransforms;

        [NativeTypeName("VkBool32")]
        public uint planeReorderPossible;

        [NativeTypeName("VkBool32")]
        public uint persistentContent;
    }
}
