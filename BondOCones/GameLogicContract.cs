using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondOCones
{
    //Contract.Requires is pre condition
    //assert is the post but different
    //ensures is post condition 
    [ContractClassFor(typeof(IGameLogic))]
    class GameLogicContract : IGameLogic
    {
        //public int[,] board = new int[10, 12]; maybe we can delete this later maybe better in contracts


        int scorePlayer1;
        int scorePlayer2;

        public List<GameCone> player1Pieces = new List<GameCone>();
        public List<GameCone> player2Pieces = new List<GameCone>();

        public void startGame()
        {
            Contract.Ensures(scorePlayer1 == 0 && scorePlayer2 == 0);
            Contract.Ensures(player1Pieces.Count == 26 && player2Pieces.Count == 26);

            Contract.Ensures(player1Pieces.GetRange(0, 9).All(x => x.value == 0)); // 10 total pieces with a value of 0
            Contract.Ensures(player1Pieces.GetRange(10, 14).All(x => x.value == 1)); // 5 total pieces with a value of 1
            Contract.Ensures(player1Pieces.GetRange(15, 20).All(x => x.value == 2)); // 6 total pieces with a value of 2
            Contract.Ensures(player1Pieces.GetRange(21, 24).All(x => x.value == 4)); // 4 total pieces with a value of 4
            Contract.Ensures(player1Pieces.GetRange(25, 25).All(x => x.value == 8)); // 8 total pieces with a value of 8        

            Contract.Ensures(player2Pieces.GetRange(0, 9).All(x => x.value == 0)); // same as above
            Contract.Ensures(player2Pieces.GetRange(10, 14).All(x => x.value == 1));
            Contract.Ensures(player2Pieces.GetRange(15, 20).All(x => x.value == 2));
            Contract.Ensures(player2Pieces.GetRange(21, 24).All(x => x.value == 4));
            Contract.Ensures(player2Pieces.GetRange(25, 25).All(x => x.value == 8));
        }

        public void setGamePieces(int player)
        {
            Contract.Ensures(player1Pieces.All(x => x.locationX != x.locationX && x.locationY != x.locationY));
            Contract.Ensures(player2Pieces.All(x => x.locationX != x.locationX && x.locationY != x.locationY));
            throw new NotImplementedException();
        }


        public int rollDie()
        {
            Contract.Ensures(rollDie() > 0 && rollDie() <= 4);
            throw new NotImplementedException();
        }

        public int SelectGamePiece()
        {
            throw new NotImplementedException();
        }

        public int SelectGameDirection()
        {
            throw new NotImplementedException();
        }
        public void moveGamePiece(int Piece, int Direction, int numberOfMoves)
        {

            throw new NotImplementedException();
        }

        public bool checkWin()
        {
            Contract.Ensures(scorePlayer1 >= 28 && checkWin() == true || scorePlayer2 >= 28 && checkWin() == true);
            throw new NotImplementedException();
        }

        public void resetGame()
        {
            Contract.Ensures(scorePlayer1 == 0 && scorePlayer2 == 0);
            Contract.Ensures(player1Pieces.Count == 26 && player2Pieces.Count == 26);
            Contract.Ensures(player1Pieces == new List<GameCone>());
            Contract.Ensures(player2Pieces == new List<GameCone>());
            throw new NotImplementedException();
        }
    }
}
