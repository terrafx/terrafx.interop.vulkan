// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkShaderEXT : IComparable, IComparable<VkShaderEXT>, IEquatable<VkShaderEXT>, IFormattable
{
    public readonly ulong Value;

    public VkShaderEXT(ulong value)
    {
        Value = value;
    }

    public static VkShaderEXT NULL => new VkShaderEXT(0);

    public static bool operator ==(VkShaderEXT left, VkShaderEXT right) => left.Value == right.Value;

    public static bool operator !=(VkShaderEXT left, VkShaderEXT right) => left.Value != right.Value;

    public static bool operator <(VkShaderEXT left, VkShaderEXT right) => left.Value < right.Value;

    public static bool operator <=(VkShaderEXT left, VkShaderEXT right) => left.Value <= right.Value;

    public static bool operator >(VkShaderEXT left, VkShaderEXT right) => left.Value > right.Value;

    public static bool operator >=(VkShaderEXT left, VkShaderEXT right) => left.Value >= right.Value;

    public static implicit operator VkShaderEXT(byte value) => new VkShaderEXT(value);

    public static explicit operator byte(VkShaderEXT value) => (byte)(value.Value);

    public static explicit operator VkShaderEXT(short value) => new VkShaderEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkShaderEXT value) => (short)(value.Value);

    public static explicit operator VkShaderEXT(int value) => new VkShaderEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkShaderEXT value) => (int)(value.Value);

    public static explicit operator VkShaderEXT(long value) => new VkShaderEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkShaderEXT value) => (long)(value.Value);

    public static explicit operator VkShaderEXT(nint value) => new VkShaderEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkShaderEXT value) => (nint)(value.Value);

    public static explicit operator VkShaderEXT(sbyte value) => new VkShaderEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkShaderEXT value) => (sbyte)(value.Value);

    public static implicit operator VkShaderEXT(ushort value) => new VkShaderEXT(value);

    public static explicit operator ushort(VkShaderEXT value) => (ushort)(value.Value);

    public static implicit operator VkShaderEXT(uint value) => new VkShaderEXT(value);

    public static explicit operator uint(VkShaderEXT value) => (uint)(value.Value);

    public static implicit operator VkShaderEXT(ulong value) => new VkShaderEXT(value);

    public static implicit operator ulong(VkShaderEXT value) => value.Value;

    public static implicit operator VkShaderEXT(nuint value) => new VkShaderEXT(value);

    public static explicit operator nuint(VkShaderEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkShaderEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkShaderEXT.");
    }

    public int CompareTo(VkShaderEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkShaderEXT other) && Equals(other);

    public bool Equals(VkShaderEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
