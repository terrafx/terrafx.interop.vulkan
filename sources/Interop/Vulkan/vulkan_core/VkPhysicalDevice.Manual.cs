// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
    {
        private void* _value;

        public VkPhysicalDevice(IntPtr value) : this(value.ToPointer())
        {
        }

        public VkPhysicalDevice(void* value)
        {
            _value = value;
        }

        public static bool operator ==(VkPhysicalDevice l, VkPhysicalDevice r) => l._value == r._value;

        public static bool operator !=(VkPhysicalDevice l, VkPhysicalDevice r) => !(l == r);

        public static implicit operator VkPhysicalDevice(IntPtr value) => new VkPhysicalDevice(value);

        public static implicit operator VkPhysicalDevice(void* value) => new VkPhysicalDevice(value);

        public static implicit operator IntPtr(VkPhysicalDevice value) => new IntPtr(value._value);

        public static implicit operator void*(VkPhysicalDevice value) => value._value;

        public override bool Equals(object? obj) => (obj is VkPhysicalDevice other) && Equals(other);

        public bool Equals(VkPhysicalDevice other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
