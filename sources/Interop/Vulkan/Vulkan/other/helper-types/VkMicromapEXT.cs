// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkMicromapEXT : IComparable, IComparable<VkMicromapEXT>, IEquatable<VkMicromapEXT>, IFormattable
{
    public readonly ulong Value;

    public VkMicromapEXT(ulong value)
    {
        Value = value;
    }

    public static VkMicromapEXT NULL => new VkMicromapEXT(0);

    public static bool operator ==(VkMicromapEXT left, VkMicromapEXT right) => left.Value == right.Value;

    public static bool operator !=(VkMicromapEXT left, VkMicromapEXT right) => left.Value != right.Value;

    public static bool operator <(VkMicromapEXT left, VkMicromapEXT right) => left.Value < right.Value;

    public static bool operator <=(VkMicromapEXT left, VkMicromapEXT right) => left.Value <= right.Value;

    public static bool operator >(VkMicromapEXT left, VkMicromapEXT right) => left.Value > right.Value;

    public static bool operator >=(VkMicromapEXT left, VkMicromapEXT right) => left.Value >= right.Value;

    public static implicit operator VkMicromapEXT(byte value) => new VkMicromapEXT(value);

    public static explicit operator byte(VkMicromapEXT value) => (byte)(value.Value);

    public static explicit operator VkMicromapEXT(short value) => new VkMicromapEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkMicromapEXT value) => (short)(value.Value);

    public static explicit operator VkMicromapEXT(int value) => new VkMicromapEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkMicromapEXT value) => (int)(value.Value);

    public static explicit operator VkMicromapEXT(long value) => new VkMicromapEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkMicromapEXT value) => (long)(value.Value);

    public static explicit operator VkMicromapEXT(nint value) => new VkMicromapEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkMicromapEXT value) => (nint)(value.Value);

    public static explicit operator VkMicromapEXT(sbyte value) => new VkMicromapEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkMicromapEXT value) => (sbyte)(value.Value);

    public static implicit operator VkMicromapEXT(ushort value) => new VkMicromapEXT(value);

    public static explicit operator ushort(VkMicromapEXT value) => (ushort)(value.Value);

    public static implicit operator VkMicromapEXT(uint value) => new VkMicromapEXT(value);

    public static explicit operator uint(VkMicromapEXT value) => (uint)(value.Value);

    public static implicit operator VkMicromapEXT(ulong value) => new VkMicromapEXT(value);

    public static implicit operator ulong(VkMicromapEXT value) => value.Value;

    public static implicit operator VkMicromapEXT(nuint value) => new VkMicromapEXT(value);

    public static explicit operator nuint(VkMicromapEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkMicromapEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkMicromapEXT.");
    }

    public int CompareTo(VkMicromapEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkMicromapEXT other) && Equals(other);

    public bool Equals(VkMicromapEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
