using Demo.Context;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region EF_Core
            EnterPriseDbContext DbContext = new EnterPriseDbContext();
            //DbContext.Database.EnsureCreated();
            //DbContext.Database.Migrate();  //Apply Ups of All Migration{Not Apply}
            #endregion
        }
    }
}
