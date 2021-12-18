namespace CovidAnalysis.API.Middlewares
{
    public class RequestValidatorMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestValidatorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                var rapidApiRequestHeader = context.Request.Headers["X-RapidAPI-Proxy-Secret"];
                if (rapidApiRequestHeader == Microsoft.Extensions.Primitives.StringValues.Empty
                    || rapidApiRequestHeader.ToString() != "a8d9f390-6032-11ec-8b58-19b72c84d741")
                    throw new Exception("Authorized Request");

                await _next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsJsonAsync(new { ErrorMessage = ex.Message });
            }
        }
    }
}
