using sc = System.Console;

namespace Revature.Week1.HelloWorld //namespace scope
{
    //class struct interface enum
    class Program   //class scope
    {
        private static void Main()
        {
            sc.WriteLine("Enter your name:");
            // stdin << name
            var input = sc.ReadLine(); //data type inference
            // stout >> name
            sc.WriteLine($"Hello {input}"); //string interpolation, template string
        }
        private void UIPath()   //method scope
        {
            {
                //block scope
            }
        }
    }
}
