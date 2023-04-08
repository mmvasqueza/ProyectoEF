namespace proyectoEF.Model;


public class Categoria 
{
    public Guid CategoriaId { get; set; } 
    public string Nombre { get; set; }
    public String  Descripcion { get; set; }
    /*Esto es una coleccion que obtiene la tareas asociadas a la categoria*/
    public virtual ICollection<Tarea> Tareas{ get; set; }
}
