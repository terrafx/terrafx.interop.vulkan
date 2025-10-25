// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkIndirectExecutionSetEXT : IComparable, IComparable<VkIndirectExecutionSetEXT>, IEquatable<VkIndirectExecutionSetEXT>, IFormattable
{
    public readonly ulong Value;

    public VkIndirectExecutionSetEXT(ulong value)
    {
        Value = value;
    }

    public static VkIndirectExecutionSetEXT NULL => new VkIndirectExecutionSetEXT(0);

    public static bool operator ==(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value == right.Value;

    public static bool operator !=(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value != right.Value;

    public static bool operator <(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value < right.Value;

    public static bool operator <=(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value <= right.Value;

    public static bool operator >(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value > right.Value;

    public static bool operator >=(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Value >= right.Value;

    public static implicit operator VkIndirectExecutionSetEXT(byte value) => new VkIndirectExecutionSetEXT(value);

    public static explicit operator byte(VkIndirectExecutionSetEXT value) => (byte)(value.Value);

    public static explicit operator VkIndirectExecutionSetEXT(short value) => new VkIndirectExecutionSetEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkIndirectExecutionSetEXT value) => (short)(value.Value);

    public static explicit operator VkIndirectExecutionSetEXT(int value) => new VkIndirectExecutionSetEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkIndirectExecutionSetEXT value) => (int)(value.Value);

    public static explicit operator VkIndirectExecutionSetEXT(long value) => new VkIndirectExecutionSetEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkIndirectExecutionSetEXT value) => (long)(value.Value);

    public static explicit operator VkIndirectExecutionSetEXT(nint value) => new VkIndirectExecutionSetEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkIndirectExecutionSetEXT value) => (nint)(value.Value);

    public static explicit operator VkIndirectExecutionSetEXT(sbyte value) => new VkIndirectExecutionSetEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkIndirectExecutionSetEXT value) => (sbyte)(value.Value);

    public static implicit operator VkIndirectExecutionSetEXT(ushort value) => new VkIndirectExecutionSetEXT(value);

    public static explicit operator ushort(VkIndirectExecutionSetEXT value) => (ushort)(value.Value);

    public static implicit operator VkIndirectExecutionSetEXT(uint value) => new VkIndirectExecutionSetEXT(value);

    public static explicit operator uint(VkIndirectExecutionSetEXT value) => (uint)(value.Value);

    public static implicit operator VkIndirectExecutionSetEXT(ulong value) => new VkIndirectExecutionSetEXT(value);

    public static implicit operator ulong(VkIndirectExecutionSetEXT value) => value.Value;

    public static implicit operator VkIndirectExecutionSetEXT(nuint value) => new VkIndirectExecutionSetEXT(value);

    public static explicit operator nuint(VkIndirectExecutionSetEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkIndirectExecutionSetEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkIndirectExecutionSetEXT.");
    }

    public int CompareTo(VkIndirectExecutionSetEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkIndirectExecutionSetEXT other) && Equals(other);

    public bool Equals(VkIndirectExecutionSetEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
