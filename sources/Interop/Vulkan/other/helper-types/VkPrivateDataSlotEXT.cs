// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct VkPrivateDataSlotEXT : IComparable, IComparable<VkPrivateDataSlotEXT>, IEquatable<VkPrivateDataSlotEXT>, IFormattable
    {
        public readonly ulong Value;

        public VkPrivateDataSlotEXT(ulong value)
        {
            Value = value;
        }

        public static VkPrivateDataSlotEXT NULL => new VkPrivateDataSlotEXT(0);

        public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value == right.Value;

        public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value != right.Value;

        public static bool operator <(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value < right.Value;

        public static bool operator <=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value <= right.Value;

        public static bool operator >(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value > right.Value;

        public static bool operator >=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Value >= right.Value;

        public static implicit operator VkPrivateDataSlotEXT(byte value) => new VkPrivateDataSlotEXT(value);

        public static explicit operator byte(VkPrivateDataSlotEXT value) => (byte)(value.Value);

        public static explicit operator VkPrivateDataSlotEXT(short value) => new VkPrivateDataSlotEXT((ulong)(value));

        public static explicit operator short(VkPrivateDataSlotEXT value) => (short)(value.Value);

        public static explicit operator VkPrivateDataSlotEXT(int value) => new VkPrivateDataSlotEXT((ulong)(value));

        public static explicit operator int(VkPrivateDataSlotEXT value) => (int)(value.Value);

        public static explicit operator VkPrivateDataSlotEXT(long value) => new VkPrivateDataSlotEXT((ulong)(value));

        public static explicit operator long(VkPrivateDataSlotEXT value) => (long)(value.Value);

        public static explicit operator VkPrivateDataSlotEXT(nint value) => new VkPrivateDataSlotEXT((ulong)(value));

        public static explicit operator nint(VkPrivateDataSlotEXT value) => (nint)(value.Value);

        public static explicit operator VkPrivateDataSlotEXT(sbyte value) => new VkPrivateDataSlotEXT((ulong)(value));

        public static explicit operator sbyte(VkPrivateDataSlotEXT value) => (sbyte)(value.Value);

        public static implicit operator VkPrivateDataSlotEXT(ushort value) => new VkPrivateDataSlotEXT(value);

        public static explicit operator ushort(VkPrivateDataSlotEXT value) => (ushort)(value.Value);

        public static implicit operator VkPrivateDataSlotEXT(uint value) => new VkPrivateDataSlotEXT(value);

        public static explicit operator uint(VkPrivateDataSlotEXT value) => (uint)(value.Value);

        public static implicit operator VkPrivateDataSlotEXT(ulong value) => new VkPrivateDataSlotEXT(value);

        public static implicit operator ulong(VkPrivateDataSlotEXT value) => value.Value;

        public static implicit operator VkPrivateDataSlotEXT(nuint value) => new VkPrivateDataSlotEXT(value);

        public static explicit operator nuint(VkPrivateDataSlotEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is VkPrivateDataSlotEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of VkPrivateDataSlotEXT.");
        }

        public int CompareTo(VkPrivateDataSlotEXT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is VkPrivateDataSlotEXT other) && Equals(other);

        public bool Equals(VkPrivateDataSlotEXT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
