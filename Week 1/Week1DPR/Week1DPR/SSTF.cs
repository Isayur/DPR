using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1DPR
{
    class SSTF : ISeek
    {
        public int seek(List<int> seekIn, List<int> queue, int position)
        {
            int current = position;
            seekIn.Clear();
            while (Compute(seekIn, queue, ref current)) ;
            return seekIn.Sum();
        }

        private static bool Compute(List<int> seekIn, List<int> queue, ref int position)
        {
            int i = position;
            var item = queue.Select(q => new
            {
                number = q,
                distanse = Math.Abs(q - i)
            }).OrderBy(q => q.distanse).FirstOrDefault();
            if (item == null)
            {
                return false;
            }
            queue.Remove(item.number);
            seekIn.Add(item.distanse);
            position = item.number;
            return true;
        }
    }
}
