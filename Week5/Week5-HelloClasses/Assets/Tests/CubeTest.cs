using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTest
{
    // Test the default constructor
    [Test]
    public void CubeDefaultConstructorTest()
    {
        // Setup and Act
        Cube defaultCube = new Cube();

        // Assert
        Assert.AreEqual(0, defaultCube.GetHeight());
        Assert.AreEqual(0, defaultCube.GetWidth());
        Assert.AreEqual(0, defaultCube.GetLength());
        Assert.AreEqual(0, defaultCube.GetEdgeLength());
        Assert.AreEqual(0, defaultCube.GetVolume()); 
    }

    // Test a 2 x 2 x 2 Cube
    [Test]
    public void CubeTwoByTwoByTwoTest()
    {
        // Setup and Act
        Cube twoByTwoByTwo = new Cube(2f, 2f, 2f);

        // Assert
        Assert.AreEqual(2, twoByTwoByTwo.GetHeight());
        Assert.AreEqual(2, twoByTwoByTwo.GetWidth());
        Assert.AreEqual(2, twoByTwoByTwo.GetLength());
        Assert.AreEqual(24, twoByTwoByTwo.GetEdgeLength());
        Assert.AreEqual(8, twoByTwoByTwo.GetVolume());
    }

    // Test a 10 x 10 x 20 Cube
    [Test]
    public void CubeTenByTenByTwentyTest()
    {
        // Setup and Act
        Cube tenByTenByTwenty = new Cube(10f, 10f, 20f);

        // Assert
        Assert.AreEqual(10, tenByTenByTwenty.GetHeight());
        Assert.AreEqual(10, tenByTenByTwenty.GetWidth());
        Assert.AreEqual(20, tenByTenByTwenty.GetLength());
        Assert.AreEqual(160, tenByTenByTwenty.GetEdgeLength());
        Assert.AreEqual(2000, tenByTenByTwenty.GetVolume());
    }

    // Test the SetHeight method
    [Test]
    public void CubeSetHeightTest()
    {
        // Setup
        Cube someCube = new Cube(1, 5, 7 );

        // Act
        someCube.SetHeight(100);

        // Assert
        Assert.AreNotEqual(1, someCube.GetHeight()); 
        Assert.AreEqual(100, someCube.GetHeight());

        Assert.AreEqual(5, someCube.GetWidth());
        Assert.AreEqual(7, someCube.GetLength());
        Assert.AreEqual(448, someCube.GetEdgeLength());
        Assert.AreEqual(3500, someCube.GetVolume());
    }
}
