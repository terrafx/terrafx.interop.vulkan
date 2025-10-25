// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkCuModuleNVX : IComparable, IComparable<VkCuModuleNVX>, IEquatable<VkCuModuleNVX>, IFormattable
{
    public readonly ulong Value;

    public VkCuModuleNVX(ulong value)
    {
        Value = value;
    }

    public static VkCuModuleNVX NULL => new VkCuModuleNVX(0);

    public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value == right.Value;

    public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value != right.Value;

    public static bool operator <(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value < right.Value;

    public static bool operator <=(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value <= right.Value;

    public static bool operator >(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value > right.Value;

    public static bool operator >=(VkCuModuleNVX left, VkCuModuleNVX right) => left.Value >= right.Value;

    public static implicit operator VkCuModuleNVX(byte value) => new VkCuModuleNVX(value);

    public static explicit operator byte(VkCuModuleNVX value) => (byte)(value.Value);

    public static explicit operator VkCuModuleNVX(short value) => new VkCuModuleNVX(unchecked((ulong)(value)));

    public static explicit operator short(VkCuModuleNVX value) => (short)(value.Value);

    public static explicit operator VkCuModuleNVX(int value) => new VkCuModuleNVX(unchecked((ulong)(value)));

    public static explicit operator int(VkCuModuleNVX value) => (int)(value.Value);

    public static explicit operator VkCuModuleNVX(long value) => new VkCuModuleNVX(unchecked((ulong)(value)));

    public static explicit operator long(VkCuModuleNVX value) => (long)(value.Value);

    public static explicit operator VkCuModuleNVX(nint value) => new VkCuModuleNVX(unchecked((ulong)(value)));

    public static explicit operator nint(VkCuModuleNVX value) => (nint)(value.Value);

    public static explicit operator VkCuModuleNVX(sbyte value) => new VkCuModuleNVX(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkCuModuleNVX value) => (sbyte)(value.Value);

    public static implicit operator VkCuModuleNVX(ushort value) => new VkCuModuleNVX(value);

    public static explicit operator ushort(VkCuModuleNVX value) => (ushort)(value.Value);

    public static implicit operator VkCuModuleNVX(uint value) => new VkCuModuleNVX(value);

    public static explicit operator uint(VkCuModuleNVX value) => (uint)(value.Value);

    public static implicit operator VkCuModuleNVX(ulong value) => new VkCuModuleNVX(value);

    public static implicit operator ulong(VkCuModuleNVX value) => value.Value;

    public static implicit operator VkCuModuleNVX(nuint value) => new VkCuModuleNVX(value);

    public static explicit operator nuint(VkCuModuleNVX value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCuModuleNVX other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCuModuleNVX.");
    }

    public int CompareTo(VkCuModuleNVX other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkCuModuleNVX other) && Equals(other);

    public bool Equals(VkCuModuleNVX other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
