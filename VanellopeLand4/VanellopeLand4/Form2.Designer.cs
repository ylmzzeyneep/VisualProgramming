namespace VanellopeLand4
{
    partial class Form2
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageRestrictionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vanellopeLandDataSet1 = new VanellopeLand4.VanellopeLandDataSet1();
            this.form2TableAdapter = new VanellopeLand4.VanellopeLandDataSet1TableAdapters.Form2TableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanellopeLandDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1307, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1066, 261);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(338, 22);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1258, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1258, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1258, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1258, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1063, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Game Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1063, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Game Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1063, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age Restriction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1063, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Game Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1063, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Game Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(95, 394);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(97, 22);
            this.textBox6.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1066, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(939, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 31);
            this.button4.TabIndex = 26;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.gameNameDataGridViewTextBoxColumn,
            this.gameTypeDataGridViewTextBoxColumn,
            this.ageRestrictionDataGridViewTextBoxColumn,
            this.gameFeeDataGridViewTextBoxColumn,
            this.gameDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.form2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 241);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameNameDataGridViewTextBoxColumn
            // 
            this.gameNameDataGridViewTextBoxColumn.DataPropertyName = "gameName";
            this.gameNameDataGridViewTextBoxColumn.HeaderText = "gameName";
            this.gameNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameNameDataGridViewTextBoxColumn.Name = "gameNameDataGridViewTextBoxColumn";
            this.gameNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameTypeDataGridViewTextBoxColumn
            // 
            this.gameTypeDataGridViewTextBoxColumn.DataPropertyName = "gameType";
            this.gameTypeDataGridViewTextBoxColumn.HeaderText = "gameType";
            this.gameTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameTypeDataGridViewTextBoxColumn.Name = "gameTypeDataGridViewTextBoxColumn";
            this.gameTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageRestrictionDataGridViewTextBoxColumn
            // 
            this.ageRestrictionDataGridViewTextBoxColumn.DataPropertyName = "ageRestriction";
            this.ageRestrictionDataGridViewTextBoxColumn.HeaderText = "ageRestriction";
            this.ageRestrictionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageRestrictionDataGridViewTextBoxColumn.Name = "ageRestrictionDataGridViewTextBoxColumn";
            this.ageRestrictionDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameFeeDataGridViewTextBoxColumn
            // 
            this.gameFeeDataGridViewTextBoxColumn.DataPropertyName = "gameFee";
            this.gameFeeDataGridViewTextBoxColumn.HeaderText = "gameFee";
            this.gameFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameFeeDataGridViewTextBoxColumn.Name = "gameFeeDataGridViewTextBoxColumn";
            this.gameFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameDescriptionDataGridViewTextBoxColumn
            // 
            this.gameDescriptionDataGridViewTextBoxColumn.DataPropertyName = "gameDescription";
            this.gameDescriptionDataGridViewTextBoxColumn.HeaderText = "gameDescription";
            this.gameDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameDescriptionDataGridViewTextBoxColumn.Name = "gameDescriptionDataGridViewTextBoxColumn";
            this.gameDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataMember = "Form2";
            this.form2BindingSource.DataSource = this.vanellopeLandDataSet1;
            // 
            // vanellopeLandDataSet1
            // 
            this.vanellopeLandDataSet1.DataSetName = "VanellopeLandDataSet1";
            this.vanellopeLandDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // form2TableAdapter
            // 
            this.form2TableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1259, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 31);
            this.button5.TabIndex = 28;
            this.button5.Text = "Draw Chart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 543);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanellopeLandDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VanellopeLandDataSet1 vanellopeLandDataSet1;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private VanellopeLandDataSet1TableAdapters.Form2TableAdapter form2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageRestrictionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}