namespace proyectoEF.Model;


public class Tarea 
{
    public Guid TareaId { get; set; } 
    public Guid CategoriaId { get; set; } 
    public string Titulo { get; set; }
    public String  Descripcion { get; set; }
    
    public Prioridad Prioridad { get; set; }
    
    public DateTime FechaCreacion { get; set; }

    public virtual Categoria Categoria { get; set; }
}

public enum Prioridad
{
    Baja,
    Madia,
    Alta
}
