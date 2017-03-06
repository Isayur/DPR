using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1DPR
{
    class Elevator : ISeek
    {
        public int seek(List<int> seekIn, List<int> queue, int position)
        {
            int travel = 0;
            if (position > seekIn.Count / 2)                                //Using the default values, this returns 149 because it runs the else case (position == seekIn.Count/2), while running the if case returns 147; Additional logic to check the min/max values in the queue compared to the overall list can be added
            {
                for (int i = position; i < seekIn.Count; i++)
                {
                    if (queue.Contains(seekIn[i])) { queue.Remove(seekIn[i]); }
                    if (i > position) { travel++; }
                }
                for(int i = seekIn.Count-1; i >= 0; i--)
                {
                    if (queue.Contains(seekIn[i])) { queue.Remove(seekIn[i]); }
                    if (i < seekIn.Count - 1) { travel++; }
                    if (queue.Count == 0) { break; }
                }
            }
            else
            {
                for (int i = position; i >= 0; i--)
                {
                    if (queue.Contains(seekIn[i])) { queue.Remove(seekIn[i]); }
                    if (i < position) { travel++; }
                }
                for(int i = 0; i < seekIn.Count; i++)
                {
                    if (queue.Contains(seekIn[i])) { queue.Remove(seekIn[i]); }
                    if (i > 0) { travel++; }
                    if (queue.Count == 0) { break; }
                }
            }
            return travel;
        }
    }
}