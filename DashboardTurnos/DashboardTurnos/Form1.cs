using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardTurnos
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
            GraficoMedico();
            GraficoPaciente();
        }

        ArrayList Turno = new ArrayList();
        ArrayList Medico = new ArrayList();

        ArrayList Turno1 = new ArrayList();
        ArrayList Paciente = new ArrayList();

        private void GraficoMedico()
        {
            cmd = new SqlCommand("medicoTurnos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Turno.Add(dr.GetString(0));
                Medico.Add(dr.GetInt32(1));
            }
            chartTurnosPorMedicos.Series[0].Points.DataBindXY(Turno, Medico);
            dr.Close();
            con.Close();
        }


        private void GraficoPaciente()
        {
            cmd = new SqlCommand("pacienteTurnos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Turno1.Add(dr.GetString(0));
                Paciente.Add(dr.GetInt32(1));
            }
            chartTurnosPorPaciente.Series[0].Points.DataBindXY(Turno1, Paciente);
            dr.Close();
            con.Close();
        }


    }
}
