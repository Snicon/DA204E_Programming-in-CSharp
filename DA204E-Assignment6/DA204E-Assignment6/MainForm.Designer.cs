namespace DA204E_Assignment6
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            lblDateTime = new Label();
            dtpDateTime = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblTodo = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            grpTodo = new GroupBox();
            lblDescription = new Label();
            lblToDoPriority = new Label();
            lblHour = new Label();
            lblDate = new Label();
            lstTodo = new ListBox();
            btnChange = new Button();
            btnDelete = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ttDateTime = new ToolTip(components);
            timer = new System.Windows.Forms.Timer(components);
            lblClock = new Label();
            btnClear = new Button();
            grpTodo.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(12, 38);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(81, 15);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "Date and time";
            // 
            // dtpDateTime
            // 
            dtpDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.Location = new Point(125, 32);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(471, 23);
            dtpDateTime.TabIndex = 1;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(614, 32);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(665, 29);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 3;
            // 
            // lblTodo
            // 
            lblTodo.AutoSize = true;
            lblTodo.Location = new Point(12, 69);
            lblTodo.Name = "lblTodo";
            lblTodo.Size = new Size(107, 15);
            lblTodo.TabIndex = 4;
            lblTodo.Text = "To do (description)";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 66);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(663, 23);
            txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(125, 98);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpTodo
            // 
            grpTodo.Controls.Add(lblDescription);
            grpTodo.Controls.Add(lblToDoPriority);
            grpTodo.Controls.Add(lblHour);
            grpTodo.Controls.Add(lblDate);
            grpTodo.Controls.Add(lstTodo);
            grpTodo.ForeColor = Color.ForestGreen;
            grpTodo.Location = new Point(12, 147);
            grpTodo.Name = "grpTodo";
            grpTodo.Size = new Size(776, 249);
            grpTodo.TabIndex = 7;
            grpTodo.TabStop = false;
            grpTodo.Text = "To Do";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ControlText;
            lblDescription.Location = new Point(327, 19);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblToDoPriority
            // 
            lblToDoPriority.AutoSize = true;
            lblToDoPriority.ForeColor = SystemColors.ControlText;
            lblToDoPriority.Location = new Point(219, 19);
            lblToDoPriority.Name = "lblToDoPriority";
            lblToDoPriority.Size = new Size(45, 15);
            lblToDoPriority.TabIndex = 10;
            lblToDoPriority.Text = "Priority";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.ForeColor = SystemColors.ControlText;
            lblHour.Location = new Point(155, 19);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(34, 15);
            lblHour.TabIndex = 9;
            lblHour.Text = "Hour";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(6, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // lstTodo
            // 
            lstTodo.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTodo.FormattingEnabled = true;
            lstTodo.ItemHeight = 15;
            lstTodo.Location = new Point(6, 37);
            lstTodo.Name = "lstTodo";
            lstTodo.Size = new Size(764, 199);
            lstTodo.TabIndex = 0;
            lstTodo.SelectedIndexChanged += lstTodo_SelectedIndexChanged;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(18, 402);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(111, 23);
            btnChange.TabIndex = 8;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(142, 402);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.MenuBar;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = SystemColors.MenuBar;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator1, openToolStripMenuItem, saveDataFileToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(191, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(188, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(191, 22);
            openToolStripMenuItem.Text = "Open data file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveDataFileToolStripMenuItem.Size = new Size(191, 22);
            saveDataFileToolStripMenuItem.Text = "Save as";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(191, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
            aboutToolStripMenuItem.Size = new Size(145, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ttDateTime
            // 
            ttDateTime.ToolTipIcon = ToolTipIcon.Info;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.BorderStyle = BorderStyle.Fixed3D;
            lblClock.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClock.ForeColor = Color.LightCoral;
            lblClock.Location = new Point(698, 402);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(90, 20);
            lblClock.TabIndex = 11;
            lblClock.Text = "00:00:00";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(269, 402);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblClock);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(grpTodo);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(lblTodo);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(dtpDateTime);
            Controls.Add(lblDateTime);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ToDo Reminder by Sixten Peterson";
            grpTodo.ResumeLayout(false);
            grpTodo.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDateTime;
        private DateTimePicker dtpDateTime;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private Label lblTodo;
        private TextBox txtDescription;
        private Button btnAdd;
        private GroupBox grpTodo;
        private ListBox lstTodo;
        private Label lblDate;
        private Label lblHour;
        private Label lblToDoPriority;
        private Label lblDescription;
        private Button btnChange;
        private Button btnDelete;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolTip ttDateTime;
        private System.Windows.Forms.Timer timer;
        private Label lblClock;
        private Button btnClear;
    }
}
