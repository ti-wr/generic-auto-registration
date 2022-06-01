namespace GenericAutoRegistration
{
    public class ResponseType<T> : ObjectType<Response>
        where T : class, IOutputType
    {
        protected override void Configure(
            IObjectTypeDescriptor<Response> descriptor)
        {
            descriptor.Field(f => f.Status);

            descriptor
                .Field(f => f.Payload)
                .Type<T>();
        }
    }
}
