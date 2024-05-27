using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDTO
    {
        public required string Titulo { get; set; }

        public required string Genero { get; set; }

        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
    }
}
