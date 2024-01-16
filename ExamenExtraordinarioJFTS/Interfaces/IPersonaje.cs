using System;
using ExamenExtraordinarioJFTS.Enumeradores;
namespace ExamenExtraordinarioJFTS.Interfaces
{
	public interface IPersonaje
	{
        public int Nivel { get; set; }
        public int Salud { get; set; }
        public int Mana { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public TipoDePersonajeEnum TipoDePersonaje { get; }

        void Atacar(IPersonaje objetivo);
        void Defender();
        void Curar(int cantidad);
        void AprenderHabilidad(IHabilidad habilidad);
    }
}

