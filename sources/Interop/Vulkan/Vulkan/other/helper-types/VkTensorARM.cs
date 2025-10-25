// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkTensorARM : IComparable, IComparable<VkTensorARM>, IEquatable<VkTensorARM>, IFormattable
{
    public readonly ulong Value;

    public VkTensorARM(ulong value)
    {
        Value = value;
    }

    public static VkTensorARM NULL => new VkTensorARM(0);

    public static bool operator ==(VkTensorARM left, VkTensorARM right) => left.Value == right.Value;

    public static bool operator !=(VkTensorARM left, VkTensorARM right) => left.Value != right.Value;

    public static bool operator <(VkTensorARM left, VkTensorARM right) => left.Value < right.Value;

    public static bool operator <=(VkTensorARM left, VkTensorARM right) => left.Value <= right.Value;

    public static bool operator >(VkTensorARM left, VkTensorARM right) => left.Value > right.Value;

    public static bool operator >=(VkTensorARM left, VkTensorARM right) => left.Value >= right.Value;

    public static implicit operator VkTensorARM(byte value) => new VkTensorARM(value);

    public static explicit operator byte(VkTensorARM value) => (byte)(value.Value);

    public static explicit operator VkTensorARM(short value) => new VkTensorARM(unchecked((ulong)(value)));

    public static explicit operator short(VkTensorARM value) => (short)(value.Value);

    public static explicit operator VkTensorARM(int value) => new VkTensorARM(unchecked((ulong)(value)));

    public static explicit operator int(VkTensorARM value) => (int)(value.Value);

    public static explicit operator VkTensorARM(long value) => new VkTensorARM(unchecked((ulong)(value)));

    public static explicit operator long(VkTensorARM value) => (long)(value.Value);

    public static explicit operator VkTensorARM(nint value) => new VkTensorARM(unchecked((ulong)(value)));

    public static explicit operator nint(VkTensorARM value) => (nint)(value.Value);

    public static explicit operator VkTensorARM(sbyte value) => new VkTensorARM(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkTensorARM value) => (sbyte)(value.Value);

    public static implicit operator VkTensorARM(ushort value) => new VkTensorARM(value);

    public static explicit operator ushort(VkTensorARM value) => (ushort)(value.Value);

    public static implicit operator VkTensorARM(uint value) => new VkTensorARM(value);

    public static explicit operator uint(VkTensorARM value) => (uint)(value.Value);

    public static implicit operator VkTensorARM(ulong value) => new VkTensorARM(value);

    public static implicit operator ulong(VkTensorARM value) => value.Value;

    public static implicit operator VkTensorARM(nuint value) => new VkTensorARM(value);

    public static explicit operator nuint(VkTensorARM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkTensorARM other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkTensorARM.");
    }

    public int CompareTo(VkTensorARM other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkTensorARM other) && Equals(other);

    public bool Equals(VkTensorARM other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
