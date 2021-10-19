using System;

namespace TestApp
{

    interface testInterface1 {  
        void Show();  
    }  
    interface testInterface2 {  
        void Show();  
    }  
    class Abc: testInterface1, testInterface2 {  
            public void testInterface1.Show() {  
                Console.WriteLine("For testInterface1 !!");  
            }  
            public void testInterface2.Show() {  
                Console.WriteLine("For testInterface2 !!");  
            }  
        }  


    class Program
    {
        static void Main(string[] args)
        {
            testInterface1 obj1 = new Abc();  
            testInterface2 obj2 = new Abc();  
            var obj3 = new Abc();  
            obj1.Show();  
            obj2.Show();  
            obj3.Show();  
            Console.ReadLine();  
        }
    }
}
