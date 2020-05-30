namespace Notatki.API.Dtos
{
    public class UserForUpdateDto
    {
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
        public string Music { get; set; }  
        public string City { get; set; }            // Miasto
        public string Country { get; set; }         // Kraj
    }
}