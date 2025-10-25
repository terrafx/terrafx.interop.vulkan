// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkBufferCollectionFUCHSIA : IComparable, IComparable<VkBufferCollectionFUCHSIA>, IEquatable<VkBufferCollectionFUCHSIA>, IFormattable
{
    public readonly ulong Value;

    public VkBufferCollectionFUCHSIA(ulong value)
    {
        Value = value;
    }

    public static VkBufferCollectionFUCHSIA NULL => new VkBufferCollectionFUCHSIA(0);

    public static bool operator ==(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value == right.Value;

    public static bool operator !=(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value != right.Value;

    public static bool operator <(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value < right.Value;

    public static bool operator <=(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value <= right.Value;

    public static bool operator >(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value > right.Value;

    public static bool operator >=(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Value >= right.Value;

    public static implicit operator VkBufferCollectionFUCHSIA(byte value) => new VkBufferCollectionFUCHSIA(value);

    public static explicit operator byte(VkBufferCollectionFUCHSIA value) => (byte)(value.Value);

    public static explicit operator VkBufferCollectionFUCHSIA(short value) => new VkBufferCollectionFUCHSIA(unchecked((ulong)(value)));

    public static explicit operator short(VkBufferCollectionFUCHSIA value) => (short)(value.Value);

    public static explicit operator VkBufferCollectionFUCHSIA(int value) => new VkBufferCollectionFUCHSIA(unchecked((ulong)(value)));

    public static explicit operator int(VkBufferCollectionFUCHSIA value) => (int)(value.Value);

    public static explicit operator VkBufferCollectionFUCHSIA(long value) => new VkBufferCollectionFUCHSIA(unchecked((ulong)(value)));

    public static explicit operator long(VkBufferCollectionFUCHSIA value) => (long)(value.Value);

    public static explicit operator VkBufferCollectionFUCHSIA(nint value) => new VkBufferCollectionFUCHSIA(unchecked((ulong)(value)));

    public static explicit operator nint(VkBufferCollectionFUCHSIA value) => (nint)(value.Value);

    public static explicit operator VkBufferCollectionFUCHSIA(sbyte value) => new VkBufferCollectionFUCHSIA(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkBufferCollectionFUCHSIA value) => (sbyte)(value.Value);

    public static implicit operator VkBufferCollectionFUCHSIA(ushort value) => new VkBufferCollectionFUCHSIA(value);

    public static explicit operator ushort(VkBufferCollectionFUCHSIA value) => (ushort)(value.Value);

    public static implicit operator VkBufferCollectionFUCHSIA(uint value) => new VkBufferCollectionFUCHSIA(value);

    public static explicit operator uint(VkBufferCollectionFUCHSIA value) => (uint)(value.Value);

    public static implicit operator VkBufferCollectionFUCHSIA(ulong value) => new VkBufferCollectionFUCHSIA(value);

    public static implicit operator ulong(VkBufferCollectionFUCHSIA value) => value.Value;

    public static implicit operator VkBufferCollectionFUCHSIA(nuint value) => new VkBufferCollectionFUCHSIA(value);

    public static explicit operator nuint(VkBufferCollectionFUCHSIA value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkBufferCollectionFUCHSIA other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkBufferCollectionFUCHSIA.");
    }

    public int CompareTo(VkBufferCollectionFUCHSIA other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkBufferCollectionFUCHSIA other) && Equals(other);

    public bool Equals(VkBufferCollectionFUCHSIA other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
