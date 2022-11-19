namespace GradeBook.Tests;

using System;
using Xunit;


public class TypeTests
{
    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        // Arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");
        var book3 = GetBook("Book 2");

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.Equal(book3, book2);

    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}