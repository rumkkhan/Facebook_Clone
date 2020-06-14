using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Delete
    {
        public class Command : IRequest<int>
        {
            public Guid Id {get;set;}
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly DataContext _ctx;
            public Handler(DataContext ctx)
            {
                _ctx = ctx;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                    var activity = await _ctx.Activities.FindAsync(request.Id);
                    if(activity == null)
                        throw new Exception("NOt found");

                        _ctx.Activities.Remove(activity);
                       return await _ctx.SaveChangesAsync();
            }
        }
    }
}