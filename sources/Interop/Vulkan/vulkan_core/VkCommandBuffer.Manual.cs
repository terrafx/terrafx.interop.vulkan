// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkCommandBuffer : IEquatable<VkCommandBuffer>
    {
        private void* _value;

        public VkCommandBuffer(IntPtr value) : this(value.ToPointer())
        {
        }

        public VkCommandBuffer(void* value)
        {
            _value = value;
        }

        public static bool operator ==(VkCommandBuffer l, VkCommandBuffer r) => l._value == r._value;

        public static bool operator !=(VkCommandBuffer l, VkCommandBuffer r) => !(l == r);

        public static implicit operator VkCommandBuffer(IntPtr value) => new VkCommandBuffer(value);

        public static implicit operator VkCommandBuffer(void* value) => new VkCommandBuffer(value);

        public static implicit operator IntPtr(VkCommandBuffer value) => new IntPtr(value._value);

        public static implicit operator void*(VkCommandBuffer value) => value._value;

        public override bool Equals(object? obj) => (obj is VkCommandBuffer other) && Equals(other);

        public bool Equals(VkCommandBuffer other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
