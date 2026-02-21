using FootStore.Domain.Models;

namespace FootStore.Application.Requests
{
    public class GetProducRequest
    {
        public IEnumerable<Guid>? Ids { get; set; }
        public IEnumerable<string>? Names { get; set; }
        public PageFilterRequest PageFilter { get; set; }

        public GetProducRequest()
        {
            PageFilter = new PageFilterRequest
            {
                Page = 1,
                PageSize = 60
            };
        }
    }
}