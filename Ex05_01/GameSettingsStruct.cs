using static Ex05_01.Enums;

namespace Ex05_01
{
    internal struct GameSettingsStruct
    {
        internal string Player1Name { get; }
        internal string Player2Name { get; }
        internal eBoardSize BoardSize { get; }
        internal eNumOfPlayers NumOfPlayers { get; }
        
        internal GameSettingsStruct(string i_Player1Name, string i_Player2Name, eBoardSize i_BoardSize, eNumOfPlayers i_NumOfPlayers)
        {
            this.Player1Name = i_Player1Name;
            this.Player2Name = i_Player2Name;
            this.BoardSize = i_BoardSize;
            this.NumOfPlayers = i_NumOfPlayers;
        }
    }
}
