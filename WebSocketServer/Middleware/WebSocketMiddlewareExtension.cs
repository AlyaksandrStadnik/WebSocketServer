﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebSocketServer.Middleware
{
	public static class WebSocketMiddlewareExtensions
	{
		public static IApplicationBuilder UseWebSocketServer(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<WebSocketServerMiddleware>();
		}

		public static IServiceCollection AddWebSocketManager(this IServiceCollection services)
		{
			services.AddSingleton<WebSocketServerConnectionManager>();
			return services;
		}
	}
}
