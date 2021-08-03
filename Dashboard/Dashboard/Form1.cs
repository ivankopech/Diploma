using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB; DataBase = CONTEXTO9; Integrated Security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Grafico();
        }

        ArrayList Especialidad = new ArrayList();
        ArrayList Medico = new ArrayList();
        private void Grafico()
        {
            cmd = new SqlCommand("medicosPorEspecialidad", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Especialidad.Add(dr.GetString(0));
                Medico.Add(dr.GetInt32(1));
            }
            chartMedicosxEspecialidad.Series[0].Points.DataBindXY(Especialidad, Medico);
            dr.Close();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
