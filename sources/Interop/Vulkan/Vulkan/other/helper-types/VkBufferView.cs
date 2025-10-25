// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkBufferView : IComparable, IComparable<VkBufferView>, IEquatable<VkBufferView>, IFormattable
{
    public readonly ulong Value;

    public VkBufferView(ulong value)
    {
        Value = value;
    }

    public static VkBufferView NULL => new VkBufferView(0);

    public static bool operator ==(VkBufferView left, VkBufferView right) => left.Value == right.Value;

    public static bool operator !=(VkBufferView left, VkBufferView right) => left.Value != right.Value;

    public static bool operator <(VkBufferView left, VkBufferView right) => left.Value < right.Value;

    public static bool operator <=(VkBufferView left, VkBufferView right) => left.Value <= right.Value;

    public static bool operator >(VkBufferView left, VkBufferView right) => left.Value > right.Value;

    public static bool operator >=(VkBufferView left, VkBufferView right) => left.Value >= right.Value;

    public static implicit operator VkBufferView(byte value) => new VkBufferView(value);

    public static explicit operator byte(VkBufferView value) => (byte)(value.Value);

    public static explicit operator VkBufferView(short value) => new VkBufferView(unchecked((ulong)(value)));

    public static explicit operator short(VkBufferView value) => (short)(value.Value);

    public static explicit operator VkBufferView(int value) => new VkBufferView(unchecked((ulong)(value)));

    public static explicit operator int(VkBufferView value) => (int)(value.Value);

    public static explicit operator VkBufferView(long value) => new VkBufferView(unchecked((ulong)(value)));

    public static explicit operator long(VkBufferView value) => (long)(value.Value);

    public static explicit operator VkBufferView(nint value) => new VkBufferView(unchecked((ulong)(value)));

    public static explicit operator nint(VkBufferView value) => (nint)(value.Value);

    public static explicit operator VkBufferView(sbyte value) => new VkBufferView(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkBufferView value) => (sbyte)(value.Value);

    public static implicit operator VkBufferView(ushort value) => new VkBufferView(value);

    public static explicit operator ushort(VkBufferView value) => (ushort)(value.Value);

    public static implicit operator VkBufferView(uint value) => new VkBufferView(value);

    public static explicit operator uint(VkBufferView value) => (uint)(value.Value);

    public static implicit operator VkBufferView(ulong value) => new VkBufferView(value);

    public static implicit operator ulong(VkBufferView value) => value.Value;

    public static implicit operator VkBufferView(nuint value) => new VkBufferView(value);

    public static explicit operator nuint(VkBufferView value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkBufferView other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkBufferView.");
    }

    public int CompareTo(VkBufferView other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkBufferView other) && Equals(other);

    public bool Equals(VkBufferView other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
