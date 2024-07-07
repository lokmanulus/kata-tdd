using Xunit;

namespace DotnetStarter.Logic.Tests
{
    public class ChristmasLightsTest
    {
        House house;
        public ChristmasLightsTest()
        {
            house = new House();
        }


        [Theory]
        [InlineData(887, 9, true)]   // Start coordinate
        [InlineData(959, 629, true)] // End coordinate
        [InlineData(900, 300, true)] // Intermediate point within the range
        [InlineData(950, 600, true)] // Another intermediate point within the range
        [InlineData(886, 8, false)]  // Point outside the range
        [InlineData(960, 630, false)] // Another point outside the range
        public void TurnOn(int x, int y, bool expected) {
            int[] coord1 = { 887, 9 };
            int[] coord2 = { 959, 629 };

            house.TurnOn(coord1, coord2);
            Assert.Equal(expected, house.lights[x, y]);

        }
    }
}