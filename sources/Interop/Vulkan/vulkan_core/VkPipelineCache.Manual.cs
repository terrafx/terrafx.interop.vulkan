// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.154
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkPipelineCache : IEquatable<VkPipelineCache>
    {
        private ulong _value;

        public VkPipelineCache(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkPipelineCache l, VkPipelineCache r) => l._value == r._value;

        public static bool operator !=(VkPipelineCache l, VkPipelineCache r) => !(l == r);

        public static implicit operator VkPipelineCache(ulong value) => new VkPipelineCache(value);

        public static implicit operator ulong(VkPipelineCache value) => value._value;

        public override bool Equals(object? obj) => (obj is VkPipelineCache other) && Equals(other);

        public bool Equals(VkPipelineCache other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
