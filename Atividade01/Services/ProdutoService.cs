using System.Text.Json;
using Atividade01.Models;

namespace Atividade01.Services
{
    public class ProdutoService
    {
        private string _caminho = "Data/Produtos.json";

        public void Salvar(List<Produto> produtos)
        {
            var json = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_caminho, json);

        }

        public List<Produto> Carregar()
        {
            if (!File.Exists(_caminho))
            {
                return new List<Produto>();
            }

            var json = File.ReadAllText(_caminho);
            return JsonSerializer.Deserialize<List<Produto>>(json) ?? new List<Produto>();
        }
    }
}