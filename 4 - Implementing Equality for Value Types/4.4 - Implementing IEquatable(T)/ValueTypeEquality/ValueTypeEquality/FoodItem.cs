﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquality
{
    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }

    public struct FoodItem : IEquatable<FoodItem>
    {


        #region IEquatable<FoodItem> Members

        public bool Equals(FoodItem other)
        {
            return this._name == other.Name && this._group == other._group;
        }

        #endregion

        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }

        public FoodGroup Group { get { return _group; } }

        public FoodItem(string name, FoodGroup group)
        {
            this._name = name;
            this._group = group;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
