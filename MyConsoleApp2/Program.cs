using Mylibrary;
namespace MyConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Writer("Hello, Writer!");
            MessageWriter FWriter = new MessageWriter();
            FWriter.Writer("Hello, Figgle!!!");
        }
    }
}