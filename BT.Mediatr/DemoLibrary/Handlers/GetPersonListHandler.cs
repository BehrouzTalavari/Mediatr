using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;

using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonalModel>>
    {
        private readonly IDataAccess data;

        public GetPersonListHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<List<PersonalModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.GetPeople());
        }
    }
}
