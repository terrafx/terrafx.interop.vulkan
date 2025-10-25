// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkImageView : IComparable, IComparable<VkImageView>, IEquatable<VkImageView>, IFormattable
{
    public readonly ulong Value;

    public VkImageView(ulong value)
    {
        Value = value;
    }

    public static VkImageView NULL => new VkImageView(0);

    public static bool operator ==(VkImageView left, VkImageView right) => left.Value == right.Value;

    public static bool operator !=(VkImageView left, VkImageView right) => left.Value != right.Value;

    public static bool operator <(VkImageView left, VkImageView right) => left.Value < right.Value;

    public static bool operator <=(VkImageView left, VkImageView right) => left.Value <= right.Value;

    public static bool operator >(VkImageView left, VkImageView right) => left.Value > right.Value;

    public static bool operator >=(VkImageView left, VkImageView right) => left.Value >= right.Value;

    public static implicit operator VkImageView(byte value) => new VkImageView(value);

    public static explicit operator byte(VkImageView value) => (byte)(value.Value);

    public static explicit operator VkImageView(short value) => new VkImageView(unchecked((ulong)(value)));

    public static explicit operator short(VkImageView value) => (short)(value.Value);

    public static explicit operator VkImageView(int value) => new VkImageView(unchecked((ulong)(value)));

    public static explicit operator int(VkImageView value) => (int)(value.Value);

    public static explicit operator VkImageView(long value) => new VkImageView(unchecked((ulong)(value)));

    public static explicit operator long(VkImageView value) => (long)(value.Value);

    public static explicit operator VkImageView(nint value) => new VkImageView(unchecked((ulong)(value)));

    public static explicit operator nint(VkImageView value) => (nint)(value.Value);

    public static explicit operator VkImageView(sbyte value) => new VkImageView(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkImageView value) => (sbyte)(value.Value);

    public static implicit operator VkImageView(ushort value) => new VkImageView(value);

    public static explicit operator ushort(VkImageView value) => (ushort)(value.Value);

    public static implicit operator VkImageView(uint value) => new VkImageView(value);

    public static explicit operator uint(VkImageView value) => (uint)(value.Value);

    public static implicit operator VkImageView(ulong value) => new VkImageView(value);

    public static implicit operator ulong(VkImageView value) => value.Value;

    public static implicit operator VkImageView(nuint value) => new VkImageView(value);

    public static explicit operator nuint(VkImageView value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkImageView other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkImageView.");
    }

    public int CompareTo(VkImageView other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkImageView other) && Equals(other);

    public bool Equals(VkImageView other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
