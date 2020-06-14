using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Edit
    {
        public class EditCommand : IRequest<int>
        {
            public Guid guid { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime? Date { get; set; }
            public string City { get; set; }
            public string Venue { get; set; }
        }
        public class Handler : IRequestHandler<EditCommand, int>
        {
            private readonly DataContext _ctx;
            private readonly IMapper _mapper;
            public Handler(DataContext ctx, IMapper mapper)
            {
                _mapper = mapper;
                _ctx = ctx;

            }

            public async Task<int> Handle(EditCommand request, CancellationToken cancellationToken)
            {
                var activity = await _ctx.Activities.FindAsync(request.guid);

                if (activity == null)
                    throw new Exception("Bad request");

               // var updatedActivity = _mapper.Map<Activity,Command>(Command);
               activity.Title = request.Title ?? activity.Title;
               activity.Category = request.Category ?? activity.Category;
               activity.City = request.City ?? activity.City;
               activity.Venue = request.Venue ?? activity.Venue;
               activity.Description = request.Description ?? activity.Description;
               activity.Date = request.Date ?? activity.Date;

               _ctx.Activities.Update(activity);
               return await _ctx.SaveChangesAsync();
                
            }
        }
    }

}