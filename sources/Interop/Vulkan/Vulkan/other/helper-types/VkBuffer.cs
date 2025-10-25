// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkBuffer : IComparable, IComparable<VkBuffer>, IEquatable<VkBuffer>, IFormattable
{
    public readonly ulong Value;

    public VkBuffer(ulong value)
    {
        Value = value;
    }

    public static VkBuffer NULL => new VkBuffer(0);

    public static bool operator ==(VkBuffer left, VkBuffer right) => left.Value == right.Value;

    public static bool operator !=(VkBuffer left, VkBuffer right) => left.Value != right.Value;

    public static bool operator <(VkBuffer left, VkBuffer right) => left.Value < right.Value;

    public static bool operator <=(VkBuffer left, VkBuffer right) => left.Value <= right.Value;

    public static bool operator >(VkBuffer left, VkBuffer right) => left.Value > right.Value;

    public static bool operator >=(VkBuffer left, VkBuffer right) => left.Value >= right.Value;

    public static implicit operator VkBuffer(byte value) => new VkBuffer(value);

    public static explicit operator byte(VkBuffer value) => (byte)(value.Value);

    public static explicit operator VkBuffer(short value) => new VkBuffer(unchecked((ulong)(value)));

    public static explicit operator short(VkBuffer value) => (short)(value.Value);

    public static explicit operator VkBuffer(int value) => new VkBuffer(unchecked((ulong)(value)));

    public static explicit operator int(VkBuffer value) => (int)(value.Value);

    public static explicit operator VkBuffer(long value) => new VkBuffer(unchecked((ulong)(value)));

    public static explicit operator long(VkBuffer value) => (long)(value.Value);

    public static explicit operator VkBuffer(nint value) => new VkBuffer(unchecked((ulong)(value)));

    public static explicit operator nint(VkBuffer value) => (nint)(value.Value);

    public static explicit operator VkBuffer(sbyte value) => new VkBuffer(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkBuffer value) => (sbyte)(value.Value);

    public static implicit operator VkBuffer(ushort value) => new VkBuffer(value);

    public static explicit operator ushort(VkBuffer value) => (ushort)(value.Value);

    public static implicit operator VkBuffer(uint value) => new VkBuffer(value);

    public static explicit operator uint(VkBuffer value) => (uint)(value.Value);

    public static implicit operator VkBuffer(ulong value) => new VkBuffer(value);

    public static implicit operator ulong(VkBuffer value) => value.Value;

    public static implicit operator VkBuffer(nuint value) => new VkBuffer(value);

    public static explicit operator nuint(VkBuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkBuffer other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkBuffer.");
    }

    public int CompareTo(VkBuffer other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkBuffer other) && Equals(other);

    public bool Equals(VkBuffer other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
