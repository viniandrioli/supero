namespace EEmovel.Data.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The LoginAuditoria model.
    /// </summary>
    public class PessoaSession
    {
        public PessoaSession()
        {
        }

        /// <summary>
        /// Gets or sets identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets pessoa identifier.
        /// </summary>
        public long PessoaId { get; set; }

        /// <summary>
        /// Gets or sets session
        /// </summary>
        public string Session { get; set; }

        /// <summary>
        /// Gets or sets pessoa identifier.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        public DateTime Data { get; set; }
    }
}
