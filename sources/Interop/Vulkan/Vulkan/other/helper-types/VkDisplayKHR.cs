// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDisplayKHR : IComparable, IComparable<VkDisplayKHR>, IEquatable<VkDisplayKHR>, IFormattable
{
    public readonly ulong Value;

    public VkDisplayKHR(ulong value)
    {
        Value = value;
    }

    public static VkDisplayKHR NULL => new VkDisplayKHR(0);

    public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) => left.Value == right.Value;

    public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) => left.Value != right.Value;

    public static bool operator <(VkDisplayKHR left, VkDisplayKHR right) => left.Value < right.Value;

    public static bool operator <=(VkDisplayKHR left, VkDisplayKHR right) => left.Value <= right.Value;

    public static bool operator >(VkDisplayKHR left, VkDisplayKHR right) => left.Value > right.Value;

    public static bool operator >=(VkDisplayKHR left, VkDisplayKHR right) => left.Value >= right.Value;

    public static implicit operator VkDisplayKHR(byte value) => new VkDisplayKHR(value);

    public static explicit operator byte(VkDisplayKHR value) => (byte)(value.Value);

    public static explicit operator VkDisplayKHR(short value) => new VkDisplayKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkDisplayKHR value) => (short)(value.Value);

    public static explicit operator VkDisplayKHR(int value) => new VkDisplayKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkDisplayKHR value) => (int)(value.Value);

    public static explicit operator VkDisplayKHR(long value) => new VkDisplayKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkDisplayKHR value) => (long)(value.Value);

    public static explicit operator VkDisplayKHR(nint value) => new VkDisplayKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkDisplayKHR value) => (nint)(value.Value);

    public static explicit operator VkDisplayKHR(sbyte value) => new VkDisplayKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDisplayKHR value) => (sbyte)(value.Value);

    public static implicit operator VkDisplayKHR(ushort value) => new VkDisplayKHR(value);

    public static explicit operator ushort(VkDisplayKHR value) => (ushort)(value.Value);

    public static implicit operator VkDisplayKHR(uint value) => new VkDisplayKHR(value);

    public static explicit operator uint(VkDisplayKHR value) => (uint)(value.Value);

    public static implicit operator VkDisplayKHR(ulong value) => new VkDisplayKHR(value);

    public static implicit operator ulong(VkDisplayKHR value) => value.Value;

    public static implicit operator VkDisplayKHR(nuint value) => new VkDisplayKHR(value);

    public static explicit operator nuint(VkDisplayKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDisplayKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDisplayKHR.");
    }

    public int CompareTo(VkDisplayKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDisplayKHR other) && Equals(other);

    public bool Equals(VkDisplayKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
