using System;
using ExamenExtraordinarioJFTS.Enumeradores;
using ExamenExtraordinarioJFTS.Interfaces;
namespace ExamenExtraordinarioJFTS.Clases
{
	public class HabilidadNormal : IHabilidad , IHabilidadLanzable
	{

        private string _id;
        private string _nombre;
        private int _nivelRequerido;
        private TipoDeHabilidadEnum _tipoHabilidad;
        private TipoDePersonajeEnum _tipoDePersonaje;
        private int _costoMana;
        private bool _autoAplicable;
        private TipoHabilidadActivaEnum _tipo;
        private int _potencia;


        public HabilidadNormal(string id, string nombre, int nivelRequerido, TipoDeHabilidadEnum tipoHabilidad,TipoDePersonajeEnum tipoPersonaje, int costoMana, bool autoAplicable, TipoHabilidadActivaEnum tipo, int potencia)
        {
            _id = id;
            _nombre = nombre;
            _nivelRequerido = nivelRequerido;
            _tipoHabilidad = tipoHabilidad;
            _tipoDePersonaje = tipoPersonaje;
            _costoMana = costoMana;
            _autoAplicable = autoAplicable;
            _tipo = tipo;
            _potencia = potencia; 
        }
        public string Id
        {
            get => _id;
            set
            {
                _id = value; 
            }
        }

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("EL nombre no puede estar vacio");
                }
                else
                {
                    _nombre = value;
                }
            }
        }

        public int NivelRequerido
        {
            get => _nivelRequerido;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nivel requerido incorrecto ");
                }
                else
                {
                    _nivelRequerido = value;
                }
            }
        }


        public TipoDeHabilidadEnum TipoHabilidad
        {
            get => _tipoHabilidad;
            private set => _tipoHabilidad = value; 
        }

        public TipoDePersonajeEnum TipoPersonaje
        {
            get => _tipoDePersonaje;
            private set => _tipoDePersonaje = value; 
        }

        public int CostoMana
        {
            get => _costoMana;
            set
            {
                _costoMana = value; 
            }
        }

        public bool AutoAplicable
        {
            get => _autoAplicable;
            set
            {
                _autoAplicable = value; 
            }
        }

        public TipoHabilidadActivaEnum Tipo
        {
            get => _tipo;
            private set => _tipo = value; 
        }

        public int Potencia
        {
            get => _potencia;
            set
            {
                _potencia = value; 
            }
        }

        public void Lanzar(IPersonaje lanzador, IPersonaje objetivo)
        {
            if (lanzador.Mana < CostoMana)
            {
                Console.WriteLine("No tienes suficiente mana para usar esta habilidad ");
                return;
            }

            lanzador.Mana -= CostoMana; // aqui reducimos el mana del jugador

            switch (Tipo)
            {
                case TipoHabilidadActivaEnum.Daño:
                    if (!AutoAplicable && lanzador == objetivo)
                    {
                        Console.WriteLine("Esta habilidad no puede ser usada en uno mismo");
                        return;
                    }
                    objetivo.Salud -= Potencia; // haciendole daño al otro personaje
                    break;

                case TipoHabilidadActivaEnum.Curacion:
                    if (AutoAplicable || lanzador == objetivo)
                    {
                        objetivo.Salud += Potencia; 
                    }
                    else
                    {
                        Console.WriteLine("Esta habilidad no puede ser usada en otro personaje");
                    }
                    break;  
            }
        }
    }
  }


