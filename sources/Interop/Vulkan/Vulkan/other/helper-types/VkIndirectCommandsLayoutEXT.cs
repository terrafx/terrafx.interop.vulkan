// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkIndirectCommandsLayoutEXT : IComparable, IComparable<VkIndirectCommandsLayoutEXT>, IEquatable<VkIndirectCommandsLayoutEXT>, IFormattable
{
    public readonly ulong Value;

    public VkIndirectCommandsLayoutEXT(ulong value)
    {
        Value = value;
    }

    public static VkIndirectCommandsLayoutEXT NULL => new VkIndirectCommandsLayoutEXT(0);

    public static bool operator ==(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value == right.Value;

    public static bool operator !=(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value != right.Value;

    public static bool operator <(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value < right.Value;

    public static bool operator <=(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value <= right.Value;

    public static bool operator >(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value > right.Value;

    public static bool operator >=(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Value >= right.Value;

    public static implicit operator VkIndirectCommandsLayoutEXT(byte value) => new VkIndirectCommandsLayoutEXT(value);

    public static explicit operator byte(VkIndirectCommandsLayoutEXT value) => (byte)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutEXT(short value) => new VkIndirectCommandsLayoutEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkIndirectCommandsLayoutEXT value) => (short)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutEXT(int value) => new VkIndirectCommandsLayoutEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkIndirectCommandsLayoutEXT value) => (int)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutEXT(long value) => new VkIndirectCommandsLayoutEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkIndirectCommandsLayoutEXT value) => (long)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutEXT(nint value) => new VkIndirectCommandsLayoutEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkIndirectCommandsLayoutEXT value) => (nint)(value.Value);

    public static explicit operator VkIndirectCommandsLayoutEXT(sbyte value) => new VkIndirectCommandsLayoutEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkIndirectCommandsLayoutEXT value) => (sbyte)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutEXT(ushort value) => new VkIndirectCommandsLayoutEXT(value);

    public static explicit operator ushort(VkIndirectCommandsLayoutEXT value) => (ushort)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutEXT(uint value) => new VkIndirectCommandsLayoutEXT(value);

    public static explicit operator uint(VkIndirectCommandsLayoutEXT value) => (uint)(value.Value);

    public static implicit operator VkIndirectCommandsLayoutEXT(ulong value) => new VkIndirectCommandsLayoutEXT(value);

    public static implicit operator ulong(VkIndirectCommandsLayoutEXT value) => value.Value;

    public static implicit operator VkIndirectCommandsLayoutEXT(nuint value) => new VkIndirectCommandsLayoutEXT(value);

    public static explicit operator nuint(VkIndirectCommandsLayoutEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkIndirectCommandsLayoutEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkIndirectCommandsLayoutEXT.");
    }

    public int CompareTo(VkIndirectCommandsLayoutEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkIndirectCommandsLayoutEXT other) && Equals(other);

    public bool Equals(VkIndirectCommandsLayoutEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
