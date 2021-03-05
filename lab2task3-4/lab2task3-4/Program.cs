using System;

namespace lab2task3_4
{
    
        public static class Myclass
        {
            public static string GetArray(this string list, params string[] strings)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    list += $"{strings[i]}";
                }
                return list;
            }
        }

    /*
     * Создайте расширяющий метод: public static T[] GetArray(this MyList list) 
     * Примените расширяющий метод к экземпляру типа MyList.
     * Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zapolnyte kol masiva");
            int r = Convert.ToInt32(Console.ReadLine());
            string[] mass = new string[r];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine("vvedite element massiva");
                mass[i] = Console.ReadLine();
            }
            try
            {
                string s = "result ".GetArray(mass);
                Console.WriteLine(s);
            }
            catch
            {
                Console.WriteLine("vvedite corectnoe znacheniye");
            }

        }
        /*
         * task4
        *//*
        public class MyClass<T> where T : new()
        {

            public static T FacrotyMethod()
            {
                return new T();
            }
        }

        class Program1
        {/*
      * Создайте класс MyClass, содержащий статический фабричный метод – T FacrotyMethod(),
      * который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).  
        */
        
            




    }
}
