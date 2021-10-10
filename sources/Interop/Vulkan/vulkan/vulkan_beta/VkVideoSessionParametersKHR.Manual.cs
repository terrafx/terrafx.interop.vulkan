// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkVideoSessionParametersKHR : IEquatable<VkVideoSessionParametersKHR>
    {
        private ulong _value;

        public VkVideoSessionParametersKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkVideoSessionParametersKHR l, VkVideoSessionParametersKHR r) => l._value == r._value;

        public static bool operator !=(VkVideoSessionParametersKHR l, VkVideoSessionParametersKHR r) => !(l == r);

        public static implicit operator VkVideoSessionParametersKHR(ulong value) => new VkVideoSessionParametersKHR(value);

        public static implicit operator ulong(VkVideoSessionParametersKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkVideoSessionParametersKHR other) && Equals(other);

        public bool Equals(VkVideoSessionParametersKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
