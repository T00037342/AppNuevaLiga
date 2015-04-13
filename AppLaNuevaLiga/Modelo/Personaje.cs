using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public abstract class Personaje
    {
        #region "Atributos"
        public Caraterizacion nombreSuper;//Nombre del super heroe o villano
        public Caraterizacion tipoPersonaje;//Heroe o villano
        public Caraterizacion identidadSecreta;//Nombre del personage en sociedad
        public Caraterizacion trabajo;//Trabajo en la sociedad
        public Caraterizacion lugarDeOrogen;//lugar de origen
        public Caraterizacion sexo;//genero

        public string add;//Este método recibirá por parámetro un tipo de caracterización
        public string liga;//Es un  étodo que adiciona a la liga o grupo que pertenece el personaje
        public string enemigo;//Nombre del enemigo
        #endregion

        #region "Propiedades"
        public string Add
        {
            get { return add; }
            set { add = value; }
        }
        public string Liga
        {
            get { return liga; }
            set { liga = value; }
        }
        public string Enemigo
        {
            get { return enemigo; }
            set { enemigo = value; }
        }
        #endregion

        #region "Costructores" 
        public Personaje() 
        {
            this.nombreSuper = new Caraterizacion();
            this.tipoPersonaje = new Caraterizacion();
            this.identidadSecreta = new Caraterizacion();
            this.trabajo = new Caraterizacion();
            this.lugarDeOrogen = new Caraterizacion();
            this.sexo = new Caraterizacion();
            this.add = "Tipo de caraterisacion";
            this.liga="Liga del personage";
            this.enemigo = "Enenigo del personage";
        }

        public Personaje(string add, string liga, string enemigo)
        {
            this.nombreSuper = new Caraterizacion();
            this.tipoPersonaje = new Caraterizacion();
            this.identidadSecreta = new Caraterizacion();
            this.trabajo = new Caraterizacion();
            this.lugarDeOrogen = new Caraterizacion();
            this.sexo = new Caraterizacion();
            this.add = add;
            this.liga = liga;
            this.enemigo = enemigo;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Nombre del Personaje:  " + this.nombreSuper + "\n" +
                     "Heroe o Villano: " + this.tipoPersonaje + "\n" +
                     "Identidad Secrete" + this.identidadSecreta + "\n" +
                     "Luagar de Origen: " + this.lugarDeOrogen + "\n" +
                     "Sexo Del personaje: " + this.sexo;
        }

        public override bool Equals(object obj)
        {
            Personaje P = (Personaje)obj;
            bool result = false;

            if ((this.nombreSuper == P.nombreSuper) &&
                (this.tipoPersonaje == P.tipoPersonaje) &&
                (this.identidadSecreta == P.identidadSecreta) &&
                (this.lugarDeOrogen == P.lugarDeOrogen) &&
                (this.sexo == P.sexo))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion

        #region "Metodos Abstracto"

        public abstract string Ifichas();
        #endregion
    }
}