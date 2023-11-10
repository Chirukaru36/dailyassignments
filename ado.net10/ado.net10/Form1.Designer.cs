namespace ado.net10
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertbtn = new System.Windows.Forms.Button();
            this.textcompanyid = new System.Windows.Forms.TextBox();
            this.textcompanyname = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.textcontactperson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(586, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(52, 344);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 39);
            this.insertbtn.TabIndex = 1;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // textcompanyid
            // 
            this.textcompanyid.Location = new System.Drawing.Point(224, 70);
            this.textcompanyid.Name = "textcompanyid";
            this.textcompanyid.Size = new System.Drawing.Size(100, 22);
            this.textcompanyid.TabIndex = 2;
            // 
            // textcompanyname
            // 
            this.textcompanyname.Location = new System.Drawing.Point(224, 120);
            this.textcompanyname.Name = "textcompanyname";
            this.textcompanyname.Size = new System.Drawing.Size(100, 22);
            this.textcompanyname.TabIndex = 3;
            // 
            // textcity
            // 
            this.textcity.Location = new System.Drawing.Point(224, 182);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(100, 22);
            this.textcity.TabIndex = 4;
            // 
            // textcontactperson
            // 
            this.textcontactperson.Location = new System.Drawing.Point(224, 233);
            this.textcontactperson.Name = "textcontactperson";
            this.textcontactperson.Size = new System.Drawing.Size(100, 22);
            this.textcontactperson.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter CompanyId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter CompanyName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter ContactPerson";
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(172, 344);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 39);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.Location = new System.Drawing.Point(313, 344);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 39);
            this.Findbtn.TabIndex = 11;
            this.Findbtn.Text = "Find";
            this.Findbtn.UseVisualStyleBackColor = true;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(454, 344);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 39);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 450);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textcontactperson);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.textcompanyname);
            this.Controls.Add(this.textcompanyid);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.TextBox textcompanyid;
        private System.Windows.Forms.TextBox textcompanyname;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.TextBox textcontactperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}

