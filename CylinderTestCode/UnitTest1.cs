using Xunit;
using CylinderProject.Models;

namespace CylinderTestCode
{
    public class UnitTest1
    {
        [Fact]
        public void ErtekAtadasHelyesseg()
        {
            double testingRadius = 5.5;
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);
            Assert.Equal(testingRadius, testCylinder.Radius);
            Assert.Equal(testingHeight, testCylinder.Height);
        }

        [Theory]
        [InlineData(-5,7)]
        [InlineData(5,-7)]
        [InlineData(0,7)]
        [InlineData(5,0)]
        public void MinuszVagyNullaKezeles(double testingRadius, double testingHeight)
        {

            Assert.Throws<ArgumentException>(() => new Cylinder(testingRadius,testingHeight));
 
        }
        [Fact]
        public void GetVolumeEllenorzes()
        {
            double testingRadius = 5;
            double testingHeight = 7;

            var testCylinder = new Cylinder(testingRadius, testingHeight);

            Assert.Equal(Math.PI * Math.Pow(testingRadius, 2) * testingHeight, testCylinder.GetVolume());

        }
        [Fact]
        public void GetSurfaceAreaEllenorzes()
        {
            double testingRadius = 5.5;
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);

            Assert.Equal(2 * Math.PI * Math.Pow(testingRadius, 2) + 2 * Math.PI * testingRadius * testingHeight, testCylinder.GetSurfaceArea());

        }

        [Fact]
        public void ResizeEllenorzes()
        {
            double testingRadius = 5.5;
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);

            double newRadius = 2;
            double newHeight = 9;

            testCylinder.Resize(newRadius,newHeight);

            Assert.Equal(testCylinder.Radius, newRadius);
            Assert.Equal(testCylinder.Height, newHeight);

        }

        [Theory]
        [InlineData(-2,9)]
        [InlineData(2,-9)]
        [InlineData(0,9)]
        [InlineData(2,0)]
        public void ResizeHibaKezeles(double newRadius, double newHeight)
        {
            double testingRadius = 5.5;
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);


            Assert.Throws<ArgumentException>(() => testCylinder.Resize(newRadius, newHeight));

        }

        [Fact]
        public void CylinderNotNull()
        {
            double testingRadius = 5.5;
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);

            Assert.NotNull(testCylinder);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(50)]
        [InlineData(100)]
        public void RadiusInRange(double testingRadius)
        {
            double testingHeight = 7.2;

            var testCylinder = new Cylinder(testingRadius, testingHeight);

            Assert.InRange(testCylinder.Radius, 1, 100);

        }
    }
}