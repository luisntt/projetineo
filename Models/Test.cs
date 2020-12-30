using System.ComponentModel.DataAnnotations.Schema;

namespace projetineo.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}