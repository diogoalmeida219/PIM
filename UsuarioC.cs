using CadCartas.Model;
using CadCartas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCartas
{
    public class UsuarioC
    {
        UsuarioDao usuario_dao;
        BancoM banco;

        public UsuarioC (string banco)
        {
            banco = new BancoM ();
            usuario_dao = new UsuarioDao(banco);
        }
        public void login (UsuarioM usuario)
        {
            
        }

        public void definir_banco(BancoM banco)
        {
            string aux;
            aux = banco.banco;
            usuario_dao = new UsuarioDao(aux);
        }

        public void inserir_usuario (UsuarioM usuario)
        {
            string aux;
            aux=banco.banco;
            usuario_dao = new UsuarioDao(aux);
            usuario_dao.create_usuario(usuario);
        }

        public void alterar_usuario (UsuarioM usuario)
        {
            //crud
        }

        public void ler_usuario (UsuarioM usuario)
        {
            //crud
        }

        public void excluir_usuario (UsuarioM usuario)
        {
            //crud
        }

    }
}
