// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkEvent : IComparable, IComparable<VkEvent>, IEquatable<VkEvent>, IFormattable
{
    public readonly ulong Value;

    public VkEvent(ulong value)
    {
        Value = value;
    }

    public static VkEvent NULL => new VkEvent(0);

    public static bool operator ==(VkEvent left, VkEvent right) => left.Value == right.Value;

    public static bool operator !=(VkEvent left, VkEvent right) => left.Value != right.Value;

    public static bool operator <(VkEvent left, VkEvent right) => left.Value < right.Value;

    public static bool operator <=(VkEvent left, VkEvent right) => left.Value <= right.Value;

    public static bool operator >(VkEvent left, VkEvent right) => left.Value > right.Value;

    public static bool operator >=(VkEvent left, VkEvent right) => left.Value >= right.Value;

    public static implicit operator VkEvent(byte value) => new VkEvent(value);

    public static explicit operator byte(VkEvent value) => (byte)(value.Value);

    public static explicit operator VkEvent(short value) => new VkEvent(unchecked((ulong)(value)));

    public static explicit operator short(VkEvent value) => (short)(value.Value);

    public static explicit operator VkEvent(int value) => new VkEvent(unchecked((ulong)(value)));

    public static explicit operator int(VkEvent value) => (int)(value.Value);

    public static explicit operator VkEvent(long value) => new VkEvent(unchecked((ulong)(value)));

    public static explicit operator long(VkEvent value) => (long)(value.Value);

    public static explicit operator VkEvent(nint value) => new VkEvent(unchecked((ulong)(value)));

    public static explicit operator nint(VkEvent value) => (nint)(value.Value);

    public static explicit operator VkEvent(sbyte value) => new VkEvent(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkEvent value) => (sbyte)(value.Value);

    public static implicit operator VkEvent(ushort value) => new VkEvent(value);

    public static explicit operator ushort(VkEvent value) => (ushort)(value.Value);

    public static implicit operator VkEvent(uint value) => new VkEvent(value);

    public static explicit operator uint(VkEvent value) => (uint)(value.Value);

    public static implicit operator VkEvent(ulong value) => new VkEvent(value);

    public static implicit operator ulong(VkEvent value) => value.Value;

    public static implicit operator VkEvent(nuint value) => new VkEvent(value);

    public static explicit operator nuint(VkEvent value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkEvent other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkEvent.");
    }

    public int CompareTo(VkEvent other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkEvent other) && Equals(other);

    public bool Equals(VkEvent other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
