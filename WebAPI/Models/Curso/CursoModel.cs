using System;

namespace WebAPI.Models.Instrutor
{
    public class CursoModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }
}
