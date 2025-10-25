// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDescriptorSet : IComparable, IComparable<VkDescriptorSet>, IEquatable<VkDescriptorSet>, IFormattable
{
    public readonly ulong Value;

    public VkDescriptorSet(ulong value)
    {
        Value = value;
    }

    public static VkDescriptorSet NULL => new VkDescriptorSet(0);

    public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) => left.Value == right.Value;

    public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) => left.Value != right.Value;

    public static bool operator <(VkDescriptorSet left, VkDescriptorSet right) => left.Value < right.Value;

    public static bool operator <=(VkDescriptorSet left, VkDescriptorSet right) => left.Value <= right.Value;

    public static bool operator >(VkDescriptorSet left, VkDescriptorSet right) => left.Value > right.Value;

    public static bool operator >=(VkDescriptorSet left, VkDescriptorSet right) => left.Value >= right.Value;

    public static implicit operator VkDescriptorSet(byte value) => new VkDescriptorSet(value);

    public static explicit operator byte(VkDescriptorSet value) => (byte)(value.Value);

    public static explicit operator VkDescriptorSet(short value) => new VkDescriptorSet(unchecked((ulong)(value)));

    public static explicit operator short(VkDescriptorSet value) => (short)(value.Value);

    public static explicit operator VkDescriptorSet(int value) => new VkDescriptorSet(unchecked((ulong)(value)));

    public static explicit operator int(VkDescriptorSet value) => (int)(value.Value);

    public static explicit operator VkDescriptorSet(long value) => new VkDescriptorSet(unchecked((ulong)(value)));

    public static explicit operator long(VkDescriptorSet value) => (long)(value.Value);

    public static explicit operator VkDescriptorSet(nint value) => new VkDescriptorSet(unchecked((ulong)(value)));

    public static explicit operator nint(VkDescriptorSet value) => (nint)(value.Value);

    public static explicit operator VkDescriptorSet(sbyte value) => new VkDescriptorSet(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDescriptorSet value) => (sbyte)(value.Value);

    public static implicit operator VkDescriptorSet(ushort value) => new VkDescriptorSet(value);

    public static explicit operator ushort(VkDescriptorSet value) => (ushort)(value.Value);

    public static implicit operator VkDescriptorSet(uint value) => new VkDescriptorSet(value);

    public static explicit operator uint(VkDescriptorSet value) => (uint)(value.Value);

    public static implicit operator VkDescriptorSet(ulong value) => new VkDescriptorSet(value);

    public static implicit operator ulong(VkDescriptorSet value) => value.Value;

    public static implicit operator VkDescriptorSet(nuint value) => new VkDescriptorSet(value);

    public static explicit operator nuint(VkDescriptorSet value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDescriptorSet other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDescriptorSet.");
    }

    public int CompareTo(VkDescriptorSet other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDescriptorSet other) && Equals(other);

    public bool Equals(VkDescriptorSet other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
