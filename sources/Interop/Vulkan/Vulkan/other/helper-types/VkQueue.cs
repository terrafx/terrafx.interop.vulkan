// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkQueue : IComparable, IComparable<VkQueue>, IEquatable<VkQueue>, IFormattable
{
    public readonly void* Value;

    public VkQueue(void* value)
    {
        Value = value;
    }

    public static VkQueue NULL => new VkQueue(null);

    public static bool operator ==(VkQueue left, VkQueue right) => left.Value == right.Value;

    public static bool operator !=(VkQueue left, VkQueue right) => left.Value != right.Value;

    public static bool operator <(VkQueue left, VkQueue right) => left.Value < right.Value;

    public static bool operator <=(VkQueue left, VkQueue right) => left.Value <= right.Value;

    public static bool operator >(VkQueue left, VkQueue right) => left.Value > right.Value;

    public static bool operator >=(VkQueue left, VkQueue right) => left.Value >= right.Value;

    public static explicit operator VkQueue(void* value) => new VkQueue(value);

    public static implicit operator void*(VkQueue value) => value.Value;

    public static explicit operator VkQueue(byte value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator byte(VkQueue value) => (byte)(value.Value);

    public static explicit operator VkQueue(short value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator short(VkQueue value) => (short)(value.Value);

    public static explicit operator VkQueue(int value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator int(VkQueue value) => (int)(value.Value);

    public static explicit operator VkQueue(long value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator long(VkQueue value) => (long)(value.Value);

    public static explicit operator VkQueue(nint value) => new VkQueue(unchecked((void*)(value)));

    public static implicit operator nint(VkQueue value) => (nint)(value.Value);

    public static explicit operator VkQueue(sbyte value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator sbyte(VkQueue value) => (sbyte)(value.Value);

    public static explicit operator VkQueue(ushort value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator ushort(VkQueue value) => (ushort)(value.Value);

    public static explicit operator VkQueue(uint value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator uint(VkQueue value) => (uint)(value.Value);

    public static explicit operator VkQueue(ulong value) => new VkQueue(unchecked((void*)(value)));

    public static explicit operator ulong(VkQueue value) => (ulong)(value.Value);

    public static explicit operator VkQueue(nuint value) => new VkQueue(unchecked((void*)(value)));

    public static implicit operator nuint(VkQueue value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkQueue other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkQueue.");
    }

    public int CompareTo(VkQueue other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkQueue other) && Equals(other);

    public bool Equals(VkQueue other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
