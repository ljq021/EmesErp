using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Hosting;
using Surging.Core.ApiGateWay;
using Surging.Core.CPlatform.Exceptions;
using Surging.Core.CPlatform.Messages;

namespace Emes.Gateway.Filter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public CustomExceptionFilterAttribute(
            IWebHostEnvironment hostingEnvironment,
            IModelMetadataProvider modelMetadataProvider)
        {
            _hostingEnvironment = hostingEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public override void OnException(ExceptionContext context)
        {
            //if (!_hostingEnvironment.IsDevelopment())
            //{
            //    return;
            //}
            var result = ServiceResult<object>.Create(false, errorMessage: context.Exception.Message);
            var ex = context.Exception.InnerException != null ? context.Exception.InnerException : context.Exception;
            if (ex is UserFriendlyException)
            {
                result.StatusCode = (int)StatusCode.UserFriendly;
            }
            else
            if (ex is BusinessException)
            {
                result.StatusCode = (int)StatusCode.BusinessError;
            }
            else
            if (ex is UnAuthenticationException)
            {
                result.StatusCode = (int)StatusCode.UnAuthentication;
            }
            else
            if (ex is UnAuthorizedException)
            {
                result.StatusCode = (int)StatusCode.UnAuthorized;
            }
            else
            if (ex is ValidateException)
            {
                result.StatusCode = (int)StatusCode.ValidateError;
            }
            else
            {
                result.StatusCode = (int)StatusCode.BusinessError;
            }      
            
            context.Result = new JsonResult(result);
        }
    }
}
