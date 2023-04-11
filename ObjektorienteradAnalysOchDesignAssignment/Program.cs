using ObjektorienteradAnalysOchDesignAssignment.Repositories;
using ObjektorienteradAnalysOchDesignAssignment.Services;
using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<ArticleRepository>();
builder.Services.AddScoped<AuthorRepository>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ContentTypeRepository>();
builder.Services.AddScoped<AuthorArticleRowRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
