using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange section
            // var x = 5;
            // var y = 2;
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            //act section
            // var expected = 7;
            // var actual = x + y;
            var result = book.GetStatistics();
            
            // assert section
            // Assert.Equal(expected, actual);
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
