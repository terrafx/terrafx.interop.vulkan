// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkSemaphore : IComparable, IComparable<VkSemaphore>, IEquatable<VkSemaphore>, IFormattable
{
    public readonly ulong Value;

    public VkSemaphore(ulong value)
    {
        Value = value;
    }

    public static VkSemaphore NULL => new VkSemaphore(0);

    public static bool operator ==(VkSemaphore left, VkSemaphore right) => left.Value == right.Value;

    public static bool operator !=(VkSemaphore left, VkSemaphore right) => left.Value != right.Value;

    public static bool operator <(VkSemaphore left, VkSemaphore right) => left.Value < right.Value;

    public static bool operator <=(VkSemaphore left, VkSemaphore right) => left.Value <= right.Value;

    public static bool operator >(VkSemaphore left, VkSemaphore right) => left.Value > right.Value;

    public static bool operator >=(VkSemaphore left, VkSemaphore right) => left.Value >= right.Value;

    public static implicit operator VkSemaphore(byte value) => new VkSemaphore(value);

    public static explicit operator byte(VkSemaphore value) => (byte)(value.Value);

    public static explicit operator VkSemaphore(short value) => new VkSemaphore(unchecked((ulong)(value)));

    public static explicit operator short(VkSemaphore value) => (short)(value.Value);

    public static explicit operator VkSemaphore(int value) => new VkSemaphore(unchecked((ulong)(value)));

    public static explicit operator int(VkSemaphore value) => (int)(value.Value);

    public static explicit operator VkSemaphore(long value) => new VkSemaphore(unchecked((ulong)(value)));

    public static explicit operator long(VkSemaphore value) => (long)(value.Value);

    public static explicit operator VkSemaphore(nint value) => new VkSemaphore(unchecked((ulong)(value)));

    public static explicit operator nint(VkSemaphore value) => (nint)(value.Value);

    public static explicit operator VkSemaphore(sbyte value) => new VkSemaphore(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkSemaphore value) => (sbyte)(value.Value);

    public static implicit operator VkSemaphore(ushort value) => new VkSemaphore(value);

    public static explicit operator ushort(VkSemaphore value) => (ushort)(value.Value);

    public static implicit operator VkSemaphore(uint value) => new VkSemaphore(value);

    public static explicit operator uint(VkSemaphore value) => (uint)(value.Value);

    public static implicit operator VkSemaphore(ulong value) => new VkSemaphore(value);

    public static implicit operator ulong(VkSemaphore value) => value.Value;

    public static implicit operator VkSemaphore(nuint value) => new VkSemaphore(value);

    public static explicit operator nuint(VkSemaphore value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkSemaphore other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkSemaphore.");
    }

    public int CompareTo(VkSemaphore other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkSemaphore other) && Equals(other);

    public bool Equals(VkSemaphore other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
