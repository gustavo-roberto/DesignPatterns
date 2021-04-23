namespace Monostate
{
    public class Arquivo
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double TamanhoEmMb { get; set; }

        public Arquivo(string nome, string tipo, double tamanho)
        {
            Nome = nome;
            Tipo = tipo;
            TamanhoEmMb = tamanho;
        }
    }
}
