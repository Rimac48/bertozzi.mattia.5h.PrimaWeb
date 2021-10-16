using System;
using System.ComponentModel.DataAnnotations;

namespace bertozzi.mattia._5H.PrimaWeb.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [Required(ErrorMessage="Inserisci un'email valida")]
	    [EmailAddress]
        public string Email{ get; set; }
    }
}
