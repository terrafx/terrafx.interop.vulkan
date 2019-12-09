// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkShaderModule : IEquatable<VkShaderModule>
    {
        private ulong _value;

        public VkShaderModule(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkShaderModule l, VkShaderModule r) => l._value == r._value;

        public static bool operator !=(VkShaderModule l, VkShaderModule r) => !(l == r);

        public static implicit operator VkShaderModule(ulong value) => new VkShaderModule(value);

        public static implicit operator ulong(VkShaderModule value) => value._value;

        public override bool Equals(object? obj) => (obj is VkShaderModule other) && Equals(other);

        public bool Equals(VkShaderModule other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
