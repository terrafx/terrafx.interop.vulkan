// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDebugUtilsMessengerEXT : IComparable, IComparable<VkDebugUtilsMessengerEXT>, IEquatable<VkDebugUtilsMessengerEXT>, IFormattable
{
    public readonly ulong Value;

    public VkDebugUtilsMessengerEXT(ulong value)
    {
        Value = value;
    }

    public static VkDebugUtilsMessengerEXT NULL => new VkDebugUtilsMessengerEXT(0);

    public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value == right.Value;

    public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value != right.Value;

    public static bool operator <(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value < right.Value;

    public static bool operator <=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value <= right.Value;

    public static bool operator >(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value > right.Value;

    public static bool operator >=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Value >= right.Value;

    public static implicit operator VkDebugUtilsMessengerEXT(byte value) => new VkDebugUtilsMessengerEXT(value);

    public static explicit operator byte(VkDebugUtilsMessengerEXT value) => (byte)(value.Value);

    public static explicit operator VkDebugUtilsMessengerEXT(short value) => new VkDebugUtilsMessengerEXT(unchecked((ulong)(value)));

    public static explicit operator short(VkDebugUtilsMessengerEXT value) => (short)(value.Value);

    public static explicit operator VkDebugUtilsMessengerEXT(int value) => new VkDebugUtilsMessengerEXT(unchecked((ulong)(value)));

    public static explicit operator int(VkDebugUtilsMessengerEXT value) => (int)(value.Value);

    public static explicit operator VkDebugUtilsMessengerEXT(long value) => new VkDebugUtilsMessengerEXT(unchecked((ulong)(value)));

    public static explicit operator long(VkDebugUtilsMessengerEXT value) => (long)(value.Value);

    public static explicit operator VkDebugUtilsMessengerEXT(nint value) => new VkDebugUtilsMessengerEXT(unchecked((ulong)(value)));

    public static explicit operator nint(VkDebugUtilsMessengerEXT value) => (nint)(value.Value);

    public static explicit operator VkDebugUtilsMessengerEXT(sbyte value) => new VkDebugUtilsMessengerEXT(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDebugUtilsMessengerEXT value) => (sbyte)(value.Value);

    public static implicit operator VkDebugUtilsMessengerEXT(ushort value) => new VkDebugUtilsMessengerEXT(value);

    public static explicit operator ushort(VkDebugUtilsMessengerEXT value) => (ushort)(value.Value);

    public static implicit operator VkDebugUtilsMessengerEXT(uint value) => new VkDebugUtilsMessengerEXT(value);

    public static explicit operator uint(VkDebugUtilsMessengerEXT value) => (uint)(value.Value);

    public static implicit operator VkDebugUtilsMessengerEXT(ulong value) => new VkDebugUtilsMessengerEXT(value);

    public static implicit operator ulong(VkDebugUtilsMessengerEXT value) => value.Value;

    public static implicit operator VkDebugUtilsMessengerEXT(nuint value) => new VkDebugUtilsMessengerEXT(value);

    public static explicit operator nuint(VkDebugUtilsMessengerEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDebugUtilsMessengerEXT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDebugUtilsMessengerEXT.");
    }

    public int CompareTo(VkDebugUtilsMessengerEXT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDebugUtilsMessengerEXT other) && Equals(other);

    public bool Equals(VkDebugUtilsMessengerEXT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
