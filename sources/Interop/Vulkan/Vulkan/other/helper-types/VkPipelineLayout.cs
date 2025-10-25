// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPipelineLayout : IComparable, IComparable<VkPipelineLayout>, IEquatable<VkPipelineLayout>, IFormattable
{
    public readonly ulong Value;

    public VkPipelineLayout(ulong value)
    {
        Value = value;
    }

    public static VkPipelineLayout NULL => new VkPipelineLayout(0);

    public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) => left.Value == right.Value;

    public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) => left.Value != right.Value;

    public static bool operator <(VkPipelineLayout left, VkPipelineLayout right) => left.Value < right.Value;

    public static bool operator <=(VkPipelineLayout left, VkPipelineLayout right) => left.Value <= right.Value;

    public static bool operator >(VkPipelineLayout left, VkPipelineLayout right) => left.Value > right.Value;

    public static bool operator >=(VkPipelineLayout left, VkPipelineLayout right) => left.Value >= right.Value;

    public static implicit operator VkPipelineLayout(byte value) => new VkPipelineLayout(value);

    public static explicit operator byte(VkPipelineLayout value) => (byte)(value.Value);

    public static explicit operator VkPipelineLayout(short value) => new VkPipelineLayout(unchecked((ulong)(value)));

    public static explicit operator short(VkPipelineLayout value) => (short)(value.Value);

    public static explicit operator VkPipelineLayout(int value) => new VkPipelineLayout(unchecked((ulong)(value)));

    public static explicit operator int(VkPipelineLayout value) => (int)(value.Value);

    public static explicit operator VkPipelineLayout(long value) => new VkPipelineLayout(unchecked((ulong)(value)));

    public static explicit operator long(VkPipelineLayout value) => (long)(value.Value);

    public static explicit operator VkPipelineLayout(nint value) => new VkPipelineLayout(unchecked((ulong)(value)));

    public static explicit operator nint(VkPipelineLayout value) => (nint)(value.Value);

    public static explicit operator VkPipelineLayout(sbyte value) => new VkPipelineLayout(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPipelineLayout value) => (sbyte)(value.Value);

    public static implicit operator VkPipelineLayout(ushort value) => new VkPipelineLayout(value);

    public static explicit operator ushort(VkPipelineLayout value) => (ushort)(value.Value);

    public static implicit operator VkPipelineLayout(uint value) => new VkPipelineLayout(value);

    public static explicit operator uint(VkPipelineLayout value) => (uint)(value.Value);

    public static implicit operator VkPipelineLayout(ulong value) => new VkPipelineLayout(value);

    public static implicit operator ulong(VkPipelineLayout value) => value.Value;

    public static implicit operator VkPipelineLayout(nuint value) => new VkPipelineLayout(value);

    public static explicit operator nuint(VkPipelineLayout value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPipelineLayout other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPipelineLayout.");
    }

    public int CompareTo(VkPipelineLayout other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPipelineLayout other) && Equals(other);

    public bool Equals(VkPipelineLayout other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
