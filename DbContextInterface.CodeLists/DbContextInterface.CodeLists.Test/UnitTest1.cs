using DbContextInterface.CodeLists.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbContextInterface.CodeLists.Test
{
    [TestClass]
    public class UnitTest1
    {
        //todo: add project of repository
        //todo: add repository
        //todo: test repository
        //todo: add this project to wits

        [TestMethod]
        public void TestMethod1()
        {
            using(var context = new TestContext())
            {
                var codeitem = new CodeItem();

                context.CodeItems.Add(codeitem);

                context.SaveChanges();

                Assert.AreEqual(1, context.CodeItems.Find(codeitem.CodeItemID).CodeItemID);
            }

        }
    }
}
