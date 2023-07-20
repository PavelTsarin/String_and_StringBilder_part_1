using System.Text; 

namespace String_and_StringBilder_part_1
{
    internal class Program
    {
        static void jobNumberOne()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите символ X после которого будет производится вставка: ");
            char xChar = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ Y который будет вставляться в строку: ");
            char yChar = char.Parse(Console.ReadLine());
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == xChar)
                {
                    originalString.Insert(i+1, yChar);
                    i++;
                }
            }
            Console.WriteLine(originalString.ToString());            
        }

        static void jobNumberTwo()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine()); 
            for (int i = 1; i < originalString.Length; i+=2)
            {
                char temporarySymbol = originalString[i];
                originalString[i] = originalString[i - 1];
                originalString[i-1] = temporarySymbol;
            }
            Console.WriteLine(originalString.ToString());
        }

        static void jobNumberThree()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            Console.WriteLine("Введите символ X: ");
            char xChar = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ Y: ");
            char yChar = char.Parse(Console.ReadLine());
            int xCount=0, yCount=0;
            for(int i = 0; i<originalString.Length; i++)
            {
                if (originalString[i] == xChar) { xCount++; }   
                if (originalString[i] == yChar) { yCount++; }
            }
            if (xCount > yCount )
            { Console.WriteLine($"Символов X={xCount} больше чем символов Y={yCount}:"); }
            else if(yCount > xCount ) { Console.WriteLine($"Символов Y={yCount} больше чем символов X={xCount}:");}
            else { Console.WriteLine("Равное колличество:");}
        }

        static void jobNumberFour()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            Console.WriteLine("Введите символ X: ");
            char xChar = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ Y: ");
            char yChar = char.Parse(Console.ReadLine());
            int Count = 0;
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == xChar) { Count++; }
                if (originalString[i] == yChar) { Count++; }
            }
            Console.WriteLine($"Общее колво вхождение символов X и Y = {Count}:");
        }

        static void jobNumberFive()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            int Count = 0;
            for(int i = 0; i<originalString.Length; i++)
            {
                if (Char.IsLetter(originalString[i])) { Count++; }
            }
            Console.WriteLine($"Общее колво буквенных символов = {Count}:");
        }
        
        static bool jobNumberSix()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            for (int i = 0; i < originalString.Length-1; i++)
            {
                if (originalString[i]== originalString[i+1]) return true;
            }
            return false;
        }

        static void jobNumberSeven()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            if (originalString.Length % 2 == 0) { originalString.Remove(originalString.Length / 2, 2); }
            else originalString.Remove(originalString.Length / 2, 1);
            Console.WriteLine(originalString.ToString());
        }

        static void jobNumberEight()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите символ X после которого будет производится вставка: ");
            char xChar = char.Parse(Console.ReadLine());            
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == xChar)
                {
                    originalString.Insert(i + 1, xChar);
                    i++;
                }
            }
            Console.WriteLine(originalString.ToString());
        }

        static void jobNumberNine()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите символ X который будет удалятся: ");
            char xChar = char.Parse(Console.ReadLine());
            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == xChar)
                {
                    originalString.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(originalString.ToString());
        }

        static void jobNumberTen()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите подстроку substr которая будет удалена: ");
            string substr = Console.ReadLine();
            if (originalString.Length > substr.Length)
            {
                int i = 0;
                while(i<originalString.Length)
                {
                    int j = 0;
                    while (j < substr.Length)
                    {
                        if (originalString[i+j] == substr[j])
                        {
                            j++;
                            if(j == substr.Length)
                            {
                                originalString.Remove(i, j);
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                i++;
                            }
                            else
                            {
                                i += j;
                            }
                            break;
                        }
                    }
                }
            }
            else if(originalString.ToString()==substr)
            {
                originalString.Clear();
            }
            Console.WriteLine(originalString.ToString());            
        }        

        static void jobNumberEleven()
        {
            Console.WriteLine("Введите исходную строку str:");
            StringBuilder originalString = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите подстроку substr1 которая будет заменена: ");
            string substr1 = Console.ReadLine();
            Console.WriteLine("Введите подстроку substr1 которая будет заменена: ");
            string substr2 = Console.ReadLine();
            if (originalString.Length > substr1.Length)
            {
                int i = 0;
                while (i < originalString.Length)
                {
                    int j = 0;
                    while (j < substr1.Length)
                    {
                        if (originalString[i + j] == substr1[j])
                        {
                            j++;
                            if (j == substr1.Length)
                            {
                                originalString.Remove(i, j);
                                originalString.Insert(i, substr2);
                                i += substr2.Length;
                            }
                        }                        
                        else
                        {
                            if(j==0)
                            {
                                i++;
                            }
                            else
                            {
                                i += j;
                            }                            
                            break;
                        }
                    }
                }
            }
            else if (originalString.ToString() == substr1)
            {
                originalString.Clear();
                originalString.Append(substr2);
            }
            Console.WriteLine(originalString.ToString());
        }

        static void jobNumberTwelve()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            int Summa = 0;
            for (int i = 0; i < originalString.Length; i++)
            {
                if (Char.IsDigit(originalString[i])) { Summa+= (int)Char.GetNumericValue(originalString[i]); }
            }
            Console.WriteLine($"Сумма циферных символов = {Summa}:");
        }

        static void jobNumberThirteen()
        {
            Console.WriteLine("Введите исходную строку str:");
            string originalString = Console.ReadLine();
            int Count = 0;
            for (int i = 0; i < originalString.Length; i++)
            {
                if (Char.IsDigit(originalString[i])) { Count++; }
            }
            Console.WriteLine($"Общее кол-во циферных символов = {Count}:");
        }

        static void jobNumberFourteen()
        {

        }

        static void jobNumberFifteen()
        {

        }

        static void jobNumberSixteen()
        {

        }
        static void jobNumberSeventeen()
        {

        }
        static void jobNumberEighteen()
        {

        }
        static void jobNumberNineteen()
        {

        }
        static void jobNumberTwenty()
        {

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер задания: ");
                int jobNumber = int.Parse(Console.ReadLine());
                switch (jobNumber)
                {
                    case 1:
                        jobNumberOne();
                        break;
                    case 2:
                        jobNumberTwo();
                        break;
                    case 3:
                        jobNumberThree();
                        break;
                    case 4:
                        jobNumberFour();
                        break;
                    case 5:
                        jobNumberFive();
                        break;
                    case 6:
                        Console.WriteLine(jobNumberSix());
                        break;
                    case 7:
                        jobNumberSeven();
                        break;
                    case 8:
                        jobNumberEight();
                        break;
                    case 9:
                        jobNumberNine();
                        break;
                    case 10:
                        jobNumberTen();
                        break;
                    case 11:
                        jobNumberEleven();
                        break;
                    case 12:
                        jobNumberTwelve();
                        break;
                    case 13:
                        jobNumberThirteen();
                        break;
                    case 14:
                        jobNumberFourteen();
                        break;
                    case 15:
                        jobNumberFifteen();
                        break;
                    case 16:
                        jobNumberSixteen();
                        break;
                    case 17:
                        jobNumberSeventeen();
                        break;
                    case 18:
                        jobNumberEighteen();
                        break;
                    case 19:
                        jobNumberNineteen();
                        break;
                    case 20:
                        jobNumberTwenty();
                        break;
                    
                }
            }            
            
        }
    }
}