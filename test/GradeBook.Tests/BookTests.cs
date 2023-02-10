namespace GradeBook.Tests;
using Xunit;


public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        // In order to use this class, need to add the reference from csproj that this is defined, via the CLI

        // Arrange
        var book = new Book("Heres our new BOOK!!!");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // Act
        var result = book.GetStatistics();

        // Assert
        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);

    }

    [Fact]
    public void AddGradeBetweenZeroAndOneHundred()
    {
        // Arrange
        var book = new Book("Kyle's Test Book");
        book.AddGrade(99.0);

        // Act
        var result = book.GetGrades();

        // Assert
        foreach (var item in result)
        {
            Assert.Equal(99.0, item);
        }
    }
}
