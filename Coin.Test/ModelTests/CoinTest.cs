using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin.Models;

namespace Coin.Tests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]

            public void ToInt_OneTo1_True()
            {
                string input = "1";
                int output = 1;
                Assert.AreEqual(output, int.Parse(input));

            }

             [TestMethod]
            public void ChangeConvertor_HowManyQuarters_0()
            {       
             Assert.AreEqual(0, Change.ChangeConverter(4, 4)[0]);
            }
            
             public void ChangeConvertor_HowManyDime_0()
            {       
             Assert.AreEqual(10, Change.ChangeConverter(20, 10)[1]);
            }
            
             public void ChangeConvertor_HowManyNickle_0()
            {       
             Assert.AreEqual(20, Change.ChangeConverter(30, 10)[2]);
            }

             public void ChangeConvertor_HowManyPenny_0()
            {       
             Assert.AreEqual(1, Change.ChangeConverter(2, 1)[4]);
            }
        }
    }

