using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using curso_c_.dao;
using curso_c_.Modelos;
using MySqlX.XDevAPI;

namespace curso_c_.Forms
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();


        }
        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerListadoDeClientes();
            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void InitializeComponent()
        {
            listClientes = new ListBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblTarjeta = new Label();
            txtTarjetaDeCredito = new TextBox();
            btnEditar = new Button();
            label1 = new Label();
            lblId = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(23, 24);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(176, 199);
            listClientes.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(324, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(241, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(324, 229);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(124, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(241, 72);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(324, 69);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(241, 101);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(324, 98);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(241, 130);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(99, 15);
            lblTarjeta.TabIndex = 10;
            lblTarjeta.Text = "Tarjeta de Credito";
            // 
            // txtTarjetaDeCredito
            // 
            txtTarjetaDeCredito.Location = new Point(346, 127);
            txtTarjetaDeCredito.Name = "txtTarjetaDeCredito";
            txtTarjetaDeCredito.Size = new Size(78, 23);
            txtTarjetaDeCredito.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(217, 229);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 16);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(360, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(43, 229);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionClientes
            // 
            ClientSize = new Size(480, 284);
            Controls.Add(btnAgregar);
            Controls.Add(lblId);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(lblTarjeta);
            Controls.Add(txtTarjetaDeCredito);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(listClientes);
            Name = "GestionClientes";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblTarjeta;
        private TextBox txtTarjetaDeCredito;
        private Button btnEditar;
        private Label label1;
        private Label lblId;
        private Button btnAgregar;
        private ListBox listClientes;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;

            if (lblId.Text != "")
            {
                cliente.id = lblId.Text;
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarListado();

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            //listClientes.Items.RemoveAt(listClientes.SelectedIndex);

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Eliminar(cliente);
            actualizarLista();

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaDeCredito.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarListado();
        }
        private void limpiarListado()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjetaDeCredito.Text = "";
        }
    }
}
