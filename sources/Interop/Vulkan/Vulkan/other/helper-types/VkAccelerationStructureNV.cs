// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkAccelerationStructureNV : IComparable, IComparable<VkAccelerationStructureNV>, IEquatable<VkAccelerationStructureNV>, IFormattable
{
    public readonly ulong Value;

    public VkAccelerationStructureNV(ulong value)
    {
        Value = value;
    }

    public static VkAccelerationStructureNV NULL => new VkAccelerationStructureNV(0);

    public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value == right.Value;

    public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value != right.Value;

    public static bool operator <(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value < right.Value;

    public static bool operator <=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value <= right.Value;

    public static bool operator >(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value > right.Value;

    public static bool operator >=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Value >= right.Value;

    public static implicit operator VkAccelerationStructureNV(byte value) => new VkAccelerationStructureNV(value);

    public static explicit operator byte(VkAccelerationStructureNV value) => (byte)(value.Value);

    public static explicit operator VkAccelerationStructureNV(short value) => new VkAccelerationStructureNV(unchecked((ulong)(value)));

    public static explicit operator short(VkAccelerationStructureNV value) => (short)(value.Value);

    public static explicit operator VkAccelerationStructureNV(int value) => new VkAccelerationStructureNV(unchecked((ulong)(value)));

    public static explicit operator int(VkAccelerationStructureNV value) => (int)(value.Value);

    public static explicit operator VkAccelerationStructureNV(long value) => new VkAccelerationStructureNV(unchecked((ulong)(value)));

    public static explicit operator long(VkAccelerationStructureNV value) => (long)(value.Value);

    public static explicit operator VkAccelerationStructureNV(nint value) => new VkAccelerationStructureNV(unchecked((ulong)(value)));

    public static explicit operator nint(VkAccelerationStructureNV value) => (nint)(value.Value);

    public static explicit operator VkAccelerationStructureNV(sbyte value) => new VkAccelerationStructureNV(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkAccelerationStructureNV value) => (sbyte)(value.Value);

    public static implicit operator VkAccelerationStructureNV(ushort value) => new VkAccelerationStructureNV(value);

    public static explicit operator ushort(VkAccelerationStructureNV value) => (ushort)(value.Value);

    public static implicit operator VkAccelerationStructureNV(uint value) => new VkAccelerationStructureNV(value);

    public static explicit operator uint(VkAccelerationStructureNV value) => (uint)(value.Value);

    public static implicit operator VkAccelerationStructureNV(ulong value) => new VkAccelerationStructureNV(value);

    public static implicit operator ulong(VkAccelerationStructureNV value) => value.Value;

    public static implicit operator VkAccelerationStructureNV(nuint value) => new VkAccelerationStructureNV(value);

    public static explicit operator nuint(VkAccelerationStructureNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkAccelerationStructureNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkAccelerationStructureNV.");
    }

    public int CompareTo(VkAccelerationStructureNV other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkAccelerationStructureNV other) && Equals(other);

    public bool Equals(VkAccelerationStructureNV other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
