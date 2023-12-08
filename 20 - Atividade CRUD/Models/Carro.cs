using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _20___Atividade_CRUD.Models
{
    [Table("Carros")]

    public class Carro
    {
        [Key] //Falando para o BD que este atributo será uma chave

        public int CarroId { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do carro")]

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Usado { get; set; }
    }
}