namespace dazz
{
    public class HeadersMiddleware
    {
        private readonly RequestDelegate next;

        public HeadersMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.OnStarting(() =>
            {
                //context.Request.Headers.Append("Referrer-Policy", "no-referrer");
                //context.Response.Headers.Add("Accept", "application/json");
                //context.Response.Headers.Append("Content-Type", "application/json");
                context.Response.Headers.Append("Referrer-Policy", "no-referrer");
                context.Response.Headers.Append("Content-Security-Policy", "script-src 'self' 'nonce-oi6sy5eTR53rg72J4XUR1w==' ");
                return Task.CompletedTask;
            });

            await next(context);
        }
    }
}
