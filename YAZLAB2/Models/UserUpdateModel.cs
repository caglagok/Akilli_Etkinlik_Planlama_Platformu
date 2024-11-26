﻿namespace YAZLAB2.Models
{
    public class UserUpdateModel
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Konum { get; set; }
        public string TelefonNumarasi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string ProfilFoto { get; set; }
    }

}