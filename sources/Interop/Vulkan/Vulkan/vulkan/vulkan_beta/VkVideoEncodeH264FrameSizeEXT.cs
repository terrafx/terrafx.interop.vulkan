// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkVideoEncodeH264FrameSizeEXT
    {
        [NativeTypeName("uint32_t")]
        public uint frameISize;

        [NativeTypeName("uint32_t")]
        public uint framePSize;

        [NativeTypeName("uint32_t")]
        public uint frameBSize;
    }
}
