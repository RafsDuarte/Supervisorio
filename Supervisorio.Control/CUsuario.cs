using Supervisorio.Web;
using Supervisorio.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervisorio.Control
{
    public class CUsuario : IDisposable

    {
        RepositoryUsuario _Repository;

        public CUsuario()
        {
            _Repository = new RepositoryUsuario();
        }

        public void Incluir(USUARIO oUsuario)
        {
            _Repository.Incluir(oUsuario);
        }

        public void Alterar(USUARIO oUsuario, bool attach = true)
        {
            _Repository.Alterar(oUsuario, attach);
        }

        public void Excluir(USUARIO oUsuario)
        {
            _Repository.Excluir(oUsuario);
        }

        public List<USUARIO> SelecionarTodos(string usuario)
        {
            return _Repository.SelecionarTodos(usuario);
        }

        public USUARIO Selecionar(int ID)
        {
            return _Repository.Selecionar(ID);
        }

        public USUARIO SelecionarID(int ID)
        {
            return _Repository.SelecionarID(ID);
        }

        public USUARIO SelecionarNome(string Nome)
        {
            return _Repository.SelecionarNome(Nome);
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}
