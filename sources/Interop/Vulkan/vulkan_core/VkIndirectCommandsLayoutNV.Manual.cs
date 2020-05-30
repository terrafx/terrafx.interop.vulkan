// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.135
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkIndirectCommandsLayoutNV : IEquatable<VkIndirectCommandsLayoutNV>
    {
        private ulong _value;

        public VkIndirectCommandsLayoutNV(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkIndirectCommandsLayoutNV l, VkIndirectCommandsLayoutNV r) => l._value == r._value;

        public static bool operator !=(VkIndirectCommandsLayoutNV l, VkIndirectCommandsLayoutNV r) => !(l == r);

        public static implicit operator VkIndirectCommandsLayoutNV(ulong value) => new VkIndirectCommandsLayoutNV(value);

        public static implicit operator ulong(VkIndirectCommandsLayoutNV value) => value._value;

        public override bool Equals(object? obj) => (obj is VkIndirectCommandsLayoutNV other) && Equals(other);

        public bool Equals(VkIndirectCommandsLayoutNV other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
