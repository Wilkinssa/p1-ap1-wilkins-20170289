using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using p1_ap1_wilkins_20170289.DAL;
using p1_ap1_wilkins_20170289.Entidades;

namespace p1_ap1_wilkins_20170289.BLL
{
    public class AportesBLL
    {
        //guardar
        public static bool Guardar(Aportes aportes)
        {
            if (!Existe(aportes.AporteId))
                return Insertar(aportes);
            else
                return Modificar(aportes);
        }
        //insertar
        private static bool Insertar(Aportes aportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Aportes.Add(aportes);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        //modificar
        public static bool Modificar(Aportes aportes)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(aportes).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        //eliminar
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var aportes = contexto.Aportes.Find(id);
                if (aportes != null)
                {
                    contexto.Aportes.Remove(aportes);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
        //buscar
        public static Aportes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Aportes aportes;

            try
            {
                aportes = contexto.Aportes.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return aportes;
        }
        //getlist
        public static List<Aportes> GetList(Expression<Func<Aportes, bool>> criterio)
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Aportes.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
        //existe
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Aportes.Any(e => e.AporteId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        //get
        public static List<Aportes> GetEditoriales()
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Aportes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}