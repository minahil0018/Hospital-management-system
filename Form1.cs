﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PATIENTS_Click(object sender, EventArgs e)//patient
        {
            Patientlogin patientlogin = new Patientlogin();
            patientlogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)//admin
        {
            AdminLogin  adminloginForm = new AdminLogin();
            adminloginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)//employee
        {
            Employee employeelogin = new Employee();
            employeelogin.Show();
        }
    }
}
