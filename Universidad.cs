using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagement
{
    public class Universidad
    {
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}