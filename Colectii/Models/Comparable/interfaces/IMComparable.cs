using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Models.Comparable.interfaces
{
    public interface IMComparable<T> where T : User
    {

        int ComparableAgeTo<T>(T value);

        int ComparableNameTo<T>(T value);

    }
}
