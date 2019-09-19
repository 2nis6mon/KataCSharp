using NUnit.Framework;
using Kata2.TicTacToe;

namespace Kata2.TicTacToe.NUnitTests
{
    public class GameTest
    { 
        private Game _ticTacToe;
		
        [Test]
        public void TestDefaultMove() {
            _ticTacToe= new Game("XOXOX-OXO");
            Assert.That(_ticTacToe.Move('X'), Is.EqualTo(5));

            _ticTacToe= new Game("XOXOXOOX-");
            Assert.That(_ticTacToe.Move('X'), Is.EqualTo(8));

            _ticTacToe= new Game("---------");
            Assert.That(_ticTacToe.Move('X'), Is.EqualTo(0));

            _ticTacToe= new Game("XXXXXXXXX");
            Assert.That(_ticTacToe.Move('X'), Is.EqualTo(-1));
        }
		
        [Test]
        public void TestFindWinningMove() {
            _ticTacToe= new Game("XO-XX-OOX");
            Assert.That(_ticTacToe.Move('X'), Is.EqualTo(5));
        }
		
        [Test]
        public void Winnner_should_win_with_all_X_on_second_line() {
            _ticTacToe = new Game("-0-XXX--0");
            Assert.That(_ticTacToe.Winner(), Is.EqualTo('X'));
        }
		
        [Test]
        public void Winner_should_win_0_on_all_0_first_line() {
            _ticTacToe = new Game("000------");
            Assert.That(_ticTacToe.Winner(), Is.EqualTo('0'));
        }
    }
}