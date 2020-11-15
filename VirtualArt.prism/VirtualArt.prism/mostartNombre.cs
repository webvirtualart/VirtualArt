using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VirtualArt.prism
{
    public class mostartNombre : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string nombre = string.Empty;

        public string Nombre { 
            get => nombre;
            set
            {
                if (nombre == value)                
                    return;
                
                nombre = value;
                onPropertyChange(nameof(nombre));
                onPropertyChange(nameof(mostrarNombre));
            }
        }

        public  string mostrarNombre => $"nombre a mostrar: {Nombre}";
        void onPropertyChange(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }


    }
}
