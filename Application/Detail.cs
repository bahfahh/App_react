using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application
{
    public class Detail
    {
        public class Query : IRequest<ActivityRequestDTO>
        {
            public Guid Id { get; set; }

        }
        public class Handler : IRequestHandler<Query, ActivityRequestDTO>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<ActivityRequestDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.FindAsync(request.Id);
            }
        }
    }
}