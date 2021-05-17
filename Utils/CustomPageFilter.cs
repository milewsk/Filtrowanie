using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtrowanie.Utils
{
    public class CustomPageFilter : IAsyncPageFilter
    {
        public CustomPageFilter()
        {

        }


        public async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {

            await Task.CompletedTask;
        }


        public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {

            await next.Invoke();
        }

    }
       
}
