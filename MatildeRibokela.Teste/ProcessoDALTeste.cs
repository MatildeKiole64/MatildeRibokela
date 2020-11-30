using System;
using DTO;
using MatildeRibokela.DAL;
using MatildeRibokela.IDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatildeRibokela.Teste
{
    [TestClass]
    public class ProcessoDALTeste
    {
        [TestMethod]
        public void CreateTeste()
        {
            ProcessoDTO processoDTO = new ProcessoDTO()
            {
                Id = Guid.NewGuid(),
                CircunstPrisao = (ProcessoDTO.TipoP)1,
                DataApresentacaoMinistPub = DateTime.Now.ToUniversalTime(),
                DataDetencao = DateTime.Now.ToUniversalTime(),
                DataRemissaoDist = DateTime.Now.ToUniversalTime(),
                LocalDetencao = "Rotunda do Tio Beto",
                Instrutor = "ALKiole",
                ManterPrisao = (ProcessoDTO.TipoM)1,
                NrProcesso = "20171456",
                NrRegisto = "20171246"
            };
            IProcessoDAL processoDAL = new ProcessoDAL();
            Guid actual = processoDAL.Create(processoDTO);
            Guid expected = Guid.Empty;
            Assert.AreNotEqual(expected, actual);
        }
    }
}
