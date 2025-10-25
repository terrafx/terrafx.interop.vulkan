// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDescriptorPool : IComparable, IComparable<VkDescriptorPool>, IEquatable<VkDescriptorPool>, IFormattable
{
    public readonly ulong Value;

    public VkDescriptorPool(ulong value)
    {
        Value = value;
    }

    public static VkDescriptorPool NULL => new VkDescriptorPool(0);

    public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) => left.Value == right.Value;

    public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) => left.Value != right.Value;

    public static bool operator <(VkDescriptorPool left, VkDescriptorPool right) => left.Value < right.Value;

    public static bool operator <=(VkDescriptorPool left, VkDescriptorPool right) => left.Value <= right.Value;

    public static bool operator >(VkDescriptorPool left, VkDescriptorPool right) => left.Value > right.Value;

    public static bool operator >=(VkDescriptorPool left, VkDescriptorPool right) => left.Value >= right.Value;

    public static implicit operator VkDescriptorPool(byte value) => new VkDescriptorPool(value);

    public static explicit operator byte(VkDescriptorPool value) => (byte)(value.Value);

    public static explicit operator VkDescriptorPool(short value) => new VkDescriptorPool(unchecked((ulong)(value)));

    public static explicit operator short(VkDescriptorPool value) => (short)(value.Value);

    public static explicit operator VkDescriptorPool(int value) => new VkDescriptorPool(unchecked((ulong)(value)));

    public static explicit operator int(VkDescriptorPool value) => (int)(value.Value);

    public static explicit operator VkDescriptorPool(long value) => new VkDescriptorPool(unchecked((ulong)(value)));

    public static explicit operator long(VkDescriptorPool value) => (long)(value.Value);

    public static explicit operator VkDescriptorPool(nint value) => new VkDescriptorPool(unchecked((ulong)(value)));

    public static explicit operator nint(VkDescriptorPool value) => (nint)(value.Value);

    public static explicit operator VkDescriptorPool(sbyte value) => new VkDescriptorPool(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDescriptorPool value) => (sbyte)(value.Value);

    public static implicit operator VkDescriptorPool(ushort value) => new VkDescriptorPool(value);

    public static explicit operator ushort(VkDescriptorPool value) => (ushort)(value.Value);

    public static implicit operator VkDescriptorPool(uint value) => new VkDescriptorPool(value);

    public static explicit operator uint(VkDescriptorPool value) => (uint)(value.Value);

    public static implicit operator VkDescriptorPool(ulong value) => new VkDescriptorPool(value);

    public static implicit operator ulong(VkDescriptorPool value) => value.Value;

    public static implicit operator VkDescriptorPool(nuint value) => new VkDescriptorPool(value);

    public static explicit operator nuint(VkDescriptorPool value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDescriptorPool other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDescriptorPool.");
    }

    public int CompareTo(VkDescriptorPool other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDescriptorPool other) && Equals(other);

    public bool Equals(VkDescriptorPool other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
