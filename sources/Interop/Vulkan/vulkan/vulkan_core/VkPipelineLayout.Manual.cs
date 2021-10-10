// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkPipelineLayout : IEquatable<VkPipelineLayout>
    {
        private ulong _value;

        public VkPipelineLayout(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkPipelineLayout l, VkPipelineLayout r) => l._value == r._value;

        public static bool operator !=(VkPipelineLayout l, VkPipelineLayout r) => !(l == r);

        public static implicit operator VkPipelineLayout(ulong value) => new VkPipelineLayout(value);

        public static implicit operator ulong(VkPipelineLayout value) => value._value;

        public override bool Equals(object? obj) => (obj is VkPipelineLayout other) && Equals(other);

        public bool Equals(VkPipelineLayout other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
