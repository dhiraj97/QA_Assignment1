using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using QAAssignment1;

namespace QAAssignment1.Tests
{
    [TestFixture]
    class RectangleTest
    {
        private Rectangle rect;
        [SetUp]
        public void Init()
        {
            rect = new Rectangle();
        }

        [Test]
        public void GetLengthTest_Input1_Output1()
        {
            Assert.AreEqual(1,rect.GetLength());
        }

        [Test]
        public void SetLengthTest_Input5_Output5()
        {
            rect.SetLength(5);
            Assert.AreEqual(5, rect.GetLength());
        }
        [Test]
        public void GetWidthTest_Input1_Output1()
        {
            Assert.AreEqual(1, rect.GetWidth());
        }
        [Test]
        public void SetWidthTest_Input5_Output5()
        {
            rect.SetWidth(5);
            Assert.AreEqual(5, rect.GetWidth());
        }
        [Test]
        public void GetPerimeterTest_Input1and1_Output4()
        {
            rect.SetLength(1);
            rect.SetWidth(1);
            Assert.AreEqual(4, rect.GetPerimeter());
        }
        [Test]
        public void GetAreaTest_Input1and1_Output1()
        {
            rect.SetLength(1);
            rect.SetWidth(1);
            Assert.AreEqual(1, rect.GetArea());
        }
    }
}
