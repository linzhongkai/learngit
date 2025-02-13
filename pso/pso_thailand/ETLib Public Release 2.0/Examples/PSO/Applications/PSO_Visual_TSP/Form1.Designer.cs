namespace PSO_basic_visual_TSP
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
            this.button1 = new System.Windows.Forms.Button();
            this.PSOGraph = new ZedGraph.ZedGraphControl();
            this.ObjVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PSO_Function = new ZedGraph.ZedGraphControl();
            this.PSO_dynamic = new System.Windows.Forms.Button();
            this.RunPSO = new System.Windows.Forms.Button();
            this.Animation = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AniStepRun = new System.Windows.Forms.Button();
            this.AniStep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AniSpeed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PSOpara = new System.Windows.Forms.GroupBox();
            this.PSOcn = new System.Windows.Forms.TextBox();
            this.PSOcl = new System.Windows.Forms.TextBox();
            this.PSOcg = new System.Windows.Forms.TextBox();
            this.PSOcp = new System.Windows.Forms.TextBox();
            this.PSOwmax = new System.Windows.Forms.TextBox();
            this.PSOwmin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PSOnb = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PSOnumParticles = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PSOiter = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PSOpara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSOnb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSOnumParticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSOiter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSOGraph
            // 
            this.PSOGraph.Location = new System.Drawing.Point(22, 321);
            this.PSOGraph.Name = "PSOGraph";
            this.PSOGraph.ScrollGrace = 0;
            this.PSOGraph.ScrollMaxX = 0;
            this.PSOGraph.ScrollMaxY = 0;
            this.PSOGraph.ScrollMaxY2 = 0;
            this.PSOGraph.ScrollMinX = 0;
            this.PSOGraph.ScrollMinY = 0;
            this.PSOGraph.ScrollMinY2 = 0;
            this.PSOGraph.Size = new System.Drawing.Size(278, 192);
            this.PSOGraph.TabIndex = 1;
            // 
            // ObjVal
            // 
            this.ObjVal.Location = new System.Drawing.Point(284, 570);
            this.ObjVal.Name = "ObjVal";
            this.ObjVal.ReadOnly = true;
            this.ObjVal.Size = new System.Drawing.Size(100, 20);
            this.ObjVal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Computational Time";
            // 
            // PSO_Function
            // 
            this.PSO_Function.Location = new System.Drawing.Point(22, 27);
            this.PSO_Function.Name = "PSO_Function";
            this.PSO_Function.ScrollGrace = 0;
            this.PSO_Function.ScrollMaxX = 0;
            this.PSO_Function.ScrollMaxY = 0;
            this.PSO_Function.ScrollMaxY2 = 0;
            this.PSO_Function.ScrollMinX = 0;
            this.PSO_Function.ScrollMinY = 0;
            this.PSO_Function.ScrollMinY2 = 0;
            this.PSO_Function.Size = new System.Drawing.Size(278, 278);
            this.PSO_Function.TabIndex = 4;
            // 
            // PSO_dynamic
            // 
            this.PSO_dynamic.Enabled = false;
            this.PSO_dynamic.Location = new System.Drawing.Point(34, 114);
            this.PSO_dynamic.Name = "PSO_dynamic";
            this.PSO_dynamic.Size = new System.Drawing.Size(105, 26);
            this.PSO_dynamic.TabIndex = 7;
            this.PSO_dynamic.Text = "Animate";
            this.PSO_dynamic.UseVisualStyleBackColor = true;
            this.PSO_dynamic.Click += new System.EventHandler(this.PSO_dynamic_Click);
            // 
            // RunPSO
            // 
            this.RunPSO.Location = new System.Drawing.Point(284, 519);
            this.RunPSO.Name = "RunPSO";
            this.RunPSO.Size = new System.Drawing.Size(105, 26);
            this.RunPSO.TabIndex = 8;
            this.RunPSO.Text = "RunPSO";
            this.RunPSO.UseVisualStyleBackColor = true;
            this.RunPSO.Click += new System.EventHandler(this.button2_Click);
            // 
            // Animation
            // 
            this.Animation.Location = new System.Drawing.Point(339, 44);
            this.Animation.Name = "Animation";
            this.Animation.ScrollGrace = 0;
            this.Animation.ScrollMaxX = 0;
            this.Animation.ScrollMaxY = 0;
            this.Animation.ScrollMaxY2 = 0;
            this.Animation.ScrollMinX = 0;
            this.Animation.ScrollMinY = 0;
            this.Animation.ScrollMinY2 = 0;
            this.Animation.Size = new System.Drawing.Size(460, 460);
            this.Animation.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Final Solution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Average Objective";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Animation";
            // 
            // AniStepRun
            // 
            this.AniStepRun.Enabled = false;
            this.AniStepRun.Location = new System.Drawing.Point(155, 38);
            this.AniStepRun.Name = "AniStepRun";
            this.AniStepRun.Size = new System.Drawing.Size(105, 26);
            this.AniStepRun.TabIndex = 13;
            this.AniStepRun.Text = "Animate_Step";
            this.AniStepRun.UseVisualStyleBackColor = true;
            this.AniStepRun.Click += new System.EventHandler(this.button3_Click);
            // 
            // AniStep
            // 
            this.AniStep.Enabled = false;
            this.AniStep.Location = new System.Drawing.Point(34, 44);
            this.AniStep.Name = "AniStep";
            this.AniStep.Size = new System.Drawing.Size(100, 20);
            this.AniStep.TabIndex = 14;
            this.AniStep.TextChanged += new System.EventHandler(this.AniStep_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Step for Animation";
            // 
            // Back
            // 
            this.Back.Enabled = false;
            this.Back.Location = new System.Drawing.Point(155, 72);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 26);
            this.Back.TabIndex = 16;
            this.Back.Text = "<<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Enabled = false;
            this.Forward.Location = new System.Drawing.Point(210, 72);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(49, 26);
            this.Forward.TabIndex = 17;
            this.Forward.Text = ">>";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ani_Speed (ms/step)";
            // 
            // AniSpeed
            // 
            this.AniSpeed.Enabled = false;
            this.AniSpeed.Location = new System.Drawing.Point(34, 83);
            this.AniSpeed.Name = "AniSpeed";
            this.AniSpeed.Size = new System.Drawing.Size(100, 20);
            this.AniSpeed.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "Rescale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PSOpara
            // 
            this.PSOpara.Controls.Add(this.PSOcn);
            this.PSOpara.Controls.Add(this.PSOcl);
            this.PSOpara.Controls.Add(this.PSOcg);
            this.PSOpara.Controls.Add(this.PSOcp);
            this.PSOpara.Controls.Add(this.PSOwmax);
            this.PSOpara.Controls.Add(this.PSOwmin);
            this.PSOpara.Controls.Add(this.label15);
            this.PSOpara.Controls.Add(this.PSOnb);
            this.PSOpara.Controls.Add(this.label13);
            this.PSOpara.Controls.Add(this.label14);
            this.PSOpara.Controls.Add(this.label11);
            this.PSOpara.Controls.Add(this.label12);
            this.PSOpara.Controls.Add(this.label10);
            this.PSOpara.Controls.Add(this.label9);
            this.PSOpara.Controls.Add(this.label8);
            this.PSOpara.Controls.Add(this.PSOnumParticles);
            this.PSOpara.Controls.Add(this.label2);
            this.PSOpara.Controls.Add(this.PSOiter);
            this.PSOpara.Location = new System.Drawing.Point(22, 514);
            this.PSOpara.Name = "PSOpara";
            this.PSOpara.Size = new System.Drawing.Size(237, 164);
            this.PSOpara.TabIndex = 22;
            this.PSOpara.TabStop = false;
            this.PSOpara.Text = "PSO parameters";
            // 
            // PSOcn
            // 
            this.PSOcn.Location = new System.Drawing.Point(173, 103);
            this.PSOcn.Name = "PSOcn";
            this.PSOcn.Size = new System.Drawing.Size(49, 20);
            this.PSOcn.TabIndex = 44;
            // 
            // PSOcl
            // 
            this.PSOcl.Location = new System.Drawing.Point(173, 78);
            this.PSOcl.Name = "PSOcl";
            this.PSOcl.Size = new System.Drawing.Size(49, 20);
            this.PSOcl.TabIndex = 43;
            // 
            // PSOcg
            // 
            this.PSOcg.Location = new System.Drawing.Point(173, 49);
            this.PSOcg.Name = "PSOcg";
            this.PSOcg.Size = new System.Drawing.Size(49, 20);
            this.PSOcg.TabIndex = 42;
            // 
            // PSOcp
            // 
            this.PSOcp.Location = new System.Drawing.Point(173, 23);
            this.PSOcp.Name = "PSOcp";
            this.PSOcp.Size = new System.Drawing.Size(49, 20);
            this.PSOcp.TabIndex = 41;
            // 
            // PSOwmax
            // 
            this.PSOwmax.Location = new System.Drawing.Point(73, 103);
            this.PSOwmax.Name = "PSOwmax";
            this.PSOwmax.Size = new System.Drawing.Size(50, 20);
            this.PSOwmax.TabIndex = 40;
            // 
            // PSOwmin
            // 
            this.PSOwmin.Location = new System.Drawing.Point(73, 78);
            this.PSOwmin.Name = "PSOwmin";
            this.PSOwmin.Size = new System.Drawing.Size(50, 20);
            this.PSOwmin.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "# local";
            // 
            // PSOnb
            // 
            this.PSOnb.Location = new System.Drawing.Point(73, 130);
            this.PSOnb.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.PSOnb.Name = "PSOnb";
            this.PSOnb.Size = new System.Drawing.Size(50, 20);
            this.PSOnb.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "wmax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "wmin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "cn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "cl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "cg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "cp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "# particles";
            // 
            // PSOnumParticles
            // 
            this.PSOnumParticles.Location = new System.Drawing.Point(73, 50);
            this.PSOnumParticles.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PSOnumParticles.Name = "PSOnumParticles";
            this.PSOnumParticles.Size = new System.Drawing.Size(50, 20);
            this.PSOnumParticles.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "# iteration";
            // 
            // PSOiter
            // 
            this.PSOiter.Location = new System.Drawing.Point(73, 23);
            this.PSOiter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PSOiter.Name = "PSOiter";
            this.PSOiter.Size = new System.Drawing.Size(50, 20);
            this.PSOiter.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AniSpeed);
            this.groupBox1.Controls.Add(this.Forward);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AniStep);
            this.groupBox1.Controls.Add(this.AniStepRun);
            this.groupBox1.Controls.Add(this.PSO_dynamic);
            this.groupBox1.Location = new System.Drawing.Point(414, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 164);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation";
            // 
            // Form1
            // 
            this.AcceptButton = this.RunPSO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PSOpara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Animation);
            this.Controls.Add(this.RunPSO);
            this.Controls.Add(this.PSO_Function);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObjVal);
            this.Controls.Add(this.PSOGraph);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSO_TSP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PSOpara.ResumeLayout(false);
            this.PSOpara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PSOnb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSOnumParticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSOiter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl PSOGraph;
        private System.Windows.Forms.TextBox ObjVal;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl PSO_Function;
        private System.Windows.Forms.Button PSO_dynamic;
        private System.Windows.Forms.Button RunPSO;
        private ZedGraph.ZedGraphControl Animation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AniStepRun;
        private System.Windows.Forms.TextBox AniStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AniSpeed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox PSOpara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PSOiter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PSOnumParticles;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown PSOnb;
        private System.Windows.Forms.TextBox PSOcn;
        private System.Windows.Forms.TextBox PSOcl;
        private System.Windows.Forms.TextBox PSOcg;
        private System.Windows.Forms.TextBox PSOcp;
        private System.Windows.Forms.TextBox PSOwmax;
        private System.Windows.Forms.TextBox PSOwmin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

