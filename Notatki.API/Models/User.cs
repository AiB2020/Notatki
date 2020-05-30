using System;
using System.Collections.Generic;
namespace Notatki.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


        // Postawowe informacje
        public string Gender { get; set; }          // Płeć
        public DateTime DateOfBirth { get; set; }   // Data urodzenia
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
        public ICollection<Photo> Photos { get; set; }      // Zdjęcia notatek użytkownika
    }
}