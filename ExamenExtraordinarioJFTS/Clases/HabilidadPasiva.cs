using System;
using ExamenExtraordinarioJFTS.Enumeradores;
using ExamenExtraordinarioJFTS.Interfaces;
namespace ExamenExtraordinarioJFTS.Clases
{
    public class HabilidadPasiva : IHabilidad, IHabilidadLanzable
    {
        private static int lastId = 0;
        private string _id;
        private string _nombre;
        private int _nivelRequerido;
        private TipoDePersonajeEnum _tipoPersonaje;
        private TipoDeHabilidadEnum _tipoDeHabilidad;
        private bool _autoAplicable;
        private int _potencia; 

        public HabilidadPasiva(string nombre, int nivelRequerido, TipoDePersonajeEnum tipoPersonaje,TipoDeHabilidadEnum tipoDeHabilidad,  bool autoAplicable, int potencia)
        {
            _id = "Pasiva" + (++lastId).ToString();
            _nombre = nombre;
            _nivelRequerido = nivelRequerido;
            _tipoPersonaje = tipoPersonaje;
            _tipoDeHabilidad = tipoDeHabilidad;
            _autoAplicable = autoAplicable;
        }

        public string Id
        {
            get => _id;
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("El nombre no puede estar vacio ");
                }
            }
        }

       public int NivelRequerido
        {
            get => _nivelRequerido;
            set
            {
                _nivelRequerido = value; 
            }
        }

        public TipoDeHabilidadEnum TipoHabilidad
        { 
            get => _tipoDeHabilidad;
            private set => _tipoDeHabilidad = value;
        }

        public TipoDePersonajeEnum TipoPersonaje
        {
            get => _tipoPersonaje;
            private set => _tipoPersonaje = value; 
        }

        

        public bool AutoAplicable
        {
            get => _autoAplicable;
            set
            {
                _autoAplicable = value;
            }
        }

        // no aplica 
        public TipoHabilidadActivaEnum Tipo => throw new NotImplementedException(); // 

        public int Potencia
        {
            get => _potencia;
            set
            {
                _potencia = value; 
            }
        }

        // no aplica en la pasiva 
        public int CostoMana => throw new NotImplementedException();

        public void AplicarEfecto()
        {
            throw new NotImplementedException();
        }

        public void Lanzar(IPersonaje lanzador, IPersonaje objetivo)
        {
            throw new NotImplementedException();
        }
    }
}

