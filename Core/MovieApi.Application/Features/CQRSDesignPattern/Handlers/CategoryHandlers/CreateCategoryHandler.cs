using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand request)
        {
            await _context.Categories.AddAsync(new Category
            {
                CategoryName = request.CategoryName
            });
        }
    }
}
