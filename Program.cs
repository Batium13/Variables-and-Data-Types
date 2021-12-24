using System;

namespace Variables_and_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 2;
            sbyte sB = 2;

            short sh1 = 2;
            ushort uSh1 = 2;

            Int16 i16 = 4;
            Int32 i32 = 8;
            int i = 4;
            Int64 i64 = 5;

            uint ui = 4;
            long l = 5;
            ulong ul = 45;

            float f = 4f;
            double d = 5d;
            decimal de = 16;

            char ch = 'b';
            string str = "batu";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 ="b";
            object o2 ='c';
            object o3 = 4;
            object o4 = 56.7;

            string str1 = string.Empty;
            str1="Batuhan ALTINEL";

            string name = "Batuhan";
            string surname="ALTINEL";

            Console.WriteLine(name+" "+surname);


            int bir = 1;
            int iki = 2;

            int toplam = bir + iki;
            Console.WriteLine(toplam);

            bool bool1 = (10/2)<3; // false

            string str21 = "21";
            int int21 = 21;

            string yeniDeger = str21 + int21.ToString();

            int top = int21 + Convert.ToInt32(str21);

            Console.WriteLine(yeniDeger);
            Console.WriteLine(top);


            int int22 = int21 + int.Parse(str21);

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            string datetime1 = DateTime.Now.ToString("dd/mm/yyyy");
            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(datetime);
            Console.WriteLine(datetime1);
            Console.WriteLine(hour);



        }
    }
}
