using NonProfitManager.Models;

namespace NonProfitManager.Data
{
    public interface INonNonProfitManagerSeeder
    {
        public void Seed();
    }

    public class NonProfitManagerSeeder : INonNonProfitManagerSeeder
    {
        private readonly NonProfitManagerDbContext _dbContext;

        public NonProfitManagerSeeder(NonProfitManagerDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Organizations.Any())
                {
                    _dbContext.Organizations.Add(new Organization()
                    {
                        Name = "LabRescue",
                        Email = "lab.rescue.adopcje@gmail.com",
                        KRS = "0000855434",
                        NIP = "5213905199",
                        REGON = "38683545800000",
                        Street = "Puławska",
                        BuildingNumber = "158/164",
                        ApartmentNumber = "7",
                        AreaCode = "02-670",
                        City = "Warszawa",
                        Animals = new List<Animal>() {}
                    });

                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Roles.Any())
                {
                    _dbContext.Roles.AddRange(
                        new Role()
                        {
                            Name = "Admin",
                        },
                        new Role()
                        {
                            Name = "User"
                        }
                    );

                    _dbContext.SaveChanges();
                }
            }
        }
    }
}
