// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkImage : IComparable, IComparable<VkImage>, IEquatable<VkImage>, IFormattable
{
    public readonly ulong Value;

    public VkImage(ulong value)
    {
        Value = value;
    }

    public static VkImage NULL => new VkImage(0);

    public static bool operator ==(VkImage left, VkImage right) => left.Value == right.Value;

    public static bool operator !=(VkImage left, VkImage right) => left.Value != right.Value;

    public static bool operator <(VkImage left, VkImage right) => left.Value < right.Value;

    public static bool operator <=(VkImage left, VkImage right) => left.Value <= right.Value;

    public static bool operator >(VkImage left, VkImage right) => left.Value > right.Value;

    public static bool operator >=(VkImage left, VkImage right) => left.Value >= right.Value;

    public static implicit operator VkImage(byte value) => new VkImage(value);

    public static explicit operator byte(VkImage value) => (byte)(value.Value);

    public static explicit operator VkImage(short value) => new VkImage(unchecked((ulong)(value)));

    public static explicit operator short(VkImage value) => (short)(value.Value);

    public static explicit operator VkImage(int value) => new VkImage(unchecked((ulong)(value)));

    public static explicit operator int(VkImage value) => (int)(value.Value);

    public static explicit operator VkImage(long value) => new VkImage(unchecked((ulong)(value)));

    public static explicit operator long(VkImage value) => (long)(value.Value);

    public static explicit operator VkImage(nint value) => new VkImage(unchecked((ulong)(value)));

    public static explicit operator nint(VkImage value) => (nint)(value.Value);

    public static explicit operator VkImage(sbyte value) => new VkImage(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkImage value) => (sbyte)(value.Value);

    public static implicit operator VkImage(ushort value) => new VkImage(value);

    public static explicit operator ushort(VkImage value) => (ushort)(value.Value);

    public static implicit operator VkImage(uint value) => new VkImage(value);

    public static explicit operator uint(VkImage value) => (uint)(value.Value);

    public static implicit operator VkImage(ulong value) => new VkImage(value);

    public static implicit operator ulong(VkImage value) => value.Value;

    public static implicit operator VkImage(nuint value) => new VkImage(value);

    public static explicit operator nuint(VkImage value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkImage other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkImage.");
    }

    public int CompareTo(VkImage other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkImage other) && Equals(other);

    public bool Equals(VkImage other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
