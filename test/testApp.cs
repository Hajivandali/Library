using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;

namespace test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMain()
        {
            // Arrange
            var obj1 = new Obj();
            var obj2 = new Obj();
            var obj3 = new Obj();

            var expectedModels = obj1.res();
            var expectedNumStrings = obj2.NumString();
            var expectedOrderedModels = obj3.Order();

            // Act
            var output = new List<string>();
            Console.SetOut(new System.IO.StringWriter());
            Program.Main();
            output = Console.Out.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            // Assert
            int index = 0;
            foreach (var item in expectedOrderedModels)
            {
                Assert.AreEqual($"Name: {item.Name} ID: {item.Id} Age: {item.Age}", output[index++]);
                foreach (var mobile in item.Mobile)
                {
                    Assert.AreEqual($"Mobile: {mobile}", output[index++]);
                }
            }

            foreach (var x in expectedNumStrings)
            {
                Assert.AreEqual($"num : {x}", output[index++]);
            }

            foreach (var Stu in expectedModels)
            {
                Assert.AreEqual($" Name: {Stu.Name } ID: {Stu.Id}  AGE: {Stu.Age} ", output[index++]);
            }
        }
    }
}