namespace SuperHero.Domains
{
    public record SuperHeroDomain
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = String.Empty;
        public string FirstName { get; init; } = String.Empty;
        public string LastName { get; init; } = String.Empty;
        public string Place { get; init; } = String.Empty;
        public DateTimeOffset CreatedCate { get; init; }
    }
}