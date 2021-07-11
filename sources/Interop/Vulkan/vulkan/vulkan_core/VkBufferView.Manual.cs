// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkBufferView : IEquatable<VkBufferView>
    {
        private ulong _value;

        public VkBufferView(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkBufferView l, VkBufferView r) => l._value == r._value;

        public static bool operator !=(VkBufferView l, VkBufferView r) => !(l == r);

        public static implicit operator VkBufferView(ulong value) => new VkBufferView(value);

        public static implicit operator ulong(VkBufferView value) => value._value;

        public override bool Equals(object? obj) => (obj is VkBufferView other) && Equals(other);

        public bool Equals(VkBufferView other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
