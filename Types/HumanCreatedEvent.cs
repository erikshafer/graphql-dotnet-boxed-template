namespace graphql_dotnet_boxed_template.Types
{
    using graphql_dotnet_boxed_template.Repositories;

    public class HumanCreatedEvent : HumanObject
    {
        public HumanCreatedEvent(IHumanRepository humanRepository)
            : base(humanRepository)
        {
        }
    }
}
