namespace KnapsackAlgorithm
{
    partial class Calculator
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
            this.LB_Weight = new System.Windows.Forms.Label();
            this.LB_Volume = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_MaxWeigth = new System.Windows.Forms.Label();
            this.LB_MaxVolume = new System.Windows.Forms.Label();
            this.LB_ObjectAmount = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.GB_Objects = new System.Windows.Forms.GroupBox();
            this.BT_Next = new System.Windows.Forms.Button();
            this.NUD_Value = new System.Windows.Forms.NumericUpDown();
            this.NUD_Volume = new System.Windows.Forms.NumericUpDown();
            this.NUD_Weight = new System.Windows.Forms.NumericUpDown();
            this.LB_Value = new System.Windows.Forms.Label();
            this.NUD_MaxWeight = new System.Windows.Forms.NumericUpDown();
            this.NUD_MaxVolume = new System.Windows.Forms.NumericUpDown();
            this.NUD_ObjectNum = new System.Windows.Forms.NumericUpDown();
            this.BT_ToObjects = new System.Windows.Forms.Button();
            this.GB_Initialise = new System.Windows.Forms.GroupBox();
            this.LB_Solution = new System.Windows.Forms.Label();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.GB_Objects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ObjectNum)).BeginInit();
            this.GB_Initialise.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Weight
            // 
            this.LB_Weight.AutoSize = true;
            this.LB_Weight.Location = new System.Drawing.Point(7, 181);
            this.LB_Weight.Name = "LB_Weight";
            this.LB_Weight.Size = new System.Drawing.Size(63, 20);
            this.LB_Weight.TabIndex = 0;
            this.LB_Weight.Text = "Weight:";
            // 
            // LB_Volume
            // 
            this.LB_Volume.AutoSize = true;
            this.LB_Volume.Location = new System.Drawing.Point(215, 181);
            this.LB_Volume.Name = "LB_Volume";
            this.LB_Volume.Size = new System.Drawing.Size(67, 20);
            this.LB_Volume.TabIndex = 1;
            this.LB_Volume.Text = "Volume:";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(15, 75);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(55, 20);
            this.LB_Name.TabIndex = 2;
            this.LB_Name.Text = "Name:";
            // 
            // LB_MaxWeigth
            // 
            this.LB_MaxWeigth.AutoSize = true;
            this.LB_MaxWeigth.Location = new System.Drawing.Point(47, 60);
            this.LB_MaxWeigth.Name = "LB_MaxWeigth";
            this.LB_MaxWeigth.Size = new System.Drawing.Size(120, 20);
            this.LB_MaxWeigth.TabIndex = 3;
            this.LB_MaxWeigth.Text = "Maximal weight:";
            // 
            // LB_MaxVolume
            // 
            this.LB_MaxVolume.AutoSize = true;
            this.LB_MaxVolume.Location = new System.Drawing.Point(39, 92);
            this.LB_MaxVolume.Name = "LB_MaxVolume";
            this.LB_MaxVolume.Size = new System.Drawing.Size(128, 20);
            this.LB_MaxVolume.TabIndex = 4;
            this.LB_MaxVolume.Text = "Maximal Volume:";
            // 
            // LB_ObjectAmount
            // 
            this.LB_ObjectAmount.AutoSize = true;
            this.LB_ObjectAmount.Location = new System.Drawing.Point(22, 124);
            this.LB_ObjectAmount.Name = "LB_ObjectAmount";
            this.LB_ObjectAmount.Size = new System.Drawing.Size(145, 20);
            this.LB_ObjectAmount.TabIndex = 5;
            this.LB_ObjectAmount.Text = "Number of Objects:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(76, 72);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(120, 26);
            this.TB_Name.TabIndex = 8;
            // 
            // GB_Objects
            // 
            this.GB_Objects.Controls.Add(this.NUD_Value);
            this.GB_Objects.Controls.Add(this.NUD_Volume);
            this.GB_Objects.Controls.Add(this.NUD_Weight);
            this.GB_Objects.Controls.Add(this.LB_Value);
            this.GB_Objects.Controls.Add(this.LB_Weight);
            this.GB_Objects.Controls.Add(this.TB_Name);
            this.GB_Objects.Controls.Add(this.LB_Volume);
            this.GB_Objects.Controls.Add(this.LB_Name);
            this.GB_Objects.Enabled = false;
            this.GB_Objects.Location = new System.Drawing.Point(199, 231);
            this.GB_Objects.Name = "GB_Objects";
            this.GB_Objects.Size = new System.Drawing.Size(423, 262);
            this.GB_Objects.TabIndex = 12;
            this.GB_Objects.TabStop = false;
            // 
            // BT_Next
            // 
            this.BT_Next.Enabled = false;
            this.BT_Next.Location = new System.Drawing.Point(531, 499);
            this.BT_Next.Name = "BT_Next";
            this.BT_Next.Size = new System.Drawing.Size(75, 30);
            this.BT_Next.TabIndex = 19;
            this.BT_Next.Text = "Next";
            this.BT_Next.UseVisualStyleBackColor = true;
            this.BT_Next.Click += new System.EventHandler(this.BT_Next_Click);
            // 
            // NUD_Value
            // 
            this.NUD_Value.Location = new System.Drawing.Point(287, 73);
            this.NUD_Value.Name = "NUD_Value";
            this.NUD_Value.Size = new System.Drawing.Size(120, 26);
            this.NUD_Value.TabIndex = 16;
            // 
            // NUD_Volume
            // 
            this.NUD_Volume.Location = new System.Drawing.Point(288, 179);
            this.NUD_Volume.Name = "NUD_Volume";
            this.NUD_Volume.Size = new System.Drawing.Size(120, 26);
            this.NUD_Volume.TabIndex = 17;
            // 
            // NUD_Weight
            // 
            this.NUD_Weight.Location = new System.Drawing.Point(76, 179);
            this.NUD_Weight.Name = "NUD_Weight";
            this.NUD_Weight.Size = new System.Drawing.Size(120, 26);
            this.NUD_Weight.TabIndex = 18;
            // 
            // LB_Value
            // 
            this.LB_Value.AutoSize = true;
            this.LB_Value.Location = new System.Drawing.Point(227, 72);
            this.LB_Value.Name = "LB_Value";
            this.LB_Value.Size = new System.Drawing.Size(54, 20);
            this.LB_Value.TabIndex = 12;
            this.LB_Value.Text = "Value:";
            // 
            // NUD_MaxWeight
            // 
            this.NUD_MaxWeight.Location = new System.Drawing.Point(173, 58);
            this.NUD_MaxWeight.Name = "NUD_MaxWeight";
            this.NUD_MaxWeight.Size = new System.Drawing.Size(120, 26);
            this.NUD_MaxWeight.TabIndex = 13;
            // 
            // NUD_MaxVolume
            // 
            this.NUD_MaxVolume.Location = new System.Drawing.Point(173, 90);
            this.NUD_MaxVolume.Name = "NUD_MaxVolume";
            this.NUD_MaxVolume.Size = new System.Drawing.Size(120, 26);
            this.NUD_MaxVolume.TabIndex = 14;
            // 
            // NUD_ObjectNum
            // 
            this.NUD_ObjectNum.Location = new System.Drawing.Point(173, 122);
            this.NUD_ObjectNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_ObjectNum.Name = "NUD_ObjectNum";
            this.NUD_ObjectNum.Size = new System.Drawing.Size(120, 26);
            this.NUD_ObjectNum.TabIndex = 15;
            this.NUD_ObjectNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BT_ToObjects
            // 
            this.BT_ToObjects.Location = new System.Drawing.Point(218, 154);
            this.BT_ToObjects.Name = "BT_ToObjects";
            this.BT_ToObjects.Size = new System.Drawing.Size(75, 33);
            this.BT_ToObjects.TabIndex = 16;
            this.BT_ToObjects.Text = "Ready";
            this.BT_ToObjects.UseVisualStyleBackColor = true;
            this.BT_ToObjects.Click += new System.EventHandler(this.BT_ToObjects_Click);
            // 
            // GB_Initialise
            // 
            this.GB_Initialise.Controls.Add(this.BT_ToObjects);
            this.GB_Initialise.Controls.Add(this.LB_MaxWeigth);
            this.GB_Initialise.Controls.Add(this.NUD_ObjectNum);
            this.GB_Initialise.Controls.Add(this.LB_MaxVolume);
            this.GB_Initialise.Controls.Add(this.NUD_MaxVolume);
            this.GB_Initialise.Controls.Add(this.LB_ObjectAmount);
            this.GB_Initialise.Controls.Add(this.NUD_MaxWeight);
            this.GB_Initialise.Location = new System.Drawing.Point(37, 12);
            this.GB_Initialise.Name = "GB_Initialise";
            this.GB_Initialise.Size = new System.Drawing.Size(392, 213);
            this.GB_Initialise.TabIndex = 17;
            this.GB_Initialise.TabStop = false;
            // 
            // LB_Solution
            // 
            this.LB_Solution.AutoSize = true;
            this.LB_Solution.Location = new System.Drawing.Point(84, 544);
            this.LB_Solution.Name = "LB_Solution";
            this.LB_Solution.Size = new System.Drawing.Size(0, 20);
            this.LB_Solution.TabIndex = 18;
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(874, 644);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(75, 30);
            this.BT_Exit.TabIndex = 20;
            this.BT_Exit.Text = "Exit";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 691);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Next);
            this.Controls.Add(this.LB_Solution);
            this.Controls.Add(this.GB_Initialise);
            this.Controls.Add(this.GB_Objects);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.GB_Objects.ResumeLayout(false);
            this.GB_Objects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_MaxVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ObjectNum)).EndInit();
            this.GB_Initialise.ResumeLayout(false);
            this.GB_Initialise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Weight;
        private System.Windows.Forms.Label LB_Volume;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_MaxWeigth;
        private System.Windows.Forms.Label LB_MaxVolume;
        private System.Windows.Forms.Label LB_ObjectAmount;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.GroupBox GB_Objects;
        private System.Windows.Forms.Label LB_Value;
        private System.Windows.Forms.NumericUpDown NUD_Value;
        private System.Windows.Forms.NumericUpDown NUD_Volume;
        private System.Windows.Forms.NumericUpDown NUD_Weight;
        private System.Windows.Forms.NumericUpDown NUD_MaxWeight;
        private System.Windows.Forms.NumericUpDown NUD_MaxVolume;
        private System.Windows.Forms.NumericUpDown NUD_ObjectNum;
        private System.Windows.Forms.Button BT_Next;
        private System.Windows.Forms.Button BT_ToObjects;
        private System.Windows.Forms.GroupBox GB_Initialise;
        private System.Windows.Forms.Label LB_Solution;
        private System.Windows.Forms.Button BT_Exit;
    }
}

