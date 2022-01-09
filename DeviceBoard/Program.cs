
using DeviceBoard.Data;
using DeviceBoard.Interfaces;
using DeviceBoard.Mutation;
using DeviceBoard.Query;
using DeviceBoard.Schema;
using DeviceBoard.Services;
using DeviceBoard.Type;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder =  WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IDevice, DeviceService>();
builder.Services.AddTransient<DeviceType>();
builder.Services.AddTransient<DeviceQuery>();
builder.Services.AddTransient<DeviceMutation>();
builder.Services.AddTransient<ISchema, DeviceSchema>();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = false;
}).AddSystemTextJson();

builder.Services.AddDbContext<GraphQLDbContext>(options => options.UseSqlServer(@"Data Source= (localdb)\MSSQLLocalDB;Initial Catalog=GraphQLDb;Integrated Security = True"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();
app.Run();
