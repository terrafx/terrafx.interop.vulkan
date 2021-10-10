// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDeferredOperationKHR : IEquatable<VkDeferredOperationKHR>
    {
        private ulong _value;

        public VkDeferredOperationKHR(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDeferredOperationKHR l, VkDeferredOperationKHR r) => l._value == r._value;

        public static bool operator !=(VkDeferredOperationKHR l, VkDeferredOperationKHR r) => !(l == r);

        public static implicit operator VkDeferredOperationKHR(ulong value) => new VkDeferredOperationKHR(value);

        public static implicit operator ulong(VkDeferredOperationKHR value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDeferredOperationKHR other) && Equals(other);

        public bool Equals(VkDeferredOperationKHR other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
