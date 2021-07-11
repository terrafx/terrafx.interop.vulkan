// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.182
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkPipeline : IEquatable<VkPipeline>
    {
        private ulong _value;

        public VkPipeline(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkPipeline l, VkPipeline r) => l._value == r._value;

        public static bool operator !=(VkPipeline l, VkPipeline r) => !(l == r);

        public static implicit operator VkPipeline(ulong value) => new VkPipeline(value);

        public static implicit operator ulong(VkPipeline value) => value._value;

        public override bool Equals(object? obj) => (obj is VkPipeline other) && Equals(other);

        public bool Equals(VkPipeline other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
