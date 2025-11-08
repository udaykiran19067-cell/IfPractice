namespace IfPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emp = new string[] { "vijay", "vkinay", "vikas", "Vidya" };
            Console.WriteLine("Employee names:");

           foreach(var name in emp) 
            {
                Console.WriteLine(name);
                if (name == "vikas")


                {

                    break;
                }
            }
        }
    }
}
