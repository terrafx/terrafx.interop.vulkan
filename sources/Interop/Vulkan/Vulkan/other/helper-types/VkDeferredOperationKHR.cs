// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Vulkan;

public readonly partial struct VkDeferredOperationKHR : IComparable, IComparable<VkDeferredOperationKHR>, IEquatable<VkDeferredOperationKHR>, IFormattable
{
    public readonly ulong Value;

    public VkDeferredOperationKHR(ulong value)
    {
        Value = value;
    }

    public static VkDeferredOperationKHR NULL => new VkDeferredOperationKHR(0);

    public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value == right.Value;

    public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value != right.Value;

    public static bool operator <(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value < right.Value;

    public static bool operator <=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value <= right.Value;

    public static bool operator >(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value > right.Value;

    public static bool operator >=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Value >= right.Value;

    public static implicit operator VkDeferredOperationKHR(byte value) => new VkDeferredOperationKHR(value);

    public static explicit operator byte(VkDeferredOperationKHR value) => (byte)(value.Value);

    public static explicit operator VkDeferredOperationKHR(short value) => new VkDeferredOperationKHR(unchecked((ulong)(value)));

    public static explicit operator short(VkDeferredOperationKHR value) => (short)(value.Value);

    public static explicit operator VkDeferredOperationKHR(int value) => new VkDeferredOperationKHR(unchecked((ulong)(value)));

    public static explicit operator int(VkDeferredOperationKHR value) => (int)(value.Value);

    public static explicit operator VkDeferredOperationKHR(long value) => new VkDeferredOperationKHR(unchecked((ulong)(value)));

    public static explicit operator long(VkDeferredOperationKHR value) => (long)(value.Value);

    public static explicit operator VkDeferredOperationKHR(nint value) => new VkDeferredOperationKHR(unchecked((ulong)(value)));

    public static explicit operator nint(VkDeferredOperationKHR value) => (nint)(value.Value);

    public static explicit operator VkDeferredOperationKHR(sbyte value) => new VkDeferredOperationKHR(unchecked((ulong)(value)));

    public static explicit operator sbyte(VkDeferredOperationKHR value) => (sbyte)(value.Value);

    public static implicit operator VkDeferredOperationKHR(ushort value) => new VkDeferredOperationKHR(value);

    public static explicit operator ushort(VkDeferredOperationKHR value) => (ushort)(value.Value);

    public static implicit operator VkDeferredOperationKHR(uint value) => new VkDeferredOperationKHR(value);

    public static explicit operator uint(VkDeferredOperationKHR value) => (uint)(value.Value);

    public static implicit operator VkDeferredOperationKHR(ulong value) => new VkDeferredOperationKHR(value);

    public static implicit operator ulong(VkDeferredOperationKHR value) => value.Value;

    public static implicit operator VkDeferredOperationKHR(nuint value) => new VkDeferredOperationKHR(value);

    public static explicit operator nuint(VkDeferredOperationKHR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is VkDeferredOperationKHR other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkDeferredOperationKHR.");
    }

    public int CompareTo(VkDeferredOperationKHR other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is VkDeferredOperationKHR other) && Equals(other);

    public bool Equals(VkDeferredOperationKHR other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
