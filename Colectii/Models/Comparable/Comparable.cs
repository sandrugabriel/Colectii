using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Models.Comparable
{
    public class Comparable<T>
    {

        public virtual int CompareByName(T y) {
            return -1;
        }

        public virtual int CompareByAge(T y) { return 0;}

    }
}
