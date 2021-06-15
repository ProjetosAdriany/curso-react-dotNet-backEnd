namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    // Record: garante imutabilidade | A propriedade so pode ser alterada no construtor
    public record EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; set; }

        public string RoleName { get; init; }

    }
}
