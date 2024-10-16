namespace Mylibrary
{
    public class FiggleWriter
    {
        public void Writer(string message)
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render(message));
        }
    }
}
