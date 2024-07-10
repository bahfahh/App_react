using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Persistence;
namespace Application
{
    public class DeleteActivity
    {
        public class Command : IRequest<Unit>
        {
            public Guid Id { get; set; }
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
                System.Diagnostics.Debug.WriteLine($"Handling delete activity request for ID: {request.Id}");
                System.Diagnostics.Debug.WriteLine($"delete .....doing");
                System.Console.WriteLine(request.Id);
                var activity = await _context.Activities.FindAsync(request.Id);
                _context.Remove(activity);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}