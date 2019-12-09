// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkIndirectCommandsLayoutNVX : IEquatable<VkIndirectCommandsLayoutNVX>
    {
        private ulong _value;

        public VkIndirectCommandsLayoutNVX(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkIndirectCommandsLayoutNVX l, VkIndirectCommandsLayoutNVX r) => l._value == r._value;

        public static bool operator !=(VkIndirectCommandsLayoutNVX l, VkIndirectCommandsLayoutNVX r) => !(l == r);

        public static implicit operator VkIndirectCommandsLayoutNVX(ulong value) => new VkIndirectCommandsLayoutNVX(value);

        public static implicit operator ulong(VkIndirectCommandsLayoutNVX value) => value._value;

        public override bool Equals(object? obj) => (obj is VkIndirectCommandsLayoutNVX other) && Equals(other);

        public bool Equals(VkIndirectCommandsLayoutNVX other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
