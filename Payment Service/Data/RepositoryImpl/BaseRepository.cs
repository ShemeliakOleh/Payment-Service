namespace Payment_Service.Data.RepositoryImpl
{
    public class BaseRepository
    {
        public ApplicationDbContext db { get; set; }

        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            this.db = applicationDbContext;
        }
    }
}
