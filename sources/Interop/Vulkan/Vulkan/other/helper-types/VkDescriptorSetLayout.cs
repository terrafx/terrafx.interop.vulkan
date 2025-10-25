// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDescriptorSetLayout : IComparable, IComparable<VkDescriptorSetLayout>, IEquatable<VkDescriptorSetLayout>, IFormattable
{
    public readonly ulong Value;

    public VkDescriptorSetLayout(ulong value)
    {
        Value = value;
    }

    public static VkDescriptorSetLayout NULL => new VkDescriptorSetLayout(0);

    public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value == right.Value;

    public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value != right.Value;

    public static bool operator <(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value < right.Value;

    public static bool operator <=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value <= right.Value;

    public static bool operator >(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value > right.Value;

    public static bool operator >=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Value >= right.Value;

    public static implicit operator VkDescriptorSetLayout(byte value) => new VkDescriptorSetLayout(value);

    public static explicit operator byte(VkDescriptorSetLayout value) => (byte)(value.Value);

    public static explicit operator VkDescriptorSetLayout(short value) => new VkDescriptorSetLayout(unchecked((ulong)(value)));

    public static explicit operator short(VkDescriptorSetLayout value) => (short)(value.Value);

    public static explicit operator VkDescriptorSetLayout(int value) => new VkDescriptorSetLayout(unchecked((ulong)(value)));

    public static explicit operator int(VkDescriptorSetLayout value) => (int)(value.Value);

    public static explicit operator VkDescriptorSetLayout(long value) => new VkDescriptorSetLayout(unchecked((ulong)(value)));

    public static explicit operator long(VkDescriptorSetLayout value) => (long)(value.Value);

    public static explicit operator VkDescriptorSetLayout(nint value) => new VkDescriptorSetLayout(unchecked((ulong)(value)));

    public static explicit operator nint(VkDescriptorSetLayout value) => (nint)(value.Value);

    public static explicit operator VkDescriptorSetLayout(sbyte value) => new VkDescriptorSetLayout(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDescriptorSetLayout value) => (sbyte)(value.Value);

    public static implicit operator VkDescriptorSetLayout(ushort value) => new VkDescriptorSetLayout(value);

    public static explicit operator ushort(VkDescriptorSetLayout value) => (ushort)(value.Value);

    public static implicit operator VkDescriptorSetLayout(uint value) => new VkDescriptorSetLayout(value);

    public static explicit operator uint(VkDescriptorSetLayout value) => (uint)(value.Value);

    public static implicit operator VkDescriptorSetLayout(ulong value) => new VkDescriptorSetLayout(value);

    public static implicit operator ulong(VkDescriptorSetLayout value) => value.Value;

    public static implicit operator VkDescriptorSetLayout(nuint value) => new VkDescriptorSetLayout(value);

    public static explicit operator nuint(VkDescriptorSetLayout value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDescriptorSetLayout other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDescriptorSetLayout.");
    }

    public int CompareTo(VkDescriptorSetLayout other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDescriptorSetLayout other) && Equals(other);

    public bool Equals(VkDescriptorSetLayout other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
