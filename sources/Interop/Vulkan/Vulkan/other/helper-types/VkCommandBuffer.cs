// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkCommandBuffer : IComparable, IComparable<VkCommandBuffer>, IEquatable<VkCommandBuffer>, IFormattable
{
    public readonly void* Value;

    public VkCommandBuffer(void* value)
    {
        Value = value;
    }

    public static VkCommandBuffer NULL => new VkCommandBuffer(null);

    public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) => left.Value == right.Value;

    public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) => left.Value != right.Value;

    public static bool operator <(VkCommandBuffer left, VkCommandBuffer right) => left.Value < right.Value;

    public static bool operator <=(VkCommandBuffer left, VkCommandBuffer right) => left.Value <= right.Value;

    public static bool operator >(VkCommandBuffer left, VkCommandBuffer right) => left.Value > right.Value;

    public static bool operator >=(VkCommandBuffer left, VkCommandBuffer right) => left.Value >= right.Value;

    public static explicit operator VkCommandBuffer(void* value) => new VkCommandBuffer(value);

    public static implicit operator void*(VkCommandBuffer value) => value.Value;

    public static explicit operator VkCommandBuffer(byte value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator byte(VkCommandBuffer value) => (byte)(value.Value);

    public static explicit operator VkCommandBuffer(short value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator short(VkCommandBuffer value) => (short)(value.Value);

    public static explicit operator VkCommandBuffer(int value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator int(VkCommandBuffer value) => (int)(value.Value);

    public static explicit operator VkCommandBuffer(long value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator long(VkCommandBuffer value) => (long)(value.Value);

    public static explicit operator VkCommandBuffer(nint value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static implicit operator nint(VkCommandBuffer value) => (nint)(value.Value);

    public static explicit operator VkCommandBuffer(sbyte value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator sbyte(VkCommandBuffer value) => (sbyte)(value.Value);

    public static explicit operator VkCommandBuffer(ushort value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator ushort(VkCommandBuffer value) => (ushort)(value.Value);

    public static explicit operator VkCommandBuffer(uint value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator uint(VkCommandBuffer value) => (uint)(value.Value);

    public static explicit operator VkCommandBuffer(ulong value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static explicit operator ulong(VkCommandBuffer value) => (ulong)(value.Value);

    public static explicit operator VkCommandBuffer(nuint value) => new VkCommandBuffer(unchecked((void*)(value)));

    public static implicit operator nuint(VkCommandBuffer value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkCommandBuffer other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkCommandBuffer.");
    }

    public int CompareTo(VkCommandBuffer other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkCommandBuffer other) && Equals(other);

    public bool Equals(VkCommandBuffer other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
