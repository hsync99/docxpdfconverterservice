using docxpdfconverterservice.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IConvertationService, ConvertationService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt9QHFqVkJrW05FcEBAXWFKblJ3T2ZQdVx2ZDU7a15RRnVfRVxiS31Wf0dlUXdfcg==;Mgo+DSMBPh8sVXJ2S0d+X1VPcUBDW3xLflF1VWJYdVt5fldAcDwsT3RfQF5jTn9SdEZmUH1YeH1QRA==;ORg4AjUWIQA/Gnt2V1hhQlJAfVhdXGVWfFN0RnNYflR1fV9EZkwxOX1dQl9gSXlSd0dgXHZcdn1URmI=;MjU2NTA5OUAzMjMyMmUzMDJlMzBPSWlZZWllWlZXNWhBMnUyalpHY1pHVDF0OHROWkVZZUJHMXFiZzQwZnc4PQ==;MjU2NTEwMEAzMjMyMmUzMDJlMzBZMlZGVUNRbVR1RDB0M3JwendoNWJ4cXlLcDdsNFVjOXpGN0pNVlZNN3JZPQ==;NRAiBiAaIQQuGjN/V0R+XU9HclRFQmJPYVF2R2BJfl96cVxMYlpBJAtUQF1hSn5Ud0RhWnpXcnJcTmJe;MjU2NTEwMkAzMjMyMmUzMDJlMzBDQ1FVVVhZRk1yalRHMEhuTGRLK3djQnRrRHlWUlI5VUhtRC9jQ1FqM3EwPQ==;MjU2NTEwM0AzMjMyMmUzMDJlMzBEODRHL1Y4ek5zeE9vcnl2NzV4ZXl5dFJlZlZWbjFtbFJTQk1RaUp4WmVvPQ==;Mgo+DSMBMAY9C3t2V1hhQlJAfVhdXGVWfFN0RnNYflR1fV9EZkwxOX1dQl9gSXlSd0dgXHZcd3RQQWI=;MjU2NTEwNUAzMjMyMmUzMDJlMzBWVzlHc0N4Zys1WXVLWGxSQzU1d3kzTlladjJKMXpUTHVsRWpVN0RxTjFnPQ==;MjU2NTEwNkAzMjMyMmUzMDJlMzBIdjZTejRpRXBRN3NjZFZIWGltTENxZThmdjJzQ2I5aHJIMVJCaVVzTnFzPQ==;MjU2NTEwN0AzMjMyMmUzMDJlMzBDQ1FVVVhZRk1yalRHMEhuTGRLK3djQnRrRHlWUlI5VUhtRC9jQ1FqM3EwPQ==");
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
