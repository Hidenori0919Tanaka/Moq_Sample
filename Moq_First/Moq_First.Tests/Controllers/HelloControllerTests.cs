using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq_First.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;

namespace Moq_First.Controllers.Tests
{
    [TestClass()]
    public class HelloControllerTests
    {
        [TestMethod()]
        public void SampleTest()
        {

        }

        [TestMethod]
        public void Sample()
        {
            //  HelloControllerクラスのモックを作成
            var mock = new Mock<HelloController>();

            //  Sampleメソッドを準備＆ 戻り値の登録
            mock.Setup(c => c.Sample()).Returns(
                new ViewResult() { ViewName = "Sample" });

            // モック・オブジェクトを取得＆アクションの実行
            var con = mock.Object;
            var result = con.Sample() as ViewResult;

            // 結果の検証
            Assert.AreEqual("Sample", result.ViewName);
        }
    }
}