using System;
using RegistroPrestamosBlazor2.DAL;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public static class TestBLL
    {
        private static Contexto contexto;

        public static Contexto GetContexto()
        {
            if(contexto == null)
            {
                var options = new DbContextOpcionsBuilder<Contexto>()
                    .UseSqlServer("DefaultConnection").Options;
                contexto = new Contexto(options);
            }
            return contexto;
        }
    }
}
