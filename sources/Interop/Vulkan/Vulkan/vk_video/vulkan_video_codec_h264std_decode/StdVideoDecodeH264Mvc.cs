// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std_decode.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct StdVideoDecodeH264Mvc
    {
        [NativeTypeName("uint32_t")]
        public uint viewId0;

        [NativeTypeName("uint32_t")]
        public uint mvcElementCount;

        public StdVideoDecodeH264MvcElement* pMvcElements;
    }
}
