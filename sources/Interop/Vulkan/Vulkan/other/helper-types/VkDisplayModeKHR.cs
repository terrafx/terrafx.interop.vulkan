// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDisplayModeKHR : IComparable, IComparable<VkDisplayModeKHR>, IEquatable<VkDisplayModeKHR>, IFormattable
{
    public readonly ulong Value;

    public VkDisplayModeKHR(ulong value)
    {
        Value = value;
    }

    public static VkDisplayModeKHR NULL => new VkDisplayModeKHR(0);

    public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value == right.Value;

    public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value != right.Value;

    public static bool operator <(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value < right.Value;

    public static bool operator <=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value <= right.Value;

    public static bool operator >(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value > right.Value;

    public static bool operator >=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Value >= right.Value;

    public static implicit operator VkDisplayModeKHR(byte value) => new VkDisplayModeKHR(value);

    public static explicit operator byte(VkDisplayModeKHR value) => (byte)(value.Value);

    public static explicit operator VkDisplayModeKHR(short value) => new VkDisplayModeKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkDisplayModeKHR value) => (short)(value.Value);

    public static explicit operator VkDisplayModeKHR(int value) => new VkDisplayModeKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkDisplayModeKHR value) => (int)(value.Value);

    public static explicit operator VkDisplayModeKHR(long value) => new VkDisplayModeKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkDisplayModeKHR value) => (long)(value.Value);

    public static explicit operator VkDisplayModeKHR(nint value) => new VkDisplayModeKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkDisplayModeKHR value) => (nint)(value.Value);

    public static explicit operator VkDisplayModeKHR(sbyte value) => new VkDisplayModeKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDisplayModeKHR value) => (sbyte)(value.Value);

    public static implicit operator VkDisplayModeKHR(ushort value) => new VkDisplayModeKHR(value);

    public static explicit operator ushort(VkDisplayModeKHR value) => (ushort)(value.Value);

    public static implicit operator VkDisplayModeKHR(uint value) => new VkDisplayModeKHR(value);

    public static explicit operator uint(VkDisplayModeKHR value) => (uint)(value.Value);

    public static implicit operator VkDisplayModeKHR(ulong value) => new VkDisplayModeKHR(value);

    public static implicit operator ulong(VkDisplayModeKHR value) => value.Value;

    public static implicit operator VkDisplayModeKHR(nuint value) => new VkDisplayModeKHR(value);

    public static explicit operator nuint(VkDisplayModeKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDisplayModeKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDisplayModeKHR.");
    }

    public int CompareTo(VkDisplayModeKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDisplayModeKHR other) && Equals(other);

    public bool Equals(VkDisplayModeKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
