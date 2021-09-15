using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}