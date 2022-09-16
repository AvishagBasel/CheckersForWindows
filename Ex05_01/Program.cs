namespace Ex05_01
{
    internal static class Program
    {

        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            GameManagement game = new GameManagement();
            game.Run();
        }
    }
}