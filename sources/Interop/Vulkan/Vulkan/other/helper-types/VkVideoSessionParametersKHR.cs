// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkVideoSessionParametersKHR : IComparable, IComparable<VkVideoSessionParametersKHR>, IEquatable<VkVideoSessionParametersKHR>, IFormattable
{
    public readonly ulong Value;

    public VkVideoSessionParametersKHR(ulong value)
    {
        Value = value;
    }

    public static VkVideoSessionParametersKHR NULL => new VkVideoSessionParametersKHR(0);

    public static bool operator ==(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value == right.Value;

    public static bool operator !=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value != right.Value;

    public static bool operator <(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value < right.Value;

    public static bool operator <=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value <= right.Value;

    public static bool operator >(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value > right.Value;

    public static bool operator >=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Value >= right.Value;

    public static implicit operator VkVideoSessionParametersKHR(byte value) => new VkVideoSessionParametersKHR(value);

    public static explicit operator byte(VkVideoSessionParametersKHR value) => (byte)(value.Value);

    public static explicit operator VkVideoSessionParametersKHR(short value) => new VkVideoSessionParametersKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkVideoSessionParametersKHR value) => (short)(value.Value);

    public static explicit operator VkVideoSessionParametersKHR(int value) => new VkVideoSessionParametersKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkVideoSessionParametersKHR value) => (int)(value.Value);

    public static explicit operator VkVideoSessionParametersKHR(long value) => new VkVideoSessionParametersKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkVideoSessionParametersKHR value) => (long)(value.Value);

    public static explicit operator VkVideoSessionParametersKHR(nint value) => new VkVideoSessionParametersKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkVideoSessionParametersKHR value) => (nint)(value.Value);

    public static explicit operator VkVideoSessionParametersKHR(sbyte value) => new VkVideoSessionParametersKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkVideoSessionParametersKHR value) => (sbyte)(value.Value);

    public static implicit operator VkVideoSessionParametersKHR(ushort value) => new VkVideoSessionParametersKHR(value);

    public static explicit operator ushort(VkVideoSessionParametersKHR value) => (ushort)(value.Value);

    public static implicit operator VkVideoSessionParametersKHR(uint value) => new VkVideoSessionParametersKHR(value);

    public static explicit operator uint(VkVideoSessionParametersKHR value) => (uint)(value.Value);

    public static implicit operator VkVideoSessionParametersKHR(ulong value) => new VkVideoSessionParametersKHR(value);

    public static implicit operator ulong(VkVideoSessionParametersKHR value) => value.Value;

    public static implicit operator VkVideoSessionParametersKHR(nuint value) => new VkVideoSessionParametersKHR(value);

    public static explicit operator nuint(VkVideoSessionParametersKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkVideoSessionParametersKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkVideoSessionParametersKHR.");
    }

    public int CompareTo(VkVideoSessionParametersKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkVideoSessionParametersKHR other) && Equals(other);

    public bool Equals(VkVideoSessionParametersKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
