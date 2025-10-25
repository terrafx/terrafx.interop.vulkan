// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkFence : IComparable, IComparable<VkFence>, IEquatable<VkFence>, IFormattable
{
    public readonly ulong Value;

    public VkFence(ulong value)
    {
        Value = value;
    }

    public static VkFence NULL => new VkFence(0);

    public static bool operator ==(VkFence left, VkFence right) => left.Value == right.Value;

    public static bool operator !=(VkFence left, VkFence right) => left.Value != right.Value;

    public static bool operator <(VkFence left, VkFence right) => left.Value < right.Value;

    public static bool operator <=(VkFence left, VkFence right) => left.Value <= right.Value;

    public static bool operator >(VkFence left, VkFence right) => left.Value > right.Value;

    public static bool operator >=(VkFence left, VkFence right) => left.Value >= right.Value;

    public static implicit operator VkFence(byte value) => new VkFence(value);

    public static explicit operator byte(VkFence value) => (byte)(value.Value);

    public static explicit operator VkFence(short value) => new VkFence(unchecked((ulong)(value)));

    public static explicit operator short(VkFence value) => (short)(value.Value);

    public static explicit operator VkFence(int value) => new VkFence(unchecked((ulong)(value)));

    public static explicit operator int(VkFence value) => (int)(value.Value);

    public static explicit operator VkFence(long value) => new VkFence(unchecked((ulong)(value)));

    public static explicit operator long(VkFence value) => (long)(value.Value);

    public static explicit operator VkFence(nint value) => new VkFence(unchecked((ulong)(value)));

    public static explicit operator nint(VkFence value) => (nint)(value.Value);

    public static explicit operator VkFence(sbyte value) => new VkFence(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkFence value) => (sbyte)(value.Value);

    public static implicit operator VkFence(ushort value) => new VkFence(value);

    public static explicit operator ushort(VkFence value) => (ushort)(value.Value);

    public static implicit operator VkFence(uint value) => new VkFence(value);

    public static explicit operator uint(VkFence value) => (uint)(value.Value);

    public static implicit operator VkFence(ulong value) => new VkFence(value);

    public static implicit operator ulong(VkFence value) => value.Value;

    public static implicit operator VkFence(nuint value) => new VkFence(value);

    public static explicit operator nuint(VkFence value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkFence other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkFence.");
    }

    public int CompareTo(VkFence other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkFence other) && Equals(other);

    public bool Equals(VkFence other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
