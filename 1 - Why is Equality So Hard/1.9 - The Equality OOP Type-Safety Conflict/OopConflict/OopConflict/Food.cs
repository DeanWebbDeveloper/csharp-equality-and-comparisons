using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConflict
{
    public class Food : IEquatable<Food>
    {
        public virtual bool Equals(Food other)
        {
            throw new NotImplementedException();
        }
    }

    public class CookedFood : Food, IEquatable<CookedFood>
    {
        public virtual bool Equals(CookedFood other)
        {
            throw new NotImplementedException();
        }
    }
}
