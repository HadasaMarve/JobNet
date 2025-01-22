namespace JobNet.Middlewares
{
    public class ShabbosBlockingMiddleware
    {
        private readonly RequestDelegate _next;

        public ShabbosBlockingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (DateTime.UtcNow.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Access is forbidden on Saturdays.");
                return;
            }
            await _next(context);
        }
    }
}
