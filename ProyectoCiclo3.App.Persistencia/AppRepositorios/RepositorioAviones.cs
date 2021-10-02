using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> Aviones;
 
    public RepositorioAviones()
        {
    
            
                Aviones= new List<Aviones>()
            {
                new Aviones{id=1,Marca ="Virgi",Modelo= 2020,NumeroAsiento  = 4, NumeroBanos = 4, CapacidadMax =150},
                new Aviones{id=2,Marca ="Flay",Modelo= 2021,NumeroAsiento  = 16, NumeroBanos = 4, CapacidadMax =200},
                new Aviones{id=3,Marca ="Boing",Modelo= 2000,NumeroAsiento  = 24, NumeroBanos = 4, CapacidadMax =80}
            };
            
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return Aviones;
        }
 
        public Aviones GetAvionesWithId(int id){
            return Aviones.SingleOrDefault(b => b.id == id);
    
        }
            public Aviones Update(Aviones newAvion){
            var avion= Aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.Marca = newAvion.Marca;
                avion.Modelo = newAvion.Modelo;
                avion.NumeroAsiento = newAvion.NumeroAsiento;
                avion.NumeroBanos = newAvion.NumeroBanos;
                avion.CapacidadMax = newAvion.CapacidadMax;
            }
        return avion;
        }
    }

}
