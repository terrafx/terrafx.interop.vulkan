// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public partial struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;

        public uint _bitfield1;

        [NativeTypeName("uint32_t : 24")]
        public uint instanceCustomIndex
        {
            get
            {
                return _bitfield1 & 0xFFFFFFu;
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("uint32_t : 8")]
        public uint mask
        {
            get
            {
                return (_bitfield1 >> 24) & 0xFFu;
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        public uint _bitfield2;

        [NativeTypeName("uint32_t : 24")]
        public uint instanceShaderBindingTableRecordOffset
        {
            get
            {
                return _bitfield2 & 0xFFFFFFu;
            }

            set
            {
                _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("VkGeometryInstanceFlagsKHR : 8")]
        public uint flags
        {
            get
            {
                return (_bitfield2 >> 24) & 0xFFu;
            }

            set
            {
                _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        [NativeTypeName("uint64_t")]
        public ulong accelerationStructureReference;
    }
}
