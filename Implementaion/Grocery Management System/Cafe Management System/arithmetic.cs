using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class arithmetic
    {
        public int first;
        public int second;

        public arithmetic(int f, int s)
        {
            first = f;
            second = s;

        }

        public int add()
        {
            return first + second;
        }

        public int sub()
        {
            return first - second;
        }

        public int multi()
        {
            return first * second;
        }

        public int div()
        {
            return first / second;
        }

    }
}
