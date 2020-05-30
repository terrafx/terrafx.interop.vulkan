// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkInstance : IEquatable<VkInstance>
    {
        private void* _value;

        public VkInstance(IntPtr value) : this(value.ToPointer())
        {
        }

        public VkInstance(void* value)
        {
            _value = value;
        }

        public static bool operator ==(VkInstance l, VkInstance r) => l._value == r._value;

        public static bool operator !=(VkInstance l, VkInstance r) => !(l == r);

        public static implicit operator VkInstance(IntPtr value) => new VkInstance(value);

        public static implicit operator VkInstance(void* value) => new VkInstance(value);

        public static implicit operator IntPtr(VkInstance value) => new IntPtr(value._value);

        public static implicit operator void*(VkInstance value) => value._value;

        public override bool Equals(object? obj) => (obj is VkInstance other) && Equals(other);

        public bool Equals(VkInstance other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
