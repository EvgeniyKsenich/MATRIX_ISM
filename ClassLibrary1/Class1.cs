using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Transponovana(int[,] matr)
        {
            try
            {
                int[,] mas = new int[matr.GetLength(1), matr.GetLength(0)];
                for (int n = 0; n < matr.GetLength(1); n++)
                {
                    for (int m = 0; m < matr.GetLength(0); m++)
                    {
                        mas[n, m] = matr[m, n];
                    }
                }

                for (int m = 0; m < mas.GetLength(0); m++)
                {
                    for (int n = 0; n < mas.GetLength(1); n++)
                    {
                        Console.Write(mas[m, n].ToString() + " ");
                    }
                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }




        public void SumStovpNoneMinus(int[,] matr)
        {
            try {
                int z = 0, all = 0;
                for (int n = 0; n < matr.GetLength(1); n++)
                {
                    z = 0;
                    all = 0;
                    for (int m = 0; m < matr.GetLength(0); m++)
                    {
                        if (matr[m, n] < 0) z++;
                    }
                    if (z == 0)
                    {
                        for (int m = 0; m < matr.GetLength(0); m++)
                        {
                            all += matr[m, n];
                        }
                        Console.WriteLine("suma stovpca " + n.ToString() + " " + all.ToString());
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }

        public void SumStovWhereMinus(int[,] matr)
        {
            try {
                int z = 0, all = 0;
                for (int n = 0; n < matr.GetLength(1); n++)
                {
                    z = 0;
                    all = 0;
                    for (int m = 0; m < matr.GetLength(0); m++)
                    {
                        if (matr[m, n] < 0) z++;
                    }
                    if (z > 0)
                    {
                        for (int m = 0; m < matr.GetLength(0); m++)
                        {
                            all += matr[m, n];
                        }
                        Console.WriteLine("suma stovpca " + n.ToString() + " " + all.ToString());
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }


        public void MinSumModulPobDiagon(int[,] matr)
        {
            try {
                int m = -1, n = 0, sum_b = matr[0, 0], sum = matr[0, 0];
                int mm = -1, nn = 0;
                while (true)
                {
                    m = -1;
                    n = nn;
                    sum = 0;
                    while (true)
                    {
                        m++;
                        n++;
                        sum += matr[m, n];
                        if (m == matr.GetLength(0) - 1 || n == matr.GetLength(1) - 1) break;
                    }
                    nn++;
                    if (Math.Sqrt(sum_b) > Math.Sqrt(sum)) sum_b = sum;
                    if (nn == matr.GetLength(0)) break;
                }
                mm = 0;
                while (true)
                {
                    m = mm;
                    n = -1;
                    sum = 0;
                    while (true)
                    {
                        m++;
                        n++;
                        sum += matr[m, n];
                        if (m == matr.GetLength(0) - 1 || n == matr.GetLength(1) - 1) break;
                    }
                    mm++;
                    if (Math.Sqrt(sum_b) > Math.Sqrt(sum)) sum_b = sum;
                    if (mm == matr.GetLength(0) - 1) break;
                }
                Console.WriteLine(sum_b.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }


        public void MaxSumModPobDiag(int[,] matr)
        {
            try {
                int m = -1, n = 0, sum_b = 0, sum = 0;
                int mm = -1, nn = 0;
                while (true)
                {
                    m = -1;
                    n = nn;
                    sum = 0;
                    while (true)
                    {
                        m++;
                        n++;
                        sum += matr[m, n];
                        if (m == matr.GetLength(0) - 1 || n == matr.GetLength(1) - 1) break;
                    }
                    nn++;
                    if (sum_b < sum) sum_b = sum;
                    if (nn == matr.GetLength(0)) break;
                }
                mm = 0;
                while (true)
                {
                    m = mm;
                    n = -1;
                    sum = 0;
                    while (true)
                    {
                        m++;
                        n++;
                        sum += matr[m, n];
                        if (m == matr.GetLength(0) - 1 || n == matr.GetLength(1) - 1) break;
                    }
                    mm++;
                    if (sum_b < sum) sum_b = sum;
                    if (mm == matr.GetLength(0) - 1) break;
                }
                Console.WriteLine(sum_b.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }


        public void DobeLrADNonZero(int[,] matr)
        {
            try {
                int lic = 0, nn = 0, dob = 1;
                for (int m = 0; m < matr.GetLength(0); m++)
                {
                    lic = 0;
                    nn = 0;
                    dob = 1;
                    for (int n = 0; n < matr.GetLength(1); n++)
                    {
                        if (matr[m, n] >= 0) nn++;
                    }
                    if (nn == matr.GetLength(1))
                    {
                        for (int n = 0; n < matr.GetLength(1); n++)
                        {
                            dob *= matr[m, n];
                        }
                        Console.WriteLine("dobutok ryadu " + m.ToString() + " " + dob.ToString());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }


        public int LongestSame(int[,] matr)
        {
            try {
                int same = 0, lic = 0, s = 0, sm = 0;
                for (int m = 0; m < matr.GetLength(0); m++)
                {
                    same = 0;
                    sm = 0;
                    for (int n = 0; n < matr.GetLength(1); n++)
                    {
                        if (n > 0)
                        {
                            if (matr[m, n] == matr[m, n - 1]) sm++;
                            if (matr[m, n] != matr[m, n - 1])
                            {
                                if (same < sm) same = sm;
                            }
                        }
                    }
                    if (same < sm) same = sm;
                    if (s < same)
                    {
                        lic = m;
                        s = same;
                    }
                }
                return lic;
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                return 0;
            }
        }

        public int KilSTPkminOneZeroEl(int[,] matr)
        {
            try { 
            int z = 0, lic = 0;
            for (int n = 0; n < matr.GetLength(1); n++)
            {
                z = 0;
                for (int m = 0; m < matr.GetLength(0); m++)
                {
                    if (matr[m, n] == 0) z++;
                }
                if (z > 0) lic++;
            }
            return lic;
        }
            catch (Exception)
            {
                Console.WriteLine("error");
                return 0;
            }
        }


        public void MaxMoreOnse(int[,] matr)
        {
            try {
                int[] mas = new int[matr.GetLength(0) * matr.GetLength(1)];
                int i = 0, max_el = matr[0, 0], min_el = matr[0, 0];
                for (int m = 0; m < matr.GetLength(0); m++)
                {
                    for (int n = 0; n < matr.GetLength(1); n++)
                    {
                        mas[i] = matr[m, n];
                        i++;
                        if (max_el < matr[m, n]) max_el = matr[m, n];
                        if (min_el > matr[m, n]) min_el = matr[m, n];
                    }
                }
                int lic = 0;
                bool os = true;
                while (os)
                {
                    lic = 0;
                    for (int o = 0; o < mas.Length; o++)
                    {
                        if (max_el == mas[o]) lic++;
                        if (lic >= 2)
                        {
                            Console.WriteLine("max el more 2s = " + max_el.ToString());
                            os = false;
                            break;
                        }
                    }
                    max_el--;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
        }

        public int RydWhithNoneZero(int[,] matr)
        {
            try
            {
                int nonz = 0, lic = 0;
                for (int m = 0; m < matr.GetLength(0); m++)
                {
                    nonz = 0;
                    for (int n = 0; n < matr.GetLength(1); n++)
                    {
                        if (matr[m, n] != 0) nonz++;
                    }
                    if (nonz == matr.GetLength(1)) lic++;
                }
                return lic;
            }
            catch (Exception)
            {
                Console.WriteLine("error");
                return 0;
            }
        }





    }
}
