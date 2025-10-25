// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkVideoSessionKHR : IComparable, IComparable<VkVideoSessionKHR>, IEquatable<VkVideoSessionKHR>, IFormattable
{
    public readonly ulong Value;

    public VkVideoSessionKHR(ulong value)
    {
        Value = value;
    }

    public static VkVideoSessionKHR NULL => new VkVideoSessionKHR(0);

    public static bool operator ==(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value == right.Value;

    public static bool operator !=(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value != right.Value;

    public static bool operator <(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value < right.Value;

    public static bool operator <=(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value <= right.Value;

    public static bool operator >(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value > right.Value;

    public static bool operator >=(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Value >= right.Value;

    public static implicit operator VkVideoSessionKHR(byte value) => new VkVideoSessionKHR(value);

    public static explicit operator byte(VkVideoSessionKHR value) => (byte)(value.Value);

    public static explicit operator VkVideoSessionKHR(short value) => new VkVideoSessionKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkVideoSessionKHR value) => (short)(value.Value);

    public static explicit operator VkVideoSessionKHR(int value) => new VkVideoSessionKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkVideoSessionKHR value) => (int)(value.Value);

    public static explicit operator VkVideoSessionKHR(long value) => new VkVideoSessionKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkVideoSessionKHR value) => (long)(value.Value);

    public static explicit operator VkVideoSessionKHR(nint value) => new VkVideoSessionKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkVideoSessionKHR value) => (nint)(value.Value);

    public static explicit operator VkVideoSessionKHR(sbyte value) => new VkVideoSessionKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkVideoSessionKHR value) => (sbyte)(value.Value);

    public static implicit operator VkVideoSessionKHR(ushort value) => new VkVideoSessionKHR(value);

    public static explicit operator ushort(VkVideoSessionKHR value) => (ushort)(value.Value);

    public static implicit operator VkVideoSessionKHR(uint value) => new VkVideoSessionKHR(value);

    public static explicit operator uint(VkVideoSessionKHR value) => (uint)(value.Value);

    public static implicit operator VkVideoSessionKHR(ulong value) => new VkVideoSessionKHR(value);

    public static implicit operator ulong(VkVideoSessionKHR value) => value.Value;

    public static implicit operator VkVideoSessionKHR(nuint value) => new VkVideoSessionKHR(value);

    public static explicit operator nuint(VkVideoSessionKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkVideoSessionKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkVideoSessionKHR.");
    }

    public int CompareTo(VkVideoSessionKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkVideoSessionKHR other) && Equals(other);

    public bool Equals(VkVideoSessionKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
