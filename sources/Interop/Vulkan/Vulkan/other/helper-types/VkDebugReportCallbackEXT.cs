// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDebugReportCallbackEXT : IComparable, IComparable<VkDebugReportCallbackEXT>, IEquatable<VkDebugReportCallbackEXT>, IFormattable
{
    public readonly ulong Value;

    public VkDebugReportCallbackEXT(ulong value)
    {
        Value = value;
    }

    public static VkDebugReportCallbackEXT NULL => new VkDebugReportCallbackEXT(0);

    public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value == right.Value;

    public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value != right.Value;

    public static bool operator <(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value < right.Value;

    public static bool operator <=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value <= right.Value;

    public static bool operator >(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value > right.Value;

    public static bool operator >=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Value >= right.Value;

    public static implicit operator VkDebugReportCallbackEXT(byte value) => new VkDebugReportCallbackEXT(value);

    public static explicit operator byte(VkDebugReportCallbackEXT value) => (byte)(value.Value);

    public static explicit operator VkDebugReportCallbackEXT(short value) => new VkDebugReportCallbackEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkDebugReportCallbackEXT value) => (short)(value.Value);

    public static explicit operator VkDebugReportCallbackEXT(int value) => new VkDebugReportCallbackEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkDebugReportCallbackEXT value) => (int)(value.Value);

    public static explicit operator VkDebugReportCallbackEXT(long value) => new VkDebugReportCallbackEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkDebugReportCallbackEXT value) => (long)(value.Value);

    public static explicit operator VkDebugReportCallbackEXT(nint value) => new VkDebugReportCallbackEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkDebugReportCallbackEXT value) => (nint)(value.Value);

    public static explicit operator VkDebugReportCallbackEXT(sbyte value) => new VkDebugReportCallbackEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDebugReportCallbackEXT value) => (sbyte)(value.Value);

    public static implicit operator VkDebugReportCallbackEXT(ushort value) => new VkDebugReportCallbackEXT(value);

    public static explicit operator ushort(VkDebugReportCallbackEXT value) => (ushort)(value.Value);

    public static implicit operator VkDebugReportCallbackEXT(uint value) => new VkDebugReportCallbackEXT(value);

    public static explicit operator uint(VkDebugReportCallbackEXT value) => (uint)(value.Value);

    public static implicit operator VkDebugReportCallbackEXT(ulong value) => new VkDebugReportCallbackEXT(value);

    public static implicit operator ulong(VkDebugReportCallbackEXT value) => value.Value;

    public static implicit operator VkDebugReportCallbackEXT(nuint value) => new VkDebugReportCallbackEXT(value);

    public static explicit operator nuint(VkDebugReportCallbackEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDebugReportCallbackEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDebugReportCallbackEXT.");
    }

    public int CompareTo(VkDebugReportCallbackEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDebugReportCallbackEXT other) && Equals(other);

    public bool Equals(VkDebugReportCallbackEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
