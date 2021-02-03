using Microsoft.EntityFrameworkCore;
using RegistroPrestamosBlazor2.DAL;
using RegistroPrestamosBlazor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RegistroPrestamosBlazor2.BLL
{
    public class PersonasBLL
    {
        private Contexto contexto;
        public PersonasBLL(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<bool> Existe(int id)
        {
            bool paso = false;
            try
            {
                paso = await contexto.Personas.AnyAsync(p => p.PersonaId == id);
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public async Task<bool> Guardar(Personas persona)
        {
            if (!await Existe(persona.PersonaId))
                return await Insertar(persona);
            else
                return await Modificar(persona);
        }

        private async Task<bool> Insertar(Personas persona)
        {
            bool paso = false;

            try
            {
                await contexto.Personas.AddAsync(persona);
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }
        private async Task<bool> Modificar(Personas persona)
        {
            bool paso = false;

            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
                paso = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }
        public async Task<Personas> Buscar(int id)
        {
            Personas persona;

            try
            {
                persona = await contexto.Personas.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

            return persona;
        }
        public async Task<bool> Eliminar(int id)
        {
            bool borrar = false;

            try
            {
                var registros = await contexto.Personas.FindAsync(id);
                if (registros != null)
                {
                    contexto.Personas.Remove(registros);
                    borrar = await contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return borrar;
        }
        public async Task<List<Personas>> GetPersonas()
        {
            List<Personas> lista = new List<Personas>();

            try
            {
                lista = await contexto.Personas.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
        public async Task<List<Personas>> GetPersonas(Expression<Func<Personas, bool>> criterio)
        {
            List<Personas> lista = new List<Personas>();

            try
            {
                lista = await contexto.Personas.Where(criterio).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
