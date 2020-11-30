using System;
using IBLL;
using MatildeRibokela.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatildeRibokela.Teste
{
    [TestClass]
    public class ProcessoBLLTeste
    {
        [TestMethod]
        public void List()
        {
            IProcessoBLL processoBLL = new ProcessoBLL();
            var Lista = processoBLL.List(null);
            Assert.AreNotEqual(null, Lista);
        }
    }
}
