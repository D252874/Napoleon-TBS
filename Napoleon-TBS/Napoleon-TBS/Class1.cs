using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napoleon_TBS
{
    class Class1
    {
        private int Range;

        public Class1()
        {
            this.Range = 500;
        }
        public void CheckRange()
        {
            
        }
        public void SetRange(int range)
        {
            this.Range= this.Range - range;
        }

    }
}
