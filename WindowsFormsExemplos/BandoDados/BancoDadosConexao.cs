using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExemplos.BandoDados
{
    public class BancoDadosConexao
    {
        public SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\73343\source\repos\proway-curso-c-sharp-lc1-jose\WindowsFormsExemplos\BandoDados\WindowsFormsBancosDados.mdf;Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();
            return comando;
        }
    }
}
