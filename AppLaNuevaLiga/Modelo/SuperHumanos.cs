using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public class SuperHumanos : Personaje
    {
        #region "Atributos"
        private string habilidadSobrenatural;
        #endregion

        #region "Propiedades"
        public string HabilidadSobrenatural
        {
            get { return habilidadSobrenatural; }
            set { habilidadSobrenatural = value; }
        }
        #endregion

        #region "Costruhctor"
        public SuperHumanos()
            : base()
        {
            this.habilidadSobrenatural = "Mutacion o Avidad Especial";
        }
        public SuperHumanos(string add, string liga, string enemigo,string habilidadSobrenatural)
            : base(add, liga, enemigo) 
        {
            this.habilidadSobrenatural = habilidadSobrenatural;
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
            return "Mutacion O Avilidad ESpecial: " + this.habilidadSobrenatural;
        }

        public override bool Equals(object obj)
        {
            SuperHumanos S = (SuperHumanos)obj;
            bool result = false;

            if ((this.habilidadSobrenatural == S.habilidadSobrenatural))

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