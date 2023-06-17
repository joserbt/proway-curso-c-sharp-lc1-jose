using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Repositorios;
using static WindowsFormsExemplos.Repositorios.ProdutoRepositorio;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico
    {
        //CRUD
        public void Cadastrar(string nome, decimal precoUntario, int quantidade)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Cadastrar(nome, precoUntario, quantidade);
        }

        public List<Produto> ObterTodos(string pesquisa)
        {
            //obter a lista de produtos da tabela de produtos
            var produtoRepositorio = new ProdutoRepositorio();
            var produtos = produtoRepositorio.ObterTodos();
            //retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            //instancioanando um objeto de class ProdutoRepositorio
            var produtoRepositorio = new ProdutoRepositorio();
            
            //chamar o método Apagar do ProdutoRepositorio(que ira executar o DELETE)
            produtoRepositorio.Apagar(id);
        }

        public Produto ObterPorId(int id)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            var produto = produtoRepositorio.ObterPorId(id);
            return produto;
        }

        internal void Editar(int idProdutoEditar, string nome, decimal precoUnitario, int quantidade)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Editar(idProdutoEditar, nome, precoUnitario, quantidade);
        }
    }
}
