#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace ValidacionEnvioFormularios.Models;

public class Usuario{
    [Required(ErrorMessage="Por favor proporciona este dato!")]
    [MinLength(4, ErrorMessage = "El nombre debe tener al menos 4 caracteres")]
    public string Nombre {get;set;}

    [Required(ErrorMessage="Por favor proporciona este dato!")]
    [MinLength(4, ErrorMessage = "El Apellido debe tener al menos 4 caracteres")]
    public string Apellido {get;set;}

    [Required(ErrorMessage="Por favor proporciona este dato!")]
    [Range(0, Int32.MaxValue, ErrorMessage ="Se requiere un número positivo")]
    public int Edad {get;set;}

    [Required(ErrorMessage="Por favor proporciona este dato!")]
    [EmailAddress(ErrorMessage = "Por favor proporciona un correo válido")]
    public string Email {get; set;}

    [Required(ErrorMessage="Por favor proporciona este dato!")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "El password debe tener al menos 8 caracteres")]
    public string Password {get;set;}
}