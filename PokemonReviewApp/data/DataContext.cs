using Microsoft.EntityFrameworkCore;

namespace PokemonReviewApp.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
