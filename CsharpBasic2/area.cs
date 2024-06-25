

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("너비를 입력 하세요 : ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("높이를 입력 하세요 : ");
            int height = int.Parse(Console.ReadLine());
            double result = (width * height);
            Console.WriteLine($"넓이는 {result} 입니다.");
        }
    }
}
