using static System.Console;
using static System.DateTime;

namespace superconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "WORLD!!";
            
            WriteLine($"Hello {name}. The Time is "+ Now.ToString("t"));
            
        }
    }
}
