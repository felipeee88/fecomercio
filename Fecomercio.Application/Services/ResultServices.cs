using FluentValidation.Results;

namespace Fecomercio.Application.Services
{
    public class ResultService
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public ICollection<ErrorValidation> Errors { get; set; }

        public static ResultService RequestError(string message, ValidationResult validationResult)
        {
            return new ResultService()
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation() { Field = x.PropertyName, Message = x.ErrorMessage}).ToList()
            };
        }

        public static ResultService<t> RequestError<t>(string message, ValidationResult validationResult)
        {
            return new ResultService<t>()
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrorValidation() { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }

        public static ResultService Fail(string message) => new ResultService() { IsSucess = false, Message = message };
       
        public static ResultService<t> Fail<t>(string message) => new ResultService<t>() { IsSucess = false, Message = message };

        public static ResultService Ok(string message) => new ResultService() { IsSucess = true, Message = message };

        public static ResultService<t> Ok<t>(t data) => new ResultService<t>() { IsSucess = true, Data = data };
    }

    public class ResultService<t>: ResultService
    {
        public t Data { get; set; }
    }
}
