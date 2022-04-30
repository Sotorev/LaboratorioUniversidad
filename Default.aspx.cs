using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UniversityManagement
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnos = new List<Alumno>();
        static List<Universidad> universidades = new List<Universidad>();
        static List<Nota> notasTemp = new List<Nota>();
        void LeerDatos()
        {
            string archivo = Server.MapPath("Universidades.json");

            try
            {
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                if (json.Length > 0)
                {
                    universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
                    GridView2.DataSource = universidades;
                    GridView2.DataBind();
                }
            }
            catch(Exception e)
            {

            }
            
            
        }
        void GuardarDatos()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        void LimpiarCajas()
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            TextBox4.Text = null;
            TextBox5.Text = null;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                LeerDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota()
            {
                Curso = TextBox5.Text,
                Punteo = Convert.ToInt32(TextBox4.Text)
            };
            notasTemp.Add(nota);
            GridView1.DataSource = notasTemp;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                Carne = TextBox1.Text,
                Nombre = TextBox2.Text,
                Apellido = TextBox3.Text,
                Notas = notasTemp.ToArray().ToList()
            };
            alumnos.Add(alumno);
            GridView2.DataSource = alumnos;
            GridView2.DataBind();
            notasTemp.Clear();
            GridView1.DataSource = notasTemp;
            GridView1.DataBind();
            LimpiarCajas();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Universidad u = new Universidad()
            {
                Alumnos = alumnos,
                Nombre = DropDownList1.Text
            };
            universidades.Add(u);
            GuardarDatos();
            alumnos.Clear();
        }
    }
}