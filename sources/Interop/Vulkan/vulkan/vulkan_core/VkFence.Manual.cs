// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkFence : IEquatable<VkFence>
    {
        private ulong _value;

        public VkFence(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkFence l, VkFence r) => l._value == r._value;

        public static bool operator !=(VkFence l, VkFence r) => !(l == r);

        public static implicit operator VkFence(ulong value) => new VkFence(value);

        public static implicit operator ulong(VkFence value) => value._value;

        public override bool Equals(object? obj) => (obj is VkFence other) && Equals(other);

        public bool Equals(VkFence other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
