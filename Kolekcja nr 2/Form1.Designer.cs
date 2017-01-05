namespace Kolekcja_nr_2
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
            this.AddValueGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NewValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValueByIndexShowButton = new System.Windows.Forms.Button();
            this.IndexToShowValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IndeksByValueShowButton = new System.Windows.Forms.Button();
            this.ValueToShowIndex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModifyValueButton = new System.Windows.Forms.Button();
            this.IndexToModifyValue = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RemoveByValueButton = new System.Windows.Forms.Button();
            this.ValueToDeleteElement = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RemoveByIndexButton = new System.Windows.Forms.Button();
            this.IndexToDeleteValue = new System.Windows.Forms.TextBox();
            this.CollectionView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowCollectionButton = new System.Windows.Forms.Button();
            this.ClearCollectionButton = new System.Windows.Forms.Button();
            this.ValueToModify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddValueGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddValueGroupBox
            // 
            this.AddValueGroupBox.Controls.Add(this.AddButton);
            this.AddValueGroupBox.Controls.Add(this.NewValue);
            this.AddValueGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddValueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddValueGroupBox.Name = "AddValueGroupBox";
            this.AddValueGroupBox.Size = new System.Drawing.Size(181, 158);
            this.AddValueGroupBox.TabIndex = 0;
            this.AddValueGroupBox.TabStop = false;
            this.AddValueGroupBox.Text = "Dodaj wartość do kolekcji";
            this.AddValueGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 100);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(159, 35);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NewValue
            // 
            this.NewValue.Location = new System.Drawing.Point(6, 61);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(159, 26);
            this.NewValue.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ValueByIndexShowButton);
            this.groupBox1.Controls.Add(this.IndexToShowValue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyświetl wartość o podanym indeksie";
            // 
            // ValueByIndexShowButton
            // 
            this.ValueByIndexShowButton.Location = new System.Drawing.Point(18, 111);
            this.ValueByIndexShowButton.Name = "ValueByIndexShowButton";
            this.ValueByIndexShowButton.Size = new System.Drawing.Size(147, 39);
            this.ValueByIndexShowButton.TabIndex = 1;
            this.ValueByIndexShowButton.Text = "Wyświetl";
            this.ValueByIndexShowButton.UseVisualStyleBackColor = true;
            this.ValueByIndexShowButton.Click += new System.EventHandler(this.ValueByIndexShowButton_Click);
            // 
            // IndexToShowValue
            // 
            this.IndexToShowValue.Location = new System.Drawing.Point(18, 75);
            this.IndexToShowValue.Name = "IndexToShowValue";
            this.IndexToShowValue.Size = new System.Drawing.Size(147, 26);
            this.IndexToShowValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IndeksByValueShowButton);
            this.groupBox2.Controls.Add(this.ValueToShowIndex);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(227, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyświetl indeks podanej wartości";
            // 
            // IndeksByValueShowButton
            // 
            this.IndeksByValueShowButton.Location = new System.Drawing.Point(18, 87);
            this.IndeksByValueShowButton.Name = "IndeksByValueShowButton";
            this.IndeksByValueShowButton.Size = new System.Drawing.Size(147, 39);
            this.IndeksByValueShowButton.TabIndex = 1;
            this.IndeksByValueShowButton.Text = "Wyświetl";
            this.IndeksByValueShowButton.UseVisualStyleBackColor = true;
            this.IndeksByValueShowButton.Click += new System.EventHandler(this.IndeksByValueShowButton_Click);
            // 
            // ValueToShowIndex
            // 
            this.ValueToShowIndex.Location = new System.Drawing.Point(18, 51);
            this.ValueToShowIndex.Name = "ValueToShowIndex";
            this.ValueToShowIndex.Size = new System.Drawing.Size(147, 26);
            this.ValueToShowIndex.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ValueToModify);
            this.groupBox3.Controls.Add(this.ModifyValueButton);
            this.groupBox3.Controls.Add(this.IndexToModifyValue);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(436, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 190);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modyfikuj wartość o podanym indeksie";
            // 
            // ModifyValueButton
            // 
            this.ModifyValueButton.Location = new System.Drawing.Point(18, 138);
            this.ModifyValueButton.Name = "ModifyValueButton";
            this.ModifyValueButton.Size = new System.Drawing.Size(147, 39);
            this.ModifyValueButton.TabIndex = 1;
            this.ModifyValueButton.Text = "Modyfikuj";
            this.ModifyValueButton.UseVisualStyleBackColor = true;
            this.ModifyValueButton.Click += new System.EventHandler(this.ModifyValueButton_Click);
            // 
            // IndexToModifyValue
            // 
            this.IndexToModifyValue.Location = new System.Drawing.Point(54, 102);
            this.IndexToModifyValue.Name = "IndexToModifyValue";
            this.IndexToModifyValue.Size = new System.Drawing.Size(111, 26);
            this.IndexToModifyValue.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RemoveByValueButton);
            this.groupBox4.Controls.Add(this.ValueToDeleteElement);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(436, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 156);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuń element na podstawie wartości";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // RemoveByValueButton
            // 
            this.RemoveByValueButton.Location = new System.Drawing.Point(18, 104);
            this.RemoveByValueButton.Name = "RemoveByValueButton";
            this.RemoveByValueButton.Size = new System.Drawing.Size(147, 39);
            this.RemoveByValueButton.TabIndex = 1;
            this.RemoveByValueButton.Text = "Usuń";
            this.RemoveByValueButton.UseVisualStyleBackColor = true;
            this.RemoveByValueButton.Click += new System.EventHandler(this.RemoveByValueButton_Click);
            // 
            // ValueToDeleteElement
            // 
            this.ValueToDeleteElement.Location = new System.Drawing.Point(18, 68);
            this.ValueToDeleteElement.Name = "ValueToDeleteElement";
            this.ValueToDeleteElement.Size = new System.Drawing.Size(147, 26);
            this.ValueToDeleteElement.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RemoveByIndexButton);
            this.groupBox5.Controls.Add(this.IndexToDeleteValue);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox5.Location = new System.Drawing.Point(227, 186);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 178);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuń element na podstawie indeksu";
            // 
            // RemoveByIndexButton
            // 
            this.RemoveByIndexButton.Location = new System.Drawing.Point(18, 101);
            this.RemoveByIndexButton.Name = "RemoveByIndexButton";
            this.RemoveByIndexButton.Size = new System.Drawing.Size(147, 39);
            this.RemoveByIndexButton.TabIndex = 1;
            this.RemoveByIndexButton.Text = "Usuń";
            this.RemoveByIndexButton.UseVisualStyleBackColor = true;
            this.RemoveByIndexButton.Click += new System.EventHandler(this.RemoveByIndexButton_Click);
            // 
            // IndexToDeleteValue
            // 
            this.IndexToDeleteValue.Location = new System.Drawing.Point(18, 65);
            this.IndexToDeleteValue.Name = "IndexToDeleteValue";
            this.IndexToDeleteValue.Size = new System.Drawing.Size(147, 26);
            this.IndexToDeleteValue.TabIndex = 0;
            // 
            // CollectionView
            // 
            this.CollectionView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CollectionView.FormattingEnabled = true;
            this.CollectionView.ItemHeight = 20;
            this.CollectionView.Location = new System.Drawing.Point(642, 42);
            this.CollectionView.Name = "CollectionView";
            this.CollectionView.Size = new System.Drawing.Size(251, 244);
            this.CollectionView.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(639, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolekcja";
            // 
            // ShowCollectionButton
            // 
            this.ShowCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowCollectionButton.Location = new System.Drawing.Point(766, 307);
            this.ShowCollectionButton.Name = "ShowCollectionButton";
            this.ShowCollectionButton.Size = new System.Drawing.Size(127, 57);
            this.ShowCollectionButton.TabIndex = 8;
            this.ShowCollectionButton.Text = "Pokaż kolekcję";
            this.ShowCollectionButton.UseVisualStyleBackColor = true;
            this.ShowCollectionButton.Click += new System.EventHandler(this.ShowCollectionButton_Click);
            // 
            // ClearCollectionButton
            // 
            this.ClearCollectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearCollectionButton.Location = new System.Drawing.Point(642, 305);
            this.ClearCollectionButton.Name = "ClearCollectionButton";
            this.ClearCollectionButton.Size = new System.Drawing.Size(117, 59);
            this.ClearCollectionButton.TabIndex = 9;
            this.ClearCollectionButton.Text = "Wyczyść kolekcję";
            this.ClearCollectionButton.UseVisualStyleBackColor = true;
            this.ClearCollectionButton.Click += new System.EventHandler(this.ClearCollectionButton_Click);
            // 
            // ValueToModify
            // 
            this.ValueToModify.Location = new System.Drawing.Point(54, 70);
            this.ValueToModify.Name = "ValueToModify";
            this.ValueToModify.Size = new System.Drawing.Size(111, 26);
            this.ValueToModify.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Val:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ind:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 384);
            this.Controls.Add(this.ClearCollectionButton);
            this.Controls.Add(this.ShowCollectionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CollectionView);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddValueGroupBox);
            this.Name = "Form1";
            this.Text = "Kolekcje ver 2";
            this.AddValueGroupBox.ResumeLayout(false);
            this.AddValueGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddValueGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NewValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ValueByIndexShowButton;
        private System.Windows.Forms.TextBox IndexToShowValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button IndeksByValueShowButton;
        private System.Windows.Forms.TextBox ValueToShowIndex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ModifyValueButton;
        private System.Windows.Forms.TextBox IndexToModifyValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button RemoveByValueButton;
        private System.Windows.Forms.TextBox ValueToDeleteElement;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button RemoveByIndexButton;
        private System.Windows.Forms.TextBox IndexToDeleteValue;
        private System.Windows.Forms.ListBox CollectionView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowCollectionButton;
        private System.Windows.Forms.Button ClearCollectionButton;
        private System.Windows.Forms.TextBox ValueToModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

