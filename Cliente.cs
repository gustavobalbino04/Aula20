namespace Aula20
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public Cliente(string _nome, string _enderecoatual){
            this.Nome = _nome;
            this.EnderecoAtual = _enderecoatual;
        }
    }
}