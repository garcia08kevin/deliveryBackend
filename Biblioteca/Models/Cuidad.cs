﻿namespace Biblioteca.Models
{
    public class Cuidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public Provincia? Provincia { get; set; }
    }
}
