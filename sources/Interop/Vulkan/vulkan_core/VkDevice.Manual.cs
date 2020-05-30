// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkDevice : IEquatable<VkDevice>
    {
        private void* _value;

        public VkDevice(IntPtr value) : this(value.ToPointer())
        {
        }

        public VkDevice(void* value)
        {
            _value = value;
        }

        public static bool operator ==(VkDevice l, VkDevice r) => l._value == r._value;

        public static bool operator !=(VkDevice l, VkDevice r) => !(l == r);

        public static implicit operator VkDevice(IntPtr value) => new VkDevice(value);

        public static implicit operator VkDevice(void* value) => new VkDevice(value);

        public static implicit operator IntPtr(VkDevice value) => new IntPtr(value._value);

        public static implicit operator void*(VkDevice value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDevice other) && Equals(other);

        public bool Equals(VkDevice other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
