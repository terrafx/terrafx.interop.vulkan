// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkAccelerationStructureKHR : IComparable, IComparable<VkAccelerationStructureKHR>, IEquatable<VkAccelerationStructureKHR>, IFormattable
{
    public readonly ulong Value;

    public VkAccelerationStructureKHR(ulong value)
    {
        Value = value;
    }

    public static VkAccelerationStructureKHR NULL => new VkAccelerationStructureKHR(0);

    public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value == right.Value;

    public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value != right.Value;

    public static bool operator <(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value < right.Value;

    public static bool operator <=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value <= right.Value;

    public static bool operator >(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value > right.Value;

    public static bool operator >=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Value >= right.Value;

    public static implicit operator VkAccelerationStructureKHR(byte value) => new VkAccelerationStructureKHR(value);

    public static explicit operator byte(VkAccelerationStructureKHR value) => (byte)(value.Value);

    public static explicit operator VkAccelerationStructureKHR(short value) => new VkAccelerationStructureKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkAccelerationStructureKHR value) => (short)(value.Value);

    public static explicit operator VkAccelerationStructureKHR(int value) => new VkAccelerationStructureKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkAccelerationStructureKHR value) => (int)(value.Value);

    public static explicit operator VkAccelerationStructureKHR(long value) => new VkAccelerationStructureKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkAccelerationStructureKHR value) => (long)(value.Value);

    public static explicit operator VkAccelerationStructureKHR(nint value) => new VkAccelerationStructureKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkAccelerationStructureKHR value) => (nint)(value.Value);

    public static explicit operator VkAccelerationStructureKHR(sbyte value) => new VkAccelerationStructureKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkAccelerationStructureKHR value) => (sbyte)(value.Value);

    public static implicit operator VkAccelerationStructureKHR(ushort value) => new VkAccelerationStructureKHR(value);

    public static explicit operator ushort(VkAccelerationStructureKHR value) => (ushort)(value.Value);

    public static implicit operator VkAccelerationStructureKHR(uint value) => new VkAccelerationStructureKHR(value);

    public static explicit operator uint(VkAccelerationStructureKHR value) => (uint)(value.Value);

    public static implicit operator VkAccelerationStructureKHR(ulong value) => new VkAccelerationStructureKHR(value);

    public static implicit operator ulong(VkAccelerationStructureKHR value) => value.Value;

    public static implicit operator VkAccelerationStructureKHR(nuint value) => new VkAccelerationStructureKHR(value);

    public static explicit operator nuint(VkAccelerationStructureKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkAccelerationStructureKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkAccelerationStructureKHR.");
    }

    public int CompareTo(VkAccelerationStructureKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkAccelerationStructureKHR other) && Equals(other);

    public bool Equals(VkAccelerationStructureKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
