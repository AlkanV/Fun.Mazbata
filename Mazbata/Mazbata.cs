using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazbata
{
    class Mazbata
    {
        static void Main(string[] args)
        {
            const int REMAINING_DAY = 1822;
            const int UNTIL_DAY = 1825;

            const string INTRO = "1, 2,3 gün geçti, IBB Başkanı Ekrem Imamoglu'na hala mabatasını vermediler, ";

            int rowNum = 1;

            bool isOk = false;

            string article = INTRO;
            
            TypeWrite(INTRO, 7, 0);

            System.Threading.Thread.Sleep(1000);

            for (int dayCount = 4; dayCount <= UNTIL_DAY; dayCount++)
            {
                if (dayCount < UNTIL_DAY)
                {
                    if (dayCount % 4 == 0)
                    {
                        Console.Write("\r\n");
                        isOk = true;
                        rowNum++;
                    }
                    if (isOk)
                        Console.Write(dayCount.ToString() + ", ");
                    else
                        Console.Write(dayCount.ToString());

                    article = article + dayCount.ToString() + ", ";
                }
                else
                {
                    Console.WriteLine("şunun şurasında kala kala " + dayCount.ToString() + " gün kaldı...");
                }
            }
           string LAST_WORDS = "Alt tarafı " + REMAINING_DAY + " güncük daha geciktirmeyi başarırsanız, \r\nIBB Başkanı Ekrem Imamoğlu " +
                          " mazbatasını almadan, \r\nöbür seçim gelmiş olur.";
           const string IMPACT = "\r\nAğlayacaksanız oynamayalım. :)";

            TypeWrite(LAST_WORDS, 15, 1000);
            TypeWrite(IMPACT, 50, 1000);

            Console.ReadLine();

        }


        static void TypeWrite(string message, int sleepTime, int waitTime)
        {
            System.Threading.Thread.Sleep(waitTime);
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(sleepTime);
            }

        }
    }
}
