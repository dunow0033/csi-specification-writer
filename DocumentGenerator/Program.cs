using DocumentGenerator.Helpers.DropdownOptions.Implementations;
using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service;
using DocumentGenerator.Service.Implementations;
using DocumentGenerator.Service.Implementations.Step1;
using DocumentGenerator.Service.Implementations.Step2;
using DocumentGenerator.Service.Implementations.Step3;
using DocumentGenerator.Service.Implementations.Step4;
using DocumentGenerator.Service.Implementations.Step5;
using DocumentGenerator.Service.Implementations.Step6;
using DocumentGenerator.Service.Implementations.Step7;
using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using DocumentGenerator.Service.Interfaces.Step2;
using DocumentGenerator.Service.Interfaces.Step3;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Interfaces.Step5;
using DocumentGenerator.Service.Interfaces.Step6;
using DocumentGenerator.Service.Interfaces.Step7;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IExcel, Excel>();

builder.Services.AddScoped<IStep1, Step1>();
builder.Services.AddScoped<IProjectInformation, ProjectInformation>();
builder.Services.AddScoped<IArchitectInformation, ArchitectInformation>();
builder.Services.AddScoped<IGpsDistributor, GpsDistributor>();


builder.Services.AddScoped<IGet, Get>();



builder.Services.AddScoped<IStep2, Step2>();
builder.Services.AddScoped<IBasketballStructure, BasketballStructure>();
builder.Services.AddScoped<IBasketballAccessories, BasketballAccessories>();
builder.Services.AddScoped<IStep2DropdownOptions, Step2DropdownOptions>();
builder.Services.AddScoped<IStep2DropdownMapping, Step2DropdownMapping>();

builder.Services.AddScoped<IStep3, Step3>();
builder.Services.AddScoped<ICurtainModel, CurtainModel>();
builder.Services.AddScoped<IDividerCurtain, DividerCurtain>();
builder.Services.AddScoped<ICurtainAccessories, CurtainAccessories>();
builder.Services.AddScoped<IStep3DropdownOptions, Step3DropdownOptions>();
builder.Services.AddScoped<IStep3DropdownMapping, Step3DropdownMapping>();

builder.Services.AddScoped<IStep4, Step4>();
builder.Services.AddScoped<IBattingMultisportThrowCagesModel, BattingMultisportThrowCagesModel>();
builder.Services.AddScoped<IBattingMultisportThrowCages, BattingMultisportThrowCages>();
builder.Services.AddScoped<IBattingMultisportThrowCagesAccessories, BattingMultisportThrowCagesAccessories>();
builder.Services.AddScoped<IStep4DropdownOptions, Step4DropdownOptions>();
builder.Services.AddScoped<IStep4DropdownMapping, Step4DropdownMapping>();

builder.Services.AddScoped<IStep5, Step5>();
builder.Services.AddScoped<IProtectivePadding, ProtectivePadding>();
builder.Services.AddScoped<IProtectivePaddingAccessories, ProtectivePaddingAccessories>();
builder.Services.AddScoped<IStep5DropdownOptions, Step5DropdownOptions>();
builder.Services.AddScoped<IStep5DropdownMapping, Step5DropdownMapping>();

builder.Services.AddScoped<IStep6, Step6>();
builder.Services.AddScoped<IVolleyballEquipment, VolleyballEquipment>();
builder.Services.AddScoped<IVolleyballEquipmentAccessories, VolleyballEquipmentAccessories>();
builder.Services.AddScoped<IStep6DropdownOptions, Step6DropdownOptions>();
builder.Services.AddScoped<IStep6DropdownMapping, Step6DropdownMapping>();

builder.Services.AddScoped<IStep7, Step7>();
builder.Services.AddScoped<IMatStorageSystems, MatStorageSystems>();
builder.Services.AddScoped<IMatStorageAccessories, MatStorageAccessories>();
builder.Services.AddScoped<IStep7DropdownOptions, Step7DropdownOptions>();
builder.Services.AddScoped<IStep7DropdownMapping, Step7DropdownMapping>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Step1}/{action=Index}/{id?}");

app.Run();

