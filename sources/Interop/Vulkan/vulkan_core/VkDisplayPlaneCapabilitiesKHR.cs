// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan\vulkan_core.h in the Vulkan-Headers repository for tag v1.1.123
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkDisplayPlaneCapabilitiesKHR
    {
        [NativeTypeName("VkDisplayPlaneAlphaFlagsKHR")]
        public uint supportedAlpha;

        public VkOffset2D minSrcPosition;

        public VkOffset2D maxSrcPosition;

        public VkExtent2D minSrcExtent;

        public VkExtent2D maxSrcExtent;

        public VkOffset2D minDstPosition;

        public VkOffset2D maxDstPosition;

        public VkExtent2D minDstExtent;

        public VkExtent2D maxDstExtent;
    }
}
