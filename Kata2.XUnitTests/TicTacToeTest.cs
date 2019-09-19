using Kata2.TicTacToe;
using Xunit;

namespace Kata2.XUnitTests
{
    public class TicTacToeTest
    {
        private Game _ticTacToe;
		
        [Fact]
        public void TestDefaultMove() {
            _ticTacToe= new Game("XOXOX-OXO");
            Assert.Equal(5, _ticTacToe.Move('X'));

            _ticTacToe= new Game("XOXOXOOX-");
            Assert.Equal(8, _ticTacToe.Move('X'));

            _ticTacToe= new Game("---------");
            Assert.Equal(0, _ticTacToe.Move('X'));

            _ticTacToe= new Game("XXXXXXXXX");
            Assert.Equal(-1, _ticTacToe.Move('X'));
        }
		
        [Fact]
        public void TestFindWinningMove() {
            _ticTacToe= new Game("XO-XX-OOX");
            Assert.Equal(5, _ticTacToe.Move('X'));
        }
		
        [Fact]
        public void Winner_should_win_with_all_X_on_second_line() {
            _ticTacToe = new Game("-0-XXX--0");
            Assert.Equal('X', _ticTacToe.Winner());
        }
		
        [Fact]
        public void Winner_should_win_0_on_all_0_first_line() {
            _ticTacToe = new Game("000------");
            Assert.Equal('0', _ticTacToe.Winner());
        }
    }
}