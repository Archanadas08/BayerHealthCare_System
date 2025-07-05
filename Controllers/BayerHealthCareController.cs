using BayerHealthCare_System.MessageContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Runtime;

namespace BayerHealthCare_System.Controllers
{
    [ApiController]
    [Route("/appointment")]
    public class BayerHealthCareController : ControllerBase
    { 
        private readonly ILogger<BayerHealthCareController> _logger;
        private readonly IMongoClient _client;
        private readonly MongoDbSettings _settings;

        public BayerHealthCareController(ILogger<BayerHealthCareController> logger, IMongoClient client, IOptions<MongoDbSettings> settings)
        {
            _logger = logger;
            _client = client;
            _settings = settings.Value;
            _logger.LogInformation("DatabaseName: {DatabaseName}", _settings.DatabaseName);
        }
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<appointment>> GetCombined()
        {
            var appointmentDb = _client.GetDatabase(_settings.DatabaseName);

            var appointmentCollection = appointmentDb.GetCollection<appointment>("appointment");

            var patient = await appointmentCollection.Find(_ => true).FirstOrDefaultAsync();

            return Ok(patient);
        }
    }
}
