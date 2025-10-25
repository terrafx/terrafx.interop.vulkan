// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkPhysicalDevice : IComparable, IComparable<VkPhysicalDevice>, IEquatable<VkPhysicalDevice>, IFormattable
{
    public readonly void* Value;

    public VkPhysicalDevice(void* value)
    {
        Value = value;
    }

    public static VkPhysicalDevice NULL => new VkPhysicalDevice(null);

    public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value == right.Value;

    public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value != right.Value;

    public static bool operator <(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value < right.Value;

    public static bool operator <=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value <= right.Value;

    public static bool operator >(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value > right.Value;

    public static bool operator >=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Value >= right.Value;

    public static explicit operator VkPhysicalDevice(void* value) => new VkPhysicalDevice(value);

    public static implicit operator void*(VkPhysicalDevice value) => value.Value;

    public static explicit operator VkPhysicalDevice(byte value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator byte(VkPhysicalDevice value) => (byte)(value.Value);

    public static explicit operator VkPhysicalDevice(short value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator short(VkPhysicalDevice value) => (short)(value.Value);

    public static explicit operator VkPhysicalDevice(int value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator int(VkPhysicalDevice value) => (int)(value.Value);

    public static explicit operator VkPhysicalDevice(long value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator long(VkPhysicalDevice value) => (long)(value.Value);

    public static explicit operator VkPhysicalDevice(nint value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static implicit operator nint(VkPhysicalDevice value) => (nint)(value.Value);

    public static explicit operator VkPhysicalDevice(sbyte value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator sbyte(VkPhysicalDevice value) => (sbyte)(value.Value);

    public static explicit operator VkPhysicalDevice(ushort value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator ushort(VkPhysicalDevice value) => (ushort)(value.Value);

    public static explicit operator VkPhysicalDevice(uint value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator uint(VkPhysicalDevice value) => (uint)(value.Value);

    public static explicit operator VkPhysicalDevice(ulong value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static explicit operator ulong(VkPhysicalDevice value) => (ulong)(value.Value);

    public static explicit operator VkPhysicalDevice(nuint value) => new VkPhysicalDevice(unchecked((void*)(value)));

    public static implicit operator nuint(VkPhysicalDevice value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkPhysicalDevice other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPhysicalDevice.");
    }

    public int CompareTo(VkPhysicalDevice other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkPhysicalDevice other) && Equals(other);

    public bool Equals(VkPhysicalDevice other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
