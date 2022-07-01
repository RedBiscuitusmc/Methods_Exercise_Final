using System;

/*.=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= -.
   /------------------------------ \
  |     By                                     |
  |     Jacob Merlin                   |
   \------------------------------ /
                 !           ! 
                !           !
                !          !
               ! _       !
         /   !__)     !
 __/___/_____)
        (_______)
 ___(______)
      \_(____)
         !       !
         !      !
         \__/
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='*/

namespace Methods
{//todo===============================================================================================================
    public class Methods
    {//?=============================================================================================================
        public static void addSpaces()
        {//~========================================================================================================
            Console.WriteLine("================================================================");
            Console.WriteLine("================================================================");
        }//~========================================================================================================

        public static void PrintGreeting()
        {//~========================================================================================================
         //== varibes == 
         //================
            string str_1;
            //================
            str_1 = "Hello everyone! Welcome to my methods script.";
            //================

            //!Logic ================================================================================================
            Console.WriteLine(str_1);

        }//~========================================================================================================

        public static void Game_Message()
        {//~========================================================================================================
         //== varibes == 
         //================
            string mesg_01;
            string mesg_02;
            string mesg_03;
            string mesg_04;
            string mesg_05;
            string mesg_06;
            string mesg_07;
            string mesg_08;
            //================
            mesg_01 = "Welcome to the Method script.\n";
            mesg_02 = "This will showcase using and defining methods inside of c#.\n";
            mesg_03 = "We are first going to run through a short little story game.\n";
            mesg_04 = "We will explore setting and using logic inside of a method.\n";
            mesg_05 = "Then we are going to go through  exponentiate method.\n";
            mesg_06 = "Then calculates the result of raising the first to the second number.\n";
            mesg_07 = "Last is a method to find out if a number is prime or not.\n";
            mesg_08 = "Thanks for taking the time to checkout my code!.\n";
            //================

            //!Logic ================================================================================================
            string mesg_combo = String.Join(mesg_01 + mesg_02, mesg_03 + mesg_04 + mesg_05 + mesg_06 + mesg_07 + mesg_08);
            Console.WriteLine(mesg_combo);

        }//~========================================================================================================

        public static void Story_Handler()
        {//~========================================================================================================
         //====varibles==
         //================
            string add_Break = " ================================================================ ";
            //================

            Console.WriteLine("What is your name?");
            string call_Name = Console.ReadLine();
            Console.WriteLine(add_Break);
            //================
            Console.WriteLine("What is your favorite color?");
            string call_Color = Console.ReadLine();
            Console.WriteLine(add_Break);
            //================
            Console.WriteLine("What is your favorite animal?");
            string call_Animal = Console.ReadLine();
            Console.WriteLine(add_Break);
            //================
            Console.WriteLine("What is your favorite band?");
            string call_Band = Console.ReadLine();
            Console.WriteLine(add_Break);
            //================
            //!Logic ================================================================================================
            string combo = String.Format($"So you telling me you are a {call_Color}  {call_Animal} ? You go by the name {call_Name} and you play the tuba in  {call_Band}?");
            Console.WriteLine(combo);

        }//~========================================================================================================

        public static void Exponentiate()
        {//~========================================================================================================
         //====varibles==
         //================
            string call_number;
            string call_power;
            int base_Number;
            int power_Number;
            //================
            Console.WriteLine("GIVE ME A NUMBER!");
            call_number = Console.ReadLine();
            base_Number = Convert.ToInt32(call_number);
            //================
            Console.WriteLine("Give me a power!");
            call_power = Console.ReadLine();
            power_Number = Convert.ToInt32(call_power);
            //================
            //!Logic ================================================================================================
            double total = Math.Pow(base_Number, power_Number);
            Console.WriteLine(total);

        }//~========================================================================================================

        public static void prime_Num_Logic()
        {//~========================================================================================================
         //====varibles==
         //================
            string call_prim_str;
            //================
            Console.WriteLine("Give any number.");
            call_prim_str = Console.ReadLine();
            int base_Num_int = Convert.ToInt32(call_prim_str);
            //================
            //!Logic ================================================================================================
            if (base_Num_int == 1)
            { Console.WriteLine("Number 1 is prime"); return; }

            //!Logic ================================================================================================
            for (int i = 2; i < base_Num_int / 2 + 1; i++)
            {//~================================================================================
                bool isPrime = (base_Num_int % i == 0);

                if (isPrime)
                {//~==========================
                    Console.WriteLine("Number {0} is not prime", base_Num_int);
                    return;
                }//~==========================

            }//~================================================================================
            Console.WriteLine("Number {0} is prime", base_Num_int);
        }//~========================================================================================================

        public static void End_Game()
        {//~========================================================================================================
            string thanks_for_playing = "Thanks for plaything game!";
            Console.WriteLine(thanks_for_playing);
        }//~========================================================================================================

    }//?=========================================================================================================
}//todo===============================================================================================================