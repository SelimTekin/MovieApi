using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieHandler
    {
        private readonly MovieContext _context;

        public CreateMovieHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(CreateMovieCommand request)
        {
            await _context.Movies.AddAsync(new Movie
            {
                CoverImageUrl = request.CoverImageUrl,
                CreatedYear = request.CreatedYear,
                Description = request.Description,
                Duration = request.Duration,
                Rating = request.Rating,
                ReleaseDate = request.ReleaseDate,
                Status = request.Status,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
