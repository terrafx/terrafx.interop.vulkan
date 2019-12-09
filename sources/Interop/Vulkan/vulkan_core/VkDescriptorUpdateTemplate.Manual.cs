// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDescriptorUpdateTemplate : IEquatable<VkDescriptorUpdateTemplate>
    {
        private ulong _value;

        public VkDescriptorUpdateTemplate(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDescriptorUpdateTemplate l, VkDescriptorUpdateTemplate r) => l._value == r._value;

        public static bool operator !=(VkDescriptorUpdateTemplate l, VkDescriptorUpdateTemplate r) => !(l == r);

        public static implicit operator VkDescriptorUpdateTemplate(ulong value) => new VkDescriptorUpdateTemplate(value);

        public static implicit operator ulong(VkDescriptorUpdateTemplate value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDescriptorUpdateTemplate other) && Equals(other);

        public bool Equals(VkDescriptorUpdateTemplate other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
