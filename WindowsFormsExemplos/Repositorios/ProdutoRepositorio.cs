using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BandoDados;

namespace WindowsFormsExemplos.Repositorios
{
    public class ProdutoRepositorio
    {
        public void Cadastrar(string nome, decimal precoUnitario, int quantidade)
        {
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            comando.CommandText = @"INSERT INTO produtos (nome, preco_unitario, quantidade) VALUES (@NOME, @PRECO_UNITARIO, @QUANTIDADE);";

            comando.Parameters.AddWithValue("@NOME", nome);
            comando.Parameters.AddWithValue("@PRECO_UNITARIO", precoUnitario);
            comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

            comando.ExecuteNonQuery();
        }

        public void Editar(string nome, decimal precoUnitario, int quantidade, int id)
        {

        }

        public void Apagar(int id)
        {
            //abrir a conexao
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();
            //definir o comando
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            //executar o comando
            comando.ExecuteNonQuery();
        }

        public List<Produto> ObterTodos()
        {
            var produtos = new List<Produto>();
            //conexao
            var bancoDadosConexao = new BancoDadosConexao();
            var comando = bancoDadosConexao.Conectar();

            //executar o comando do SELECT
            comando.CommandText = "SELECT * FROM produtos";

            //criar a tabela em memoria para carregar os registros da tabela de produtos
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //criar a lista de produtos com os produos do banco de dados
            for(int i = 0;i <tabelaEmMemoria.Rows.Count; i++)
            {
                //obter o registro (consultado da tabela de produtos) da tabela em memoria
                var registro = tabelaEmMemoria.Rows[i];

                //intanciar um pbjeto de calsse produto
                var produto = new Produto();

                //preencher as propriedades do objetos do produto
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.Quantidade = Convert.ToInt32(registro["quantidade"]);
                produto.PrecoUnitario = Convert.ToDecimal(registro["preco_unitario"]);

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

            //instaciar o objeto de produto
            var produto = new Produto();

            produto.Id= Convert.ToInt32(linha["id"]);
            produto.Nome = linha["nome"].ToString();
            produto.Quantidade = Convert.ToInt32(linha["quantidade"]);
            produto.PrecoUnitario = Convert.ToDecimal(linha["preco_unitario"]);

            //retornar o objeto do produto preenchido com os dados do registro consultado
            return produto;
        }

        public class Produto
        {
            public int Id { get; set; }

            public string Nome { get; set; }

            public decimal PrecoUnitario { get; set; }

            public int Quantidade { get; set; }
        }
    }
}
