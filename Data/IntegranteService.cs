using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using ChurchApp.Data;




namespace ChurchApp.Data
{


    public class IntegranteService
    {
     
     private AplicacionDbContext DbContext;

     public  IntegranteService(AplicacionDbContext dbContext)
     {
         this.DbContext = dbContext;

     }
     public async Task <List<Modelo>> GetModelosAsync()
     {
         return await DbContext.Integrantes.ToListAsync();

     }
     public async Task <Modelo> AddIntegranteAsync(Modelo modelo)
     {
         try
         {
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
             var integranteExist = DbContext.Integrantes.FirstOrDefault(p=> p.IntegranteId == modelo.IntegranteId);
             if (integranteExist! = null)
             {
                 DbContext.Integrantes.Add(modelo);
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
