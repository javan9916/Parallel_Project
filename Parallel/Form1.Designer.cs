namespace ParallelProject
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
            System.Windows.Forms.ColumnHeader head;
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ejecucion1 = new System.Windows.Forms.Label();
            this.ejecucion2 = new System.Windows.Forms.Label();
            this.ejecucion3 = new System.Windows.Forms.Label();
            this.ejecucion4 = new System.Windows.Forms.Label();
            this.ejecucion5 = new System.Windows.Forms.Label();
            this.ejecucion6 = new System.Windows.Forms.Label();
            this.ejecucion7 = new System.Windows.Forms.Label();
            this.ejecucion8 = new System.Windows.Forms.Label();
            this.ejecucion9 = new System.Windows.Forms.Label();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CPUprogressBar = new System.Windows.Forms.ProgressBar();
            this.RAMprogressBar = new System.Windows.Forms.ProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblRepeats = new System.Windows.Forms.Label();
            this.lblRepeats2 = new System.Windows.Forms.Label();
            this.ejecucion0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ejecucionSecuencial = new System.Windows.Forms.Label();
            this.ejecucionParalela = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            head = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            head.Text = "Palabras más comunes";
            head.Width = 155;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Archivo: ";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(78, 82);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(0, 13);
            this.lblArchivo.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Documentos Word (*.doc),(*.docx)|*.doc;*.docx";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(827, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 141);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Secuencial";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 164);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Paralelo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elija el método";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Palabra más larga";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(26, 225);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Total de palabras";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(26, 249);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(170, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Número de palabras diferentes";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(26, 272);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(118, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Total de carácteres";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 295);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(179, 17);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Total de carácteres sin espacios";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(26, 318);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(137, 17);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "Recuento de oraciones";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(26, 346);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(152, 17);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "Repeticiones de la palabra";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(397, 18);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(135, 17);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Palabras más comunes";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(146, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(211, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(211, 246);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(211, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(211, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(211, 316);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 344);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(114, 20);
            this.textBox7.TabIndex = 27;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            head});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(397, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(162, 140);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header1,
            this.header2,
            this.header3});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(600, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(323, 275);
            this.listView2.TabIndex = 29;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // header1
            // 
            this.header1.Text = "Cant. de carácteres";
            this.header1.Width = 107;
            // 
            // header2
            // 
            this.header2.Text = "Núm. de incidencias";
            this.header2.Width = 110;
            // 
            // header3
            // 
            this.header3.Text = "Porcentaje";
            this.header3.Width = 97;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(529, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(30, 20);
            this.textBox8.TabIndex = 30;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(600, 18);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(66, 17);
            this.checkBox9.TabIndex = 31;
            this.checkBox9.Text = "Ranking";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Seleccionar todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ejecucion1
            // 
            this.ejecucion1.AutoSize = true;
            this.ejecucion1.Location = new System.Drawing.Point(285, 203);
            this.ejecucion1.Name = "ejecucion1";
            this.ejecucion1.Size = new System.Drawing.Size(13, 13);
            this.ejecucion1.TabIndex = 34;
            this.ejecucion1.Text = "0";
            // 
            // ejecucion2
            // 
            this.ejecucion2.AutoSize = true;
            this.ejecucion2.Location = new System.Drawing.Point(285, 226);
            this.ejecucion2.Name = "ejecucion2";
            this.ejecucion2.Size = new System.Drawing.Size(13, 13);
            this.ejecucion2.TabIndex = 35;
            this.ejecucion2.Text = "0";
            // 
            // ejecucion3
            // 
            this.ejecucion3.AutoSize = true;
            this.ejecucion3.Location = new System.Drawing.Point(285, 250);
            this.ejecucion3.Name = "ejecucion3";
            this.ejecucion3.Size = new System.Drawing.Size(13, 13);
            this.ejecucion3.TabIndex = 36;
            this.ejecucion3.Text = "0";
            // 
            // ejecucion4
            // 
            this.ejecucion4.AutoSize = true;
            this.ejecucion4.Location = new System.Drawing.Point(285, 273);
            this.ejecucion4.Name = "ejecucion4";
            this.ejecucion4.Size = new System.Drawing.Size(13, 13);
            this.ejecucion4.TabIndex = 37;
            this.ejecucion4.Text = "0";
            // 
            // ejecucion5
            // 
            this.ejecucion5.AutoSize = true;
            this.ejecucion5.Location = new System.Drawing.Point(285, 296);
            this.ejecucion5.Name = "ejecucion5";
            this.ejecucion5.Size = new System.Drawing.Size(13, 13);
            this.ejecucion5.TabIndex = 38;
            this.ejecucion5.Text = "0";
            // 
            // ejecucion6
            // 
            this.ejecucion6.AutoSize = true;
            this.ejecucion6.Location = new System.Drawing.Point(285, 319);
            this.ejecucion6.Name = "ejecucion6";
            this.ejecucion6.Size = new System.Drawing.Size(13, 13);
            this.ejecucion6.TabIndex = 39;
            this.ejecucion6.Text = "0";
            // 
            // ejecucion7
            // 
            this.ejecucion7.AutoSize = true;
            this.ejecucion7.Location = new System.Drawing.Point(304, 347);
            this.ejecucion7.Name = "ejecucion7";
            this.ejecucion7.Size = new System.Drawing.Size(13, 13);
            this.ejecucion7.TabIndex = 40;
            this.ejecucion7.Text = "0";
            // 
            // ejecucion8
            // 
            this.ejecucion8.AutoSize = true;
            this.ejecucion8.Location = new System.Drawing.Point(405, 190);
            this.ejecucion8.Name = "ejecucion8";
            this.ejecucion8.Size = new System.Drawing.Size(13, 13);
            this.ejecucion8.TabIndex = 41;
            this.ejecucion8.Text = "0";
            // 
            // ejecucion9
            // 
            this.ejecucion9.AutoSize = true;
            this.ejecucion9.Location = new System.Drawing.Point(607, 323);
            this.ejecucion9.Name = "ejecucion9";
            this.ejecucion9.Size = new System.Drawing.Size(13, 13);
            this.ejecucion9.TabIndex = 42;
            this.ejecucion9.Text = "0";
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "CPU: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "RAM: ";
            // 
            // CPUprogressBar
            // 
            this.CPUprogressBar.Location = new System.Drawing.Point(397, 223);
            this.CPUprogressBar.Name = "CPUprogressBar";
            this.CPUprogressBar.Size = new System.Drawing.Size(135, 23);
            this.CPUprogressBar.TabIndex = 45;
            // 
            // RAMprogressBar
            // 
            this.RAMprogressBar.Location = new System.Drawing.Point(397, 252);
            this.RAMprogressBar.Name = "RAMprogressBar";
            this.RAMprogressBar.Size = new System.Drawing.Size(135, 23);
            this.RAMprogressBar.TabIndex = 46;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(535, 230);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(24, 13);
            this.lblCPU.TabIndex = 47;
            this.lblCPU.Text = "0 %";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(535, 262);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(24, 13);
            this.lblRAM.TabIndex = 48;
            this.lblRAM.Text = "0 %";
            // 
            // lblRepeats
            // 
            this.lblRepeats.AutoSize = true;
            this.lblRepeats.Location = new System.Drawing.Point(192, 367);
            this.lblRepeats.Name = "lblRepeats";
            this.lblRepeats.Size = new System.Drawing.Size(13, 13);
            this.lblRepeats.TabIndex = 49;
            this.lblRepeats.Text = "0";
            // 
            // lblRepeats2
            // 
            this.lblRepeats2.AutoSize = true;
            this.lblRepeats2.Location = new System.Drawing.Point(229, 367);
            this.lblRepeats2.Name = "lblRepeats2";
            this.lblRepeats2.Size = new System.Drawing.Size(69, 13);
            this.lblRepeats2.TabIndex = 50;
            this.lblRepeats2.Text = "Repeticiones";
            // 
            // ejecucion0
            // 
            this.ejecucion0.AutoSize = true;
            this.ejecucion0.Location = new System.Drawing.Point(115, 50);
            this.ejecucion0.Name = "ejecucion0";
            this.ejecucion0.Size = new System.Drawing.Size(13, 13);
            this.ejecucion0.TabIndex = 51;
            this.ejecucion0.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Secuencial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Paralela:";
            // 
            // ejecucionSecuencial
            // 
            this.ejecucionSecuencial.AutoSize = true;
            this.ejecucionSecuencial.Location = new System.Drawing.Point(666, 350);
            this.ejecucionSecuencial.Name = "ejecucionSecuencial";
            this.ejecucionSecuencial.Size = new System.Drawing.Size(13, 13);
            this.ejecucionSecuencial.TabIndex = 56;
            this.ejecucionSecuencial.Text = "0";
            // 
            // ejecucionParalela
            // 
            this.ejecucionParalela.AutoSize = true;
            this.ejecucionParalela.Location = new System.Drawing.Point(666, 376);
            this.ejecucionParalela.Name = "ejecucionParalela";
            this.ejecucionParalela.Size = new System.Drawing.Size(13, 13);
            this.ejecucionParalela.TabIndex = 58;
            this.ejecucionParalela.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 405);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ejecucionParalela);
            this.Controls.Add(this.ejecucionSecuencial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ejecucion0);
            this.Controls.Add(this.lblRepeats2);
            this.Controls.Add(this.lblRepeats);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.RAMprogressBar);
            this.Controls.Add(this.CPUprogressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ejecucion9);
            this.Controls.Add(this.ejecucion8);
            this.Controls.Add(this.ejecucion7);
            this.Controls.Add(this.ejecucion6);
            this.Controls.Add(this.ejecucion5);
            this.Controls.Add(this.ejecucion4);
            this.Controls.Add(this.ejecucion3);
            this.Controls.Add(this.ejecucion2);
            this.Controls.Add(this.ejecucion1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Proyecto Arquitectura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader header1;
        private System.Windows.Forms.ColumnHeader header2;
        private System.Windows.Forms.ColumnHeader header3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ejecucion1;
        private System.Windows.Forms.Label ejecucion2;
        private System.Windows.Forms.Label ejecucion3;
        private System.Windows.Forms.Label ejecucion4;
        private System.Windows.Forms.Label ejecucion5;
        private System.Windows.Forms.Label ejecucion6;
        private System.Windows.Forms.Label ejecucion7;
        private System.Windows.Forms.Label ejecucion8;
        private System.Windows.Forms.Label ejecucion9;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar CPUprogressBar;
        private System.Windows.Forms.ProgressBar RAMprogressBar;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblRepeats;
        private System.Windows.Forms.Label lblRepeats2;
        private System.Windows.Forms.Label ejecucion0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ejecucionSecuencial;
        private System.Windows.Forms.Label ejecucionParalela;
        private System.Windows.Forms.Label label8;
    }
}

