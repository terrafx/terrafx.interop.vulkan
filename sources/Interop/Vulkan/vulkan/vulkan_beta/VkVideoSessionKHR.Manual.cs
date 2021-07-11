// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkVideoSessionKHR : IEquatable<VkVideoSessionKHR>
    {
        private ulong _value;

        public VkVideoSessionKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkVideoSessionKHR l, VkVideoSessionKHR r) => l._value == r._value;

        public static bool operator !=(VkVideoSessionKHR l, VkVideoSessionKHR r) => !(l == r);

        public static implicit operator VkVideoSessionKHR(ulong value) => new VkVideoSessionKHR(value);

        public static implicit operator ulong(VkVideoSessionKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkVideoSessionKHR other) && Equals(other);

        public bool Equals(VkVideoSessionKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
