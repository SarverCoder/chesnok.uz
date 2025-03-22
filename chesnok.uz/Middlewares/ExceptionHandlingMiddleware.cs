using System.Text.Json;

namespace chesnok.uz.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ExceptionHandlingMiddleware>();
        }


        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred.");
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(JsonSerializer.Serialize(new
                {
                    error = "Something went wrong!"
                }));

            }
        }

    }
}
