namespace Fundamentos.Herancas
{
    //conta corrente herda as propriedades e metodos da classe "Conta"
    public class ContaCorrente : Conta
    {
        public decimal SaldoChequeEspecial { get; set; }

        //o override é uma sobre escrita do metodo obter extrato, ou seja, mudamos o comportamento do metodo da classe pai
        public override string ObterExtrato()
        {
            //obtém o extrato da ckasse pai Conta
            //base e´ultilizado para chamar metodos de classes pai, avô
            var extratoPai = base.ObterExtrato();
            var extratoFilho = $"\nSaldo cheque especial: {SaldoChequeEspecial}"; 

            //retorna o extrato da classe pai Conta + extrato da conta corrente
            return $"{extratoPai}/n {extratoFilho}";
        }
    }
}