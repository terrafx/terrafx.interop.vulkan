// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPrivateDataSlot : IComparable, IComparable<VkPrivateDataSlot>, IEquatable<VkPrivateDataSlot>, IFormattable
{
    public readonly ulong Value;

    public VkPrivateDataSlot(ulong value)
    {
        Value = value;
    }

    public static VkPrivateDataSlot NULL => new VkPrivateDataSlot(0);

    public static bool operator ==(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value == right.Value;

    public static bool operator !=(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value != right.Value;

    public static bool operator <(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value < right.Value;

    public static bool operator <=(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value <= right.Value;

    public static bool operator >(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value > right.Value;

    public static bool operator >=(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Value >= right.Value;

    public static implicit operator VkPrivateDataSlot(byte value) => new VkPrivateDataSlot(value);

    public static explicit operator byte(VkPrivateDataSlot value) => (byte)(value.Value);

    public static explicit operator VkPrivateDataSlot(short value) => new VkPrivateDataSlot(unchecked((ulong)(value)));

    public static explicit operator short(VkPrivateDataSlot value) => (short)(value.Value);

    public static explicit operator VkPrivateDataSlot(int value) => new VkPrivateDataSlot(unchecked((ulong)(value)));

    public static explicit operator int(VkPrivateDataSlot value) => (int)(value.Value);

    public static explicit operator VkPrivateDataSlot(long value) => new VkPrivateDataSlot(unchecked((ulong)(value)));

    public static explicit operator long(VkPrivateDataSlot value) => (long)(value.Value);

    public static explicit operator VkPrivateDataSlot(nint value) => new VkPrivateDataSlot(unchecked((ulong)(value)));

    public static explicit operator nint(VkPrivateDataSlot value) => (nint)(value.Value);

    public static explicit operator VkPrivateDataSlot(sbyte value) => new VkPrivateDataSlot(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPrivateDataSlot value) => (sbyte)(value.Value);

    public static implicit operator VkPrivateDataSlot(ushort value) => new VkPrivateDataSlot(value);

    public static explicit operator ushort(VkPrivateDataSlot value) => (ushort)(value.Value);

    public static implicit operator VkPrivateDataSlot(uint value) => new VkPrivateDataSlot(value);

    public static explicit operator uint(VkPrivateDataSlot value) => (uint)(value.Value);

    public static implicit operator VkPrivateDataSlot(ulong value) => new VkPrivateDataSlot(value);

    public static implicit operator ulong(VkPrivateDataSlot value) => value.Value;

    public static implicit operator VkPrivateDataSlot(nuint value) => new VkPrivateDataSlot(value);

    public static explicit operator nuint(VkPrivateDataSlot value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPrivateDataSlot other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPrivateDataSlot.");
    }

    public int CompareTo(VkPrivateDataSlot other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPrivateDataSlot other) && Equals(other);

    public bool Equals(VkPrivateDataSlot other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
