﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsExemplos.BandoDados;
using WindowsFormsExemplos.Forms.Modelos;

namespace WindowsFormsExemplos.Repositorios
{
    internal class PedidoRepositorio
    {
        private BancoDadosConexao bancoDadosConexao;

        public PedidoRepositorio()
        {
            bancoDadosConexao = new BancoDadosConexao();
        }

        internal int CriarOrcamento(Pedido pedido)
        {
            var comando = bancoDadosConexao.Conectar();
            comando.CommandText = @"INSERT INTO pedidos (id_cliente, status) 
                OUTPUT INSERTED.ID
                VALUES (@ID_CLIENTE, @STATUS)";
            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@STATUS", pedido.Status);

            var idPedido = Convert.ToInt32(comando.ExecuteScalar());

            return idPedido;
        }
    }
}