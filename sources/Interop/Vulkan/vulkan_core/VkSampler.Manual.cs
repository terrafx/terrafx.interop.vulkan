// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkSampler : IEquatable<VkSampler>
    {
        private ulong _value;

        public VkSampler(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkSampler l, VkSampler r) => l._value == r._value;

        public static bool operator !=(VkSampler l, VkSampler r) => !(l == r);

        public static implicit operator VkSampler(ulong value) => new VkSampler(value);

        public static implicit operator ulong(VkSampler value) => value._value;

        public override bool Equals(object? obj) => (obj is VkSampler other) && Equals(other);

        public bool Equals(VkSampler other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
