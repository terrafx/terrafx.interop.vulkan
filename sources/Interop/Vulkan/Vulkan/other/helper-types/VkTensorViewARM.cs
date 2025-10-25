// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkTensorViewARM : IComparable, IComparable<VkTensorViewARM>, IEquatable<VkTensorViewARM>, IFormattable
{
    public readonly ulong Value;

    public VkTensorViewARM(ulong value)
    {
        Value = value;
    }

    public static VkTensorViewARM NULL => new VkTensorViewARM(0);

    public static bool operator ==(VkTensorViewARM left, VkTensorViewARM right) => left.Value == right.Value;

    public static bool operator !=(VkTensorViewARM left, VkTensorViewARM right) => left.Value != right.Value;

    public static bool operator <(VkTensorViewARM left, VkTensorViewARM right) => left.Value < right.Value;

    public static bool operator <=(VkTensorViewARM left, VkTensorViewARM right) => left.Value <= right.Value;

    public static bool operator >(VkTensorViewARM left, VkTensorViewARM right) => left.Value > right.Value;

    public static bool operator >=(VkTensorViewARM left, VkTensorViewARM right) => left.Value >= right.Value;

    public static implicit operator VkTensorViewARM(byte value) => new VkTensorViewARM(value);

    public static explicit operator byte(VkTensorViewARM value) => (byte)(value.Value);

    public static explicit operator VkTensorViewARM(short value) => new VkTensorViewARM(unchecked((ulong)(value)));

    public static explicit operator short(VkTensorViewARM value) => (short)(value.Value);

    public static explicit operator VkTensorViewARM(int value) => new VkTensorViewARM(unchecked((ulong)(value)));

    public static explicit operator int(VkTensorViewARM value) => (int)(value.Value);

    public static explicit operator VkTensorViewARM(long value) => new VkTensorViewARM(unchecked((ulong)(value)));

    public static explicit operator long(VkTensorViewARM value) => (long)(value.Value);

    public static explicit operator VkTensorViewARM(nint value) => new VkTensorViewARM(unchecked((ulong)(value)));

    public static explicit operator nint(VkTensorViewARM value) => (nint)(value.Value);

    public static explicit operator VkTensorViewARM(sbyte value) => new VkTensorViewARM(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkTensorViewARM value) => (sbyte)(value.Value);

    public static implicit operator VkTensorViewARM(ushort value) => new VkTensorViewARM(value);

    public static explicit operator ushort(VkTensorViewARM value) => (ushort)(value.Value);

    public static implicit operator VkTensorViewARM(uint value) => new VkTensorViewARM(value);

    public static explicit operator uint(VkTensorViewARM value) => (uint)(value.Value);

    public static implicit operator VkTensorViewARM(ulong value) => new VkTensorViewARM(value);

    public static implicit operator ulong(VkTensorViewARM value) => value.Value;

    public static implicit operator VkTensorViewARM(nuint value) => new VkTensorViewARM(value);

    public static explicit operator nuint(VkTensorViewARM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkTensorViewARM other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkTensorViewARM.");
    }

    public int CompareTo(VkTensorViewARM other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkTensorViewARM other) && Equals(other);

    public bool Equals(VkTensorViewARM other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
