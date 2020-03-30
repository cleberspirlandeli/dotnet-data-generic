using dotnet_core_mvc.Models;
using dotnet_core_mvc.Models.Config;

namespace dotnet_core_mvc.Repository
{
    public class FundoCapitalRepository : GenericRepository<FundoCapital>
    {
        public FundoCapitalRepository(ContextBase context) : base(context) { }


    }
}
