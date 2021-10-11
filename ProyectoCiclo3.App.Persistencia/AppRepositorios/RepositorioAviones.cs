using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        
        private readonly AppContext _appContext = new AppContext(); 
    
        public IEnumerable<Aviones> GetAll()
        {
             return _appContext.Aviones;
        }

          public Aviones GetAvionesWithId(int id){
             return _appContext.Aviones.Find(id);
    
        } 
      
        
        public Aviones Create(Aviones newAvion)
        {
        var addAvion = _appContext.Aviones.Add(newAvion);
         _appContext.SaveChanges();
        return addAvion.Entity;
        }

  public void Delete(int id)
    {
    var avion = _appContext.Aviones.Find(id);
    if (avion == null)
        return;
    _appContext.Aviones.Remove(avion);
    _appContext.SaveChanges();
    }
            public Aviones Update(Aviones newAvion){
            var avion = _appContext.Aviones.Find(newAvion.id);
            if(avion != null){
                avion.Marca = newAvion.Marca;
                avion.Modelo = newAvion.Modelo;
                avion.NumeroAsiento = newAvion.NumeroAsiento;
                avion.NumeroBanos = newAvion.NumeroBanos;
                avion.CapacidadMax = newAvion.CapacidadMax;
                        //Guardar en base de datos
            _appContext.SaveChanges();
            }
        return avion;
        }

  
    }

}
