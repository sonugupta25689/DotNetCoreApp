using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;
namespace CoreWebAPIAzure.Test;
using Xunit;
//Unit Test
public class UnitTest1
{
    ValuesController valuesController=new ValuesController(); // This is Arrange
    [Fact]//Arrange , Act , Assert
    public void Test1()
    {
        var test =valuesController.Get(1); // this is Act
        Assert.Equal("Yukti",test);

    }
}