using System;
using System.Collections.Generic;
using Notatki.API.Models;

namespace Notatki.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }


        // Postawowe informacje
        public string Gender { get; set; }          // Płeć
        public int Age { get; set; }   // wiek
        public DateTime Created { get; set; }       // Data utworzenia/rejestracji
        public DateTime LastActive { get; set; }    // Ostatnia aktywność
        public string City { get; set; }            // Miasto
        public string Country { get; set; }         // Kraj

        // Zakładka Info
        public string School { get; set; }          //Szkoła/Uczelnia
        public string Department { get; set; }      // Wydział
        public string Direction { get; set; }       // Kierunek
        public string Specialisation { get; set; }  // Specjalizacja
        public string Semester { get; set; }        // Semestr


        // Zakłada  O mnie
        public string Motto { get; set; }           // Motto życiowe
        public string Description { get; set; }     // Opis


        // Zakłaka Pasje, zaiteresowania
        public string Interests { get; set; }       // Zainteresowania
        public string FreeTime { get; set; }        // Czas wolny
        public string Sport { get; set; }           // Sport
        public string Movies { get; set; }          // Filmy
        public string Music { get; set; }           // Muzyka


        // Zakładka zdjecia
        public ICollection<PhotosForDetailedDto> Photos { get; set; }      // Zdjęcia użytkownika

        public string PhotoUrl { get; set; }
    }
}