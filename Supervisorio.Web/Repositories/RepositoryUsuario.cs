using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supervisorio.Web.Repositories
{

    public class RepositoryUsuario : IDisposable
    {
        private UsinaEntities odb;
        private readonly bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryUsuario()
        {
            odb = Helper.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryUsuario(UsinaEntities obd)
        {
            obd = odb;
        }

        // ok
        public USUARIO SelecionarNome(string Nome)
        {
            return (from p in odb.USUARIO where p.Nome.Equals(Nome) select p).FirstOrDefault();
        }

        public USUARIO SelecionarID(int ID)
        {
            return (from p in odb.USUARIO where p.ID == ID select p).FirstOrDefault();
        }

        public USUARIO Selecionar(int ID)
        {
            return (from p in odb.USUARIO where p.ID == ID select p).FirstOrDefault();
        }

        public USUARIO Selecionar(int? ID)
        {
            return (from p in odb.USUARIO where p.ID == ID select p).FirstOrDefault();
        }
        // ok
        public List<USUARIO> SelecionarTodos(string USUARIO)
        {
            if (USUARIO.Trim() == "")
            {
                return (from p in odb.USUARIO orderby p.Nome select p).ToList();
            }
            else
            {
                return (from p in odb.USUARIO where p.Nome.Contains(USUARIO) select p).ToList();
            }
        }

        public void Incluir(USUARIO oUsuario)
        {

            UsinaEntities db = new UsinaEntities();
            odb.USUARIO.Add(oUsuario);
            odb.SaveChanges();
        }

        public List<USUARIO> SelecionarTodosUSUARIOs()
        {
            return odb.USUARIO.OrderBy(p => p.Nome).ToList();
        }

        public void Alterar(USUARIO oUsuario, bool attach = true)
        {
            if (attach)
            {
                odb.Entry(oUsuario).State = System.Data.Entity.EntityState.Modified;
            }
            odb.SaveChanges();
        }

        public void Excluir(USUARIO oUsuario)
        {
            odb.USUARIO.Attach(oUsuario);
            odb.USUARIO.Remove(oUsuario);
            odb.SaveChanges();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}