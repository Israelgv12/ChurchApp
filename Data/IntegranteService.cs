using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using System.IO;




namespace ChurchApp.Data
{


    public class IntegranteService
    {
     
     private AplicacionDbContext DbContext;

     private readonly IWebHostEnvironment webHostEnvironment;  

     public  IntegranteService(AplicacionDbContext dbContext,IWebHostEnvironment Environment)
     {
         this.DbContext = dbContext;

         this.webHostEnvironment = Environment;

     }
     public async Task <List<Modelo>> GetModelosAsync()
     {
         return await DbContext.Integrantes.ToListAsync();

     }
     public async Task <Modelo> AddIntegranteAsync(Modelo modelo, IFileListEntry file)
     {
        try
        {
            var path = Path.Combine(webHostEnvironment.ContentRootPath, "./wwwroot/Images", file.Name);
            var streamwiter = new MemoryStream();
            await file.Data.CopyToAsync(streamwiter);
            FileStream files = new FileStream(path, FileMode.Create, FileAccess.Write);
            {
                streamwiter.WriteTo(files);
                    modelo.Foto = path.Substring(path.LastIndexOf("Images"));
            }
            DbContext.Integrantes.Add(modelo);
                await DbContext.SaveChangesAsync();
        }
        catch(Exception)
        {       
           throw;
        }
        return modelo;

     }
     public async Task<Modelo> UpdateIntegranteAsync(Modelo modelo)
     {
         try
         {
             var integranteExist = DbContext.Integrantes.FirstOrDefault(p => p.IntegranteId == modelo.IntegranteId);
             if (integranteExist != null)
             {
                 DbContext.Integrantes.Update(modelo);
                 await DbContext.SaveChangesAsync();

             }
         }
         catch(Exception)
         {
             throw;

         }
         return modelo;

     }
     public async Task DeleteIntegranteAsync(Modelo modelo)
     {
         try
         {
             DbContext.Integrantes.Remove(modelo);
             await DbContext.SaveChangesAsync();

         }
         catch(Exception)
         {
             throw;

         }

     }     
    }
}