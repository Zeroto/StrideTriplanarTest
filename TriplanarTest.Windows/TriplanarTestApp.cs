using Stride.Engine;

namespace TriplanarTest
{
    class TriplanarTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
