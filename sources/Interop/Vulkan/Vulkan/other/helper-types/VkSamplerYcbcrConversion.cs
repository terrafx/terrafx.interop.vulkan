// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkSamplerYcbcrConversion : IComparable, IComparable<VkSamplerYcbcrConversion>, IEquatable<VkSamplerYcbcrConversion>, IFormattable
{
    public readonly ulong Value;

    public VkSamplerYcbcrConversion(ulong value)
    {
        Value = value;
    }

    public static VkSamplerYcbcrConversion NULL => new VkSamplerYcbcrConversion(0);

    public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value == right.Value;

    public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value != right.Value;

    public static bool operator <(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value < right.Value;

    public static bool operator <=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value <= right.Value;

    public static bool operator >(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value > right.Value;

    public static bool operator >=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Value >= right.Value;

    public static implicit operator VkSamplerYcbcrConversion(byte value) => new VkSamplerYcbcrConversion(value);

    public static explicit operator byte(VkSamplerYcbcrConversion value) => (byte)(value.Value);

    public static explicit operator VkSamplerYcbcrConversion(short value) => new VkSamplerYcbcrConversion(unchecked((ulong)(value)));

    public static explicit operator short(VkSamplerYcbcrConversion value) => (short)(value.Value);

    public static explicit operator VkSamplerYcbcrConversion(int value) => new VkSamplerYcbcrConversion(unchecked((ulong)(value)));

    public static explicit operator int(VkSamplerYcbcrConversion value) => (int)(value.Value);

    public static explicit operator VkSamplerYcbcrConversion(long value) => new VkSamplerYcbcrConversion(unchecked((ulong)(value)));

    public static explicit operator long(VkSamplerYcbcrConversion value) => (long)(value.Value);

    public static explicit operator VkSamplerYcbcrConversion(nint value) => new VkSamplerYcbcrConversion(unchecked((ulong)(value)));

    public static explicit operator nint(VkSamplerYcbcrConversion value) => (nint)(value.Value);

    public static explicit operator VkSamplerYcbcrConversion(sbyte value) => new VkSamplerYcbcrConversion(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkSamplerYcbcrConversion value) => (sbyte)(value.Value);

    public static implicit operator VkSamplerYcbcrConversion(ushort value) => new VkSamplerYcbcrConversion(value);

    public static explicit operator ushort(VkSamplerYcbcrConversion value) => (ushort)(value.Value);

    public static implicit operator VkSamplerYcbcrConversion(uint value) => new VkSamplerYcbcrConversion(value);

    public static explicit operator uint(VkSamplerYcbcrConversion value) => (uint)(value.Value);

    public static implicit operator VkSamplerYcbcrConversion(ulong value) => new VkSamplerYcbcrConversion(value);

    public static implicit operator ulong(VkSamplerYcbcrConversion value) => value.Value;

    public static implicit operator VkSamplerYcbcrConversion(nuint value) => new VkSamplerYcbcrConversion(value);

    public static explicit operator nuint(VkSamplerYcbcrConversion value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkSamplerYcbcrConversion other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkSamplerYcbcrConversion.");
    }

    public int CompareTo(VkSamplerYcbcrConversion other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkSamplerYcbcrConversion other) && Equals(other);

    public bool Equals(VkSamplerYcbcrConversion other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
