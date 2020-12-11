using System;
using System.Collections.Generic;
using System.Text;
using MovieRank.Contracts;
using MovieRank.Libs.models;

namespace MovieRank.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> response);
    }
}
