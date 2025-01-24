namespace CylinderTest
{
    public class UnitTest1
    {

        //1.
        [Fact]
        public void Is_Correct_Constructor_Attribute_Settings()
        {
            //Arrange & Act
            var henger = new Cylinder(10, 20);
            //Assert
            Assert.Equal(10, henger.Radius);
            Assert.Equal(20, henger.Height);
        }

        //2a
        //[Fact]
        //public void ThrowException_For_Wrong_Datas()
        //{
        //    //Arrange
        //    var henger = new Cylinder(0, 20);

        //    Assert.Throws<ArgumentException>(() => new Cylinder(0, 20));
        //    Assert.Throws<ArgumentException>(() => new Cylinder(20,0));
        //    Assert.Throws<ArgumentException>(() => new Cylinder(-1, 20));
        //    Assert.Throws<ArgumentException>(() => new Cylinder(20, -1));
        //}

        //2b
        [Theory]
        [InlineData(0,10)]
        [InlineData(10,0)]
        [InlineData(-6,10)]
        [InlineData(10,-6)]
        public void ThrowException_For_Wrong_Datas(double radius, double height)
        {
            //Arrange & Act
            Assert.Throws<ArgumentException>(() => new Cylinder(radius, height));
        }

        //3
        [Theory]
        [InlineData(10,20, 12566.370614)]
        [InlineData(5.65, 12.37, 1240.556270)]
        [InlineData(3.2346865, 12345, 405546.899)]
        public void Check_Correct_Volume(double radius, double height, double expected)
        {
            //Arrange 
            var henger = new Cylinder(radius, height);
            //Act
            var terfogat=henger.GetVolume();

            //Assert
            Assert.Equal(expected, Math.Round(terfogat,6));
        }

        //4a 
        [Fact]
        public void Is_Correct_Resize_Attribute_Settings()
        {
            //Arrange & Act
            var henger = new Cylinder(10, 20);
            //Assert
            Assert.Equal(10, henger.Radius);
            Assert.Equal(20, henger.Height);
        }

        //4b
        [Theory]
        [InlineData(0, 10)]
        [InlineData(10, 0)]
        [InlineData(-6, 10)]
        [InlineData(10, -6)]
        public void ThrowException_For_Wrong_Resize_Datas(double radius, double height)
        {
            //Arrange & Act
            Assert.Throws<ArgumentException>(() => new Cylinder(radius, height));
        }

        //5.
        [Fact]
        public void Is_Valid_Cylinder()
        {
            
        }

        //6a
        public void Is_In_Range_Radius()
        {
            //Arrange-Act
            var henger = new Cylinder(radius,20);

            //Assert
            Assert.InRange(henger.Radius, 1, 100);
        }
        //6b

    }
}