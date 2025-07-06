using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieWeb_Repo;
using MovieWeb_BO;
using System.Collections.Generic;
using System.Linq;
using MovieWeb_BO.Entities;
using System.Threading.Tasks;

public class Director_MovieModel : PageModel
{
    private readonly IMovieRepo _movieRepo;
    private readonly IDirectorRepo _directorRepo;

    public Director_MovieModel(IMovieRepo movieRepo, IDirectorRepo directorRepo)
    {
        _movieRepo = movieRepo;
        _directorRepo = directorRepo;
    }

    public List<MovieViewModel> Movies { get; set; }
    public List<Director> Directors { get; set; }

    [BindProperty(SupportsGet = true)]
    public int? directorId { get; set; }


    public async Task OnGetAsync()
    {
        Directors = await _directorRepo.GetListDirectorFunc();
        List<Movie> movies;
        if (directorId.HasValue)
        {
            movies = await _movieRepo.GetListMovieByDirectorFunc(directorId.Value);
        }
        else
        {
            movies = await _movieRepo.GetListMovieFunc();
        }
        Movies = movies.Select(m => new MovieViewModel
        {
            Title = m.Title,
            ReleaseDate = m.ReleaseDate,
            Description = m.Description,
            Language = m.Language,
            DirectorName = m.Director?.FullName ?? Directors.FirstOrDefault(d => d.Id == m.DirectorId)?.FullName,
            Stars = m.Stars.Select(s => s.FullName).ToList()
        }).ToList();
    }

    public class MovieViewModel
    {
        public string Title { get; set; }
        public DateOnly? ReleaseDate { get; set; }
        public string? Description { get; set; }
        public string Language { get; set; }
        public string DirectorName { get; set; }
        public List<string> Stars { get; set; }
    }
} 