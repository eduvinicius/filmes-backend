﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDTO
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
        public required string Genero { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "A duração deve ter de 70 a 600 minutos")]
        public int Duracao { get; set; }
    }
}
