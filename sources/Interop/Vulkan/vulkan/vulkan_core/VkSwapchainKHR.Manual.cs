// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkSwapchainKHR : IEquatable<VkSwapchainKHR>
    {
        private ulong _value;

        public VkSwapchainKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkSwapchainKHR l, VkSwapchainKHR r) => l._value == r._value;

        public static bool operator !=(VkSwapchainKHR l, VkSwapchainKHR r) => !(l == r);

        public static implicit operator VkSwapchainKHR(ulong value) => new VkSwapchainKHR(value);

        public static implicit operator ulong(VkSwapchainKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkSwapchainKHR other) && Equals(other);

        public bool Equals(VkSwapchainKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
