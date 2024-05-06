

namespace ChuBank.Kernel.Domain.Model.Entities
{
    public class Entity<TId> : IEquatable<Entity<TId>>, IEntity
    {
        public TId Id { get; set; }

        public bool Equals(Entity<TId> other)
        {
            if (other == null) return false;

            if (other.Id.Equals(default(TId)) && Id.Equals(default(TId)))
                return ReferenceEquals(this, other);

            return GetType() == other.GetType() && Id.Equals(other.Id);
        }

        public override bool Equals(object obj) => Equals(obj as Entity<TId>);

        public override int GetHashCode() => Id.GetHashCode();

        public Entity<TId> Clone() => (Entity<TId>)MemberwiseClone();

        public override string ToString() => Id.ToString();
    }
}
