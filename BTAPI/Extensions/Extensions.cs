using Stocks.Domain.Helpers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Stocks.API.Extensions
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, int currentPage, int recordsPerPage, int totalRecords, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, recordsPerPage, totalRecords, totalPages);
            var formattedPagHeader = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, formattedPagHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }

        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
