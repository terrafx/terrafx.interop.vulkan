// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkImage : IEquatable<VkImage>
    {
        private ulong _value;

        public VkImage(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkImage l, VkImage r) => l._value == r._value;

        public static bool operator !=(VkImage l, VkImage r) => !(l == r);

        public static implicit operator VkImage(ulong value) => new VkImage(value);

        public static implicit operator ulong(VkImage value) => value._value;

        public override bool Equals(object? obj) => (obj is VkImage other) && Equals(other);

        public bool Equals(VkImage other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
