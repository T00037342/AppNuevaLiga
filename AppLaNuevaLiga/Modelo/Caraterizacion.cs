using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLaNuevaLiga.Modelo
{
    public class Caraterizacion
    {
        #region "Atributos"
        private string nombreSuper;//Nombre del super heroe o villano
        private string tipoPersonaje;//Heroe o villano
        private string identidadSecreta;//Nombre del personage en sociedad
        private string trabajo;//Trabajo en la sociedad
        private string lugarDeOrogen;//lugar de origen
        private string sexo;//genero
        
        private string habilidades;
        private string debilidades;
        private string armas;
        private string personalidad;
        #endregion

        #region "Propiedades"
        public string NombreSuper
        {
            get { return nombreSuper; }
            set { nombreSuper = value; }
        }
        public string TipoPersonaje
        {
            get { return tipoPersonaje; }
            set { tipoPersonaje = value; }
        }
        public string IdentidadSecreta
        {
            get { return identidadSecreta; }
            set { identidadSecreta = value; }
        }
        public string Trabajo
        {
            get { return trabajo; }
            set { trabajo = value; }
        }
        public string LugarDeOrogen
        {
            get { return lugarDeOrogen; }
            set { lugarDeOrogen = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Habilidades
        {
            get { return habilidades; }
            set { habilidades = value; }
        }
        public string Debilidades
        {
            get { return debilidades; }
            set { debilidades = value; }
        }public string Armas
        {
            get { return armas; }
            set { armas = value; }
        }public string Personalidad
        {
            get { return personalidad; }
            set { personalidad = value; }
        }
        #endregion

        #region "Costructor"
        public Caraterizacion() 
        {
            this.nombreSuper = "Nombre del Heroe o Villano";
            this.tipoPersonaje = "Heroe o Villano";
            this.identidadSecreta = "Nombre real del personage(Identidad Secreta)";
            this.trabajo = "Dedicasuon u ofisio";
            this.lugarDeOrogen = "Lugar De Orogen";
            this.sexo = "Sexo(genero)";

            this.habilidades = "Habilidades";
            this.debilidades = "Dabilidades";
            this.armas = "Armas";
            this.personalidad = "Personalidad";
        }

        public Caraterizacion(string nombreSuper,string tipoPersonaje,string identidadSecreta,string trabajo,
            string lugarDeOrogen,string sexo,string habilidades, string debilidades, string armas, string personalidad)
        {
            this.tipoPersonaje = nombreSuper;
            this.identidadSecreta = tipoPersonaje;
            this.trabajo = identidadSecreta;
            this.lugarDeOrogen = lugarDeOrogen;
            this.sexo = sexo;

            this.habilidades = habilidades;
            this.debilidades = debilidades;
            this.armas = armas;
            this.personalidad = personalidad;
        }

        #endregion

        #region "Metodos SobreEscritos"
        public override bool Equals(object obj)
        {
            Caraterizacion C = (Caraterizacion)obj;
            bool result = false;

            if ((this.nombreSuper == C.nombreSuper) &&
                (this.tipoPersonaje == C.tipoPersonaje) &&
                (this.identidadSecreta == C.identidadSecreta) &&
                (this.trabajo == C.trabajo) &&
                (this.lugarDeOrogen == C.lugarDeOrogen) &&
                (this.sexo == C.sexo) &&
                (this.habilidades == C.habilidades) &&
                (this.debilidades == C.debilidades) &&
                (this.armas == C.armas) &&
                (this.personalidad == C.personalidad))

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