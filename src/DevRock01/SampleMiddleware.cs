using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System;
using System.Threading.Tasks;

namespace DevRock01
{
	public class SampleMiddleware
	{
		private readonly RequestDelegate next;
		public SampleMiddleware(RequestDelegate next)
		{
			this.next = next;
		}
		public Task Invoke(HttpContext context)
		{
			context.Response.Headers.Append("PowerBy", "MVC");
			return this.next.Invoke(context);
		}
	}
}