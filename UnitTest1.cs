using Xunit;
using xUnitExample.Controllers;

namespace xUnitExample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void xUnitExampleController_Index_ValidLargerNumberResult()
        {
            //AAA
            //Arange
            xUnitExampleController controller = new xUnitExampleController();
            int guessedNumber = 120;
            string result = controller.Index(guessedNumber);

            //Act
            string expectedResult = "Wrong! Try a Smaller number";

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void xUnitExampleController_Index_ValidSmallerNumberResult()
        {
            //AAA
            //Arange
            xUnitExampleController controller = new xUnitExampleController();
            int guessedNumber = 80;
            string result = controller.Index(guessedNumber);

            //Act
            string expectedResult = "Wrong! Try a Larger number";

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void xUnitExampleController_Index_ValidEqualResult()
        {
            //AAA
            //Arange
            xUnitExampleController controller = new xUnitExampleController();
            int guessedNumber = 100;
            string result = controller.Index(guessedNumber);

            //Act
            string expectedResult = "You Gussed Correct number";

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}