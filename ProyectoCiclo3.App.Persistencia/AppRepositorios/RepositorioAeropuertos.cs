using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> Aeropuertos;
 
    public RepositorioAeropuertos()
        {
          
            
                Aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,Nombre="Virgi",Ciudad= "Bogota",Pais  = "Colombia", CoordX = 4, Coordy =150},
                new Aeropuertos{id=2,Nombre="Flay",Ciudad= "Medellin",Pais  = "Colombia", CoordX = 4, Coordy =200},
                new Aeropuertos{id=3,Nombre="Boing",Ciudad= "Pereira",Pais  = "Colombia", CoordX = 4, Coordy =80}
            
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertosWithId(int id){
            return Aeropuertos.SingleOrDefault(b => b.id == id);
        }
    }
}
