// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPipelineCache : IComparable, IComparable<VkPipelineCache>, IEquatable<VkPipelineCache>, IFormattable
{
    public readonly ulong Value;

    public VkPipelineCache(ulong value)
    {
        Value = value;
    }

    public static VkPipelineCache NULL => new VkPipelineCache(0);

    public static bool operator ==(VkPipelineCache left, VkPipelineCache right) => left.Value == right.Value;

    public static bool operator !=(VkPipelineCache left, VkPipelineCache right) => left.Value != right.Value;

    public static bool operator <(VkPipelineCache left, VkPipelineCache right) => left.Value < right.Value;

    public static bool operator <=(VkPipelineCache left, VkPipelineCache right) => left.Value <= right.Value;

    public static bool operator >(VkPipelineCache left, VkPipelineCache right) => left.Value > right.Value;

    public static bool operator >=(VkPipelineCache left, VkPipelineCache right) => left.Value >= right.Value;

    public static implicit operator VkPipelineCache(byte value) => new VkPipelineCache(value);

    public static explicit operator byte(VkPipelineCache value) => (byte)(value.Value);

    public static explicit operator VkPipelineCache(short value) => new VkPipelineCache(unchecked((ulong)(value)));

    public static explicit operator short(VkPipelineCache value) => (short)(value.Value);

    public static explicit operator VkPipelineCache(int value) => new VkPipelineCache(unchecked((ulong)(value)));

    public static explicit operator int(VkPipelineCache value) => (int)(value.Value);

    public static explicit operator VkPipelineCache(long value) => new VkPipelineCache(unchecked((ulong)(value)));

    public static explicit operator long(VkPipelineCache value) => (long)(value.Value);

    public static explicit operator VkPipelineCache(nint value) => new VkPipelineCache(unchecked((ulong)(value)));

    public static explicit operator nint(VkPipelineCache value) => (nint)(value.Value);

    public static explicit operator VkPipelineCache(sbyte value) => new VkPipelineCache(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPipelineCache value) => (sbyte)(value.Value);

    public static implicit operator VkPipelineCache(ushort value) => new VkPipelineCache(value);

    public static explicit operator ushort(VkPipelineCache value) => (ushort)(value.Value);

    public static implicit operator VkPipelineCache(uint value) => new VkPipelineCache(value);

    public static explicit operator uint(VkPipelineCache value) => (uint)(value.Value);

    public static implicit operator VkPipelineCache(ulong value) => new VkPipelineCache(value);

    public static implicit operator ulong(VkPipelineCache value) => value.Value;

    public static implicit operator VkPipelineCache(nuint value) => new VkPipelineCache(value);

    public static explicit operator nuint(VkPipelineCache value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPipelineCache other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPipelineCache.");
    }

    public int CompareTo(VkPipelineCache other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPipelineCache other) && Equals(other);

    public bool Equals(VkPipelineCache other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
