namespace Aula20
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public Restaurante (string _nomerestaurante, string _endereco){
            NomeRestaurante = _nomerestaurante;
            Endereco = _endereco;
        }
        
    }
}