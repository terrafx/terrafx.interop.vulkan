// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkValidationCacheEXT : IComparable, IComparable<VkValidationCacheEXT>, IEquatable<VkValidationCacheEXT>, IFormattable
{
    public readonly ulong Value;

    public VkValidationCacheEXT(ulong value)
    {
        Value = value;
    }

    public static VkValidationCacheEXT NULL => new VkValidationCacheEXT(0);

    public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value == right.Value;

    public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value != right.Value;

    public static bool operator <(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value < right.Value;

    public static bool operator <=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value <= right.Value;

    public static bool operator >(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value > right.Value;

    public static bool operator >=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Value >= right.Value;

    public static implicit operator VkValidationCacheEXT(byte value) => new VkValidationCacheEXT(value);

    public static explicit operator byte(VkValidationCacheEXT value) => (byte)(value.Value);

    public static explicit operator VkValidationCacheEXT(short value) => new VkValidationCacheEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkValidationCacheEXT value) => (short)(value.Value);

    public static explicit operator VkValidationCacheEXT(int value) => new VkValidationCacheEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkValidationCacheEXT value) => (int)(value.Value);

    public static explicit operator VkValidationCacheEXT(long value) => new VkValidationCacheEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkValidationCacheEXT value) => (long)(value.Value);

    public static explicit operator VkValidationCacheEXT(nint value) => new VkValidationCacheEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkValidationCacheEXT value) => (nint)(value.Value);

    public static explicit operator VkValidationCacheEXT(sbyte value) => new VkValidationCacheEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkValidationCacheEXT value) => (sbyte)(value.Value);

    public static implicit operator VkValidationCacheEXT(ushort value) => new VkValidationCacheEXT(value);

    public static explicit operator ushort(VkValidationCacheEXT value) => (ushort)(value.Value);

    public static implicit operator VkValidationCacheEXT(uint value) => new VkValidationCacheEXT(value);

    public static explicit operator uint(VkValidationCacheEXT value) => (uint)(value.Value);

    public static implicit operator VkValidationCacheEXT(ulong value) => new VkValidationCacheEXT(value);

    public static implicit operator ulong(VkValidationCacheEXT value) => value.Value;

    public static implicit operator VkValidationCacheEXT(nuint value) => new VkValidationCacheEXT(value);

    public static explicit operator nuint(VkValidationCacheEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkValidationCacheEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkValidationCacheEXT.");
    }

    public int CompareTo(VkValidationCacheEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkValidationCacheEXT other) && Equals(other);

    public bool Equals(VkValidationCacheEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
