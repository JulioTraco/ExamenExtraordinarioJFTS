using System;
using ExamenExtraordinarioJFTS.Enumeradores;
using ExamenExtraordinarioJFTS.Interfaces;
namespace ExamenExtraordinarioJFTS.Clases
{
	public class Personaje : IPersonaje
	{
        private int _nivel;
        private int _salud;
        private int _mana;
        private int _ataque;
        private int _defensa;
        private TipoDePersonajeEnum _tipoDePersonaje;
       

        public Personaje(TipoDePersonajeEnum tipoDePersonaje)
        {
            _tipoDePersonaje = tipoDePersonaje;
           
        }

        public int Nivel
        {
            get => _nivel;
            set => _nivel = value; 
        }

        public int Salud
        {
            get => _salud;
            set => _salud = value; 
        }

        public int Mana
        {
            get => _mana;
            set => _mana = value;
        }

        public int Ataque
        {
            get => _ataque;
            set => _ataque = value; 
        }

        public int Defensa
        {
            get => _defensa;
            set => _defensa = value; 
        }


        
        public TipoDePersonajeEnum TipoDePersonaje => throw new NotImplementedException();

        public void AprenderHabilidad(IHabilidad habilidad)
        {
            throw new NotImplementedException();
        }

        public void Atacar(IPersonaje objetivo)
        {
            throw new NotImplementedException();
        }

        public void Curar(int cantidad)
        {
            throw new NotImplementedException();
        }

        public void Defender()
        {
            throw new NotImplementedException();
        }
    }
}

