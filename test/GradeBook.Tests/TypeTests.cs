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

        // Act

        // Assert
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);

    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
        // Arrange
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Same(book1, book2);

        // Act

        // Assert
        Assert.Same(book1, book2);
        Assert.True(Object.ReferenceEquals(book1, book2));
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}