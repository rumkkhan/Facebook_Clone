using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest<int>
        {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }  
        public string Category { get; set; }
        public DateTime Date { get; set; } 
        public string City { get; set; }  
        public string Venue { get; set; }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly DataContext _ctx;
            private IMapper  _mapper;
            public Handler(DataContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                   var result = _mapper.Map<Command,Activity>(request);
                //    var result = new Activity(){
                //         Title = request.Title,
                //         Description = request.Description,
                //         Date = request.Date,
                //         Venue = request.Venue,
                //         City = request.City,
                //         Category = request.Category
                //    };
                    await _ctx.AddAsync(result);
                   var  success =  await _ctx.SaveChangesAsync();
                   if(success > 0)
                            return success;

                             throw new Exception("Some went wroing");
            }
        }
    }
}