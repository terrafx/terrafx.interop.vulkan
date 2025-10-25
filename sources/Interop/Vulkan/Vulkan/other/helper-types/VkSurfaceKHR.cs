// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkSurfaceKHR : IComparable, IComparable<VkSurfaceKHR>, IEquatable<VkSurfaceKHR>, IFormattable
{
    public readonly ulong Value;

    public VkSurfaceKHR(ulong value)
    {
        Value = value;
    }

    public static VkSurfaceKHR NULL => new VkSurfaceKHR(0);

    public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value == right.Value;

    public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value != right.Value;

    public static bool operator <(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value < right.Value;

    public static bool operator <=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value <= right.Value;

    public static bool operator >(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value > right.Value;

    public static bool operator >=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Value >= right.Value;

    public static implicit operator VkSurfaceKHR(byte value) => new VkSurfaceKHR(value);

    public static explicit operator byte(VkSurfaceKHR value) => (byte)(value.Value);

    public static explicit operator VkSurfaceKHR(short value) => new VkSurfaceKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkSurfaceKHR value) => (short)(value.Value);

    public static explicit operator VkSurfaceKHR(int value) => new VkSurfaceKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkSurfaceKHR value) => (int)(value.Value);

    public static explicit operator VkSurfaceKHR(long value) => new VkSurfaceKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkSurfaceKHR value) => (long)(value.Value);

    public static explicit operator VkSurfaceKHR(nint value) => new VkSurfaceKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkSurfaceKHR value) => (nint)(value.Value);

    public static explicit operator VkSurfaceKHR(sbyte value) => new VkSurfaceKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkSurfaceKHR value) => (sbyte)(value.Value);

    public static implicit operator VkSurfaceKHR(ushort value) => new VkSurfaceKHR(value);

    public static explicit operator ushort(VkSurfaceKHR value) => (ushort)(value.Value);

    public static implicit operator VkSurfaceKHR(uint value) => new VkSurfaceKHR(value);

    public static explicit operator uint(VkSurfaceKHR value) => (uint)(value.Value);

    public static implicit operator VkSurfaceKHR(ulong value) => new VkSurfaceKHR(value);

    public static implicit operator ulong(VkSurfaceKHR value) => value.Value;

    public static implicit operator VkSurfaceKHR(nuint value) => new VkSurfaceKHR(value);

    public static explicit operator nuint(VkSurfaceKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkSurfaceKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkSurfaceKHR.");
    }

    public int CompareTo(VkSurfaceKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkSurfaceKHR other) && Equals(other);

    public bool Equals(VkSurfaceKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
