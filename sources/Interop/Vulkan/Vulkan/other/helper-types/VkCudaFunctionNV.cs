// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkCudaFunctionNV : IComparable, IComparable<VkCudaFunctionNV>, IEquatable<VkCudaFunctionNV>, IFormattable
{
    public readonly ulong Value;

    public VkCudaFunctionNV(ulong value)
    {
        Value = value;
    }

    public static VkCudaFunctionNV NULL => new VkCudaFunctionNV(0);

    public static bool operator ==(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value == right.Value;

    public static bool operator !=(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value != right.Value;

    public static bool operator <(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value < right.Value;

    public static bool operator <=(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value <= right.Value;

    public static bool operator >(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value > right.Value;

    public static bool operator >=(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Value >= right.Value;

    public static implicit operator VkCudaFunctionNV(byte value) => new VkCudaFunctionNV(value);

    public static explicit operator byte(VkCudaFunctionNV value) => (byte)(value.Value);

    public static explicit operator VkCudaFunctionNV(short value) => new VkCudaFunctionNV(unchecked((ulong)(value)));

    public static explicit operator short(VkCudaFunctionNV value) => (short)(value.Value);

    public static explicit operator VkCudaFunctionNV(int value) => new VkCudaFunctionNV(unchecked((ulong)(value)));

    public static explicit operator int(VkCudaFunctionNV value) => (int)(value.Value);

    public static explicit operator VkCudaFunctionNV(long value) => new VkCudaFunctionNV(unchecked((ulong)(value)));

    public static explicit operator long(VkCudaFunctionNV value) => (long)(value.Value);

    public static explicit operator VkCudaFunctionNV(nint value) => new VkCudaFunctionNV(unchecked((ulong)(value)));

    public static explicit operator nint(VkCudaFunctionNV value) => (nint)(value.Value);

    public static explicit operator VkCudaFunctionNV(sbyte value) => new VkCudaFunctionNV(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkCudaFunctionNV value) => (sbyte)(value.Value);

    public static implicit operator VkCudaFunctionNV(ushort value) => new VkCudaFunctionNV(value);

    public static explicit operator ushort(VkCudaFunctionNV value) => (ushort)(value.Value);

    public static implicit operator VkCudaFunctionNV(uint value) => new VkCudaFunctionNV(value);

    public static explicit operator uint(VkCudaFunctionNV value) => (uint)(value.Value);

    public static implicit operator VkCudaFunctionNV(ulong value) => new VkCudaFunctionNV(value);

    public static implicit operator ulong(VkCudaFunctionNV value) => value.Value;

    public static implicit operator VkCudaFunctionNV(nuint value) => new VkCudaFunctionNV(value);

    public static explicit operator nuint(VkCudaFunctionNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCudaFunctionNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCudaFunctionNV.");
    }

    public int CompareTo(VkCudaFunctionNV other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkCudaFunctionNV other) && Equals(other);

    public bool Equals(VkCudaFunctionNV other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
