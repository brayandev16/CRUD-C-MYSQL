namespace curso_c_
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionar = new Button();
            SuspendLayout();
            // 
            // btnGestionar
            // 
            btnGestionar.Location = new Point(174, 129);
            btnGestionar.Name = "btnGestionar";
            btnGestionar.Size = new Size(75, 52);
            btnGestionar.TabIndex = 1;
            btnGestionar.Text = "Gestionar Clientes";
            btnGestionar.UseVisualStyleBackColor = true;
            btnGestionar.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 249);
            Controls.Add(btnGestionar);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Peso;
        private Button btnGestionar;
        private TextBox txtPeso;
        private Label lblAltura;
        private TextBox txtAltura;
        private TextBox txtResultado;
    }
}