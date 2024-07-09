using System.Diagnostics;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Application
{
    public class ActivitiesList
    {
        public class Query : IRequest<List<ActivityRequestDTO>> { };

        public class Handler : IRequestHandler<Query, List<ActivityRequestDTO>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<ActivityRequestDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
               return await _context.Activities.ToListAsync();
            }
            
        }
        }


    }
