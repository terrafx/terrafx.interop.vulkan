// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDescriptorPool : IEquatable<VkDescriptorPool>
    {
        private ulong _value;

        public VkDescriptorPool(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDescriptorPool l, VkDescriptorPool r) => l._value == r._value;

        public static bool operator !=(VkDescriptorPool l, VkDescriptorPool r) => !(l == r);

        public static implicit operator VkDescriptorPool(ulong value) => new VkDescriptorPool(value);

        public static implicit operator ulong(VkDescriptorPool value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDescriptorPool other) && Equals(other);

        public bool Equals(VkDescriptorPool other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
