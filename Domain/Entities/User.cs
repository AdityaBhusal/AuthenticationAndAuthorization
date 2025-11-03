namespace AuthenticationAndAuthorization.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address{ get; set; }
        public string? Bio { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool SoftDeleted { get; set; }
        public Guid DeletedBy { get; set; } = Guid.Empty;
    }
}
