using System;

namespace Notatki.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }


        // Postawowe informacje
        public string Gender { get; set; }          // Płeć
        public int Age { get; set; }                // Data urodzenia
        public DateTime Created { get; set; }       // Data utworzenia/rejestracji
        public DateTime LastActive { get; set; }    // Ostatnia aktywność
        public string City { get; set; }            // Miasto
        public string Country { get; set; }         // Kraj
        public string PhotoUrl { get; set; }
       
    }
}