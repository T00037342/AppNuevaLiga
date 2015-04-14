using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppLaNuevaLiga.Modelo;

namespace AppLaNuevaLiga.Datos
{
    public class PersonajeRepositories
    {
        private static List<Personaje> people = new List<Personaje>();
        private static List<Caraterizacion> data = new List<Caraterizacion>();

        Caraterizacion datos = new Caraterizacion("Nombre del Heroe o Villano","Heroe o Villano","Nombre real del personage(Identidad Secreta)",
            "Dedicasuon u ofisio","Lugar De Orogen","Sexo(genero)","Habilidades","Dabilidades","Armas","Personalidad");

        public PersonajeRepositories()
        {
            data.Add(datos);
        }

        public IEnumerable<Personaje> getPersonaje()
        {
            Humanos perso1 = new Humanos("Add", " Liga", "Enemigo", " Tecnologia", "Traje");
            Aliens perso2 = new Aliens("Add", " Liga", "Enemigo","Raza","Planeta","superHabilidadesNaturales","TecnologiaAliens");
            Artificiales perso3 = new Artificiales("Add", " Liga", "Enemigo", "Material Del Que Esta Costruido", "Tipo(Humanoide o Saibor)");
            SuperHumanos perso4 = new SuperHumanos("Add", " Liga", "Enemigo", "Habilidad Sobrenatural");

            people.Add(perso1);
            people.Add(perso2);
            people.Add(perso3);
            people.Add(perso4);

            return people;
        }

        public void AddCaraterizacion(Caraterizacion C) 
        {
            data.Add(C);
        }

        public IEnumerable<Caraterizacion> getData() 
        {
            return data;   
        }

    }  
}