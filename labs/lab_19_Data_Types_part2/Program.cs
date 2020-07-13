using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace lab_19_Data_Types_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var tps = TimeSpan.TicksPerSecond;
            var nowInTicks = DateTime.Now.Ticks;

            Console.WriteLine(tps);
            Console.WriteLine(nowInTicks);
            */

            /*
            //New DateTime object mapped to middnight, 1 Jan 0001
            var d = new DateTime();
            var d1 = DateTime.Today;
            //Now
            var d2 = DateTime.Now;

            var d3 = new DateTime(2020, 7, 13, 11, 5, 18);

            //add one day
            d= d.AddDays(1);
            //add month
            d = d.AddMonths(1);
            */

            //Working out age in years
            //  var nishBday = new DateTime(1989, 11, 02);
            /*
            var age = (int)((DateTime.Now - nishBday).Days/365.25);
        
            Console.WriteLine(age);
            */

            /*
            //Different Formats
            var date = DateTime.Now.ToString("dd-MM-yyyy");
            var date2 = nishBday.ToString("yy/MMM/dd");   //MM - Number eg 10, MMM- short hand eg Oct, MMMM , full eg October
            Console.WriteLine(date);
            Console.WriteLine(date2);
            */

            /*
            //Timespan object
            var timespan = new TimeSpan(1, 0, 0);
            //add this right now
            var date = DateTime.Now + timespan;
            //add one tick
            var tick = new TimeSpan(1);
            date += tick;
            */


            #region Random Card
            
            var rand = new Random();
            Suit theSuit = Suit.HEARTS;
       
            for (int i = 0; i < 10; i++)
            {
                int suitNum = rand.Next(1, 5);
                int cardNum = rand.Next(1, 14);

                switch (suitNum)
                {
                    case (1):
                        theSuit = Suit.HEARTS;
                        break;
                    case (2):
                        theSuit = Suit.CLUBS;
                        break;
                    case (3):
                        theSuit = Suit.DIAMONDS;
                        break;
                    case (4):
                        theSuit = Suit.SPADES;
                        break;
                }


                switch (theSuit)
                {
                    case (Suit.HEARTS):
                        Console.WriteLine(cardNum + " of Hearts");
                        break;
                    case (Suit.CLUBS):
                        Console.WriteLine(cardNum + " of Clubs");
                        break;
                    case (Suit.DIAMONDS):
                        Console.WriteLine(cardNum + " of Diamonds");
                        break;
                    case (Suit.SPADES):
                        Console.WriteLine(cardNum + " of Spades");
                        break;
                }            
            }
            
            #endregion

     
        }

        public enum Suit
        {
            HEARTS,
            CLUBS,
            DIAMONDS,
            SPADES
        }
    }
}
