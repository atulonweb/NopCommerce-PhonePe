﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Payments.PhonePe.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PDT
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PhonePe.HandlePostBack", "Plugins/PaymentPhonePe/HandlePostBack",
                 new { controller = "PaymentPhonePe", action = "HandlePostBack"  });

            //IPN
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PhonePe.IPNHandler", "Plugins/PaymentPhonePe/IPNHandler",
                 new { controller = "PaymentPhonePe", action = "IPNHandler" });

            //Cancel
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.PhonePe.CancelOrder", "Plugins/PaymentPhonePe/CancelOrder",
                 new { controller = "PaymentPhonePe", action = "CancelOrder" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => -1;
    }
}