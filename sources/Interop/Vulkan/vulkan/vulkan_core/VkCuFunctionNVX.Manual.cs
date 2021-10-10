// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkCuFunctionNVX : IEquatable<VkCuFunctionNVX>
    {
        private ulong _value;

        public VkCuFunctionNVX(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkCuFunctionNVX l, VkCuFunctionNVX r) => l._value == r._value;

        public static bool operator !=(VkCuFunctionNVX l, VkCuFunctionNVX r) => !(l == r);

        public static implicit operator VkCuFunctionNVX(ulong value) => new VkCuFunctionNVX(value);

        public static implicit operator ulong(VkCuFunctionNVX value) => value._value;

        public override bool Equals(object? obj) => (obj is VkCuFunctionNVX other) && Equals(other);

        public bool Equals(VkCuFunctionNVX other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
