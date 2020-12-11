using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieRank.Contracts;
using MovieRank.Libs.models;

namespace MovieRank.Libs.Repositories
{
    public interface IMovieRankRepository
    {
        Task<IEnumerable<MovieDb>> GetAllItems();
    }
}
