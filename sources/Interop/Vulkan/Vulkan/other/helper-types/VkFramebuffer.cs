// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkFramebuffer : IComparable, IComparable<VkFramebuffer>, IEquatable<VkFramebuffer>, IFormattable
{
    public readonly ulong Value;

    public VkFramebuffer(ulong value)
    {
        Value = value;
    }

    public static VkFramebuffer NULL => new VkFramebuffer(0);

    public static bool operator ==(VkFramebuffer left, VkFramebuffer right) => left.Value == right.Value;

    public static bool operator !=(VkFramebuffer left, VkFramebuffer right) => left.Value != right.Value;

    public static bool operator <(VkFramebuffer left, VkFramebuffer right) => left.Value < right.Value;

    public static bool operator <=(VkFramebuffer left, VkFramebuffer right) => left.Value <= right.Value;

    public static bool operator >(VkFramebuffer left, VkFramebuffer right) => left.Value > right.Value;

    public static bool operator >=(VkFramebuffer left, VkFramebuffer right) => left.Value >= right.Value;

    public static implicit operator VkFramebuffer(byte value) => new VkFramebuffer(value);

    public static explicit operator byte(VkFramebuffer value) => (byte)(value.Value);

    public static explicit operator VkFramebuffer(short value) => new VkFramebuffer(unchecked((ulong)(value)));

    public static explicit operator short(VkFramebuffer value) => (short)(value.Value);

    public static explicit operator VkFramebuffer(int value) => new VkFramebuffer(unchecked((ulong)(value)));

    public static explicit operator int(VkFramebuffer value) => (int)(value.Value);

    public static explicit operator VkFramebuffer(long value) => new VkFramebuffer(unchecked((ulong)(value)));

    public static explicit operator long(VkFramebuffer value) => (long)(value.Value);

    public static explicit operator VkFramebuffer(nint value) => new VkFramebuffer(unchecked((ulong)(value)));

    public static explicit operator nint(VkFramebuffer value) => (nint)(value.Value);

    public static explicit operator VkFramebuffer(sbyte value) => new VkFramebuffer(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkFramebuffer value) => (sbyte)(value.Value);

    public static implicit operator VkFramebuffer(ushort value) => new VkFramebuffer(value);

    public static explicit operator ushort(VkFramebuffer value) => (ushort)(value.Value);

    public static implicit operator VkFramebuffer(uint value) => new VkFramebuffer(value);

    public static explicit operator uint(VkFramebuffer value) => (uint)(value.Value);

    public static implicit operator VkFramebuffer(ulong value) => new VkFramebuffer(value);

    public static implicit operator ulong(VkFramebuffer value) => value.Value;

    public static implicit operator VkFramebuffer(nuint value) => new VkFramebuffer(value);

    public static explicit operator nuint(VkFramebuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkFramebuffer other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkFramebuffer.");
    }

    public int CompareTo(VkFramebuffer other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkFramebuffer other) && Equals(other);

    public bool Equals(VkFramebuffer other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
