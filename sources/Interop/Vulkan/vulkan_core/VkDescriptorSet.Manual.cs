// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDescriptorSet : IEquatable<VkDescriptorSet>
    {
        private ulong _value;

        public VkDescriptorSet(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDescriptorSet l, VkDescriptorSet r) => l._value == r._value;

        public static bool operator !=(VkDescriptorSet l, VkDescriptorSet r) => !(l == r);

        public static implicit operator VkDescriptorSet(ulong value) => new VkDescriptorSet(value);

        public static implicit operator ulong(VkDescriptorSet value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDescriptorSet other) && Equals(other);

        public bool Equals(VkDescriptorSet other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
