// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkQueryPool : IEquatable<VkQueryPool>
    {
        private ulong _value;

        public VkQueryPool(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkQueryPool l, VkQueryPool r) => l._value == r._value;

        public static bool operator !=(VkQueryPool l, VkQueryPool r) => !(l == r);

        public static implicit operator VkQueryPool(ulong value) => new VkQueryPool(value);

        public static implicit operator ulong(VkQueryPool value) => value._value;

        public override bool Equals(object? obj) => (obj is VkQueryPool other) && Equals(other);

        public bool Equals(VkQueryPool other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
