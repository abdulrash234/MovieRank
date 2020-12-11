using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2.Model;
using MovieRank.Contracts;
using MovieRank.Libs.models;

namespace MovieRank.Libs.Mappers
{
    public class Mapper:IMapper
    {
        public IEnumerable<MovieResponse> ToMovieContract(IEnumerable<MovieDb> items)
        {
            return items.Select(ToMovieContract);
        }
    }
}
