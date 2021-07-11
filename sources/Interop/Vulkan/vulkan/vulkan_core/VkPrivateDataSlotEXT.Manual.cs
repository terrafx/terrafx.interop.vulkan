// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkPrivateDataSlotEXT : IEquatable<VkPrivateDataSlotEXT>
    {
        private ulong _value;

        public VkPrivateDataSlotEXT(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkPrivateDataSlotEXT l, VkPrivateDataSlotEXT r) => l._value == r._value;

        public static bool operator !=(VkPrivateDataSlotEXT l, VkPrivateDataSlotEXT r) => !(l == r);

        public static implicit operator VkPrivateDataSlotEXT(ulong value) => new VkPrivateDataSlotEXT(value);

        public static implicit operator ulong(VkPrivateDataSlotEXT value) => value._value;

        public override bool Equals(object? obj) => (obj is VkPrivateDataSlotEXT other) && Equals(other);

        public bool Equals(VkPrivateDataSlotEXT other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
