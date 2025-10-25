// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDescriptorUpdateTemplate : IComparable, IComparable<VkDescriptorUpdateTemplate>, IEquatable<VkDescriptorUpdateTemplate>, IFormattable
{
    public readonly ulong Value;

    public VkDescriptorUpdateTemplate(ulong value)
    {
        Value = value;
    }

    public static VkDescriptorUpdateTemplate NULL => new VkDescriptorUpdateTemplate(0);

    public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value == right.Value;

    public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value != right.Value;

    public static bool operator <(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value < right.Value;

    public static bool operator <=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value <= right.Value;

    public static bool operator >(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value > right.Value;

    public static bool operator >=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Value >= right.Value;

    public static implicit operator VkDescriptorUpdateTemplate(byte value) => new VkDescriptorUpdateTemplate(value);

    public static explicit operator byte(VkDescriptorUpdateTemplate value) => (byte)(value.Value);

    public static explicit operator VkDescriptorUpdateTemplate(short value) => new VkDescriptorUpdateTemplate(unchecked((ulong)(value)));

    public static explicit operator short(VkDescriptorUpdateTemplate value) => (short)(value.Value);

    public static explicit operator VkDescriptorUpdateTemplate(int value) => new VkDescriptorUpdateTemplate(unchecked((ulong)(value)));

    public static explicit operator int(VkDescriptorUpdateTemplate value) => (int)(value.Value);

    public static explicit operator VkDescriptorUpdateTemplate(long value) => new VkDescriptorUpdateTemplate(unchecked((ulong)(value)));

    public static explicit operator long(VkDescriptorUpdateTemplate value) => (long)(value.Value);

    public static explicit operator VkDescriptorUpdateTemplate(nint value) => new VkDescriptorUpdateTemplate(unchecked((ulong)(value)));

    public static explicit operator nint(VkDescriptorUpdateTemplate value) => (nint)(value.Value);

    public static explicit operator VkDescriptorUpdateTemplate(sbyte value) => new VkDescriptorUpdateTemplate(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDescriptorUpdateTemplate value) => (sbyte)(value.Value);

    public static implicit operator VkDescriptorUpdateTemplate(ushort value) => new VkDescriptorUpdateTemplate(value);

    public static explicit operator ushort(VkDescriptorUpdateTemplate value) => (ushort)(value.Value);

    public static implicit operator VkDescriptorUpdateTemplate(uint value) => new VkDescriptorUpdateTemplate(value);

    public static explicit operator uint(VkDescriptorUpdateTemplate value) => (uint)(value.Value);

    public static implicit operator VkDescriptorUpdateTemplate(ulong value) => new VkDescriptorUpdateTemplate(value);

    public static implicit operator ulong(VkDescriptorUpdateTemplate value) => value.Value;

    public static implicit operator VkDescriptorUpdateTemplate(nuint value) => new VkDescriptorUpdateTemplate(value);

    public static explicit operator nuint(VkDescriptorUpdateTemplate value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDescriptorUpdateTemplate other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDescriptorUpdateTemplate.");
    }

    public int CompareTo(VkDescriptorUpdateTemplate other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDescriptorUpdateTemplate other) && Equals(other);

    public bool Equals(VkDescriptorUpdateTemplate other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
