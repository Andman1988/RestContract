﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Codeworx.Rest.Client;
using Codeworx.Rest.UnitTests.Api.Contract;
using Codeworx.Rest.UnitTests.Model;

namespace Codeworx.Rest.UnitTests.Dao
{
    public class PathDao : RestClient<IPathController>, IPathController
    {
        public PathDao(RestOptions options)
            : base(options)
        {
        }

        public Task<bool> EmptyPathWithoutParameters()
        {
            return CallAsync(c => c.EmptyPathWithoutParameters());
        }

        public Task<bool> EmptyPathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.EmptyPathWithQueryParameters(text, number, id, date));
        }

        public Task<bool> EmptyPathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.EmptyPathWithUrlParameters(text, number, id, date));
        }

        public Task<bool> EmptyPathWithBodyParameter(Item item)
        {
            return CallAsync(c => c.EmptyPathWithBodyParameter(item));
        }

        public Task<bool> EmptyPathWithAllParameters(
            Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl)
        {
            return CallAsync(c => c.EmptyPathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }

        public Task<bool> SimplePathWithoutParameters()
        {
            return CallAsync(c => c.SimplePathWithoutParameters());
        }

        public Task<bool> SimplePathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.SimplePathWithQueryParameters(text, number, id, date));
        }

        public Task<bool> SimplePathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.SimplePathWithUrlParameters(text, number, id, date));
        }

        public Task<bool> SimplePathWithBodyParameter(Item item)
        {
            return CallAsync(c => c.SimplePathWithBodyParameter(item));
        }

        public Task<bool> SimplePathWithAllParameters(
            Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl)
        {
            return CallAsync(c => c.SimplePathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }

        public Task<bool> ComplexPathWithoutParameters()
        {
            return CallAsync(c => c.ComplexPathWithoutParameters());
        }

        public Task<bool> ComplexPathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.ComplexPathWithQueryParameters(text, number, id, date));
        }

        public Task<bool> ComplexPathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date)
        {
            return CallAsync(c => c.ComplexPathWithUrlParameters(text, number, id, date));
        }

        public Task<bool> ComplexPathWithBodyParameter(Item item)
        {
            return CallAsync(c => c.ComplexPathWithBodyParameter(item));
        }

        public Task<bool> ComplexPathWithAllParameters(
            Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl)
        {
            return CallAsync(c => c.ComplexPathWithAllParameters(itemBody, textQuery, numberQuery, idQuery, dateQuery, textUrl, numberUrl, idUrl, dateUrl));
        }
    }
}