namespace RemoteThermoControlPC
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
            this.accel_z = new System.Windows.Forms.Label();
            this.accel_y = new System.Windows.Forms.Label();
            this.accel_x = new System.Windows.Forms.Label();
            this.humid = new System.Windows.Forms.Label();
            this.ambiTemp = new System.Windows.Forms.Label();
            this.press = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gyrox = new System.Windows.Forms.Label();
            this.gyroy = new System.Windows.Forms.Label();
            this.gyroz = new System.Windows.Forms.Label();
            this.magx = new System.Windows.Forms.Label();
            this.magy = new System.Windows.Forms.Label();
            this.magz = new System.Windows.Forms.Label();
            this.mag = new System.Windows.Forms.Label();
            this.accelz = new System.Windows.Forms.Label();
            this.accely = new System.Windows.Forms.Label();
            this.accelx = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.accel = new System.Windows.Forms.Label();
            this.accx = new System.Windows.Forms.Label();
            this.accy = new System.Windows.Forms.Label();
            this.accz = new System.Windows.Forms.Label();
            this.maz = new System.Windows.Forms.Label();
            this.may = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.gyrz = new System.Windows.Forms.Label();
            this.gyry = new System.Windows.Forms.Label();
            this.gyrx = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.humi = new System.Windows.Forms.Label();
            this.TempTh = new System.Windows.Forms.Label();
            this.TempThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sysstatus = new System.Windows.Forms.Label();
            this.SetTemp = new System.Windows.Forms.Button();
            this.msgt = new System.Windows.Forms.Label();
            this.msgTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accel_z
            // 
            this.accel_z.AutoSize = true;
            this.accel_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accel_z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.accel_z.Location = new System.Drawing.Point(106, 189);
            this.accel_z.Name = "accel_z";
            this.accel_z.Size = new System.Drawing.Size(0, 29);
            this.accel_z.TabIndex = 18;
            // 
            // accel_y
            // 
            this.accel_y.AutoSize = true;
            this.accel_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accel_y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.accel_y.Location = new System.Drawing.Point(106, 160);
            this.accel_y.Name = "accel_y";
            this.accel_y.Size = new System.Drawing.Size(0, 29);
            this.accel_y.TabIndex = 17;
            // 
            // accel_x
            // 
            this.accel_x.AutoSize = true;
            this.accel_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accel_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.accel_x.Location = new System.Drawing.Point(106, 131);
            this.accel_x.Name = "accel_x";
            this.accel_x.Size = new System.Drawing.Size(0, 29);
            this.accel_x.TabIndex = 16;
            // 
            // humid
            // 
            this.humid.AutoSize = true;
            this.humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humid.ForeColor = System.Drawing.Color.Lime;
            this.humid.Location = new System.Drawing.Point(58, 319);
            this.humid.Name = "humid";
            this.humid.Size = new System.Drawing.Size(162, 29);
            this.humid.TabIndex = 15;
            this.humid.Text = "Humidity (%) :";
            // 
            // ambiTemp
            // 
            this.ambiTemp.AutoSize = true;
            this.ambiTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiTemp.ForeColor = System.Drawing.Color.Lime;
            this.ambiTemp.Location = new System.Drawing.Point(58, 277);
            this.ambiTemp.Name = "ambiTemp";
            this.ambiTemp.Size = new System.Drawing.Size(204, 29);
            this.ambiTemp.TabIndex = 14;
            this.ambiTemp.Text = "Temperature (C) :";
            // 
            // press
            // 
            this.press.AutoSize = true;
            this.press.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.press.ForeColor = System.Drawing.Color.Lime;
            this.press.Location = new System.Drawing.Point(58, 237);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(186, 29);
            this.press.TabIndex = 13;
            this.press.Text = "Pressure (hPa) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(640, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gyroscope (deg/s)";
            // 
            // gyrox
            // 
            this.gyrox.AutoSize = true;
            this.gyrox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyrox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyrox.Location = new System.Drawing.Point(640, 131);
            this.gyrox.Name = "gyrox";
            this.gyrox.Size = new System.Drawing.Size(42, 29);
            this.gyrox.TabIndex = 10;
            this.gyrox.Text = "X :";
            // 
            // gyroy
            // 
            this.gyroy.AutoSize = true;
            this.gyroy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyroy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyroy.Location = new System.Drawing.Point(640, 160);
            this.gyroy.Name = "gyroy";
            this.gyroy.Size = new System.Drawing.Size(41, 29);
            this.gyroy.TabIndex = 11;
            this.gyroy.Text = "Y :";
            // 
            // gyroz
            // 
            this.gyroz.AutoSize = true;
            this.gyroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyroz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyroz.Location = new System.Drawing.Point(640, 189);
            this.gyroz.Name = "gyroz";
            this.gyroz.Size = new System.Drawing.Size(39, 29);
            this.gyroz.TabIndex = 12;
            this.gyroz.Text = "Z :";
            // 
            // magx
            // 
            this.magx.AutoSize = true;
            this.magx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.magx.Location = new System.Drawing.Point(347, 131);
            this.magx.Name = "magx";
            this.magx.Size = new System.Drawing.Size(42, 29);
            this.magx.TabIndex = 6;
            this.magx.Text = "X :";
            // 
            // magy
            // 
            this.magy.AutoSize = true;
            this.magy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.magy.Location = new System.Drawing.Point(347, 160);
            this.magy.Name = "magy";
            this.magy.Size = new System.Drawing.Size(41, 29);
            this.magy.TabIndex = 7;
            this.magy.Text = "Y :";
            // 
            // magz
            // 
            this.magz.AutoSize = true;
            this.magz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.magz.Location = new System.Drawing.Point(347, 189);
            this.magz.Name = "magz";
            this.magz.Size = new System.Drawing.Size(39, 29);
            this.magz.TabIndex = 8;
            this.magz.Text = "Z :";
            // 
            // mag
            // 
            this.mag.AutoSize = true;
            this.mag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag.ForeColor = System.Drawing.Color.Lime;
            this.mag.Location = new System.Drawing.Point(347, 102);
            this.mag.Name = "mag";
            this.mag.Size = new System.Drawing.Size(220, 29);
            this.mag.TabIndex = 5;
            this.mag.Text = "Magnetometer (uT)";
            // 
            // accelz
            // 
            this.accelz.AutoSize = true;
            this.accelz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accelz.Location = new System.Drawing.Point(58, 189);
            this.accelz.Name = "accelz";
            this.accelz.Size = new System.Drawing.Size(39, 29);
            this.accelz.TabIndex = 4;
            this.accelz.Text = "Z :";
            // 
            // accely
            // 
            this.accely.AutoSize = true;
            this.accely.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accely.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accely.Location = new System.Drawing.Point(58, 160);
            this.accely.Name = "accely";
            this.accely.Size = new System.Drawing.Size(41, 29);
            this.accely.TabIndex = 3;
            this.accely.Text = "Y :";
            // 
            // accelx
            // 
            this.accelx.AutoSize = true;
            this.accelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accelx.Location = new System.Drawing.Point(58, 131);
            this.accelx.Name = "accelx";
            this.accelx.Size = new System.Drawing.Size(42, 29);
            this.accelx.TabIndex = 2;
            this.accelx.Text = "X :";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(324, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(402, 38);
            this.Title.TabIndex = 0;
            this.Title.Text = "Remote Thermo Controller";
            // 
            // accel
            // 
            this.accel.AutoSize = true;
            this.accel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accel.ForeColor = System.Drawing.Color.Lime;
            this.accel.Location = new System.Drawing.Point(58, 102);
            this.accel.Name = "accel";
            this.accel.Size = new System.Drawing.Size(206, 29);
            this.accel.TabIndex = 1;
            this.accel.Text = "Accelerometer (g)";
            // 
            // accx
            // 
            this.accx.AutoSize = true;
            this.accx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accx.Location = new System.Drawing.Point(106, 131);
            this.accx.Name = "accx";
            this.accx.Size = new System.Drawing.Size(0, 29);
            this.accx.TabIndex = 19;
            // 
            // accy
            // 
            this.accy.AutoSize = true;
            this.accy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accy.Location = new System.Drawing.Point(106, 160);
            this.accy.Name = "accy";
            this.accy.Size = new System.Drawing.Size(0, 29);
            this.accy.TabIndex = 20;
            // 
            // accz
            // 
            this.accz.AutoSize = true;
            this.accz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accz.Location = new System.Drawing.Point(106, 189);
            this.accz.Name = "accz";
            this.accz.Size = new System.Drawing.Size(0, 29);
            this.accz.TabIndex = 21;
            // 
            // maz
            // 
            this.maz.AutoSize = true;
            this.maz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maz.Location = new System.Drawing.Point(395, 189);
            this.maz.Name = "maz";
            this.maz.Size = new System.Drawing.Size(0, 29);
            this.maz.TabIndex = 24;
            // 
            // may
            // 
            this.may.AutoSize = true;
            this.may.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.may.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.may.Location = new System.Drawing.Point(395, 160);
            this.may.Name = "may";
            this.may.Size = new System.Drawing.Size(0, 29);
            this.may.TabIndex = 23;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.max.Location = new System.Drawing.Point(395, 131);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(0, 29);
            this.max.TabIndex = 22;
            // 
            // gyrz
            // 
            this.gyrz.AutoSize = true;
            this.gyrz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyrz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyrz.Location = new System.Drawing.Point(684, 189);
            this.gyrz.Name = "gyrz";
            this.gyrz.Size = new System.Drawing.Size(0, 29);
            this.gyrz.TabIndex = 27;
            // 
            // gyry
            // 
            this.gyry.AutoSize = true;
            this.gyry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyry.Location = new System.Drawing.Point(684, 160);
            this.gyry.Name = "gyry";
            this.gyry.Size = new System.Drawing.Size(0, 29);
            this.gyry.TabIndex = 26;
            // 
            // gyrx
            // 
            this.gyrx.AutoSize = true;
            this.gyrx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gyrx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gyrx.Location = new System.Drawing.Point(684, 131);
            this.gyrx.Name = "gyrx";
            this.gyrx.Size = new System.Drawing.Size(0, 29);
            this.gyrx.TabIndex = 25;
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pressure.Location = new System.Drawing.Point(275, 237);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(0, 29);
            this.pressure.TabIndex = 28;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.temperature.Location = new System.Drawing.Point(275, 277);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(0, 29);
            this.temperature.TabIndex = 29;
            // 
            // humi
            // 
            this.humi.AutoSize = true;
            this.humi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.humi.Location = new System.Drawing.Point(275, 319);
            this.humi.Name = "humi";
            this.humi.Size = new System.Drawing.Size(0, 29);
            this.humi.TabIndex = 30;
            // 
            // TempTh
            // 
            this.TempTh.AutoSize = true;
            this.TempTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempTh.ForeColor = System.Drawing.Color.Lime;
            this.TempTh.Location = new System.Drawing.Point(463, 277);
            this.TempTh.Name = "TempTh";
            this.TempTh.Size = new System.Drawing.Size(320, 29);
            this.TempTh.TabIndex = 31;
            this.TempTh.Text = "Temperature Threshold (C) :";
            // 
            // TempThreshold
            // 
            this.TempThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempThreshold.Location = new System.Drawing.Point(789, 277);
            this.TempThreshold.Name = "TempThreshold";
            this.TempThreshold.Size = new System.Drawing.Size(100, 34);
            this.TempThreshold.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(168, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chiller Status :";
            // 
            // sysstatus
            // 
            this.sysstatus.AutoSize = true;
            this.sysstatus.BackColor = System.Drawing.Color.Red;
            this.sysstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sysstatus.Location = new System.Drawing.Point(366, 433);
            this.sysstatus.Name = "sysstatus";
            this.sysstatus.Size = new System.Drawing.Size(151, 29);
            this.sysstatus.TabIndex = 34;
            this.sysstatus.Text = "Cooler OFF";
            // 
            // SetTemp
            // 
            this.SetTemp.BackColor = System.Drawing.Color.Yellow;
            this.SetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SetTemp.Location = new System.Drawing.Point(717, 351);
            this.SetTemp.Name = "SetTemp";
            this.SetTemp.Size = new System.Drawing.Size(79, 36);
            this.SetTemp.TabIndex = 35;
            this.SetTemp.Text = "Set";
            this.SetTemp.UseVisualStyleBackColor = false;
            this.SetTemp.Click += new System.EventHandler(this.SetTemp_Click);
            // 
            // msgt
            // 
            this.msgt.AutoSize = true;
            this.msgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgt.ForeColor = System.Drawing.Color.Lime;
            this.msgt.Location = new System.Drawing.Point(58, 358);
            this.msgt.Name = "msgt";
            this.msgt.Size = new System.Drawing.Size(174, 29);
            this.msgt.TabIndex = 36;
            this.msgt.Text = "Message Time";
            // 
            // msgTime
            // 
            this.msgTime.AutoSize = true;
            this.msgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msgTime.Location = new System.Drawing.Point(264, 358);
            this.msgTime.Name = "msgTime";
            this.msgTime.Size = new System.Drawing.Size(0, 29);
            this.msgTime.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1087, 528);
            this.Controls.Add(this.msgTime);
            this.Controls.Add(this.msgt);
            this.Controls.Add(this.SetTemp);
            this.Controls.Add(this.sysstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempThreshold);
            this.Controls.Add(this.TempTh);
            this.Controls.Add(this.humi);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.gyrz);
            this.Controls.Add(this.gyry);
            this.Controls.Add(this.gyrx);
            this.Controls.Add(this.maz);
            this.Controls.Add(this.may);
            this.Controls.Add(this.max);
            this.Controls.Add(this.accz);
            this.Controls.Add(this.accy);
            this.Controls.Add(this.accx);
            this.Controls.Add(this.accel_z);
            this.Controls.Add(this.accel_y);
            this.Controls.Add(this.accel_x);
            this.Controls.Add(this.humid);
            this.Controls.Add(this.ambiTemp);
            this.Controls.Add(this.press);
            this.Controls.Add(this.gyroz);
            this.Controls.Add(this.gyroy);
            this.Controls.Add(this.gyrox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.magz);
            this.Controls.Add(this.magy);
            this.Controls.Add(this.magx);
            this.Controls.Add(this.mag);
            this.Controls.Add(this.accelz);
            this.Controls.Add(this.accely);
            this.Controls.Add(this.accelx);
            this.Controls.Add(this.accel);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Remote Thermo Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label accelx;
        private System.Windows.Forms.Label accely;
        private System.Windows.Forms.Label accelz;
        private System.Windows.Forms.Label mag;
        private System.Windows.Forms.Label magz;
        private System.Windows.Forms.Label magy;
        private System.Windows.Forms.Label magx;
        private System.Windows.Forms.Label gyroz;
        private System.Windows.Forms.Label gyroy;
        private System.Windows.Forms.Label gyrox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label press;
        private System.Windows.Forms.Label ambiTemp;
        private System.Windows.Forms.Label humid;
        private System.Windows.Forms.Label accel_x;
        private System.Windows.Forms.Label accel_y;
        private System.Windows.Forms.Label accel_z;
        private System.Windows.Forms.Label accx;
        private System.Windows.Forms.Label accy;
        private System.Windows.Forms.Label accz;
        private System.Windows.Forms.Label maz;
        private System.Windows.Forms.Label may;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label gyrz;
        private System.Windows.Forms.Label gyry;
        private System.Windows.Forms.Label gyrx;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label humi;
        private System.Windows.Forms.Label TempTh;
        private System.Windows.Forms.TextBox TempThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sysstatus;
        private System.Windows.Forms.Button SetTemp;
        private System.Windows.Forms.Label msgt;
        private System.Windows.Forms.Label msgTime;
    }
}

