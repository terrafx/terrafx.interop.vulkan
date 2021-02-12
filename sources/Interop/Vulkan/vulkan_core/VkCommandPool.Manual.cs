// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkCommandPool : IEquatable<VkCommandPool>
    {
        private ulong _value;

        public VkCommandPool(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkCommandPool l, VkCommandPool r) => l._value == r._value;

        public static bool operator !=(VkCommandPool l, VkCommandPool r) => !(l == r);

        public static implicit operator VkCommandPool(ulong value) => new VkCommandPool(value);

        public static implicit operator ulong(VkCommandPool value) => value._value;

        public override bool Equals(object? obj) => (obj is VkCommandPool other) && Equals(other);

        public bool Equals(VkCommandPool other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
