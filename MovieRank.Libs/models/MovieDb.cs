using System;
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2.DataModel;

namespace MovieRank.Libs.models
{
    [DynamoDBTable("MovieRank")]
    public class MovieDb
    {
        public int UserId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }

        public List<string> Actors { get; set; }

        public int Ranking { get; set; }

        public string RankedDateTime { get; set; }
    }
}
