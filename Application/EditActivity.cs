using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application
{
    public class EditActivity
    {

        public class Command : IRequest<Unit>
        {
            public required ActivityRequestDTO ActivityDTO { get; set; }

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.ActivityDTO.Id);
                activity.Title = request.ActivityDTO.Title ?? activity.Title;
                //TODO :fix activityDTO.Description is nullable 
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }

    }
}