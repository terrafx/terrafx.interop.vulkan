// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly unsafe partial struct VkExternalComputeQueueNV : IComparable, IComparable<VkExternalComputeQueueNV>, IEquatable<VkExternalComputeQueueNV>, IFormattable
{
    public readonly void* Value;

    public VkExternalComputeQueueNV(void* value)
    {
        Value = value;
    }

    public static VkExternalComputeQueueNV NULL => new VkExternalComputeQueueNV(null);

    public static bool operator ==(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value == right.Value;

    public static bool operator !=(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value != right.Value;

    public static bool operator <(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value < right.Value;

    public static bool operator <=(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value <= right.Value;

    public static bool operator >(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value > right.Value;

    public static bool operator >=(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Value >= right.Value;

    public static explicit operator VkExternalComputeQueueNV(void* value) => new VkExternalComputeQueueNV(value);

    public static implicit operator void*(VkExternalComputeQueueNV value) => value.Value;

    public static explicit operator VkExternalComputeQueueNV(byte value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator byte(VkExternalComputeQueueNV value) => (byte)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(short value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator short(VkExternalComputeQueueNV value) => (short)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(int value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator int(VkExternalComputeQueueNV value) => (int)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(long value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator long(VkExternalComputeQueueNV value) => (long)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(nint value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static implicit operator nint(VkExternalComputeQueueNV value) => (nint)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(sbyte value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator sbyte(VkExternalComputeQueueNV value) => (sbyte)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(ushort value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator ushort(VkExternalComputeQueueNV value) => (ushort)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(uint value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator uint(VkExternalComputeQueueNV value) => (uint)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(ulong value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static explicit operator ulong(VkExternalComputeQueueNV value) => (ulong)(value.Value);

    public static explicit operator VkExternalComputeQueueNV(nuint value) => new VkExternalComputeQueueNV(unchecked((void*)(value)));

    public static implicit operator nuint(VkExternalComputeQueueNV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkExternalComputeQueueNV other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkExternalComputeQueueNV.");
    }

    public int CompareTo(VkExternalComputeQueueNV other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is VkExternalComputeQueueNV other) && Equals(other);

    public bool Equals(VkExternalComputeQueueNV other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
