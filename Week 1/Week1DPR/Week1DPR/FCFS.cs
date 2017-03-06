using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1DPR
{
    class FCFS : ISeek
    {
        public int seek(List<int> seekIn, List<int> queue, int position)
        {
            int travel = 0;
            foreach (int item in queue)
            {
                while(seekIn[position] > item)
                {
                    position--;
                    travel++;
                }
                while(seekIn[position] < item)
                {
                    position++;
                    travel++;
                }
            }
            return travel;
        }
    }
}
