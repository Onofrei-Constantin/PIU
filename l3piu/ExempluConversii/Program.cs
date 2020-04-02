using System;

namespace ExempluConversii
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            float z;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;

            x = 10.0;
            y = 3.0;

            // conversie double -> int (cu pierdere de date)
            i = (int)(x / y);
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("int ( x / y ): {0}", i);
            Console.WriteLine();

            // conversie int->byte (fara pierdere de date)
            i = 255;
            b = (byte)i;
            Console.WriteLine("b =(byte)255 : {0} -- fara pierdere de date.", b);

            // conversie int->byte (cu pierdere de date) 
            i = 257;
            b = (byte)i;
            Console.WriteLine("b= (byte)257 : {0} -- cu pierdere de date.", b);
            Console.WriteLine();

            // conversie uint -> short (fara pierdere de date) 
            u = 32000;
            s = (short)u;
            Console.WriteLine("s= (short)32000: {0} -- fara pierdere de date.", s);

            // conversie uint -> short (cu pierdere de date) 
            u = 64000;
            s = (short)u;
            Console.WriteLine("s= (short)64000: {0} -- cu pierdere de date.", s);
            Console.WriteLine();

            // conversie long -> uint (fara pierdere de date)  
            l = 64000;
            u = (uint)l;
            Console.WriteLine("u= (uint)64000: {0} -- fara pierdere de date.", u);

            // conversie long -> uint (cu pierdere de date) 
            l = -12;
            u = (uint)l;
            Console.WriteLine("u= (uint)-12: {0} -- cu pierdere de date.", u);
            Console.WriteLine();

            // conversie byte -> char 
            b = 88;  
            ch = (char)b;
            Console.WriteLine("ch= (char)88 : {0}", ch);
            Console.WriteLine();

            /*** conversii utilizand clasa Convert   ***/

            //conversie char -> int
            ch = 'a';
			i = Convert.ToInt32(ch);
			Console.WriteLine("i= (int)'a' : {0}", i);
			
			string str = "123";
			i = Convert.ToInt32(str);
			Console.WriteLine("i= (int)\"123\" : {0}", i);

            Console.ReadKey();
        }
    }
}
