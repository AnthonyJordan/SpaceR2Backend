namespace SpaceR2Backend.DAOs
{
    public class DAO
    {

        private readonly IConfiguration _config;
        public DAO(IConfiguration configuration)
        {

            _config = configuration;
  
        }
        protected string LoadConnectionString(string id = "Default")
        {
            return _config["ConnectionStrings:" + id];
        }
    }
}
