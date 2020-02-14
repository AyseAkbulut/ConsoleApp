using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    public class Program
    {
        public static int[] OrderList(int[] sayi)
        {
            int gecici;

            for (int i = sayi.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (sayi[j - 1] > sayi[j])
                    {
                        gecici = sayi[j - 1];
                        sayi[j - 1] = sayi[j];
                        sayi[j] = gecici;
                    }
                }
            }

            return sayi;
        }

        public static int[] BiggestSmallest(int[] sayi)
        {

            int big = 0, small = 0;
            int eb = sayi[0];

            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] > eb) big = sayi[i];
                else if (small < eb) small = sayi[i];
            }

            int[] dizi = new int[2];
            dizi[0] = big;
            dizi[1] = small;

            return dizi;
        }

        public static int[] DoubleNumbers(int[] array)
        {
            int[] singleArray = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    singleArray[i] = array[i];
                   
                }
            }
            return singleArray;
        }

        public static int[] SingleNumbers(int[] array)
        {
            int[] singleArray = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    singleArray[i] = array[i];
                    Console.WriteLine(singleArray[i]);
                }
            }
            return singleArray;
        }

        static void Main(string[] args)
        {
            int[] array = new int[100];
            int[] dizi = new int[100];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
            }

            dizi = OrderList(array);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            dizi = BiggestSmallest(array);
            Console.WriteLine("Dizi de ki en büyük ve en küçük sayılar");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(dizi[i]);

            }

            Console.WriteLine("Dizi de ki tek sayılar");
            dizi = SingleNumbers(array);

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            Console.WriteLine("Dizi de ki çift sayılar");

             dizi = DoubleNumbers(array);

            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i]!=0) Console.WriteLine(dizi[i]);

            }

            Console.ReadLine();
        }
    }
}
