﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using MovieRank.Contracts;
using MovieRank.Libs.models;

namespace MovieRank.Libs.Repositories
{
    public class MovieRankRepository:IMovieRankRepository
    {
        private readonly IDynamoDBContext _context;


        public MovieRankRepository(IAmazonDynamoDB dynamoDbClient)
        {
            _context = new DynamoDBContext(dynamoDbClient);
        }

        public async Task<IEnumerable<MovieDb>> GetAllItems()
        {
            return await _context.ScanAsync<MovieDb>(new List<ScanCondition>()).GetRemainingAsync();
        }
    }
}
