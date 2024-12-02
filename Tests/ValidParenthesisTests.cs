using DataStructures;
namespace Tests;

public class ValidParenthesisTests
{
    [Fact]
    public void ValidParenthesis_ShouldReturnTrue_ForValidStrings()
    {
        Assert.True(ValidParenthesis.IsValid("()"));
        Assert.True(ValidParenthesis.IsValid("()[]{}"));
        Assert.True(ValidParenthesis.IsValid("{[()]}"));
    }

    [Fact]
    public void ValidParenthesis_ShouldReturnFalse_ForInvalidStrings()
    {
        Assert.False(ValidParenthesis.IsValid("(]"));
        Assert.False(ValidParenthesis.IsValid("([)]"));
        Assert.False(ValidParenthesis.IsValid("{[}"));
    }

    [Fact]
    public void ValidParenthesis_ShouldHandleEdgeCases()
    {
        Assert.True(ValidParenthesis.IsValid(""));
        Assert.False(ValidParenthesis.IsValid("("));
        Assert.False(ValidParenthesis.IsValid(")"));
    }
}