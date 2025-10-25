// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkInstance : IComparable, IComparable<VkInstance>, IEquatable<VkInstance>, IFormattable
{
    public readonly void* Value;

    public VkInstance(void* value)
    {
        Value = value;
    }

    public static VkInstance NULL => new VkInstance(null);

    public static bool operator ==(VkInstance left, VkInstance right) => left.Value == right.Value;

    public static bool operator !=(VkInstance left, VkInstance right) => left.Value != right.Value;

    public static bool operator <(VkInstance left, VkInstance right) => left.Value < right.Value;

    public static bool operator <=(VkInstance left, VkInstance right) => left.Value <= right.Value;

    public static bool operator >(VkInstance left, VkInstance right) => left.Value > right.Value;

    public static bool operator >=(VkInstance left, VkInstance right) => left.Value >= right.Value;

    public static explicit operator VkInstance(void* value) => new VkInstance(value);

    public static implicit operator void*(VkInstance value) => value.Value;

    public static explicit operator VkInstance(byte value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator byte(VkInstance value) => (byte)(value.Value);

    public static explicit operator VkInstance(short value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator short(VkInstance value) => (short)(value.Value);

    public static explicit operator VkInstance(int value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator int(VkInstance value) => (int)(value.Value);

    public static explicit operator VkInstance(long value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator long(VkInstance value) => (long)(value.Value);

    public static explicit operator VkInstance(nint value) => new VkInstance(unchecked((void*)(value)));

    public static implicit operator nint(VkInstance value) => (nint)(value.Value);

    public static explicit operator VkInstance(sbyte value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator sbyte(VkInstance value) => (sbyte)(value.Value);

    public static explicit operator VkInstance(ushort value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator ushort(VkInstance value) => (ushort)(value.Value);

    public static explicit operator VkInstance(uint value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator uint(VkInstance value) => (uint)(value.Value);

    public static explicit operator VkInstance(ulong value) => new VkInstance(unchecked((void*)(value)));

    public static explicit operator ulong(VkInstance value) => (ulong)(value.Value);

    public static explicit operator VkInstance(nuint value) => new VkInstance(unchecked((void*)(value)));

    public static implicit operator nuint(VkInstance value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkInstance other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkInstance.");
    }

    public int CompareTo(VkInstance other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkInstance other) && Equals(other);

    public bool Equals(VkInstance other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
