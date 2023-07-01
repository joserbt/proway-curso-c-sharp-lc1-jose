using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.Forms.Modelos;
using WindowsFormsExemplos.Repositorios;
using static WindowsFormsExemplos.Repositorios.ProdutoRepositorio;

namespace WindowsFormsExemplos.Servicos
{
    public class ProdutoServico
    {
        private ProdutoRepositorio produtoRepositorio;

        //construtor
        public ProdutoServico()
        {
            //instanciando o objeto da classe ProdutoRepositorio    
            produtoRepositorio = new ProdutoRepositorio();
        }
        //CRUD
        public void Cadastrar(Produto produto)
        {
            produtoRepositorio.Cadastrar(produto);
        }

        public List<Produto> ObterTodos(string pesquisa)
        {
            var produtos = produtoRepositorio.ObterTodos(pesquisa);

            //retornar a lista de produtos
            return produtos;
        }

        public void Apagar(int id)
        {
            
            //chamar o método Apagar do ProdutoRepositorio(que ira executar o DELETE)
            produtoRepositorio.Apagar(id);
        }

        public Produto ObterPorId(int id)
        {
            var produto = produtoRepositorio.ObterPorId(id);
            return produto;
        }

        internal void Editar(Produto produto)
        {
            produtoRepositorio.Editar(produto);
        }
    }
}
