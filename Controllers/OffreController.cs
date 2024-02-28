using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceOffre.DAO;
using ServiceOffre.Entities;

namespace ServiceOffre.Controllers
{
    [Route("Offres")]
    [ApiController]
    public class OffreController : ControllerBase
    {

        //injection du repository 
        private readonly OffreRepository _offreRepository;

        public OffreController(OffreRepository OffreRepository) 
        {
            _offreRepository = OffreRepository;
        }

        [HttpGet]
        public async Task<ObjectResult> GetAll()
        {
            try
            {
                var allOffers = await _offreRepository.GetAllOffers();
                return Ok(allOffers); //200   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{Id}")]
        public async Task<ObjectResult> GetById(int Id)
        {
            try
            {
                var offer = await _offreRepository.GetOfferById(Id);
                return Ok(offer); //200   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<ObjectResult> SaveOffer([FromBody] Offre offre)
        {
            try
            {
                 await _offreRepository.SaveOffer(offre);
                return Ok(true); //200   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{Id}")]
        public async Task<ObjectResult> DeleteOffer(int Id)
        {
            try
            {
                await _offreRepository.DeleteOffer(Id);
                return Ok(true); //200   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
