using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityComparerDemo
{
    class FoodItemEqualityComparer : EqualityComparer<FoodItem>
    {
        private static readonly FoodItemEqualityComparer _instance =
            new FoodItemEqualityComparer();

        public static FoodItemEqualityComparer Instance { get { return _instance; } }

        private FoodItemEqualityComparer() { }

        #region IEqualityComparer<FoodItem> Members

        public override bool Equals(FoodItem x, FoodItem y)
        {
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant()
                && x.Group == y.Group;
        }

        public override int GetHashCode(FoodItem obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
