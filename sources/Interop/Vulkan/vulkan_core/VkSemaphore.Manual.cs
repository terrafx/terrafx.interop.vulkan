// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.162
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkSemaphore : IEquatable<VkSemaphore>
    {
        private ulong _value;

        public VkSemaphore(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkSemaphore l, VkSemaphore r) => l._value == r._value;

        public static bool operator !=(VkSemaphore l, VkSemaphore r) => !(l == r);

        public static implicit operator VkSemaphore(ulong value) => new VkSemaphore(value);

        public static implicit operator ulong(VkSemaphore value) => value._value;

        public override bool Equals(object? obj) => (obj is VkSemaphore other) && Equals(other);

        public bool Equals(VkSemaphore other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
