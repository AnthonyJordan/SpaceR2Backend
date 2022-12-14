namespace SpaceR2Backend.DAOs
{
    public class DAO
    {

        private readonly IConfiguration _config;
        protected HttpClient _httpClient;
        public DAO(IConfiguration configuration, HttpClient httpClient)
        {

            _config = configuration;
            _httpClient = httpClient;
  
        }
    }
}
