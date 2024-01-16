using System;
using ExamenExtraordinarioJFTS.Enumeradores;
namespace ExamenExtraordinarioJFTS.Interfaces
{
	public interface IPersonaje
	{
        int Nivel { get; set; }
        int Salud { get; set; }
        int Mana { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        TipoDePersonajeEnum TipoDePersonaje { get; }

        void Atacar(IPersonaje objetivo);
        void Defender();
        void Curar(int cantidad);
        void AprenderHabilidad(IHabilidad habilidad);
    }
}

