using System;
using ExamenExtraordinarioJFTS.Enumeradores;
namespace ExamenExtraordinarioJFTS.Interfaces
{
	public interface IHabilidadLanzable
	{
		public int CostoMana { get; }
		public Boolean AutoAplicable { get; }
		public TipoHabilidadActivaEnum Tipo { get; }
		public int potencia { get; }

		void Lanzar(IPersonaje lanzador, IPersonaje objetivo);

	}
}

