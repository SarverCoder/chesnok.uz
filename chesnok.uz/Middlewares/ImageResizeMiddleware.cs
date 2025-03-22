namespace chesnok.uz.Middlewares
{
    public class ImageResizeMiddleware(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/StaticFiles"))
            {
                
            }



            await next(context);
        }

        
    }
}
