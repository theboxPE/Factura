using System.ComponentModel.DataAnnotations;

public class Factura
{
    public string Id { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha es obligatoria.")]
    public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El código del cliente es obligatorio.")]
    public string CodigoCliente { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    public string NombreCliente { get; set; } = string.Empty;

    public List<Articulo> Articulos { get; set; } = new List<Articulo>();

    [Required(ErrorMessage = "El total a pagar es obligatorio.")]
    public decimal TotalPagar { get; set; }

    [Required(ErrorMessage = "El comentario es obligatorio.")]
    public string Comentario { get; set; } = string.Empty;
}

public class Articulo
{
    [Required(ErrorMessage = "El nombre del artículo es obligatorio.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La cantidad del artículo es obligatoria.")]
    public int Cantidad { get; set; }
    
    [Required(ErrorMessage = "El precio del artículo es obligatorio.")]
    public decimal Precio { get; set; }
    public decimal Total { get { return Cantidad * Precio; } }
}






 