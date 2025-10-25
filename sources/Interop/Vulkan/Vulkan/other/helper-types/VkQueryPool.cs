// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkQueryPool : IComparable, IComparable<VkQueryPool>, IEquatable<VkQueryPool>, IFormattable
{
    public readonly ulong Value;

    public VkQueryPool(ulong value)
    {
        Value = value;
    }

    public static VkQueryPool NULL => new VkQueryPool(0);

    public static bool operator ==(VkQueryPool left, VkQueryPool right) => left.Value == right.Value;

    public static bool operator !=(VkQueryPool left, VkQueryPool right) => left.Value != right.Value;

    public static bool operator <(VkQueryPool left, VkQueryPool right) => left.Value < right.Value;

    public static bool operator <=(VkQueryPool left, VkQueryPool right) => left.Value <= right.Value;

    public static bool operator >(VkQueryPool left, VkQueryPool right) => left.Value > right.Value;

    public static bool operator >=(VkQueryPool left, VkQueryPool right) => left.Value >= right.Value;

    public static implicit operator VkQueryPool(byte value) => new VkQueryPool(value);

    public static explicit operator byte(VkQueryPool value) => (byte)(value.Value);

    public static explicit operator VkQueryPool(short value) => new VkQueryPool(unchecked((ulong)(value)));

    public static explicit operator short(VkQueryPool value) => (short)(value.Value);

    public static explicit operator VkQueryPool(int value) => new VkQueryPool(unchecked((ulong)(value)));

    public static explicit operator int(VkQueryPool value) => (int)(value.Value);

    public static explicit operator VkQueryPool(long value) => new VkQueryPool(unchecked((ulong)(value)));

    public static explicit operator long(VkQueryPool value) => (long)(value.Value);

    public static explicit operator VkQueryPool(nint value) => new VkQueryPool(unchecked((ulong)(value)));

    public static explicit operator nint(VkQueryPool value) => (nint)(value.Value);

    public static explicit operator VkQueryPool(sbyte value) => new VkQueryPool(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkQueryPool value) => (sbyte)(value.Value);

    public static implicit operator VkQueryPool(ushort value) => new VkQueryPool(value);

    public static explicit operator ushort(VkQueryPool value) => (ushort)(value.Value);

    public static implicit operator VkQueryPool(uint value) => new VkQueryPool(value);

    public static explicit operator uint(VkQueryPool value) => (uint)(value.Value);

    public static implicit operator VkQueryPool(ulong value) => new VkQueryPool(value);

    public static implicit operator ulong(VkQueryPool value) => value.Value;

    public static implicit operator VkQueryPool(nuint value) => new VkQueryPool(value);

    public static explicit operator nuint(VkQueryPool value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkQueryPool other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkQueryPool.");
    }

    public int CompareTo(VkQueryPool other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkQueryPool other) && Equals(other);

    public bool Equals(VkQueryPool other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
