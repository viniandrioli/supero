//---------------------------------------------------------------------------------
// <copyright file="PerfilUsuario.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model.ComplexType
{
    /// <summary>
    /// Classe que define perfil de usuário.
    /// </summary>
    public class PerfilUsuario
    {
		public PerfilUsuario()
        { }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets nome.
        /// </summary>
        public string Nome { get; set; }

		/// <summary>
		/// Gets or sets imobiliaria.
		/// </summary>
		public Imobiliaria Imobiliaria { get; set; }
    }
}
