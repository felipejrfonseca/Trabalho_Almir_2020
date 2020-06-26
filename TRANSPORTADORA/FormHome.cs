using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using TRANSPORTADORA.CAMADAS;

namespace TRANSPORTADORA
{
    public partial class FormHome : Form
    {
        private IconButton AtualBtn;
        private Panel leftBorderBtn;
        private Form AtualChildForm;
        
        //Construtor
        public FormHome()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,45);
            PanelMenu.Controls.Add(leftBorderBtn);
            // Form Barra de titulo
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Struct
        private struct RGBCores
        {
            public static Color cor1 = Color.FromArgb(172, 126, 241);
            public static Color cor2 = Color.FromArgb(249, 118,176);
            public static Color cor3 = Color.FromArgb(253, 138, 114);
            public static Color cor4 = Color.FromArgb(95, 77, 221);
            public static Color cor5 = Color.FromArgb(249, 88, 115);
            public static Color cor6 = Color.FromArgb(24, 161, 251);
        }

        //Metodos
        private void AtivarBtn(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DesativarBtn();
                AtualBtn = (IconButton)senderBtn;
                AtualBtn.BackColor = Color.FromArgb(37, 36, 81);
                AtualBtn.ForeColor = color;
                AtualBtn.TextAlign = ContentAlignment.MiddleCenter;
                AtualBtn.IconColor = color;
                AtualBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                AtualBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, AtualBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icone Formulario HOME
                IconeFormInicio.IconChar = AtualBtn.IconChar;
                IconeFormInicio.IconColor = color;


            }
        }

        private void DesativarBtn()
        {
            if(AtualBtn != null)
            {
                AtualBtn.BackColor = Color.FromArgb(31, 30, 68);
                AtualBtn.ForeColor = Color.White;
                AtualBtn.TextAlign = ContentAlignment.MiddleLeft;
                AtualBtn.IconColor = Color.White;
                AtualBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                AtualBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
           if(AtualChildForm != null)
            {
                //Abrir Formularios
                AtualChildForm.Close();
            }
            
            AtualChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TituloFomInicio.Text = childForm.Text;

        }

        
        private void BtnTransporte_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBCores.cor1);
            OpenChildForm(new FormMotoristas());
        }

        private void BtnTransportadora_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBCores.cor2);
            OpenChildForm(new FormTransportadora());
        }

        
        private void BtnCaminhoes_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBCores.cor4);
            OpenChildForm(new FormCaminhoes());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            AtualChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DesativarBtn();
            leftBorderBtn.Visible = false;
            IconeFormInicio.IconChar = IconChar.Home;
            IconeFormInicio.IconColor = Color.MediumPurple;
            TituloFomInicio.Text = "HOME";
        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //Movimentação Barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconeFormInicio_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximinizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnFrete_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBCores.cor5);
            OpenChildForm(new FormFrete());
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            AtivarBtn(sender, RGBCores.cor6);
            OpenChildForm(new FormRelatorio());
        }
    }
}
