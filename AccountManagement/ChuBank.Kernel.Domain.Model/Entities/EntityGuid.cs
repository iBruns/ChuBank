
namespace ChuBank.Kernel.Domain.Model.Entities
{
    public class EntityGuid : Entity<Guid>
    {

        public EntityGuid() 
        { 
            if(Id.Equals(Guid.Empty))
            {
                Id = Guid.NewGuid();
            }
        }
    }
}
