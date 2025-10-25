// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkSampler : IComparable, IComparable<VkSampler>, IEquatable<VkSampler>, IFormattable
{
    public readonly ulong Value;

    public VkSampler(ulong value)
    {
        Value = value;
    }

    public static VkSampler NULL => new VkSampler(0);

    public static bool operator ==(VkSampler left, VkSampler right) => left.Value == right.Value;

    public static bool operator !=(VkSampler left, VkSampler right) => left.Value != right.Value;

    public static bool operator <(VkSampler left, VkSampler right) => left.Value < right.Value;

    public static bool operator <=(VkSampler left, VkSampler right) => left.Value <= right.Value;

    public static bool operator >(VkSampler left, VkSampler right) => left.Value > right.Value;

    public static bool operator >=(VkSampler left, VkSampler right) => left.Value >= right.Value;

    public static implicit operator VkSampler(byte value) => new VkSampler(value);

    public static explicit operator byte(VkSampler value) => (byte)(value.Value);

    public static explicit operator VkSampler(short value) => new VkSampler(unchecked((ulong)(value)));

    public static explicit operator short(VkSampler value) => (short)(value.Value);

    public static explicit operator VkSampler(int value) => new VkSampler(unchecked((ulong)(value)));

    public static explicit operator int(VkSampler value) => (int)(value.Value);

    public static explicit operator VkSampler(long value) => new VkSampler(unchecked((ulong)(value)));

    public static explicit operator long(VkSampler value) => (long)(value.Value);

    public static explicit operator VkSampler(nint value) => new VkSampler(unchecked((ulong)(value)));

    public static explicit operator nint(VkSampler value) => (nint)(value.Value);

    public static explicit operator VkSampler(sbyte value) => new VkSampler(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkSampler value) => (sbyte)(value.Value);

    public static implicit operator VkSampler(ushort value) => new VkSampler(value);

    public static explicit operator ushort(VkSampler value) => (ushort)(value.Value);

    public static implicit operator VkSampler(uint value) => new VkSampler(value);

    public static explicit operator uint(VkSampler value) => (uint)(value.Value);

    public static implicit operator VkSampler(ulong value) => new VkSampler(value);

    public static implicit operator ulong(VkSampler value) => value.Value;

    public static implicit operator VkSampler(nuint value) => new VkSampler(value);

    public static explicit operator nuint(VkSampler value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkSampler other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkSampler.");
    }

    public int CompareTo(VkSampler other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkSampler other) && Equals(other);

    public bool Equals(VkSampler other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
