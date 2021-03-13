// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.170
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
    {
        private ulong _value;

        public VkSurfaceKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkSurfaceKHR l, VkSurfaceKHR r) => l._value == r._value;

        public static bool operator !=(VkSurfaceKHR l, VkSurfaceKHR r) => !(l == r);

        public static implicit operator VkSurfaceKHR(ulong value) => new VkSurfaceKHR(value);

        public static implicit operator ulong(VkSurfaceKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkSurfaceKHR other) && Equals(other);

        public bool Equals(VkSurfaceKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
