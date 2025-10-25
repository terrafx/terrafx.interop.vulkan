// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkCudaModuleNV : IComparable, IComparable<VkCudaModuleNV>, IEquatable<VkCudaModuleNV>, IFormattable
{
    public readonly ulong Value;

    public VkCudaModuleNV(ulong value)
    {
        Value = value;
    }

    public static VkCudaModuleNV NULL => new VkCudaModuleNV(0);

    public static bool operator ==(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value == right.Value;

    public static bool operator !=(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value != right.Value;

    public static bool operator <(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value < right.Value;

    public static bool operator <=(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value <= right.Value;

    public static bool operator >(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value > right.Value;

    public static bool operator >=(VkCudaModuleNV left, VkCudaModuleNV right) => left.Value >= right.Value;

    public static implicit operator VkCudaModuleNV(byte value) => new VkCudaModuleNV(value);

    public static explicit operator byte(VkCudaModuleNV value) => (byte)(value.Value);

    public static explicit operator VkCudaModuleNV(short value) => new VkCudaModuleNV(unchecked((ulong)(value)));

    public static explicit operator short(VkCudaModuleNV value) => (short)(value.Value);

    public static explicit operator VkCudaModuleNV(int value) => new VkCudaModuleNV(unchecked((ulong)(value)));

    public static explicit operator int(VkCudaModuleNV value) => (int)(value.Value);

    public static explicit operator VkCudaModuleNV(long value) => new VkCudaModuleNV(unchecked((ulong)(value)));

    public static explicit operator long(VkCudaModuleNV value) => (long)(value.Value);

    public static explicit operator VkCudaModuleNV(nint value) => new VkCudaModuleNV(unchecked((ulong)(value)));

    public static explicit operator nint(VkCudaModuleNV value) => (nint)(value.Value);

    public static explicit operator VkCudaModuleNV(sbyte value) => new VkCudaModuleNV(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkCudaModuleNV value) => (sbyte)(value.Value);

    public static implicit operator VkCudaModuleNV(ushort value) => new VkCudaModuleNV(value);

    public static explicit operator ushort(VkCudaModuleNV value) => (ushort)(value.Value);

    public static implicit operator VkCudaModuleNV(uint value) => new VkCudaModuleNV(value);

    public static explicit operator uint(VkCudaModuleNV value) => (uint)(value.Value);

    public static implicit operator VkCudaModuleNV(ulong value) => new VkCudaModuleNV(value);

    public static implicit operator ulong(VkCudaModuleNV value) => value.Value;

    public static implicit operator VkCudaModuleNV(nuint value) => new VkCudaModuleNV(value);

    public static explicit operator nuint(VkCudaModuleNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCudaModuleNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCudaModuleNV.");
    }

    public int CompareTo(VkCudaModuleNV other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkCudaModuleNV other) && Equals(other);

    public bool Equals(VkCudaModuleNV other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
