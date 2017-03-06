using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1DPR
{
    interface ISeek
    {
        int seek(List<int> seekIn, List<int> queue, int position);
    }
}
