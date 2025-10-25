// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkDevice : IComparable, IComparable<VkDevice>, IEquatable<VkDevice>, IFormattable
{
    public readonly void* Value;

    public VkDevice(void* value)
    {
        Value = value;
    }

    public static VkDevice NULL => new VkDevice(null);

    public static bool operator ==(VkDevice left, VkDevice right) => left.Value == right.Value;

    public static bool operator !=(VkDevice left, VkDevice right) => left.Value != right.Value;

    public static bool operator <(VkDevice left, VkDevice right) => left.Value < right.Value;

    public static bool operator <=(VkDevice left, VkDevice right) => left.Value <= right.Value;

    public static bool operator >(VkDevice left, VkDevice right) => left.Value > right.Value;

    public static bool operator >=(VkDevice left, VkDevice right) => left.Value >= right.Value;

    public static explicit operator VkDevice(void* value) => new VkDevice(value);

    public static implicit operator void*(VkDevice value) => value.Value;

    public static explicit operator VkDevice(byte value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator byte(VkDevice value) => (byte)(value.Value);

    public static explicit operator VkDevice(short value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator short(VkDevice value) => (short)(value.Value);

    public static explicit operator VkDevice(int value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator int(VkDevice value) => (int)(value.Value);

    public static explicit operator VkDevice(long value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator long(VkDevice value) => (long)(value.Value);

    public static explicit operator VkDevice(nint value) => new VkDevice(unchecked((void*)(value)));

    public static implicit operator nint(VkDevice value) => (nint)(value.Value);

    public static explicit operator VkDevice(sbyte value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator sbyte(VkDevice value) => (sbyte)(value.Value);

    public static explicit operator VkDevice(ushort value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator ushort(VkDevice value) => (ushort)(value.Value);

    public static explicit operator VkDevice(uint value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator uint(VkDevice value) => (uint)(value.Value);

    public static explicit operator VkDevice(ulong value) => new VkDevice(unchecked((void*)(value)));

    public static explicit operator ulong(VkDevice value) => (ulong)(value.Value);

    public static explicit operator VkDevice(nuint value) => new VkDevice(unchecked((void*)(value)));

    public static implicit operator nuint(VkDevice value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDevice other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDevice.");
    }

    public int CompareTo(VkDevice other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkDevice other) && Equals(other);

    public bool Equals(VkDevice other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
