// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkAccelerationStructureKHR : IEquatable<VkAccelerationStructureKHR>
    {
        private ulong _value;

        public VkAccelerationStructureKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkAccelerationStructureKHR l, VkAccelerationStructureKHR r) => l._value == r._value;

        public static bool operator !=(VkAccelerationStructureKHR l, VkAccelerationStructureKHR r) => !(l == r);

        public static implicit operator VkAccelerationStructureKHR(ulong value) => new VkAccelerationStructureKHR(value);

        public static implicit operator ulong(VkAccelerationStructureKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkAccelerationStructureKHR other) && Equals(other);

        public bool Equals(VkAccelerationStructureKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
