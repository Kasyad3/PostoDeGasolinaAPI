namespace PostoDeGasolinaAPI
{
    public static class BancoDeDados
    {
        public static List<Combustivel> Combustiveis = new List<Combustivel>()
        {
            new Combustivel
            {
                CodigoDoProduto = 1,
                Descricao = "Gasolina Comum",
                PrecoLitro = 5.99
            },
            new Combustivel
            {
                CodigoDoProduto = 2,
                Descricao = "Etanol Comum",
                PrecoLitro = 3.99
            },
            new Combustivel
            {
                CodigoDoProduto = 3,
                Descricao = "Diesel",
                PrecoLitro = 6.99
            }
        };

        public static List<Compra> Compras = new List<Compra>();

    }
}
