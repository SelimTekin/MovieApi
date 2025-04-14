using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;
        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }
        // CancellationToken is used to cancel the request if needed. For example , if the user navigates away from the page before the request is completed or if the request takes too long to complete.
        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            await _context.Casts.AddAsync(new Cast
            {
                Biography = request.Biography,
                Imageurl = request.Imageurl,
                Name = request.Name,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
