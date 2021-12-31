
namespace Terminal
{
    partial class MainForm
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
            System.Windows.Forms.PropertyGrid propertyPortA;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialPortA = new System.IO.Ports.SerialPort(this.components);
            this.serialPortB = new System.IO.Ports.SerialPort(this.components);
            this.propertyPortB = new System.Windows.Forms.PropertyGrid();
            this._openPortA = new System.Windows.Forms.Button();
            this._closePortA = new System.Windows.Forms.Button();
            this._openPortB = new System.Windows.Forms.Button();
            this._closePortB = new System.Windows.Forms.Button();
            propertyPortA = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(961, 359);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._closePortA);
            this.groupBox1.Controls.Add(this._openPortA);
            this.groupBox1.Controls.Add(propertyPortA);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._closePortB);
            this.groupBox2.Controls.Add(this._openPortB);
            this.groupBox2.Controls.Add(this.propertyPortB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(483, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 353);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port B";
            // 
            // propertyPortA
            // 
            propertyPortA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            propertyPortA.Location = new System.Drawing.Point(5, 21);
            propertyPortA.Name = "propertyPortA";
            propertyPortA.SelectedObject = this.serialPortA;
            propertyPortA.Size = new System.Drawing.Size(463, 297);
            propertyPortA.TabIndex = 0;
            // 
            // propertyPortB
            // 
            this.propertyPortB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyPortB.Location = new System.Drawing.Point(6, 21);
            this.propertyPortB.Name = "propertyPortB";
            this.propertyPortB.SelectedObject = this.serialPortB;
            this.propertyPortB.Size = new System.Drawing.Size(463, 297);
            this.propertyPortB.TabIndex = 0;
            // 
            // _openPortA
            // 
            this._openPortA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._openPortA.Location = new System.Drawing.Point(5, 324);
            this._openPortA.Name = "_openPortA";
            this._openPortA.Size = new System.Drawing.Size(75, 23);
            this._openPortA.TabIndex = 1;
            this._openPortA.Text = "Open";
            this._openPortA.UseVisualStyleBackColor = true;
            this._openPortA.Click += new System.EventHandler(this._openPortA_Click);
            // 
            // _closePortA
            // 
            this._closePortA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._closePortA.Location = new System.Drawing.Point(86, 324);
            this._closePortA.Name = "_closePortA";
            this._closePortA.Size = new System.Drawing.Size(75, 23);
            this._closePortA.TabIndex = 2;
            this._closePortA.Text = "Close";
            this._closePortA.UseVisualStyleBackColor = true;
            this._closePortA.Click += new System.EventHandler(this._closePortA_Click);
            // 
            // _openPortB
            // 
            this._openPortB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._openPortB.Location = new System.Drawing.Point(6, 324);
            this._openPortB.Name = "_openPortB";
            this._openPortB.Size = new System.Drawing.Size(75, 23);
            this._openPortB.TabIndex = 1;
            this._openPortB.Text = "Open";
            this._openPortB.UseVisualStyleBackColor = true;
            this._openPortB.Click += new System.EventHandler(this._openPortB_Click);
            // 
            // _closePortB
            // 
            this._closePortB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._closePortB.Location = new System.Drawing.Point(87, 324);
            this._closePortB.Name = "_closePortB";
            this._closePortB.Size = new System.Drawing.Size(75, 23);
            this._closePortB.TabIndex = 2;
            this._closePortB.Text = "Close";
            this._closePortB.UseVisualStyleBackColor = true;
            this._closePortB.Click += new System.EventHandler(this._closePortB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Terminal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPortA;
        private System.IO.Ports.SerialPort serialPortB;
        private System.Windows.Forms.PropertyGrid propertyPortB;
        private System.Windows.Forms.Button _closePortA;
        private System.Windows.Forms.Button _openPortA;
        private System.Windows.Forms.Button _closePortB;
        private System.Windows.Forms.Button _openPortB;
    }
}

