namespace Fundamentos.OriantaçãoObjetos
{
    internal class FolhaPagamento
    {
        //propriedades
        public string NomeColaborador;
        public double ValorHora;
        public int QuantidadeHoras;

        private const double AliquotaInss14Porcento = 0.14;
        private const double AliquotaInss12Porcento = 0.12;
        private const double AliquotaInss9Porcento = 0.09;
        private const double AliquotaInss7meioPorcento = 0.075;

        public double CalcularSalarioBruto()
        {
            double salarioBruto = ValorHora * QuantidadeHoras;

            return salarioBruto;
        }

        public double CalcularInss()
        {
            double salarioBruto = CalcularSalarioBruto();
            double aliquota = ObterAliquota(salarioBruto);

            return salarioBruto * aliquota;
        }

        private double ObterAliquota(double salarioBruto)
        {
            if (salarioBruto <= 1320)
            {
                return AliquotaInss7meioPorcento;
            }

            if (salarioBruto <= 2571)
            {
                return AliquotaInss9Porcento;
            }

            if (salarioBruto <= 3856)
            {
                return AliquotaInss12Porcento;
            }

            return AliquotaInss14Porcento;
        }
    }
}
