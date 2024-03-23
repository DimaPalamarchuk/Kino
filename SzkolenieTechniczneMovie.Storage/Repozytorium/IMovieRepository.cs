using System;
using System.Collections.Generic;
using SzkolenieTechniczneMovie.Storage.Common;
using System.Text;
using SzkolenieTechniczneMovie.Storage.Catalog;

namespace SzkolenieTechniczneMovie.Storage.Repozytorium
{
    internal interface IMovieRepository
    {
        List<Catalog.Movie> GetMovies();
        Catalog.Movie GetMovieById(long movieId);

        void AddMovie(Catalog.Movie movie);
        void EditMovie(Catalog.Movie movie);
        bool MovieExist(long movieId);

        bool IsMovieExist(long movieId);
        bool IsSeanceExist(DateTime date);

        void AddSeance(Catalog.Seance seance);
        List<Seance> GetSeancesByMovieId(long MovieId);
        Catalog.Movie GetSeanceDetails(long MovieId);

    }
}
