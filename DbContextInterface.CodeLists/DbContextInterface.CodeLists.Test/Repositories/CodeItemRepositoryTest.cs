using DbContextInterface.CodeLists.Entities;
using DbContextInterface.CodeLists.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DbContextInterface.CodeLists.Test
{
    [TestClass]
    public class CodeItemRepositoryTest
    {
        [TestMethod]
        public void GetAllFrozenCodesTest()
        {
            using(var context = new TestContext())
            {
                var codeList = new CodeList();
                var secondCodeList = new CodeList();

                context.CodeLists.Add(codeList);
                context.CodeLists.Add(secondCodeList);

                context.SaveChanges();

                var codeInSecondList = new CodeItem();

                codeInSecondList.CodeListID = secondCodeList.CodeListID;

                context.CodeItems.Add(codeInSecondList);

                context.SaveChanges();

                var frozenCode = new CodeItem();
                var activeCode = new CodeItem();

                frozenCode.CodeListID = codeList.CodeListID;
                frozenCode.Label = "im frozen";
                activeCode.CodeListID = codeList.CodeListID;
                activeCode.Label = "im active";
                frozenCode.IsCodeFrozen = true;

                context.CodeItems.Add(frozenCode);
                context.CodeItems.Add(activeCode);

                context.SaveChanges();

                var target = new CodeItemRepository<TestContext>(context);

                var result = target.GetAllFrozenCodes(codeList.CodeListID);

                Assert.AreEqual("im frozen", result.First().Label);
                Assert.AreEqual(1, result.Count());
            }
        }

        [TestMethod]
        public void GetAllActiveCodesTest ()
        {
            using (var context = new TestContext())
            {
                var codeList = new CodeList();
                var secondCodeList = new CodeList();

                context.CodeLists.Add(codeList);
                context.CodeLists.Add(secondCodeList);

                context.SaveChanges();

                var codeInSecondList = new CodeItem();

                codeInSecondList.CodeListID = secondCodeList.CodeListID;

                context.CodeItems.Add(codeInSecondList);

                context.SaveChanges();

                var frozenCode = new CodeItem();
                var activeCode = new CodeItem();

                frozenCode.CodeListID = codeList.CodeListID;
                frozenCode.Label = "im frozen";
                activeCode.CodeListID = codeList.CodeListID;
                activeCode.Label = "im active";
                frozenCode.IsCodeFrozen = true;

                context.CodeItems.Add(frozenCode);
                context.CodeItems.Add(activeCode);

                context.SaveChanges();

                var target = new CodeItemRepository<TestContext>(context);

                var result = target.GetAllActiveCodes(codeList.CodeListID);

                Assert.AreEqual("im active", result.First().Label);
                Assert.AreEqual(1, result.Count());
            }
        }

        [TestMethod]
        public void GetAllWithParameterCodeListIDTest()
        {
            using (var context = new TestContext())
            {
                var codeList = new CodeList();
                var secondCodeList = new CodeList();

                context.CodeLists.Add(codeList);
                context.CodeLists.Add(secondCodeList);

                context.SaveChanges();

                var codeInSecondList = new CodeItem();

                codeInSecondList.CodeListID = secondCodeList.CodeListID;

                context.CodeItems.Add(codeInSecondList);

                context.SaveChanges();

                var frozenCode = new CodeItem();
                var activeCode = new CodeItem();

                frozenCode.CodeListID = codeList.CodeListID;
                frozenCode.Label = "im frozen";
                frozenCode.IsCodeFrozen = true;
                activeCode.CodeListID = codeList.CodeListID;
                activeCode.Label = "im active";

                context.CodeItems.Add(frozenCode);
                context.CodeItems.Add(activeCode);

                context.SaveChanges();

                var target = new CodeItemRepository<TestContext>(context);

                var result = target.GetAll(codeList.CodeListID);

                Assert.AreEqual(2, result.Count());
            }
        }
    }
}
