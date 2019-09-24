using System.Text;

namespace Kata2.TicTacToe
{
    public class Game
    {
        private readonly StringBuilder _board;

        public Game(string s)
        {
            _board = new StringBuilder(s);
        }

        private Game(StringBuilder s, int position, char player)
        {
            _board = new StringBuilder();
            _board.Append(s);
            _board.Insert(position, player);
        }

        private Game Play(int i, char player)
        {
            return new Game(_board, i, player);
        }
        
        public int Move(char player)
        {
            for (var i = 0; i < 9; i++)
            {
                if (_board[i] == '-')
                {
                    var game = Play(i, player);
                    if (game.Winner() == player)
                        return i;
                }
            }

            for (var i = 0; i < 9; i++)
            {
                if (_board[i] == '-')
                    return i;
            }

            return -1;
        }
        
        public char Winner()
        {
            if (_board[0] != '-' && _board[0] == _board[1]
                                 && _board[1] == _board[2])
                return _board[0];
            if (_board[3] != '-' && _board[3] == _board[4]
                                 && _board[4] == _board[5])
                return _board[3];
            if (_board[6] != '-' && _board[6] == _board[7]
                                 && _board[7] == _board[8])
                return _board[6];

            return '-';
        }
    }
}