﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVista
{
    public partial class InsertarEmpleadoVista : Form
    {
        public InsertarEmpleadoVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0; //variable local
        PersonaBss bss = new PersonaBss();
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista plv = new PersonaListarVista();
            /*plv.showDialog();*/
            if (plv.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
        UsuarioBss bssuser = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Empleado usuario = new Empleado();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Se guardo correctamente!");
        }
    }
}
