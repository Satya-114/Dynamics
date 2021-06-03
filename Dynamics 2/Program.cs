using System;

namespace Dynamics_2
{
    class Program
    {
        
        
            public static void addstr(dynamic s1, dynamic s2)
            {
                Console.WriteLine(s1 + s2);
            }

            // Main method
            static public void Main()
            {

                // Calling addstr method
                addstr("J", "V");
                addstr("Hi", "Hello");
                addstr("satya", 1232);
                addstr(12, 30);
            }
            
    }
}
