// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkShaderModule : IComparable, IComparable<VkShaderModule>, IEquatable<VkShaderModule>, IFormattable
{
    public readonly ulong Value;

    public VkShaderModule(ulong value)
    {
        Value = value;
    }

    public static VkShaderModule NULL => new VkShaderModule(0);

    public static bool operator ==(VkShaderModule left, VkShaderModule right) => left.Value == right.Value;

    public static bool operator !=(VkShaderModule left, VkShaderModule right) => left.Value != right.Value;

    public static bool operator <(VkShaderModule left, VkShaderModule right) => left.Value < right.Value;

    public static bool operator <=(VkShaderModule left, VkShaderModule right) => left.Value <= right.Value;

    public static bool operator >(VkShaderModule left, VkShaderModule right) => left.Value > right.Value;

    public static bool operator >=(VkShaderModule left, VkShaderModule right) => left.Value >= right.Value;

    public static implicit operator VkShaderModule(byte value) => new VkShaderModule(value);

    public static explicit operator byte(VkShaderModule value) => (byte)(value.Value);

    public static explicit operator VkShaderModule(short value) => new VkShaderModule(unchecked((ulong)(value)));

    public static explicit operator short(VkShaderModule value) => (short)(value.Value);

    public static explicit operator VkShaderModule(int value) => new VkShaderModule(unchecked((ulong)(value)));

    public static explicit operator int(VkShaderModule value) => (int)(value.Value);

    public static explicit operator VkShaderModule(long value) => new VkShaderModule(unchecked((ulong)(value)));

    public static explicit operator long(VkShaderModule value) => (long)(value.Value);

    public static explicit operator VkShaderModule(nint value) => new VkShaderModule(unchecked((ulong)(value)));

    public static explicit operator nint(VkShaderModule value) => (nint)(value.Value);

    public static explicit operator VkShaderModule(sbyte value) => new VkShaderModule(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkShaderModule value) => (sbyte)(value.Value);

    public static implicit operator VkShaderModule(ushort value) => new VkShaderModule(value);

    public static explicit operator ushort(VkShaderModule value) => (ushort)(value.Value);

    public static implicit operator VkShaderModule(uint value) => new VkShaderModule(value);

    public static explicit operator uint(VkShaderModule value) => (uint)(value.Value);

    public static implicit operator VkShaderModule(ulong value) => new VkShaderModule(value);

    public static implicit operator ulong(VkShaderModule value) => value.Value;

    public static implicit operator VkShaderModule(nuint value) => new VkShaderModule(value);

    public static explicit operator nuint(VkShaderModule value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkShaderModule other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkShaderModule.");
    }

    public int CompareTo(VkShaderModule other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkShaderModule other) && Equals(other);

    public bool Equals(VkShaderModule other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
