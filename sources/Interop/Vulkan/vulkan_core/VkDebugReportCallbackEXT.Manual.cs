// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from vulkan/vulkan_core.h in the Vulkan-Headers repository for tag v1.1.126
// Original source is Copyright © 2015-2019 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkDebugReportCallbackEXT : IEquatable<VkDebugReportCallbackEXT>
    {
        private ulong _value;

        public VkDebugReportCallbackEXT(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkDebugReportCallbackEXT l, VkDebugReportCallbackEXT r) => l._value == r._value;

        public static bool operator !=(VkDebugReportCallbackEXT l, VkDebugReportCallbackEXT r) => !(l == r);

        public static implicit operator VkDebugReportCallbackEXT(ulong value) => new VkDebugReportCallbackEXT(value);

        public static implicit operator ulong(VkDebugReportCallbackEXT value) => value._value;

        public override bool Equals(object? obj) => (obj is VkDebugReportCallbackEXT other) && Equals(other);

        public bool Equals(VkDebugReportCallbackEXT other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
