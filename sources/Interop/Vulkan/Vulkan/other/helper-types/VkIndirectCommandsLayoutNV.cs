// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkIndirectCommandsLayoutNV : IComparable, IComparable<VkIndirectCommandsLayoutNV>, IEquatable<VkIndirectCommandsLayoutNV>, IFormattable
{
    public readonly ulong Value;

    public VkIndirectCommandsLayoutNV(ulong value)
    {
        Value = value;
    }

    public static VkIndirectCommandsLayoutNV NULL => new VkIndirectCommandsLayoutNV(0);

    public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value == right.Value;

    public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value != right.Value;

    public static bool operator <(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value < right.Value;

    public static bool operator <=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value <= right.Value;

    public static bool operator >(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value > right.Value;

    public static bool operator >=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Value >= right.Value;

    public static implicit operator VkIndirectCommandsLayoutNV(byte value) => new VkIndirectCommandsLayoutNV(value);

    public static explicit operator byte(VkIndirectCommandsLayoutNV value) => (byte)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutNV(short value) => new VkIndirectCommandsLayoutNV(unchecked((ulong)(value)));

    public static explicit operator short(VkIndirectCommandsLayoutNV value) => (short)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutNV(int value) => new VkIndirectCommandsLayoutNV(unchecked((ulong)(value)));

    public static explicit operator int(VkIndirectCommandsLayoutNV value) => (int)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutNV(long value) => new VkIndirectCommandsLayoutNV(unchecked((ulong)(value)));

    public static explicit operator long(VkIndirectCommandsLayoutNV value) => (long)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutNV(nint value) => new VkIndirectCommandsLayoutNV(unchecked((ulong)(value)));

    public static explicit operator nint(VkIndirectCommandsLayoutNV value) => (nint)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutNV(sbyte value) => new VkIndirectCommandsLayoutNV(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkIndirectCommandsLayoutNV value) => (sbyte)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutNV(ushort value) => new VkIndirectCommandsLayoutNV(value);

    public static explicit operator ushort(VkIndirectCommandsLayoutNV value) => (ushort)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutNV(uint value) => new VkIndirectCommandsLayoutNV(value);

    public static explicit operator uint(VkIndirectCommandsLayoutNV value) => (uint)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutNV(ulong value) => new VkIndirectCommandsLayoutNV(value);

    public static implicit operator ulong(VkIndirectCommandsLayoutNV value) => value.Value;

    public static implicit operator VkIndirectCommandsLayoutNV(nuint value) => new VkIndirectCommandsLayoutNV(value);

    public static explicit operator nuint(VkIndirectCommandsLayoutNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkIndirectCommandsLayoutNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkIndirectCommandsLayoutNV.");
    }

    public int CompareTo(VkIndirectCommandsLayoutNV other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkIndirectCommandsLayoutNV other) && Equals(other);

    public bool Equals(VkIndirectCommandsLayoutNV other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
