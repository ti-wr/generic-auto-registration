using GenericAutoRegistration;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddGenericAutoRegistrationTypes()
    .AddQueryType();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
