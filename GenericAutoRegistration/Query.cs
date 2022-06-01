namespace GenericAutoRegistration
{
    public class Query
    {
        public Response GetResponse()
        {
            return new Response
            {
                Status = "OK",
                Payload = 123
            };
        }
    }
}
