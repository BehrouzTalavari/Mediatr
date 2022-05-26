using DemoLibrary.Models;

using MediatR;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonalModel>>;

    //public class GetPersonListQueryClass : IRequest<List<PersonalModel>>
    //{

    //}

}
