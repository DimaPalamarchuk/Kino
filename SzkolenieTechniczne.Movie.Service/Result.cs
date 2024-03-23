﻿using FluentValidation.Results;
using System.Security.Cryptography.X509Certificates;

namespace SzkolenieTechniczne.Movie.Service
{
    public class Result
    {
        private Result(bool isSuccess, string message, IEnumerable<Error> errors)
        {
            IsSuccess = isSuccess;
            IsFailure = IsFailure;
            Message = message;
            Errors = errors;
        }

        public string Message { get; }
        public bool IsSuccess { get; }
        public bool IsFailure { get; }
        public IEnumerable<Error> Errors { get; }

        public static Result Fail(string message)
            => new Result(false, message, Enumerable.Empty<Error>());
        public static Result Fail(ValidationResult validationResult)
            => new Result(
                false,
                string.Join(", ", validationResult.Errors.Select(x => x.ErrorMessage)),
                validationResult.Errors.Select(x => new Error(x.PropertyName, x.ErrorMessage))
        );

        public static Result Ok()
            => new Result(true, "", Enumerable.Empty<Error>());

        public class Error
        {
            public Error(string propertyName, string message)
            {
                PropertyName = propertyName;
                Message = message;
            }

            public string PropertyName { get; }
            public string Message { get; }
        }

    }
}