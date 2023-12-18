using Refactoring;

namespace MainWorkspace_Tests
{
    [TestClass]
    public class classMainWorkspace_Tests
    {
        [TestMethod]
        public void IsInRange_ReturnsFalse()
        {
            /*
             * 
             * If the input number is in between the specified range, it should return true.
             * 
             */

            const int inputValue = 100, minRange = 5, maxRange = 150;
            bool result;

            result = FirstRefactoringExercise.IsInRange(inputValue, minRange, maxRange);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ErrorsCheck_ReturnsTrue()
        {
            /*
             * 
             *  If the user reached the maximum of errors, our method should return true.
             *
             */

            const int errorNum = 3, maxErrors = 3;
            bool result;

            result = FirstRefactoringExercise.ErrorCheck(errorNum, maxErrors);

            Assert.IsTrue(errorNum, maxErrors);
        }
    }
}