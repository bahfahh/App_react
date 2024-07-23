using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Persistence;
using Domain;
namespace Application
{
    public class CreatActivity
    {
        public class Command : IRequest<Unit> // 這邊mediatir版本不同 不回傳值要這樣寫
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
                _context.Activities.Add(request.ActivityDTO);  // 注意這裡應該是同步方法
                 await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}