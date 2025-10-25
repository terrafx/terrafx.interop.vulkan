// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDeviceMemory : IComparable, IComparable<VkDeviceMemory>, IEquatable<VkDeviceMemory>, IFormattable
{
    public readonly ulong Value;

    public VkDeviceMemory(ulong value)
    {
        Value = value;
    }

    public static VkDeviceMemory NULL => new VkDeviceMemory(0);

    public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) => left.Value == right.Value;

    public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) => left.Value != right.Value;

    public static bool operator <(VkDeviceMemory left, VkDeviceMemory right) => left.Value < right.Value;

    public static bool operator <=(VkDeviceMemory left, VkDeviceMemory right) => left.Value <= right.Value;

    public static bool operator >(VkDeviceMemory left, VkDeviceMemory right) => left.Value > right.Value;

    public static bool operator >=(VkDeviceMemory left, VkDeviceMemory right) => left.Value >= right.Value;

    public static implicit operator VkDeviceMemory(byte value) => new VkDeviceMemory(value);

    public static explicit operator byte(VkDeviceMemory value) => (byte)(value.Value);

    public static explicit operator VkDeviceMemory(short value) => new VkDeviceMemory(unchecked((ulong)(value)));

    public static explicit operator short(VkDeviceMemory value) => (short)(value.Value);

    public static explicit operator VkDeviceMemory(int value) => new VkDeviceMemory(unchecked((ulong)(value)));

    public static explicit operator int(VkDeviceMemory value) => (int)(value.Value);

    public static explicit operator VkDeviceMemory(long value) => new VkDeviceMemory(unchecked((ulong)(value)));

    public static explicit operator long(VkDeviceMemory value) => (long)(value.Value);

    public static explicit operator VkDeviceMemory(nint value) => new VkDeviceMemory(unchecked((ulong)(value)));

    public static explicit operator nint(VkDeviceMemory value) => (nint)(value.Value);

    public static explicit operator VkDeviceMemory(sbyte value) => new VkDeviceMemory(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDeviceMemory value) => (sbyte)(value.Value);

    public static implicit operator VkDeviceMemory(ushort value) => new VkDeviceMemory(value);

    public static explicit operator ushort(VkDeviceMemory value) => (ushort)(value.Value);

    public static implicit operator VkDeviceMemory(uint value) => new VkDeviceMemory(value);

    public static explicit operator uint(VkDeviceMemory value) => (uint)(value.Value);

    public static implicit operator VkDeviceMemory(ulong value) => new VkDeviceMemory(value);

    public static implicit operator ulong(VkDeviceMemory value) => value.Value;

    public static implicit operator VkDeviceMemory(nuint value) => new VkDeviceMemory(value);

    public static explicit operator nuint(VkDeviceMemory value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDeviceMemory other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDeviceMemory.");
    }

    public int CompareTo(VkDeviceMemory other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDeviceMemory other) && Equals(other);

    public bool Equals(VkDeviceMemory other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
