using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    class MyOPZ
    {
        public MyOPZ()
        {
        }

        public string ToOPZ (string Sours_String)
        {
            string rez_string;
            return rez_string;
        }

        public double Calc (string OPZ_String)
        {
            double rez_OPZ;
            return rez_OPZ;
        }

        private int Priority (string Sours_String)
        {
            for (int i = 0; i < Sours_String.Length; i++)
            {
                if (Sours_String[i] == '(')
                {
                    return 0;
                    continue;
                }
                if (Sours_String[i] == ')')
                {
                    return 1;
                    continue;
                }
                if (Sours_String[i] == '+')
                {
                    return 2;
                    continue;
                }
                if (Sours_String[i] == '-')
                {
                    return 2;
                    continue;
                }
                if (Sours_String[i] == '*')
                {
                    return 3;
                    continue;
                }
                if (Sours_String[i] == '/')
                {
                    return 3;
                    continue;
                }
                if (Sours_String[i] == '^')
                {
                    return 4;
                    continue;
                }
            }
            return -1;
        }
    }
}
