//---------------------------------------------------------------------------------
// <copyright file="AssinaturaTipo.cs" company="EEmovel">
//   Copyright (c) 2015 All Right Reserved
// </copyright>
// <author>Felipe Labastia</author>
// <email>flabastia@hotmail.com</email>
// <date>2015-05-20</date>
//---------------------------------------------------------------------------------

namespace EEmovel.Data.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The AssinaturaTipo model.
    /// </summary>
    public class AssinaturaTipo
	{
		public AssinaturaTipo()
		{

		}

		/// <summary>
		/// Gets or sets id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets nome.
		/// </summary>
		public string Nome { get; set; }

        public IEnumerable<AssinaturaTipoCaracteristica> AssinaturaTipoCaracteristicas { get; set; }
    }
}
