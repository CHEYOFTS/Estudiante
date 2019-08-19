using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrimeraClasesNvl2.Model
{
    public class PropEstudiante2 : INotifyPropertyChanged_Model
    {
        private int _Id2;

        public int id2
        {
            get { return _Id2; }
            set { _Id2 = value; }
        }


        private string _NombreEstudiante2;

        public string NombreEstudiante2
        {
            get { return _NombreEstudiante2; }
            set { _NombreEstudiante2 = value; }
        }

        private string _ApellidoEstudiante2;

        public string ApellidoEstudiante2
        {
            get { return _ApellidoEstudiante2; }
            set { _ApellidoEstudiante2 = value; }
        }

        private string _Curso2;

        public string Curso2
        {
            get { return _Curso2; }
            set { _Curso2 = value; }
        }


        private int _Edad2;

        public int Edad2
        {
            get { return _Edad2; }
            set { _Edad2 = value; }
        }

        private string _Direccion2;

        public string Direccion2
        {
            get { return _Direccion2; }
            set { _Direccion2 = value; }
        }

        private string _Responsable2;
      

        public string Responsable2
        {
            get { return _Responsable2; }
            set { _Responsable2 = value; }
        }


    }
}
