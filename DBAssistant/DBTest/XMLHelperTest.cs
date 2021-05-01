using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkerCommon;

namespace DBTest
{
    [TestClass]
    public class XMLHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            XMLHelper.CreatXmlTree(AppDomain.CurrentDomain.BaseDirectory+"xmltest.xml");
        }
    }
}
