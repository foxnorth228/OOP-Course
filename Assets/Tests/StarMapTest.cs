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
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(18f), 0.1f);
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(20f), 0.1f);
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(-45f), 10f);
        Assert.AreEqual(Starmap.GetScaleFromMagnitude(-46f), 10f);

    }

    [Test]
    public void StarMapGetTemp()
    {
        Assert.AreEqual(Starmap.GetTemperatureFromColorIndex(1.0f), 4742.7383f);
        Assert.AreEqual(Starmap.GetTemperatureFromColorIndex(10.0f), 890.450134f);
        Assert.AreEqual(Starmap.GetTemperatureFromColorIndex(2.0f), 3169.35376f);
        Assert.AreEqual(Starmap.GetTemperatureFromColorIndex(0.1f), 9027.63867f);
    }

    [Test]
    public void StarMapGetColor()
    {
        Color col = Starmap.GetColorFromTemperature(4742.7383f);
        Color test = new Color(1.000f, 0.873561323f, 0.771459579f, 1.000f);
        Assert.AreEqual(col.r, test.r);
        Assert.AreEqual(col.g, test.g);
        Assert.AreEqual(col.b, test.b);
        col = Starmap.GetColorFromTemperature(890.450134f);
        test = new Color(1.000f, 0.221094087f, 0.0f, 1.000f);
        Assert.AreEqual(col.r, test.r);
        Assert.AreEqual(col.g, test.g);
        Assert.AreEqual(col.b, test.b);
    }
}
