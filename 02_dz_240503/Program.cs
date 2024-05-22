using System.Text;

namespace HomeTasks_02_dz_240503
{
    internal class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            Console.WriteLine("Enter Task Number: ");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1: HomeTask1(); break;
                case 2: HomeTask2(); break;
                case 3: HomeTask3(); break;
                case 4: HomeTask4(); break;
                case 5: HomeTask5(); break;
                case 6: HomeTask6(); break;
                case 7: HomeTask7(); break;
            }

            // HomeTask1 ============================================================================================
            void HomeTask1()
            {
                float[] a = new float[5];
                float sum_a2 = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = float.Parse(Console.ReadLine());
                    sum_a2 = (i % 2 == 0) ? sum_a2 += a[i] : sum_a2;
                }

                //for (int i = 0; i < a.Length; i++) { Console.Write(Convert.ToString(a[i]) + ' '); }
                for (int i = 0; i < a.Length; i++) { Console.Write(a[i] + " "); }

                Console.WriteLine("\n");
                Random rnd = new Random();
                float max_elmt_b = 0, min_elmt_b = 0, sum_elmt_b = 0, sum_col3 = 0;
                float[,] b = new float[3, 4];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        b[i, j] = rnd.Next();
                        b[i, j] = b[i, j] / rnd.Next();
                        Console.Write(b[i, j] + "\t");
                        sum_elmt_b = sum_elmt_b + b[i, j];
                        if (i == 0 && j == 0) max_elmt_b = min_elmt_b = b[i, j];
                        max_elmt_b = (max_elmt_b >= b[i, j]) ? max_elmt_b : b[i, j];
                        min_elmt_b = (min_elmt_b <= b[i, j]) ? min_elmt_b : b[i, j];
                        sum_col3 = (j % 2 != 0) ? sum_col3 += b[i, j] : sum_col3;
                    }
                    Console.WriteLine("\n");
                }
                float max_elmt_ab, min_elmt_ab, sum_elmt_ab;
                max_elmt_ab = (a.Max() >= max_elmt_b) ? a.Max() : max_elmt_b;
                min_elmt_ab = (a.Min() <= min_elmt_b) ? a.Min() : min_elmt_b;
                Console.WriteLine("Max_element_ab: " + max_elmt_ab + "\t" + "Min_element_ab: " + min_elmt_ab + "\n");
                sum_elmt_ab = a.Sum() + sum_elmt_b;
                Console.WriteLine("Summa_element_ab: " + sum_elmt_ab + "\n");
                Console.WriteLine("Summa_element_a2: " + sum_a2 + "\t" + "Summa_col3_b: " + sum_col3 + "\n");
            }
            // HomeTask2 ============================================================================================
            void HomeTask2()
            {
                Random rnd = new Random();
                int[][] arr = new int[5][];
                for (int i = 0; i < arr.Length; i++) arr[i] = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = rnd.Next(-100, 100);
                        Console.Write(arr[i][j] + "\t");
                    }
                    Console.WriteLine();
                }

                int min = arr[0].Min(), i_min = 0, j_min = 0;
                j_min = Array.IndexOf(arr[0], min);
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i].Min() < min)
                    {
                        min = arr[i].Min();
                        i_min = i;
                        j_min = Array.IndexOf(arr[i], min);
                    }
                }
                Console.WriteLine("Min element array: " + min);
                Console.WriteLine("Min element array: " + arr[i_min][j_min]);

                int max = arr[0].Max(), i_max = 0, j_max = 0;
                j_max = Array.IndexOf(arr[0], max);
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i].Max() > max)
                    {
                        max = arr[i].Max();
                        i_max = i;
                        j_max = Array.IndexOf(arr[i], max);
                    }
                }
                Console.WriteLine("Max element array: " + max);
                Console.WriteLine("Max element array: " + arr[i_max][j_max]);


                int sum_min_max = 0;
                int i_sum = i_min;
                int j_sum = j_min + 1;
                for (; i_sum <= i_max; i_sum++)
                {
                    if (i_sum == i_min)
                    {
                        for (; j_sum < arr[i_sum].Length; j_sum++) { sum_min_max += arr[i_sum][j_sum]; }
                    }
                    if ((i_min < i_sum) && (i_sum < i_max))
                    {
                        sum_min_max += arr[i_sum].Sum();
                    }
                    if (i_sum == i_max)
                    {
                        for (; j_sum < arr[i_sum].Length; j_sum++) { sum_min_max += arr[i_sum][j_sum]; }
                    }
                }
                Console.WriteLine("Summa beetwin Min and Max element array: " + sum_min_max);
            }
            //HomeTask3 ============================================================================================
            void HomeTask3()
            {
                Console.WriteLine("Input 1 For Encryption Or 2 For Decryption");
                int @int = Console.Read();
                switch (@int)
                {
                    case 1:
                        Console.WriteLine("Input String For Encryption");
                        string str1_in = Console.ReadLine();
                        char[] chrArr1_in = str1_in.ToCharArray();
                        Console.WriteLine("Input Encryption Key");
                        byte e_key1 = byte.Parse(Console.ReadLine());
                        for (int i = 0; i < chrArr1_in.Length; i++)
                        {
                            chrArr1_in[i] = (char)((byte)chrArr1_in[i] + e_key1);
                        }
                        string str1_out = new string(chrArr1_in);
                        Console.WriteLine(str1_out);
                        break;
                    case 2:
                        Console.WriteLine("Input String For Decryption");
                        string str2_in = Console.ReadLine();
                        char[] chrArr2_in = str2_in.ToCharArray();
                        Console.WriteLine("Input Decryption Key");
                        byte e_key2 = byte.Parse(Console.ReadLine());
                        for (int i = 0; i < chrArr2_in.Length; i++)
                        {
                            chrArr2_in[i] = (char)((byte)chrArr2_in[i] - e_key2);
                        }
                        string str2_out = new string(chrArr2_in);
                        Console.WriteLine(str2_out);
                        break;
                }
            }
            //HomeTask4 ============================================================================================
            void HomeTask4()
            {
                Random rnd4 = new Random();
                int[,] matrix_1 = new int[3, 3];
                int[,] matrix_2 = new int[3, 3];
                for (int i=0; i < 3; i++) 
                {
                    for (int j=0; j<3; j++) 
                    {
                        matrix_1[i, j] = rnd4.Next( 10);
                        matrix_2[i, j] = rnd4.Next( 10);
                    }
                }
                Console.WriteLine("Matrix_1" + "\t" + "Matrix_2");
                Console.WriteLine("========" + "\t" + "========");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(matrix_1[i, j] + "  ");
                    }
                    Console.Write("\t");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(matrix_2[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Multiplication Matrix_1 x 2 And Matrix_2 x 3");
                Console.WriteLine("Matrix_1" + "\t" + "Matrix_2");
                Console.WriteLine("========" + "\t" + "========");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(2*matrix_1[i, j] + "  ");
                    }
                    Console.Write("\t");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(3*matrix_2[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Summa Matrix_1 And Matrix_2");
                Console.WriteLine("===========================");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write((matrix_1[i, j] + matrix_2[i, j]) + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Multiplication Matrix_1 And Matrix_2");
                Console.WriteLine("====================================");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write((matrix_1[i, j] * matrix_2[i, j]) + "\t");
                    }
                    Console.WriteLine();
                }

            }
            // HomeTask5 ============================================================================================
            void HomeTask5() 
            {
                Console.WriteLine("Input Arithmetic Expression + Or -");
                string str = Console.ReadLine();
                int digit_1=0, digit_2=0;
                int n = 0;
                for (int i = 0; i < str.Length - 1; i++) 
                {
                    if (char.IsDigit(str[i])) 
                    { }
                    else 
                    { digit_1 = Int32.Parse(str.Substring(0,i)); n = i ; break; }
                }
                for (int i = n; i < str.Length - 1; i++) 
                {
                    if (char.IsDigit(str[i])) 
                    {
                        n = i;
                        break;
                    }
                }
                digit_2 = Int32.Parse(str.Substring(n,(str.Length-n)));
                if (str.Contains("+"))
                    { Console.WriteLine(digit_1 + " + " + digit_2 + " = " + (digit_1 + digit_2)); }
                else
                    { Console.WriteLine(digit_1 + " - " + digit_2 + " = " + (digit_1 - digit_2)); }
            }
            // HomeTask6 ============================================================================================
            void HomeTask6() 
            {
                Console.WriteLine("Input a Text Please");
                StringBuilder str = new StringBuilder(Console.ReadLine());
                for (int i=0; i < str.Length -1; i++) 
                {
                    if (char.IsLower(str[0])) { str[0]=char.ToUpper(str[0]); }
                    if (str[i] == '.') { str[i+1] = char.ToUpper(str[i+1]); }
                }
                Console.WriteLine(str);
            }
            // HomeTask7 ============================================================================================
            void HomeTask7()
            {
                Console.WriteLine("Input a Text Please");
                string str1 = Console.ReadLine();
                Console.WriteLine("Input the Unacceptable Word");
                string str2 = Console.ReadLine();
                string str3 = new string('*', str2.Length);
                int repl = 0;
                str1 = str1.Replace(str2, str3);
                for(int i=0; i<str1.Length; i++) 
                {
                    if (str1[i] == '*') { repl++; i += str3.Length; }
                }
                Console.WriteLine(str1);
                Console.WriteLine("Completed " + repl + " Replacement's");
            }
        }
    }
}
