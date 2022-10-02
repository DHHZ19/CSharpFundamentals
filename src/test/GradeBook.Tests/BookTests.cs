namespace GradeBook.Tests;
public class BookTests
{
    [Fact]
    public void Test1()
    {
        // arange
        var book = new Book();
        var expected = 10 + 11;
        // act 
        var actual = book.AddGrade(10, 12);
        //assert
        Assert.Equal(expected, actual);
    }
}
