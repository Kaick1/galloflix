using System.ComponentModel.DataAnnotations;

namespace GalloFlix.Models;
public class Genre

{
    [Key] // é uma notação para chave primaria
    public byte Id { get; set; }

    // Requerido - Not Null, no banco; Torna o nome obrigatório

    [Required]
    [StringLength(30)] // Tamanho máximo da propriedade
    public string Name { get; set; }
}