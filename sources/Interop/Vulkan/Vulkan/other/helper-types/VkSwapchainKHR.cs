// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkSwapchainKHR : IComparable, IComparable<VkSwapchainKHR>, IEquatable<VkSwapchainKHR>, IFormattable
{
    public readonly ulong Value;

    public VkSwapchainKHR(ulong value)
    {
        Value = value;
    }

    public static VkSwapchainKHR NULL => new VkSwapchainKHR(0);

    public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value == right.Value;

    public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value != right.Value;

    public static bool operator <(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value < right.Value;

    public static bool operator <=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value <= right.Value;

    public static bool operator >(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value > right.Value;

    public static bool operator >=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Value >= right.Value;

    public static implicit operator VkSwapchainKHR(byte value) => new VkSwapchainKHR(value);

    public static explicit operator byte(VkSwapchainKHR value) => (byte)(value.Value);

    public static explicit operator VkSwapchainKHR(short value) => new VkSwapchainKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkSwapchainKHR value) => (short)(value.Value);

    public static explicit operator VkSwapchainKHR(int value) => new VkSwapchainKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkSwapchainKHR value) => (int)(value.Value);

    public static explicit operator VkSwapchainKHR(long value) => new VkSwapchainKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkSwapchainKHR value) => (long)(value.Value);

    public static explicit operator VkSwapchainKHR(nint value) => new VkSwapchainKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkSwapchainKHR value) => (nint)(value.Value);

    public static explicit operator VkSwapchainKHR(sbyte value) => new VkSwapchainKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkSwapchainKHR value) => (sbyte)(value.Value);

    public static implicit operator VkSwapchainKHR(ushort value) => new VkSwapchainKHR(value);

    public static explicit operator ushort(VkSwapchainKHR value) => (ushort)(value.Value);

    public static implicit operator VkSwapchainKHR(uint value) => new VkSwapchainKHR(value);

    public static explicit operator uint(VkSwapchainKHR value) => (uint)(value.Value);

    public static implicit operator VkSwapchainKHR(ulong value) => new VkSwapchainKHR(value);

    public static implicit operator ulong(VkSwapchainKHR value) => value.Value;

    public static implicit operator VkSwapchainKHR(nuint value) => new VkSwapchainKHR(value);

    public static explicit operator nuint(VkSwapchainKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkSwapchainKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkSwapchainKHR.");
    }

    public int CompareTo(VkSwapchainKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkSwapchainKHR other) && Equals(other);

    public bool Equals(VkSwapchainKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
