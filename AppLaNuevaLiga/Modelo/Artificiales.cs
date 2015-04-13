using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public class Artificiales : Personaje
    {
        #region "Atributos"
        private string matarial;//Matarial del Cual esta contruido
        private string tipo;//Humanoide o Androide
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Matarial
        {
            get { return matarial; }
            set { matarial = value; }
        }
        #endregion

        #region "Costructor"
        public Artificiales()
        :base()
        {
            this.matarial="Material Del Que Esta Costruido";
            this.tipo = "Tipo(Humanoide o Saibor)";
        }
        public Artificiales(string add, string liga, string enemigo, string matarial, string tipo)
            : base(add, liga, enemigo)
        {
            this.matarial = matarial;
            this.tipo = tipo;
        }
        #endregion


        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "Material:  " + this.matarial + "\n" +
                   "Tipo: " + this.tipo;
        }

        public override bool Equals(object obj)
        {
            Artificiales A = (Artificiales)obj;
            bool result = false;

            if ((this.matarial == A.matarial) &&
                (this.tipo == A.tipo))

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