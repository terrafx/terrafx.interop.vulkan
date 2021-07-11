// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkQueue : IEquatable<VkQueue>
    {
        private void* _value;

        public VkQueue(IntPtr value) : this(value.ToPointer())
        {
        }

        public VkQueue(void* value)
        {
            _value = value;
        }

        public static bool operator ==(VkQueue l, VkQueue r) => l._value == r._value;

        public static bool operator !=(VkQueue l, VkQueue r) => !(l == r);

        public static implicit operator VkQueue(IntPtr value) => new VkQueue(value);

        public static implicit operator VkQueue(void* value) => new VkQueue(value);

        public static implicit operator IntPtr(VkQueue value) => new IntPtr(value._value);

        public static implicit operator void*(VkQueue value) => value._value;

        public override bool Equals(object? obj) => (obj is VkQueue other) && Equals(other);

        public bool Equals(VkQueue other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
