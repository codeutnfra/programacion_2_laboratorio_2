namespace BLL
{
    public abstract class BaseDAO
    {
        protected string connectionString;

        public BaseDAO()
        {
            connectionString = "Server=.;Database=CATALOGO_SERIES;Trusted_Connection=True;";
        }
    }
}
