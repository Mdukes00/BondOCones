using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondOCones
{
    [ContractClass(typeof(GameLogicContract))]
    interface IGameLogic
    {
        void startGame();

        void setGamePieces(int player);


        int rollDie();

        int SelectGamePiece();

        int SelectGameDirection();

        void moveGamePiece(int Piece, int Direction, int numberOfMoves);


        bool checkWin();

        void resetGame();


    }
}
