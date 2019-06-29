namespace GPL_application
{
    partial class Form_main
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
            this.richTextBox_comm = new System.Windows.Forms.RichTextBox();
            this.groupBox_quickacc = new System.Windows.Forms.GroupBox();
            this.radioButton_cir = new System.Windows.Forms.RadioButton();
            this.radioButton_rec = new System.Windows.Forms.RadioButton();
            this.radioButton_pen = new System.Windows.Forms.RadioButton();
            this.button_run = new System.Windows.Forms.Button();
            this.button_clear_comm = new System.Windows.Forms.Button();
            this.button_save_scr = new System.Windows.Forms.Button();
            this.button_load_scr = new System.Windows.Forms.Button();
            this.button_save_pic = new System.Windows.Forms.Button();
            this.label_mouse_pos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_thickness = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_pen_color = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_thic_err = new System.Windows.Forms.Label();
            this.button_clear_can = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label_can_x = new System.Windows.Forms.Label();
            this.label_can_y = new System.Windows.Forms.Label();
            this.button_log_clear = new System.Windows.Forms.Button();
            this.button_con_col = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_texture_br = new System.Windows.Forms.Button();
            this.pictureBox_texture = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_canvas = new System.Windows.Forms.PictureBox();
            this.groupBox_quickacc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_texture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_comm
            // 
            this.richTextBox_comm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox_comm.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_comm.EnableAutoDragDrop = true;
            this.richTextBox_comm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_comm.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_comm.Location = new System.Drawing.Point(10, 512);
            this.richTextBox_comm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_comm.Name = "richTextBox_comm";
            this.richTextBox_comm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox_comm.Size = new System.Drawing.Size(402, 150);
            this.richTextBox_comm.TabIndex = 1;
            this.richTextBox_comm.Text = "";
            this.richTextBox_comm.TextChanged += new System.EventHandler(this.richTextBox_comm_TextChanged);
            // 
            // groupBox_quickacc
            // 
            this.groupBox_quickacc.Controls.Add(this.radioButton_cir);
            this.groupBox_quickacc.Controls.Add(this.radioButton_rec);
            this.groupBox_quickacc.Controls.Add(this.radioButton_pen);
            this.groupBox_quickacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_quickacc.Location = new System.Drawing.Point(10, 5);
            this.groupBox_quickacc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_quickacc.Name = "groupBox_quickacc";
            this.groupBox_quickacc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_quickacc.Size = new System.Drawing.Size(221, 57);
            this.groupBox_quickacc.TabIndex = 5;
            this.groupBox_quickacc.TabStop = false;
            this.groupBox_quickacc.Text = "Quick Access";
            // 
            // radioButton_cir
            // 
            this.radioButton_cir.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_cir.AutoSize = true;
            this.radioButton_cir.BackColor = System.Drawing.Color.RoyalBlue;
            this.radioButton_cir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_cir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_cir.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton_cir.Location = new System.Drawing.Point(150, 20);
            this.radioButton_cir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_cir.Name = "radioButton_cir";
            this.radioButton_cir.Size = new System.Drawing.Size(58, 30);
            this.radioButton_cir.TabIndex = 2;
            this.radioButton_cir.TabStop = true;
            this.radioButton_cir.Text = "Circle";
            this.radioButton_cir.UseVisualStyleBackColor = false;
            // 
            // radioButton_rec
            // 
            this.radioButton_rec.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_rec.AutoSize = true;
            this.radioButton_rec.BackColor = System.Drawing.Color.RoyalBlue;
            this.radioButton_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_rec.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton_rec.Location = new System.Drawing.Point(60, 20);
            this.radioButton_rec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_rec.Name = "radioButton_rec";
            this.radioButton_rec.Size = new System.Drawing.Size(86, 30);
            this.radioButton_rec.TabIndex = 1;
            this.radioButton_rec.TabStop = true;
            this.radioButton_rec.Text = "Rectangle";
            this.radioButton_rec.UseVisualStyleBackColor = false;
            // 
            // radioButton_pen
            // 
            this.radioButton_pen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_pen.AutoSize = true;
            this.radioButton_pen.BackColor = System.Drawing.Color.RoyalBlue;
            this.radioButton_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_pen.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton_pen.Location = new System.Drawing.Point(8, 20);
            this.radioButton_pen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_pen.Name = "radioButton_pen";
            this.radioButton_pen.Size = new System.Drawing.Size(46, 30);
            this.radioButton_pen.TabIndex = 0;
            this.radioButton_pen.TabStop = true;
            this.radioButton_pen.Text = "Pen";
            this.radioButton_pen.UseVisualStyleBackColor = false;
            // 
            // button_run
            // 
            this.button_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_run.BackColor = System.Drawing.Color.Tomato;
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_run.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_run.Location = new System.Drawing.Point(435, 507);
            this.button_run.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(81, 36);
            this.button_run.TabIndex = 6;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = false;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_clear_comm
            // 
            this.button_clear_comm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear_comm.BackColor = System.Drawing.Color.Tomato;
            this.button_clear_comm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_comm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear_comm.Location = new System.Drawing.Point(435, 548);
            this.button_clear_comm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear_comm.Name = "button_clear_comm";
            this.button_clear_comm.Size = new System.Drawing.Size(81, 36);
            this.button_clear_comm.TabIndex = 7;
            this.button_clear_comm.Text = "Clear";
            this.button_clear_comm.UseVisualStyleBackColor = false;
            this.button_clear_comm.Click += new System.EventHandler(this.button_clear_comm_Click);
            // 
            // button_save_scr
            // 
            this.button_save_scr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_save_scr.BackColor = System.Drawing.Color.Tomato;
            this.button_save_scr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_scr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_scr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save_scr.Location = new System.Drawing.Point(435, 587);
            this.button_save_scr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save_scr.Name = "button_save_scr";
            this.button_save_scr.Size = new System.Drawing.Size(81, 36);
            this.button_save_scr.TabIndex = 8;
            this.button_save_scr.Text = "Save Script";
            this.button_save_scr.UseVisualStyleBackColor = false;
            this.button_save_scr.Click += new System.EventHandler(this.button_save_scr_Click);
            // 
            // button_load_scr
            // 
            this.button_load_scr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_load_scr.BackColor = System.Drawing.Color.Tomato;
            this.button_load_scr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load_scr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load_scr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_load_scr.Location = new System.Drawing.Point(435, 629);
            this.button_load_scr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_load_scr.Name = "button_load_scr";
            this.button_load_scr.Size = new System.Drawing.Size(81, 36);
            this.button_load_scr.TabIndex = 9;
            this.button_load_scr.Text = "Load Script";
            this.button_load_scr.UseVisualStyleBackColor = false;
            this.button_load_scr.Click += new System.EventHandler(this.button_load_scr_Click);
            // 
            // button_save_pic
            // 
            this.button_save_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save_pic.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_save_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save_pic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_save_pic.Location = new System.Drawing.Point(890, 17);
            this.button_save_pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save_pic.Name = "button_save_pic";
            this.button_save_pic.Size = new System.Drawing.Size(108, 45);
            this.button_save_pic.TabIndex = 10;
            this.button_save_pic.Text = "Save Picture";
            this.button_save_pic.UseVisualStyleBackColor = false;
            this.button_save_pic.Click += new System.EventHandler(this.button_save_pic_Click);
            // 
            // label_mouse_pos
            // 
            this.label_mouse_pos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_mouse_pos.AutoSize = true;
            this.label_mouse_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mouse_pos.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_mouse_pos.Location = new System.Drawing.Point(642, 36);
            this.label_mouse_pos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mouse_pos.Name = "label_mouse_pos";
            this.label_mouse_pos.Size = new System.Drawing.Size(25, 17);
            this.label_mouse_pos.TabIndex = 11;
            this.label_mouse_pos.Text = "x y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(390, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Thickness : ";
            // 
            // textBox_thickness
            // 
            this.textBox_thickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_thickness.Location = new System.Drawing.Point(470, 30);
            this.textBox_thickness.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_thickness.Name = "textBox_thickness";
            this.textBox_thickness.Size = new System.Drawing.Size(26, 23);
            this.textBox_thickness.TabIndex = 13;
            this.textBox_thickness.Text = "1";
            // 
            // button_pen_color
            // 
            this.button_pen_color.BackColor = System.Drawing.Color.Black;
            this.button_pen_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pen_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pen_color.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pen_color.Location = new System.Drawing.Point(523, 24);
            this.button_pen_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_pen_color.Name = "button_pen_color";
            this.button_pen_color.Size = new System.Drawing.Size(70, 32);
            this.button_pen_color.TabIndex = 14;
            this.button_pen_color.Text = "Color";
            this.button_pen_color.UseVisualStyleBackColor = false;
            this.button_pen_color.Click += new System.EventHandler(this.button_pen_color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(518, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose color";
            // 
            // label_thic_err
            // 
            this.label_thic_err.AutoSize = true;
            this.label_thic_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thic_err.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_thic_err.Location = new System.Drawing.Point(404, 11);
            this.label_thic_err.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_thic_err.Name = "label_thic_err";
            this.label_thic_err.Size = new System.Drawing.Size(91, 17);
            this.label_thic_err.TabIndex = 16;
            this.label_thic_err.Text = "Range 1-200";
            // 
            // button_clear_can
            // 
            this.button_clear_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_can.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_clear_can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear_can.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear_can.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear_can.Location = new System.Drawing.Point(756, 17);
            this.button_clear_can.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_clear_can.Name = "button_clear_can";
            this.button_clear_can.Size = new System.Drawing.Size(108, 45);
            this.button_clear_can.TabIndex = 17;
            this.button_clear_can.Text = "Clear Canvas";
            this.button_clear_can.UseVisualStyleBackColor = false;
            this.button_clear_can.Click += new System.EventHandler(this.button_clear_can_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox_output.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_output.Location = new System.Drawing.Point(610, 505);
            this.richTextBox_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ReadOnly = true;
            this.richTextBox_output.Size = new System.Drawing.Size(267, 160);
            this.richTextBox_output.TabIndex = 18;
            this.richTextBox_output.Text = "";
            // 
            // label_can_x
            // 
            this.label_can_x.AutoSize = true;
            this.label_can_x.BackColor = System.Drawing.Color.Snow;
            this.label_can_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_can_x.ForeColor = System.Drawing.Color.Green;
            this.label_can_x.Location = new System.Drawing.Point(554, 526);
            this.label_can_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_can_x.Name = "label_can_x";
            this.label_can_x.Size = new System.Drawing.Size(16, 17);
            this.label_can_x.TabIndex = 19;
            this.label_can_x.Text = "0";
            // 
            // label_can_y
            // 
            this.label_can_y.AutoSize = true;
            this.label_can_y.BackColor = System.Drawing.Color.Snow;
            this.label_can_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_can_y.ForeColor = System.Drawing.Color.Green;
            this.label_can_y.Location = new System.Drawing.Point(554, 557);
            this.label_can_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_can_y.Name = "label_can_y";
            this.label_can_y.Size = new System.Drawing.Size(16, 17);
            this.label_can_y.TabIndex = 20;
            this.label_can_y.Text = "0";
            // 
            // button_log_clear
            // 
            this.button_log_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_log_clear.BackColor = System.Drawing.Color.Tomato;
            this.button_log_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_log_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_log_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_log_clear.Location = new System.Drawing.Point(890, 506);
            this.button_log_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_log_clear.Name = "button_log_clear";
            this.button_log_clear.Size = new System.Drawing.Size(81, 36);
            this.button_log_clear.TabIndex = 21;
            this.button_log_clear.Text = "Clear";
            this.button_log_clear.UseVisualStyleBackColor = false;
            this.button_log_clear.Click += new System.EventHandler(this.button_log_clear_Click);
            // 
            // button_con_col
            // 
            this.button_con_col.BackColor = System.Drawing.Color.Black;
            this.button_con_col.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_con_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_con_col.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_con_col.Location = new System.Drawing.Point(530, 620);
            this.button_con_col.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_con_col.Name = "button_con_col";
            this.button_con_col.Size = new System.Drawing.Size(70, 32);
            this.button_con_col.TabIndex = 22;
            this.button_con_col.Text = "Color";
            this.button_con_col.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(536, 506);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(545, 597);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Color";
            // 
            // button_texture_br
            // 
            this.button_texture_br.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_texture_br.BackColor = System.Drawing.Color.Tomato;
            this.button_texture_br.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_texture_br.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_texture_br.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_texture_br.Location = new System.Drawing.Point(1024, 587);
            this.button_texture_br.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_texture_br.Name = "button_texture_br";
            this.button_texture_br.Size = new System.Drawing.Size(81, 36);
            this.button_texture_br.TabIndex = 26;
            this.button_texture_br.Text = "Texture";
            this.button_texture_br.UseVisualStyleBackColor = false;
            this.button_texture_br.Click += new System.EventHandler(this.button_texture_br_Click);
            // 
            // pictureBox_texture
            // 
            this.pictureBox_texture.Image = global::GPL_application.Properties.Resources.free_electric_lightning_texture_background_59;
            this.pictureBox_texture.Location = new System.Drawing.Point(890, 557);
            this.pictureBox_texture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_texture.Name = "pictureBox_texture";
            this.pictureBox_texture.Size = new System.Drawing.Size(122, 104);
            this.pictureBox_texture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_texture.TabIndex = 25;
            this.pictureBox_texture.TabStop = false;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_close.Image = global::GPL_application.Properties.Resources.close_hi;
            this.pictureBox_close.Location = new System.Drawing.Point(1092, 10);
            this.pictureBox_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(24, 25);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 4;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // pictureBox_min
            // 
            this.pictureBox_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_min.Image = global::GPL_application.Properties.Resources.minimize;
            this.pictureBox_min.Location = new System.Drawing.Point(1057, 10);
            this.pictureBox_min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_min.Name = "pictureBox_min";
            this.pictureBox_min.Size = new System.Drawing.Size(24, 25);
            this.pictureBox_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_min.TabIndex = 2;
            this.pictureBox_min.TabStop = false;
            this.pictureBox_min.Click += new System.EventHandler(this.pictureBox_min_Click);
            // 
            // pictureBox_canvas
            // 
            this.pictureBox_canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_canvas.Location = new System.Drawing.Point(10, 67);
            this.pictureBox_canvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_canvas.Name = "pictureBox_canvas";
            this.pictureBox_canvas.Size = new System.Drawing.Size(1107, 423);
            this.pictureBox_canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_canvas.TabIndex = 0;
            this.pictureBox_canvas.TabStop = false;
            this.pictureBox_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_canvas_MouseDown);
            this.pictureBox_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_canvas_MouseMove);
            this.pictureBox_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_canvas_MouseUp);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.button_texture_br);
            this.Controls.Add(this.pictureBox_texture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_con_col);
            this.Controls.Add(this.button_log_clear);
            this.Controls.Add(this.label_can_y);
            this.Controls.Add(this.label_can_x);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.button_clear_can);
            this.Controls.Add(this.label_thic_err);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_pen_color);
            this.Controls.Add(this.textBox_thickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mouse_pos);
            this.Controls.Add(this.button_save_pic);
            this.Controls.Add(this.button_load_scr);
            this.Controls.Add(this.button_save_scr);
            this.Controls.Add(this.button_clear_comm);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.groupBox_quickacc);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_min);
            this.Controls.Add(this.richTextBox_comm);
            this.Controls.Add(this.pictureBox_canvas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPL application";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_main_MouseUp);
            this.groupBox_quickacc.ResumeLayout(false);
            this.groupBox_quickacc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_texture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_canvas;
        private System.Windows.Forms.RichTextBox richTextBox_comm;
        private System.Windows.Forms.PictureBox pictureBox_min;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.GroupBox groupBox_quickacc;
        private System.Windows.Forms.RadioButton radioButton_pen;
        private System.Windows.Forms.RadioButton radioButton_cir;
        private System.Windows.Forms.RadioButton radioButton_rec;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_clear_comm;
        private System.Windows.Forms.Button button_save_scr;
        private System.Windows.Forms.Button button_load_scr;
        private System.Windows.Forms.Button button_save_pic;
        private System.Windows.Forms.Label label_mouse_pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_thickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_pen_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_thic_err;
        private System.Windows.Forms.Button button_clear_can;
        public System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Button button_log_clear;
        public System.Windows.Forms.Label label_can_x;
        public System.Windows.Forms.Label label_can_y;
        private System.Windows.Forms.Button button_con_col;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_texture;
        private System.Windows.Forms.Button button_texture_br;
    }
}

