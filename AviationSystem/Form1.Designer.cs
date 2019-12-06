namespace AviationSystem
{
    partial class Form1
    {
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EntryTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addToTableBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PurposeTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.OperatorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BillingAddressTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FlightNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AirCraftTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LandingPermitTable = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PermitNumberTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ExitTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AirCraftRegTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.LandingPermitTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Brown;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // EntryTextBox
            // 
            this.EntryTextBox.BackColor = System.Drawing.Color.White;
            this.EntryTextBox.Depth = 0;
            this.EntryTextBox.Hint = "";
            this.EntryTextBox.Location = new System.Drawing.Point(21, 111);
            this.EntryTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EntryTextBox.Name = "EntryTextBox";
            this.EntryTextBox.PasswordChar = '\0';
            this.EntryTextBox.SelectedText = "";
            this.EntryTextBox.SelectionLength = 0;
            this.EntryTextBox.SelectionStart = 0;
            this.EntryTextBox.Size = new System.Drawing.Size(162, 23);
            this.EntryTextBox.TabIndex = 4;
            this.EntryTextBox.Text = "Entry Point";
            this.EntryTextBox.UseSystemPasswordChar = false;
            this.EntryTextBox.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // addToTableBtn
            // 
            this.addToTableBtn.Depth = 0;
            this.addToTableBtn.Location = new System.Drawing.Point(21, 168);
            this.addToTableBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addToTableBtn.Name = "addToTableBtn";
            this.addToTableBtn.Primary = true;
            this.addToTableBtn.Size = new System.Drawing.Size(330, 54);
            this.addToTableBtn.TabIndex = 11;
            this.addToTableBtn.Text = "Add to Table";
            this.addToTableBtn.UseVisualStyleBackColor = true;
            this.addToTableBtn.Click += new System.EventHandler(this.addToTableBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // PurposeTextBox
            // 
            this.PurposeTextBox.BackColor = System.Drawing.Color.White;
            this.PurposeTextBox.Depth = 0;
            this.PurposeTextBox.Hint = "";
            this.PurposeTextBox.Location = new System.Drawing.Point(357, 140);
            this.PurposeTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PurposeTextBox.Name = "PurposeTextBox";
            this.PurposeTextBox.PasswordChar = '\0';
            this.PurposeTextBox.SelectedText = "";
            this.PurposeTextBox.SelectionLength = 0;
            this.PurposeTextBox.SelectionStart = 0;
            this.PurposeTextBox.Size = new System.Drawing.Size(330, 23);
            this.PurposeTextBox.TabIndex = 10;
            this.PurposeTextBox.Text = "Purpose of Flight";
            this.PurposeTextBox.UseSystemPasswordChar = false;
            // 
            // OperatorTextBox
            // 
            this.OperatorTextBox.BackColor = System.Drawing.Color.White;
            this.OperatorTextBox.Depth = 0;
            this.OperatorTextBox.Hint = "";
            this.OperatorTextBox.Location = new System.Drawing.Point(21, 82);
            this.OperatorTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.OperatorTextBox.Name = "OperatorTextBox";
            this.OperatorTextBox.PasswordChar = '\0';
            this.OperatorTextBox.SelectedText = "";
            this.OperatorTextBox.SelectionLength = 0;
            this.OperatorTextBox.SelectionStart = 0;
            this.OperatorTextBox.Size = new System.Drawing.Size(162, 23);
            this.OperatorTextBox.TabIndex = 0;
            this.OperatorTextBox.Text = "Operator Name";
            this.OperatorTextBox.UseSystemPasswordChar = false;
            this.OperatorTextBox.Click += new System.EventHandler(this.onClickClearTextBox);
            this.OperatorTextBox.Leave += new System.EventHandler(this.foucedOFF);
            this.OperatorTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BillingAddressTextBox
            // 
            this.BillingAddressTextBox.BackColor = System.Drawing.Color.White;
            this.BillingAddressTextBox.Depth = 0;
            this.BillingAddressTextBox.Hint = "";
            this.BillingAddressTextBox.Location = new System.Drawing.Point(525, 82);
            this.BillingAddressTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillingAddressTextBox.Name = "BillingAddressTextBox";
            this.BillingAddressTextBox.PasswordChar = '\0';
            this.BillingAddressTextBox.SelectedText = "";
            this.BillingAddressTextBox.SelectionLength = 0;
            this.BillingAddressTextBox.SelectionStart = 0;
            this.BillingAddressTextBox.Size = new System.Drawing.Size(162, 23);
            this.BillingAddressTextBox.TabIndex = 3;
            this.BillingAddressTextBox.Text = "Billing Address";
            this.BillingAddressTextBox.UseSystemPasswordChar = false;
            this.BillingAddressTextBox.Click += new System.EventHandler(this.materialSingleLineTextField3_Click);
            // 
            // FlightNumberTextBox
            // 
            this.FlightNumberTextBox.BackColor = System.Drawing.Color.White;
            this.FlightNumberTextBox.Depth = 0;
            this.FlightNumberTextBox.Hint = "";
            this.FlightNumberTextBox.Location = new System.Drawing.Point(357, 81);
            this.FlightNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FlightNumberTextBox.Name = "FlightNumberTextBox";
            this.FlightNumberTextBox.PasswordChar = '\0';
            this.FlightNumberTextBox.SelectedText = "";
            this.FlightNumberTextBox.SelectionLength = 0;
            this.FlightNumberTextBox.SelectionStart = 0;
            this.FlightNumberTextBox.Size = new System.Drawing.Size(162, 23);
            this.FlightNumberTextBox.TabIndex = 2;
            this.FlightNumberTextBox.Text = "Flight Number";
            this.FlightNumberTextBox.UseSystemPasswordChar = false;
            // 
            // AirCraftTextBox
            // 
            this.AirCraftTextBox.BackColor = System.Drawing.Color.White;
            this.AirCraftTextBox.Depth = 0;
            this.AirCraftTextBox.Hint = "";
            this.AirCraftTextBox.Location = new System.Drawing.Point(189, 82);
            this.AirCraftTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AirCraftTextBox.Name = "AirCraftTextBox";
            this.AirCraftTextBox.PasswordChar = '\0';
            this.AirCraftTextBox.SelectedText = "";
            this.AirCraftTextBox.SelectionLength = 0;
            this.AirCraftTextBox.SelectionStart = 0;
            this.AirCraftTextBox.Size = new System.Drawing.Size(162, 23);
            this.AirCraftTextBox.TabIndex = 1;
            this.AirCraftTextBox.Text = "Air Craft Type";
            this.AirCraftTextBox.UseSystemPasswordChar = false;
            // 
            // LandingPermitTable
            // 
            this.LandingPermitTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LandingPermitTable.Location = new System.Drawing.Point(21, 228);
            this.LandingPermitTable.Name = "LandingPermitTable";
            this.LandingPermitTable.Size = new System.Drawing.Size(666, 162);
            this.LandingPermitTable.TabIndex = 18;
            this.LandingPermitTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(357, 169);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(330, 54);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Create PDF";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // PermitNumberTextBox
            // 
            this.PermitNumberTextBox.BackColor = System.Drawing.Color.White;
            this.PermitNumberTextBox.Depth = 0;
            this.PermitNumberTextBox.Hint = "";
            this.PermitNumberTextBox.Location = new System.Drawing.Point(357, 111);
            this.PermitNumberTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PermitNumberTextBox.Name = "PermitNumberTextBox";
            this.PermitNumberTextBox.PasswordChar = '\0';
            this.PermitNumberTextBox.SelectedText = "";
            this.PermitNumberTextBox.SelectionLength = 0;
            this.PermitNumberTextBox.SelectionStart = 0;
            this.PermitNumberTextBox.Size = new System.Drawing.Size(162, 23);
            this.PermitNumberTextBox.TabIndex = 7;
            this.PermitNumberTextBox.Text = "Pemit Number";
            this.PermitNumberTextBox.UseSystemPasswordChar = false;
            // 
            // ExitTextBox
            // 
            this.ExitTextBox.BackColor = System.Drawing.Color.White;
            this.ExitTextBox.Depth = 0;
            this.ExitTextBox.Hint = "";
            this.ExitTextBox.Location = new System.Drawing.Point(189, 111);
            this.ExitTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitTextBox.Name = "ExitTextBox";
            this.ExitTextBox.PasswordChar = '\0';
            this.ExitTextBox.SelectedText = "";
            this.ExitTextBox.SelectionLength = 0;
            this.ExitTextBox.SelectionStart = 0;
            this.ExitTextBox.Size = new System.Drawing.Size(162, 23);
            this.ExitTextBox.TabIndex = 6;
            this.ExitTextBox.Text = "Exit Point";
            this.ExitTextBox.UseSystemPasswordChar = false;
            // 
            // AirCraftRegTextBox
            // 
            this.AirCraftRegTextBox.BackColor = System.Drawing.Color.White;
            this.AirCraftRegTextBox.Depth = 0;
            this.AirCraftRegTextBox.Hint = "";
            this.AirCraftRegTextBox.Location = new System.Drawing.Point(526, 111);
            this.AirCraftRegTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AirCraftRegTextBox.Name = "AirCraftRegTextBox";
            this.AirCraftRegTextBox.PasswordChar = '\0';
            this.AirCraftRegTextBox.SelectedText = "";
            this.AirCraftRegTextBox.SelectionLength = 0;
            this.AirCraftRegTextBox.SelectionStart = 0;
            this.AirCraftRegTextBox.Size = new System.Drawing.Size(162, 23);
            this.AirCraftRegTextBox.TabIndex = 8;
            this.AirCraftRegTextBox.Text = "Aircraft Regestration";
            this.AirCraftRegTextBox.UseSystemPasswordChar = false;
            this.AirCraftRegTextBox.Click += new System.EventHandler(this.AirCraftRegTxtBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 402);
            this.Controls.Add(this.LandingPermitTable);
            this.Controls.Add(this.OperatorTextBox);
            this.Controls.Add(this.BillingAddressTextBox);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.addToTableBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PurposeTextBox);
            this.Controls.Add(this.ExitTextBox);
            this.Controls.Add(this.PermitNumberTextBox);
            this.Controls.Add(this.AirCraftRegTextBox);
            this.Controls.Add(this.FlightNumberTextBox);
            this.Controls.Add(this.EntryTextBox);
            this.Controls.Add(this.AirCraftTextBox);
            this.Name = "Form1";
            this.Text = "Landing Permit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LandingPermitTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialSingleLineTextField EntryTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton addToTableBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialSingleLineTextField PurposeTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField OperatorTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField BillingAddressTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField FlightNumberTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField AirCraftTextBox;
        private System.Windows.Forms.DataGridView LandingPermitTable;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField PermitNumberTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ExitTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField AirCraftRegTextBox;
    }
}

