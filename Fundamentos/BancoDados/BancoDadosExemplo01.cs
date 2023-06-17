using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.BancoDados
{
    internal class BancoDadosExemplo01 : Executor
    {
        public override void Executar()
        {
            /*CRUD 
             * CREATE: INSERT INTO nome_tabela (colunas) VAULES (valores)
             * Read SELECT COLUNAS FROM nome_tabelas
             * UPDATE: UPDATE nome_tabela SET
             *          nome_coluna = valor_coluna
             *          WHERE id = id_desejado
             * DELETE: DELETE FROM nome_tabela WHERE id = id_desejado
             */

            //CriarRegistro();
            //ApagarRegistro();
            //AtualizarRegistro();
            ConsultarRegistro();
        }

        private const string CadeiaConexaoBancoDados = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\73343\Source\Repos\proway-curso-c-sharp-lc1-jose\WindowsFormsExemplos\BandoDados\WindowsFormsBancosDados.mdf;Integrated Security=True";
        private void ConsultarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, categoria FROM jogos";

            //criar uma tabela em memória para armazenar os dados da consulta
            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];
                var id = Convert.ToInt32(linha["id"]);
                var nome = linha["nome"].ToString();
                var categoria = linha["categoria"].ToString();
                Console.WriteLine($"id: {id} nome: {nome} categoria: {categoria}");
            }
        }

        private void AtualizarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE jogos SET nome = 'god of war 1' WHERE id = 1";
            comando.ExecuteNonQuery();
        }

        private void ApagarRegistro()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoBancoDados;
            conexao.Open();

            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM jogos WHERE id = 2";
            comando.ExecuteNonQuery();
        }

        private static void CriarRegistro()
        {
            var conexao = new SqlConnection();

            //connectioString nada mais é doq que o caminho do banco, assim como
            //caso necessário login, senha entre outros
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\73343\Desktop\bancoDados.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            Console.WriteLine("conectou!");

            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO jogos (nome, categoria) VALUES ('god of war', 'RPG')";
            comando.ExecuteNonQuery();

            Console.WriteLine("Registro criado com sucesso!");
        }
    }
}
