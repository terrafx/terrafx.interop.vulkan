// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDisplayKHR : IEquatable<VkDisplayKHR>
    {
        private ulong _value;

        public VkDisplayKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDisplayKHR l, VkDisplayKHR r) => l._value == r._value;

        public static bool operator !=(VkDisplayKHR l, VkDisplayKHR r) => !(l == r);

        public static implicit operator VkDisplayKHR(ulong value) => new VkDisplayKHR(value);

        public static implicit operator ulong(VkDisplayKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDisplayKHR other) && Equals(other);

        public bool Equals(VkDisplayKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
