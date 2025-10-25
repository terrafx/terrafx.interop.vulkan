// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPerformanceConfigurationINTEL : IComparable, IComparable<VkPerformanceConfigurationINTEL>, IEquatable<VkPerformanceConfigurationINTEL>, IFormattable
{
    public readonly ulong Value;

    public VkPerformanceConfigurationINTEL(ulong value)
    {
        Value = value;
    }

    public static VkPerformanceConfigurationINTEL NULL => new VkPerformanceConfigurationINTEL(0);

    public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value == right.Value;

    public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value != right.Value;

    public static bool operator <(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value < right.Value;

    public static bool operator <=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value <= right.Value;

    public static bool operator >(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value > right.Value;

    public static bool operator >=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Value >= right.Value;

    public static implicit operator VkPerformanceConfigurationINTEL(byte value) => new VkPerformanceConfigurationINTEL(value);

    public static explicit operator byte(VkPerformanceConfigurationINTEL value) => (byte)(value.Value);

    public static explicit operator VkPerformanceConfigurationINTEL(short value) => new VkPerformanceConfigurationINTEL(unchecked((ulong)(value)));

    public static explicit operator short(VkPerformanceConfigurationINTEL value) => (short)(value.Value);

    public static explicit operator VkPerformanceConfigurationINTEL(int value) => new VkPerformanceConfigurationINTEL(unchecked((ulong)(value)));

    public static explicit operator int(VkPerformanceConfigurationINTEL value) => (int)(value.Value);

    public static explicit operator VkPerformanceConfigurationINTEL(long value) => new VkPerformanceConfigurationINTEL(unchecked((ulong)(value)));

    public static explicit operator long(VkPerformanceConfigurationINTEL value) => (long)(value.Value);

    public static explicit operator VkPerformanceConfigurationINTEL(nint value) => new VkPerformanceConfigurationINTEL(unchecked((ulong)(value)));

    public static explicit operator nint(VkPerformanceConfigurationINTEL value) => (nint)(value.Value);

    public static explicit operator VkPerformanceConfigurationINTEL(sbyte value) => new VkPerformanceConfigurationINTEL(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPerformanceConfigurationINTEL value) => (sbyte)(value.Value);

    public static implicit operator VkPerformanceConfigurationINTEL(ushort value) => new VkPerformanceConfigurationINTEL(value);

    public static explicit operator ushort(VkPerformanceConfigurationINTEL value) => (ushort)(value.Value);

    public static implicit operator VkPerformanceConfigurationINTEL(uint value) => new VkPerformanceConfigurationINTEL(value);

    public static explicit operator uint(VkPerformanceConfigurationINTEL value) => (uint)(value.Value);

    public static implicit operator VkPerformanceConfigurationINTEL(ulong value) => new VkPerformanceConfigurationINTEL(value);

    public static implicit operator ulong(VkPerformanceConfigurationINTEL value) => value.Value;

    public static implicit operator VkPerformanceConfigurationINTEL(nuint value) => new VkPerformanceConfigurationINTEL(value);

    public static explicit operator nuint(VkPerformanceConfigurationINTEL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPerformanceConfigurationINTEL other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPerformanceConfigurationINTEL.");
    }

    public int CompareTo(VkPerformanceConfigurationINTEL other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPerformanceConfigurationINTEL other) && Equals(other);

    public bool Equals(VkPerformanceConfigurationINTEL other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
