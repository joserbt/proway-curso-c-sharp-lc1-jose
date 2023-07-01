using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BandoDados;
using WindowsFormsExemplos.Forms.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio
    {

        private BancoDadosConexao bancoDadosConexao;

        //construtor é executado quando ocorre um new da classe, ou seja,
        //new ProdutoRepositorio() irá executar o construtar
        public ProdutoRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }

        public void Cadastrar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"INSERT INTO produtos (nome, preco_unitario, quantidade) VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(Produto produto)
        {
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"UPDATE produtos SET
nome = @NOME,
preco_unitario = @PRECO_UNITARIO,
quantidade = @QUANTIDADE
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", produto.PrecoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            comando.Parameters.AddWithValue("@ID", produto.Id);

            comando.ExecuteNonQuery();
        }

        public void Apagar(int id)
        {
            var comando = bancoDadosConexao.Conectar();
            //definir o comando
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            //executar o comando
            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodos(string pesquisa)
        {
            var produtos = new List<Produto>();
            var comando = bancoDadosConexao.Conectar();

            //executar o comando do SELECT
            comando.CommandText = "SELECT * FROM produtos WHERE nome LIKE @PESQUISA";
            comando.Parameters.AddWithValue("@PESQUISA", $"%{pesquisa}%");

            //criar a tabela em memoria para carregar os registros da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //criar a lista de produtos com os produos do banco de dados
            for(int i = 0;i <tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o registro (consultado da tabela de produtos) da tabela em memoria
                var registro = tabelaEmMemoria.Rows[i];

                var produto = ConstruirProdutoDoRegistro(registro);

                //adicionar o produto na lista de produtos
                produtos.Add(produto);
            }
            //retornar s lista de produtos (com os registros da tabela de produtos (banco de dados))
            return produtos;
        }

        public Produto ObterPorId(int id)
        {
            //instaciando um objeto da classe banco de dados
            var bancoDadosConexao = new BancoDadosConexao();
            //abrir a conexao com banco de dados
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = "SELECT * FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            //cria tabela em memoria para carregar o registro
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //pegar o primeiro registro da consulta
            var linha = tabelaEmMemoria.Rows[0];

            var produto = ConstruirProdutoDoRegistro(linha);

            //retornar o objeto do produto preenchido com os dados do registro consultado
            return produto;
        }

        private static Produto ConstruirProdutoDoRegistro(DataRow linha)
        {

            //instaciar o objeto de produto
            var produto = new Produto();

            produto.Id = Convert.ToInt32(linha["id"]);
            produto.Nome = linha["nome"].ToString();
            produto.Quantidade = Convert.ToInt32(linha["quantidade"]);
            produto.PrecoUnitario = Convert.ToDecimal(linha["preco_unitario"]);

            return produto;
        }
    }
}
