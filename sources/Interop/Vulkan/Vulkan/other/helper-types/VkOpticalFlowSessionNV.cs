// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkOpticalFlowSessionNV : IComparable, IComparable<VkOpticalFlowSessionNV>, IEquatable<VkOpticalFlowSessionNV>, IFormattable
{
    public readonly ulong Value;

    public VkOpticalFlowSessionNV(ulong value)
    {
        Value = value;
    }

    public static VkOpticalFlowSessionNV NULL => new VkOpticalFlowSessionNV(0);

    public static bool operator ==(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value == right.Value;

    public static bool operator !=(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value != right.Value;

    public static bool operator <(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value < right.Value;

    public static bool operator <=(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value <= right.Value;

    public static bool operator >(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value > right.Value;

    public static bool operator >=(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Value >= right.Value;

    public static implicit operator VkOpticalFlowSessionNV(byte value) => new VkOpticalFlowSessionNV(value);

    public static explicit operator byte(VkOpticalFlowSessionNV value) => (byte)(value.Value);

    public static explicit operator VkOpticalFlowSessionNV(short value) => new VkOpticalFlowSessionNV(unchecked((ulong)(value)));

    public static explicit operator short(VkOpticalFlowSessionNV value) => (short)(value.Value);

    public static explicit operator VkOpticalFlowSessionNV(int value) => new VkOpticalFlowSessionNV(unchecked((ulong)(value)));

    public static explicit operator int(VkOpticalFlowSessionNV value) => (int)(value.Value);

    public static explicit operator VkOpticalFlowSessionNV(long value) => new VkOpticalFlowSessionNV(unchecked((ulong)(value)));

    public static explicit operator long(VkOpticalFlowSessionNV value) => (long)(value.Value);

    public static explicit operator VkOpticalFlowSessionNV(nint value) => new VkOpticalFlowSessionNV(unchecked((ulong)(value)));

    public static explicit operator nint(VkOpticalFlowSessionNV value) => (nint)(value.Value);

    public static explicit operator VkOpticalFlowSessionNV(sbyte value) => new VkOpticalFlowSessionNV(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkOpticalFlowSessionNV value) => (sbyte)(value.Value);

    public static implicit operator VkOpticalFlowSessionNV(ushort value) => new VkOpticalFlowSessionNV(value);

    public static explicit operator ushort(VkOpticalFlowSessionNV value) => (ushort)(value.Value);

    public static implicit operator VkOpticalFlowSessionNV(uint value) => new VkOpticalFlowSessionNV(value);

    public static explicit operator uint(VkOpticalFlowSessionNV value) => (uint)(value.Value);

    public static implicit operator VkOpticalFlowSessionNV(ulong value) => new VkOpticalFlowSessionNV(value);

    public static implicit operator ulong(VkOpticalFlowSessionNV value) => value.Value;

    public static implicit operator VkOpticalFlowSessionNV(nuint value) => new VkOpticalFlowSessionNV(value);

    public static explicit operator nuint(VkOpticalFlowSessionNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkOpticalFlowSessionNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkOpticalFlowSessionNV.");
    }

    public int CompareTo(VkOpticalFlowSessionNV other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkOpticalFlowSessionNV other) && Equals(other);

    public bool Equals(VkOpticalFlowSessionNV other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
