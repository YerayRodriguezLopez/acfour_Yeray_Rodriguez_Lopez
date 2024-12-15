namespace Acfour
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(5, true)]
        [DataRow(1, true)]
        [DataRow(10, true)]
        [DataRow(100, true)]
        [DataRow(7, true)]
        public void IsNatNum_InputPositiveNumber_ReturnsTrue(int input, bool expected)
        {
            // Act
            bool result = ProgramAcfourYerayRodriguez.IsNatNum(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-1, false)]
        [DataRow(-10, false)]
        [DataRow(-999, false)]
        [DataRow(-42, false)]
        [DataRow(-8, false)]
        public void IsNatNum_InputNegativeNumber_ReturnsFalse(int input, bool expected)
        {
            // Act
            bool result = ProgramAcfourYerayRodriguez.IsNatNum(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0, false)]
        public void IsNatNum_InputZero_ReturnsFalse(int input, bool expected)
        {
            // Act
            bool result = ProgramAcfourYerayRodriguez.IsNatNum(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(new int[] { 3, 1, 4, 1, 5, 9 }, new int[] { 9, 5, 4, 3, 1, 1 })]
        [DataRow(new int[] { 10, 20, 30, 40, 50 }, new int[] { 50, 40, 30, 20, 10 })]
        [DataRow(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2, -3, -4, -5 })]
        [DataRow(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [DataRow(new int[] { 100, 50, 25 }, new int[] { 100, 50, 25 })]
        public void QuickSortDescending_SortsArrayCorrectly(int[] array, int[] expected)
        {
            // Act
            ProgramAcfourYerayRodriguez.QuickSortDescending(array, 0, array.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }

        [DataTestMethod]
        [DataRow(new int[] { 3, 6, 8, 10, 1, 2, 1 }, 0, 6, 5)]
        [DataRow(new int[] { 9, 8, 7, 6, 5, 4, 3 }, 0, 6, 6)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0, 6, 0)]
        [DataRow(new int[] { 10, 9, 8, 7, 6, 5, 4 }, 0, 6, 6)]
        [DataRow(new int[] { 5, 10, 15, 20, 25, 30, 35 }, 0, 6, 0)]
        public void Partition_CorrectPivotPosition(int[] array, int low, int high, int expectedPivotIndex)
        {
            // Act
            int pivotIndex = ProgramAcfourYerayRodriguez.Partition(array, low, high);

            // Assert
            Assert.AreEqual(expectedPivotIndex, pivotIndex);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 0, 2, new int[] { 3, 2, 1 })]
        [DataRow(new int[] { 10, 20, 30 }, 1, 2, new int[] { 10, 30, 20 })]
        [DataRow(new int[] { -1, -2, -3 }, 0, 1, new int[] { -2, -1, -3 })]
        [DataRow(new int[] { 0, 5, 10 }, 0, 2, new int[] { 10, 5, 0 })]
        [DataRow(new int[] { 99, 100, 101 }, 1, 2, new int[] { 99, 101, 100 })]
        public void Swap_SwapsValuesCorrectly(int[] array, int index1, int index2, int[] expected)
        {
            // Act
            ProgramAcfourYerayRodriguez.Swap(array, index1, index2);

            // Assert
            CollectionAssert.AreEqual(expected, array);
        }
    }
}