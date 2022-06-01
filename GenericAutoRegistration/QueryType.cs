namespace GenericAutoRegistration
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetResponse())
                .Type<ResponseType<IntType>>();
        }
    }
}
