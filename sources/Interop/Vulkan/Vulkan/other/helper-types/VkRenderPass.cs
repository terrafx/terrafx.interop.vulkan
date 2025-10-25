// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkRenderPass : IComparable, IComparable<VkRenderPass>, IEquatable<VkRenderPass>, IFormattable
{
    public readonly ulong Value;

    public VkRenderPass(ulong value)
    {
        Value = value;
    }

    public static VkRenderPass NULL => new VkRenderPass(0);

    public static bool operator ==(VkRenderPass left, VkRenderPass right) => left.Value == right.Value;

    public static bool operator !=(VkRenderPass left, VkRenderPass right) => left.Value != right.Value;

    public static bool operator <(VkRenderPass left, VkRenderPass right) => left.Value < right.Value;

    public static bool operator <=(VkRenderPass left, VkRenderPass right) => left.Value <= right.Value;

    public static bool operator >(VkRenderPass left, VkRenderPass right) => left.Value > right.Value;

    public static bool operator >=(VkRenderPass left, VkRenderPass right) => left.Value >= right.Value;

    public static implicit operator VkRenderPass(byte value) => new VkRenderPass(value);

    public static explicit operator byte(VkRenderPass value) => (byte)(value.Value);

    public static explicit operator VkRenderPass(short value) => new VkRenderPass(unchecked((ulong)(value)));

    public static explicit operator short(VkRenderPass value) => (short)(value.Value);

    public static explicit operator VkRenderPass(int value) => new VkRenderPass(unchecked((ulong)(value)));

    public static explicit operator int(VkRenderPass value) => (int)(value.Value);

    public static explicit operator VkRenderPass(long value) => new VkRenderPass(unchecked((ulong)(value)));

    public static explicit operator long(VkRenderPass value) => (long)(value.Value);

    public static explicit operator VkRenderPass(nint value) => new VkRenderPass(unchecked((ulong)(value)));

    public static explicit operator nint(VkRenderPass value) => (nint)(value.Value);

    public static explicit operator VkRenderPass(sbyte value) => new VkRenderPass(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkRenderPass value) => (sbyte)(value.Value);

    public static implicit operator VkRenderPass(ushort value) => new VkRenderPass(value);

    public static explicit operator ushort(VkRenderPass value) => (ushort)(value.Value);

    public static implicit operator VkRenderPass(uint value) => new VkRenderPass(value);

    public static explicit operator uint(VkRenderPass value) => (uint)(value.Value);

    public static implicit operator VkRenderPass(ulong value) => new VkRenderPass(value);

    public static implicit operator ulong(VkRenderPass value) => value.Value;

    public static implicit operator VkRenderPass(nuint value) => new VkRenderPass(value);

    public static explicit operator nuint(VkRenderPass value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkRenderPass other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkRenderPass.");
    }

    public int CompareTo(VkRenderPass other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkRenderPass other) && Equals(other);

    public bool Equals(VkRenderPass other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
