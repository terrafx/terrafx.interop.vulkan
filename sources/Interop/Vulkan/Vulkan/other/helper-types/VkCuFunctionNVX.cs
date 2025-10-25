// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkCuFunctionNVX : IComparable, IComparable<VkCuFunctionNVX>, IEquatable<VkCuFunctionNVX>, IFormattable
{
    public readonly ulong Value;

    public VkCuFunctionNVX(ulong value)
    {
        Value = value;
    }

    public static VkCuFunctionNVX NULL => new VkCuFunctionNVX(0);

    public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value == right.Value;

    public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value != right.Value;

    public static bool operator <(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value < right.Value;

    public static bool operator <=(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value <= right.Value;

    public static bool operator >(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value > right.Value;

    public static bool operator >=(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Value >= right.Value;

    public static implicit operator VkCuFunctionNVX(byte value) => new VkCuFunctionNVX(value);

    public static explicit operator byte(VkCuFunctionNVX value) => (byte)(value.Value);

    public static explicit operator VkCuFunctionNVX(short value) => new VkCuFunctionNVX(unchecked((ulong)(value)));

    public static explicit operator short(VkCuFunctionNVX value) => (short)(value.Value);

    public static explicit operator VkCuFunctionNVX(int value) => new VkCuFunctionNVX(unchecked((ulong)(value)));

    public static explicit operator int(VkCuFunctionNVX value) => (int)(value.Value);

    public static explicit operator VkCuFunctionNVX(long value) => new VkCuFunctionNVX(unchecked((ulong)(value)));

    public static explicit operator long(VkCuFunctionNVX value) => (long)(value.Value);

    public static explicit operator VkCuFunctionNVX(nint value) => new VkCuFunctionNVX(unchecked((ulong)(value)));

    public static explicit operator nint(VkCuFunctionNVX value) => (nint)(value.Value);

    public static explicit operator VkCuFunctionNVX(sbyte value) => new VkCuFunctionNVX(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkCuFunctionNVX value) => (sbyte)(value.Value);

    public static implicit operator VkCuFunctionNVX(ushort value) => new VkCuFunctionNVX(value);

    public static explicit operator ushort(VkCuFunctionNVX value) => (ushort)(value.Value);

    public static implicit operator VkCuFunctionNVX(uint value) => new VkCuFunctionNVX(value);

    public static explicit operator uint(VkCuFunctionNVX value) => (uint)(value.Value);

    public static implicit operator VkCuFunctionNVX(ulong value) => new VkCuFunctionNVX(value);

    public static implicit operator ulong(VkCuFunctionNVX value) => value.Value;

    public static implicit operator VkCuFunctionNVX(nuint value) => new VkCuFunctionNVX(value);

    public static explicit operator nuint(VkCuFunctionNVX value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCuFunctionNVX other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCuFunctionNVX.");
    }

    public int CompareTo(VkCuFunctionNVX other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkCuFunctionNVX other) && Equals(other);

    public bool Equals(VkCuFunctionNVX other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
