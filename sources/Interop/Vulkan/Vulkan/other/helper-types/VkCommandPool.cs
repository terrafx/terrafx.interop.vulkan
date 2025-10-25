// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkCommandPool : IComparable, IComparable<VkCommandPool>, IEquatable<VkCommandPool>, IFormattable
{
    public readonly ulong Value;

    public VkCommandPool(ulong value)
    {
        Value = value;
    }

    public static VkCommandPool NULL => new VkCommandPool(0);

    public static bool operator ==(VkCommandPool left, VkCommandPool right) => left.Value == right.Value;

    public static bool operator !=(VkCommandPool left, VkCommandPool right) => left.Value != right.Value;

    public static bool operator <(VkCommandPool left, VkCommandPool right) => left.Value < right.Value;

    public static bool operator <=(VkCommandPool left, VkCommandPool right) => left.Value <= right.Value;

    public static bool operator >(VkCommandPool left, VkCommandPool right) => left.Value > right.Value;

    public static bool operator >=(VkCommandPool left, VkCommandPool right) => left.Value >= right.Value;

    public static implicit operator VkCommandPool(byte value) => new VkCommandPool(value);

    public static explicit operator byte(VkCommandPool value) => (byte)(value.Value);

    public static explicit operator VkCommandPool(short value) => new VkCommandPool(unchecked((ulong)(value)));

    public static explicit operator short(VkCommandPool value) => (short)(value.Value);

    public static explicit operator VkCommandPool(int value) => new VkCommandPool(unchecked((ulong)(value)));

    public static explicit operator int(VkCommandPool value) => (int)(value.Value);

    public static explicit operator VkCommandPool(long value) => new VkCommandPool(unchecked((ulong)(value)));

    public static explicit operator long(VkCommandPool value) => (long)(value.Value);

    public static explicit operator VkCommandPool(nint value) => new VkCommandPool(unchecked((ulong)(value)));

    public static explicit operator nint(VkCommandPool value) => (nint)(value.Value);

    public static explicit operator VkCommandPool(sbyte value) => new VkCommandPool(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkCommandPool value) => (sbyte)(value.Value);

    public static implicit operator VkCommandPool(ushort value) => new VkCommandPool(value);

    public static explicit operator ushort(VkCommandPool value) => (ushort)(value.Value);

    public static implicit operator VkCommandPool(uint value) => new VkCommandPool(value);

    public static explicit operator uint(VkCommandPool value) => (uint)(value.Value);

    public static implicit operator VkCommandPool(ulong value) => new VkCommandPool(value);

    public static implicit operator ulong(VkCommandPool value) => value.Value;

    public static implicit operator VkCommandPool(nuint value) => new VkCommandPool(value);

    public static explicit operator nuint(VkCommandPool value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCommandPool other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCommandPool.");
    }

    public int CompareTo(VkCommandPool other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkCommandPool other) && Equals(other);

    public bool Equals(VkCommandPool other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
