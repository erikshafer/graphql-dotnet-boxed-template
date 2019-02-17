namespace graphql_dotnet_boxed_template.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using graphql_dotnet_boxed_template.Models;

    public interface IHumanRepository
    {
        IObservable<Human> WhenHumanCreated { get; }

        Task<Human> AddHuman(Human human, CancellationToken cancellationToken);

        Task<List<Character>> GetFriends(Human human, CancellationToken cancellationToken);

        Task<Human> GetHuman(Guid id, CancellationToken cancellationToken);
    }
}
