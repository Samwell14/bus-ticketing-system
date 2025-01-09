namespace Bus_Booking_System
{
    partial class Form_Dashboard
    {
       //public static System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HelpInstrurctions = new System.Windows.Forms.Button();
            this.RouteDetailsButton = new System.Windows.Forms.Button();
            this.BookingDetailsButton = new System.Windows.Forms.Button();
            this.CancellationButton = new System.Windows.Forms.Button();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.BusMangbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2Time = new System.Windows.Forms.Timer(this.components);
            this.panelControls1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.PanelLeft.Controls.Add(this.pictureBox1);
            this.PanelLeft.Controls.Add(this.HelpInstrurctions);
            this.PanelLeft.Controls.Add(this.RouteDetailsButton);
            this.PanelLeft.Controls.Add(this.BookingDetailsButton);
            this.PanelLeft.Controls.Add(this.CancellationButton);
            this.PanelLeft.Controls.Add(this.PanelSide);
            this.PanelLeft.Controls.Add(this.BusMangbtn);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(218, 720);
            this.PanelLeft.TabIndex = 0;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 169);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // HelpInstrurctions
            // 
            this.HelpInstrurctions.FlatAppearance.BorderSize = 0;
            this.HelpInstrurctions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpInstrurctions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpInstrurctions.ForeColor = System.Drawing.Color.White;
            this.HelpInstrurctions.Image = ((System.Drawing.Image)(resources.GetObject("HelpInstrurctions.Image")));
            this.HelpInstrurctions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpInstrurctions.Location = new System.Drawing.Point(15, 576);
            this.HelpInstrurctions.Name = "HelpInstrurctions";
            this.HelpInstrurctions.Size = new System.Drawing.Size(203, 58);
            this.HelpInstrurctions.TabIndex = 7;
            this.HelpInstrurctions.Text = "       Help Details";
            this.HelpInstrurctions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HelpInstrurctions.UseVisualStyleBackColor = true;
            this.HelpInstrurctions.Click += new System.EventHandler(this.HelpInstrurctions_Click);
            // 
            // RouteDetailsButton
            // 
            this.RouteDetailsButton.FlatAppearance.BorderSize = 0;
            this.RouteDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RouteDetailsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteDetailsButton.ForeColor = System.Drawing.Color.White;
            this.RouteDetailsButton.Image = ((System.Drawing.Image)(resources.GetObject("RouteDetailsButton.Image")));
            this.RouteDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RouteDetailsButton.Location = new System.Drawing.Point(12, 242);
            this.RouteDetailsButton.Name = "RouteDetailsButton";
            this.RouteDetailsButton.Size = new System.Drawing.Size(203, 60);
            this.RouteDetailsButton.TabIndex = 6;
            this.RouteDetailsButton.Text = "      Routes Details";
            this.RouteDetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RouteDetailsButton.UseVisualStyleBackColor = true;
            this.RouteDetailsButton.Click += new System.EventHandler(this.RouteDetailsButton_Click);
            // 
            // BookingDetailsButton
            // 
            this.BookingDetailsButton.FlatAppearance.BorderSize = 0;
            this.BookingDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookingDetailsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDetailsButton.ForeColor = System.Drawing.Color.White;
            this.BookingDetailsButton.Image = ((System.Drawing.Image)(resources.GetObject("BookingDetailsButton.Image")));
            this.BookingDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookingDetailsButton.Location = new System.Drawing.Point(12, 353);
            this.BookingDetailsButton.Name = "BookingDetailsButton";
            this.BookingDetailsButton.Size = new System.Drawing.Size(203, 60);
            this.BookingDetailsButton.TabIndex = 5;
            this.BookingDetailsButton.Text = "       Booking";
            this.BookingDetailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BookingDetailsButton.UseVisualStyleBackColor = true;
            this.BookingDetailsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // CancellationButton
            // 
            this.CancellationButton.FlatAppearance.BorderSize = 0;
            this.CancellationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancellationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancellationButton.ForeColor = System.Drawing.Color.White;
            this.CancellationButton.Image = ((System.Drawing.Image)(resources.GetObject("CancellationButton.Image")));
            this.CancellationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancellationButton.Location = new System.Drawing.Point(12, 459);
            this.CancellationButton.Name = "CancellationButton";
            this.CancellationButton.Size = new System.Drawing.Size(203, 60);
            this.CancellationButton.TabIndex = 4;
            this.CancellationButton.Text = "       Cancellation";
            this.CancellationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancellationButton.UseVisualStyleBackColor = true;
            this.CancellationButton.Click += new System.EventHandler(this.CancellationButton_Click);
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.White;
            this.PanelSide.ForeColor = System.Drawing.Color.White;
            this.PanelSide.Location = new System.Drawing.Point(3, 139);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(10, 63);
            this.PanelSide.TabIndex = 3;
            // 
            // BusMangbtn
            // 
            this.BusMangbtn.FlatAppearance.BorderSize = 0;
            this.BusMangbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusMangbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusMangbtn.ForeColor = System.Drawing.Color.White;
            this.BusMangbtn.Image = ((System.Drawing.Image)(resources.GetObject("BusMangbtn.Image")));
            this.BusMangbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BusMangbtn.Location = new System.Drawing.Point(12, 142);
            this.BusMangbtn.Name = "BusMangbtn";
            this.BusMangbtn.Size = new System.Drawing.Size(206, 60);
            this.BusMangbtn.TabIndex = 3;
            this.BusMangbtn.Text = "     Bus Management";
            this.BusMangbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BusMangbtn.UseVisualStyleBackColor = true;
            this.BusMangbtn.Click += new System.EventHandler(this.BusMangbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(218, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 45);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, -5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 54);
            this.button6.TabIndex = 0;
            this.button6.Text = "     ";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(937, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 39);
            this.button7.TabIndex = 5;
            this.button7.Text = "     ";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(46, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bus Booking System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "again";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.labelTime);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(218, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 100);
            this.panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(874, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(104, 23);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "HH:MM:ss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2Time
            // 
            this.timer2Time.Tick += new System.EventHandler(this.timer2Time_Tick);
            // 
            // panelControls1
            // 
            this.panelControls1.BackColor = System.Drawing.Color.White;
            this.panelControls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls1.Location = new System.Drawing.Point(218, 145);
            this.panelControls1.Name = "panelControls1";
            this.panelControls1.Size = new System.Drawing.Size(982, 575);
            this.panelControls1.TabIndex = 3;
            this.panelControls1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControls1_Paint);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BusMangbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RouteDetailsButton;
        private System.Windows.Forms.Button BookingDetailsButton;
        private System.Windows.Forms.Button CancellationButton;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2Time;
        private System.Windows.Forms.Panel panelControls1;
        private System.Windows.Forms.Button HelpInstrurctions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}