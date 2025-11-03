namespace AuthenticationAndAuthorization.Domain.Entities
{
    public class UserCreds
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime EmailEnteredTime { get; set; }
        public DateTime? PasswordSetTime { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool SoftDeleted { get; set; }
        public Guid? DeletedBy { get; set; } = Guid.Empty;

    }
}
