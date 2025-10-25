// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPipelineBinaryKHR : IComparable, IComparable<VkPipelineBinaryKHR>, IEquatable<VkPipelineBinaryKHR>, IFormattable
{
    public readonly ulong Value;

    public VkPipelineBinaryKHR(ulong value)
    {
        Value = value;
    }

    public static VkPipelineBinaryKHR NULL => new VkPipelineBinaryKHR(0);

    public static bool operator ==(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value == right.Value;

    public static bool operator !=(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value != right.Value;

    public static bool operator <(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value < right.Value;

    public static bool operator <=(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value <= right.Value;

    public static bool operator >(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value > right.Value;

    public static bool operator >=(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Value >= right.Value;

    public static implicit operator VkPipelineBinaryKHR(byte value) => new VkPipelineBinaryKHR(value);

    public static explicit operator byte(VkPipelineBinaryKHR value) => (byte)(value.Value);

    public static explicit operator VkPipelineBinaryKHR(short value) => new VkPipelineBinaryKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkPipelineBinaryKHR value) => (short)(value.Value);

    public static explicit operator VkPipelineBinaryKHR(int value) => new VkPipelineBinaryKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkPipelineBinaryKHR value) => (int)(value.Value);

    public static explicit operator VkPipelineBinaryKHR(long value) => new VkPipelineBinaryKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkPipelineBinaryKHR value) => (long)(value.Value);

    public static explicit operator VkPipelineBinaryKHR(nint value) => new VkPipelineBinaryKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkPipelineBinaryKHR value) => (nint)(value.Value);

    public static explicit operator VkPipelineBinaryKHR(sbyte value) => new VkPipelineBinaryKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPipelineBinaryKHR value) => (sbyte)(value.Value);

    public static implicit operator VkPipelineBinaryKHR(ushort value) => new VkPipelineBinaryKHR(value);

    public static explicit operator ushort(VkPipelineBinaryKHR value) => (ushort)(value.Value);

    public static implicit operator VkPipelineBinaryKHR(uint value) => new VkPipelineBinaryKHR(value);

    public static explicit operator uint(VkPipelineBinaryKHR value) => (uint)(value.Value);

    public static implicit operator VkPipelineBinaryKHR(ulong value) => new VkPipelineBinaryKHR(value);

    public static implicit operator ulong(VkPipelineBinaryKHR value) => value.Value;

    public static implicit operator VkPipelineBinaryKHR(nuint value) => new VkPipelineBinaryKHR(value);

    public static explicit operator nuint(VkPipelineBinaryKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPipelineBinaryKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPipelineBinaryKHR.");
    }

    public int CompareTo(VkPipelineBinaryKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPipelineBinaryKHR other) && Equals(other);

    public bool Equals(VkPipelineBinaryKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
