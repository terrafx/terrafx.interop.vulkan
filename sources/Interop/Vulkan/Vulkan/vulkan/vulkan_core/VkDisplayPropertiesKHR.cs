// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR display;

        [NativeTypeName("const char *")]
        public sbyte* displayName;

        public VkExtent2D physicalDimensions;

        public VkExtent2D physicalResolution;

        public VkSurfaceTransformFlagsKHR supportedTransforms;

        public VkBool32 planeReorderPossible;

        public VkBool32 persistentContent;
    }
}
