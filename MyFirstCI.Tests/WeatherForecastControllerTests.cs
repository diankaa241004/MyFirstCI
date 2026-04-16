using Xunit;
using MyFirstCI.Api.Controllers;

namespace MyFirstCI.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void AllForecastsInFuture()
    {
        var controller = new WeatherController();
        var result = controller.Get();
        foreach (var forecast in result)
            Assert.True(forecast.Date >= DateOnly.FromDateTime(DateTime.Now));
    }

    [Fact]
    public void Get_ReturnsFiveForecasts()
    {
        var controller = new WeatherController();
        var result = controller.Get();
        Assert.Equal(5, result.Count());
    }

    [Fact]
    public void AlwaysRedTest()
    {
        Assert.True(false);
    }
}