using BilgeAdam.TestPractise;
using System.Text;

namespace BilgeAdam.TestPractise
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            var type = typeof(IProduct);
            Console.WriteLine(type.FullName);
        }
    }
}
