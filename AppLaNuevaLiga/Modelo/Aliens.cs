using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public class Aliens : Personaje
    {
        #region "Atributos"
        private string raza;
        private string planeta;
        private string superHabilidadesNaturales;
        private string tecnologiaAliens;
        #endregion

        #region "Propiedades"
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public string Planeta
        {
            get { return planeta; }
            set { planeta = value; }
        }
        public string SuperHabilidadesNaturales
        {
            get { return superHabilidadesNaturales; }
            set { superHabilidadesNaturales = value; }
        }
        public string TecnologiaAliens
        {
            get { return tecnologiaAliens; }
            set { tecnologiaAliens = value; }
        }
        #endregion

        #region "Costructor"
        public Aliens() 
            :base()
        {
            this.raza = "Raza aliens";
            this.planeta = "Planeta de procedencia";
            this.superHabilidadesNaturales = "Poderes aliens";
            this.tecnologiaAliens = "Tecnologia Aliens";
        }

        public Aliens(string add, string liga, string enemigo, string raza, string planeta, string superHabilidadesNaturales,
                      string tecnologiaAliens)
            : base(add, liga, enemigo)
        {
            this.raza = raza;
            this.planeta = planeta;
            this.superHabilidadesNaturales = superHabilidadesNaturales;
            this.tecnologiaAliens = tecnologiaAliens;
        }
        #endregion

        #region "Metodos Abstracto"
        public override string Ifichas()
        {
            return "Add: " + this.add + "\n" +
                   "Liga: " + this.liga + "\n" +
                   "Enemigo: " + this.enemigo;
        }
        #endregion

        #region "Metos sobre escritos"
        public override string ToString()
        {
            return "Raza: "+ this.raza + "\n" +
                    "Planeta: " + this.planeta + "\n" +
                    "Super podeders de la raza: " + this.superHabilidadesNaturales + "\n" +
                    "Tipo de Tecnologia: " + this.tecnologiaAliens;
        }

        public override bool Equals(object obj)
        {
            Aliens A = (Aliens)obj;
            bool result = false;

            if ((this.raza == A.raza) &&
                (this.planeta == A.planeta) &&
                (this.superHabilidadesNaturales == A.superHabilidadesNaturales) &&
                (this.tecnologiaAliens == A.tecnologiaAliens))

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