// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkPipeline : IComparable, IComparable<VkPipeline>, IEquatable<VkPipeline>, IFormattable
{
    public readonly ulong Value;

    public VkPipeline(ulong value)
    {
        Value = value;
    }

    public static VkPipeline NULL => new VkPipeline(0);

    public static bool operator ==(VkPipeline left, VkPipeline right) => left.Value == right.Value;

    public static bool operator !=(VkPipeline left, VkPipeline right) => left.Value != right.Value;

    public static bool operator <(VkPipeline left, VkPipeline right) => left.Value < right.Value;

    public static bool operator <=(VkPipeline left, VkPipeline right) => left.Value <= right.Value;

    public static bool operator >(VkPipeline left, VkPipeline right) => left.Value > right.Value;

    public static bool operator >=(VkPipeline left, VkPipeline right) => left.Value >= right.Value;

    public static implicit operator VkPipeline(byte value) => new VkPipeline(value);

    public static explicit operator byte(VkPipeline value) => (byte)(value.Value);

    public static explicit operator VkPipeline(short value) => new VkPipeline(unchecked((ulong)(value)));

    public static explicit operator short(VkPipeline value) => (short)(value.Value);

    public static explicit operator VkPipeline(int value) => new VkPipeline(unchecked((ulong)(value)));

    public static explicit operator int(VkPipeline value) => (int)(value.Value);

    public static explicit operator VkPipeline(long value) => new VkPipeline(unchecked((ulong)(value)));

    public static explicit operator long(VkPipeline value) => (long)(value.Value);

    public static explicit operator VkPipeline(nint value) => new VkPipeline(unchecked((ulong)(value)));

    public static explicit operator nint(VkPipeline value) => (nint)(value.Value);

    public static explicit operator VkPipeline(sbyte value) => new VkPipeline(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkPipeline value) => (sbyte)(value.Value);

    public static implicit operator VkPipeline(ushort value) => new VkPipeline(value);

    public static explicit operator ushort(VkPipeline value) => (ushort)(value.Value);

    public static implicit operator VkPipeline(uint value) => new VkPipeline(value);

    public static explicit operator uint(VkPipeline value) => (uint)(value.Value);

    public static implicit operator VkPipeline(ulong value) => new VkPipeline(value);

    public static implicit operator ulong(VkPipeline value) => value.Value;

    public static implicit operator VkPipeline(nuint value) => new VkPipeline(value);

    public static explicit operator nuint(VkPipeline value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPipeline other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPipeline.");
    }

    public int CompareTo(VkPipeline other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkPipeline other) && Equals(other);

    public bool Equals(VkPipeline other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
