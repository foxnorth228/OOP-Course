using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using StarMap;

public class StarMapTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void StarMapGetScaleTest()
    {
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(1.0f), 0.8f);
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(-1.0f), 1.2f);
    }
}
