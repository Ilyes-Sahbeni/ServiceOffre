using Microsoft.EntityFrameworkCore;
using ServiceOffre.Entities;

namespace ServiceOffre.DAO
{
    public class OffreRepository
    {
        //injection du db context 
        private readonly ServiceOffreDbContext _context;
        public OffreRepository(ServiceOffreDbContext context)
        {
            _context = context;
        }

        public async Task<List<Offre>> GetAllOffers()
        {
            try
            {
                return await _context.Offre.ToListAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Offre?> GetOfferById(int Id)
        {
            try
            {
                return await  _context.Offre.FirstOrDefaultAsync(offre=>offre.Id ==Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SaveOffer(Offre offre)
        {
            try
            {
                await _context.Offre.AddAsync(offre);
                await _context.SaveChangesAsync();//applicquer les changement au bd

            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task DeleteOffer(int Id)
        {
            try
            {
                Offre? offreToDelete = await GetOfferById(Id);//utiliser la fonction deja developé

                if(offreToDelete is not null)
                {
                    _context.Offre.Remove(offreToDelete);
                    await _context.SaveChangesAsync();//applicquer les changement au bd

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
