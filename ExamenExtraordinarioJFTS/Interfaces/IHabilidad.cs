using System;
using ExamenExtraordinarioJFTS.Enumeradores;
namespace ExamenExtraordinarioJFTS.Interfaces
{
	public interface IHabilidad
	{
		 string Id { get; }
		 string Nombre { get; } // set privado
		 int NivelRequerido { get; }
		 TipoDeHabilidadEnum TipoHabilidad { get; }
			TipoDePersonajeEnum TipoPersonaje { get; }
	}
}

