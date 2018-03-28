using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1Beta
{
    public interface IOtopark 
    {
        void Insert(object a);
        object Remove();
        object Peek();
        Boolean IsEmpty();
    }
}
