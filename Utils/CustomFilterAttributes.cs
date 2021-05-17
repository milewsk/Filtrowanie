using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace Filtrowanie.Utils
{
    public class CustomFilterAttributes : ResultFilterAttribute
    {


        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var Adres = context.HttpContext.Connection.RemoteIpAddress;


            var User = context.HttpContext.User.Identities;
            // var adresik  = context.HttpContext.Connection.RemoteIpAddress.AddressFamily;

            var ff = System.Net.Dns.GetHostEntry(Adres).HostName;

            var IP_loop = System.Net.IPAddress.Loopback;

            var Adres_IP = System.Net.Dns.GetHostEntry(Adres).AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

            string dd = Adres_IP.ToString();

            var result = context.Result;

            if (result is PageResult)
            {
                var page = ((PageResult)result);
                page.ViewData["filterMessage"] = $"Hej {ff}  Adres IP: {dd}";
            }

            await next.Invoke();
        }
    }
}
