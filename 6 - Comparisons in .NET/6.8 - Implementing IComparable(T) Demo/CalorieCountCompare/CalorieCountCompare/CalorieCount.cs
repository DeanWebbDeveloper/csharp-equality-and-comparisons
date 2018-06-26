using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCountCompare
{
    public struct CalorieCount : IComparable<CalorieCount>
    {
        #region IComparable<CalorieCount> Members

        public int CompareTo(CalorieCount other)
        {
            return this._value.CompareTo(other._value);
        }

        #endregion

        private float _value;

        public float Value { get { return _value; } }

        public CalorieCount(float value)
        {
            this._value = value;
        }

        public override string ToString()
        {
            return _value + " cal";
        }

    }
}
