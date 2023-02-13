using Xunit;
using Wrapper;
using RPS;

public class Test {
    
    [Theory]
    [InlineData(1,2)]
    public void compareInputTest(int a, int b) {

        string result = RPS.RPSGame.compareInput(a,b);

        Assert.Equal(result,RPS.RPSGame.compareInput(a,b)); 
    }
}