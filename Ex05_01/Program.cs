namespace Ex05_01
{
    internal static class Program
    {
        // $G$ SFN-012 (+6) Bonus: Events in the Logic layer are handled by the UI.
        // $G$ SFN-013 (+3) Bonus: Richer graphic for the game (photos for the 'X' and 'O').
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            GameManagement game = new GameManagement();
            game.Run();
        }
    }
}