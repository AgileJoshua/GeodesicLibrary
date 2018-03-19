using System;
using System.Text;
using System.Collections.Generic;
using Marknotgeorge.GeodesicLibrary;
using UnitsNet.Units;
using UnitsNet;
using Xunit;


namespace GeodesicLibraryTests
{
    /// <summary>
    /// Summary description for PositionTests
    /// </summary>
    public class PositionTests
    {
        public PositionTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private int precision = 3; 

        [Fact]
        public void GetDistanceToTest()
        {
            double expectedValue = 968.8535;
            
            Position fromPosition = new Position(50.066389, -5.714722);
            Position toPosition = new Position(58.643889, -3.07);

            double testValue = fromPosition.DistanceTo(toPosition);

            

            Assert.Equal(expectedValue, testValue, precision);

        }

        [Fact]
        public void InitialBearingTest()
        {
            double expectedValue = 9.119722;

            Position fromPosition = new Position(50.066389, -5.714722);
            Position toPosition = new Position(58.643889, -3.07);

            double testValue = fromPosition.InitialBearing(toPosition);

            Assert.Equal(expectedValue, testValue, precision);

        }

        [Fact]
        public void FinalBearingTest()
        {
            double expectedValue = 11.275278;

            Position fromPosition = new Position(50.066389, -5.714722);
            Position toPosition = new Position(58.643889, -3.07);

            double testValue = fromPosition.FinalBearing(toPosition);
            

            Assert.Equal(expectedValue, testValue, precision);

        }

        [Fact]
        public void MidpointTest()
        {
            double expectedLat = 54.362222;
            double expectedLon = -4.530556;

            Position fromPosition = new Position(50.066389, -5.714722);
            Position toPosition = new Position(58.643889, -3.07);

            Position testValue = fromPosition.MidpointTo(toPosition);

            Assert.Equal(expectedLat, testValue.Latitude, precision);
            Assert.Equal(expectedLon, testValue.Longitude, precision);
        }

        [Fact]
        public void DestinationTest()
        {
            double expectedLat = 53.188333;
            double expectedLon = 0.133333;

            Position fromPosition = new Position(53.320556, -1.729722);
            double bearing = 96.021667;
            double distance = 124.8; // km

            Position testValue  = fromPosition.Destination(bearing, distance);           

            Assert.Equal(expectedLat, testValue.Latitude, precision);
            Assert.Equal(expectedLon, testValue.Longitude, precision);
        }

        [Fact]
        public void IntersectionTest()
        {
            double expectedLat = 50.901667;
            double expectedLon = 4.494167;

            Position firstPosition = new Position(51.885, 0.235);
            Position secondPosition = new Position(49.008, 2.549);
            double firstBearing = 108.63;
            double secondBearing = 32.72;

            Position testValue = firstPosition.Intersection(firstBearing, secondPosition, secondBearing);

            Assert.Equal(expectedLat, testValue.Latitude, precision);
            Assert.Equal(expectedLon, testValue.Longitude, precision);
        }

        [Fact]
        public void RhumbDistanceTest()
        {
            double expectedValue = 5196.34;

            Position fromPosition = new Position(50.363889, -4.156944);
            Position toPosition = new Position(42.351111, -71.040833);

            double testValue = fromPosition.RhumbDistanceTo(toPosition);

            Assert.Equal(expectedValue, testValue, precision);
        }

        [Fact]
        public void RhumbBearingTest()
        {
            double expectedValue = 260.127222;

            Position fromPosition = new Position(50.363889, -4.156944);
            Position toPosition = new Position(42.351111, -71.040833);

            double testValue = fromPosition.RhumbBearingTo(toPosition);

            Assert.Equal(expectedValue, testValue, precision);
        }

        [Fact]
        public void RhumbDestinationTest()
        {
            double expectedLat = 50.96222;
            double expectedLon = 1.8525;

            Position fromPosition = new Position(51.125556, 1.338056);
            double bearing = 116.636111;
            double distance = 40.23; // km

            Position testValue = fromPosition.Destination(bearing, distance);

            Assert.Equal(expectedLat, testValue.Latitude, precision);
            Assert.Equal(expectedLon, testValue.Longitude, precision);
        }

        [Fact]
        public void RhumbMidpointTest()
        {
            double expectedLat = 46.3575;
            double expectedLon = -38.8274;

            Position fromPosition = new Position(50.363889, -4.156944);
            Position toPosition = new Position(42.351111, -71.040833);

            Position testValue = fromPosition.RhumbMidpointTo(toPosition);

            Assert.Equal(expectedLat, testValue.Latitude, precision);
            Assert.Equal(expectedLon, testValue.Longitude, precision);
        }



    }
}
