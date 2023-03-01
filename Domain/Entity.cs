namespace IWanteApp.Domain;

public abstract class Entity
{

//gera um novo Id sempre que guid for instanciado
public Entity()
{
    Id = Guid.NewGuid();
}

public Guid Id { get; set; }
public string Name { get; set; }
public string CreatedBy { get; set; }
public DateTime CreatedOn { get; set; }
public string EditedBy { get; set; } 
public DateTime EditedOn { get; set; }
}