using WebApplication1.Contexts;

namespace WebApplication1.Utils
{
    public class DatabaseSingleton
    {
        private DatabaseSingleton()
        {

        }

        private static AppDbContext _context;

        public static AppDbContext Context
        {
            get
            {
                //_context içerisinde herhangi bir instance mevcut mu? Eğer instance tanımlanmadıysa bir adet instance tanımlanacak.
                if(_context == null)
                {
                    _context = new AppDbContext();
                }

                return _context;
            }
        }

        //Singleton pattern

    }
}
