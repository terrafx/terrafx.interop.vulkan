// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDataGraphPipelineSessionARM : IComparable, IComparable<VkDataGraphPipelineSessionARM>, IEquatable<VkDataGraphPipelineSessionARM>, IFormattable
{
    public readonly ulong Value;

    public VkDataGraphPipelineSessionARM(ulong value)
    {
        Value = value;
    }

    public static VkDataGraphPipelineSessionARM NULL => new VkDataGraphPipelineSessionARM(0);

    public static bool operator ==(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value == right.Value;

    public static bool operator !=(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value != right.Value;

    public static bool operator <(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value < right.Value;

    public static bool operator <=(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value <= right.Value;

    public static bool operator >(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value > right.Value;

    public static bool operator >=(VkDataGraphPipelineSessionARM left, VkDataGraphPipelineSessionARM right) => left.Value >= right.Value;

    public static implicit operator VkDataGraphPipelineSessionARM(byte value) => new VkDataGraphPipelineSessionARM(value);

    public static explicit operator byte(VkDataGraphPipelineSessionARM value) => (byte)(value.Value);

    public static explicit operator VkDataGraphPipelineSessionARM(short value) => new VkDataGraphPipelineSessionARM(unchecked((ulong)(value)));

    public static explicit operator short(VkDataGraphPipelineSessionARM value) => (short)(value.Value);

    public static explicit operator VkDataGraphPipelineSessionARM(int value) => new VkDataGraphPipelineSessionARM(unchecked((ulong)(value)));

    public static explicit operator int(VkDataGraphPipelineSessionARM value) => (int)(value.Value);

    public static explicit operator VkDataGraphPipelineSessionARM(long value) => new VkDataGraphPipelineSessionARM(unchecked((ulong)(value)));

    public static explicit operator long(VkDataGraphPipelineSessionARM value) => (long)(value.Value);

    public static explicit operator VkDataGraphPipelineSessionARM(nint value) => new VkDataGraphPipelineSessionARM(unchecked((ulong)(value)));

    public static explicit operator nint(VkDataGraphPipelineSessionARM value) => (nint)(value.Value);

    public static explicit operator VkDataGraphPipelineSessionARM(sbyte value) => new VkDataGraphPipelineSessionARM(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDataGraphPipelineSessionARM value) => (sbyte)(value.Value);

    public static implicit operator VkDataGraphPipelineSessionARM(ushort value) => new VkDataGraphPipelineSessionARM(value);

    public static explicit operator ushort(VkDataGraphPipelineSessionARM value) => (ushort)(value.Value);

    public static implicit operator VkDataGraphPipelineSessionARM(uint value) => new VkDataGraphPipelineSessionARM(value);

    public static explicit operator uint(VkDataGraphPipelineSessionARM value) => (uint)(value.Value);

    public static implicit operator VkDataGraphPipelineSessionARM(ulong value) => new VkDataGraphPipelineSessionARM(value);

    public static implicit operator ulong(VkDataGraphPipelineSessionARM value) => value.Value;

    public static implicit operator VkDataGraphPipelineSessionARM(nuint value) => new VkDataGraphPipelineSessionARM(value);

    public static explicit operator nuint(VkDataGraphPipelineSessionARM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDataGraphPipelineSessionARM other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDataGraphPipelineSessionARM.");
    }

    public int CompareTo(VkDataGraphPipelineSessionARM other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDataGraphPipelineSessionARM other) && Equals(other);

    public bool Equals(VkDataGraphPipelineSessionARM other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
