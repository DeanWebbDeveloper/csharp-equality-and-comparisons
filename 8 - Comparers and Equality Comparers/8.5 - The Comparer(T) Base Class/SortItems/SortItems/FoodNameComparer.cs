using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortItems
{
    class FoodNameComparer : Comparer<Food>
    {
        #region IComparer<Food> Members

        public override int Compare(Food x, Food y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }

        #endregion
    }
}

