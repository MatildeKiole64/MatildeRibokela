using System;
using MatildeRibokela.DAL;
using DTO;
using MatildeRibokela.IDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using DAL;

namespace MatildeRibokela.Teste
{
    [TestClass()]
    public class ArguidoDALTeste
    {
    
        [TestMethod()]
        public void CreateTeste()
        {
            ArguidoDTO arguidoDTO = new ArguidoDTO()
            {
                Id = Guid.NewGuid(),
                Contacto1 = 912345678,
                Contacto2 = 923456789,
                Idade = 53,
                Nome = "Jane Doe",
                ProcessoId = Guid.NewGuid(),
                ResidenciaHabitual = "No Where"
            };
            IArguidoDAL arguidoDAL = new ArguidoDAL();
            Guid actual = arguidoDAL.Create(arguidoDTO);
            Guid expected = Guid.Empty;
            Assert.AreNotEqual(expected,actual);
        }
    }
}
