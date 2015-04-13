using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public class Humanos : Personaje
    {
        #region "Atributos"
        private string tecnologia;
        private string traje;
        #endregion

        #region "Propiedades"
        public string Tecnologia
        {
            get { return tecnologia; }
            set { tecnologia = value; }
        }
        public string Traje
        {
            get { return traje; }
            set { traje = value; }
        }
        #endregion

        #region "Costructor"
        public Humanos() 
            :base()
        {
            this.tecnologia = "Armas";
            this.traje = "Traje";
        }

        public Humanos(string add, string liga, string enemigo, string tecnologia, string traje)
            : base(add, liga, enemigo)
        {

            this.tecnologia = tecnologia;
            this.traje = traje;
        }
        #endregion 

        #region "Metodos Abstracto"
        public override string Ifichas ()
        {
            return "Add: " + this.add + "\n" + 
                   "Liga: "+this.liga + "\n" +
                   "Enemigo: "+this.enemigo;
        }

        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "Tecnologia:  " + this.tecnologia + "\n" +
                   "Traje: " + this.traje;
        }

        public override bool Equals(object obj)
        {
            Humanos H = (Humanos)obj;
            bool result = false;

            if ((this.tecnologia == H.tecnologia) &&
                (this.traje == H.traje))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}