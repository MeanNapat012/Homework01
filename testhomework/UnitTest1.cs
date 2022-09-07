namespace testhomework;

public class UnitTest1
{
    [Fact]
    public void TestConvertNumberToDouble()
    {
        double number = Program.ConvertNumberToDouble("212121");

        Assert.Equal(number, 212121);
    }
    [Fact]
    public void TestConvertNumberToDoubleTOdoublelsnCorrect()
    {
        Assert.Throws<Exception>(() => Program.ConvertNumberToDouble("Mean"));
    }

    [Fact]
    public void TestConvertMoneyTodouble()
    {
        double number = Program.ConvertMoneyTodouble("100000");

        Assert.Equal(number, 100000);
    }
    [Fact]
    public void TestConvertMoneyTodoubleTOdoublelsnCorrect()
    {
        Assert.Throws<Exception>(() => Program.ConvertNumberToDouble("Mean"));
    }

    [Fact]
    public void TestConvertStringTodouble()
    {
        double number = Program.ConvertStringTodouble("5120.25");

        Assert.Equal(number, 5120.25);
    }
    [Fact]
    public void TTestConvertStringTodoubleTOdoublelsnCorrect()
    {
        Assert.Throws<Exception>(() => Program.ConvertNumberToDouble("Mean"));
    }
}