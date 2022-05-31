namespace servidor_banco_de_dados;

public class Filme
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Sinopse { get; set; }
    public string Rating { get; set; }


    public static List<Filme> ObterLista()
    {
        var filmes = new List<Filme>();
        for (int i=0;i<100;i++)
        {
            filmes.Add(new Filme()
            {
                Id = i+1,
                Nome = $"Filme de Cadastro {i+1}",
                Rating = "10.0",
                Sinopse = $"Sinopse de Cadastro {i+1}"
            });
        }

        return filmes;
    }
}