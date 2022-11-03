namespace WindowsFormsApp_Kha
{
    partial class Students
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
            System.Windows.Forms.Label номер_зачетной_книжкиLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label специальностиLabel;
            System.Windows.Forms.Label курсLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label биографияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.label1 = new System.Windows.Forms.Label();
            this.education_KhamidullinDataSet = new WindowsFormsApp_Kha.Education_KhamidullinDataSet();
            this.students_KhamidullinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_KhamidullinTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Students_KhamidullinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager();
            this.students_KhamidullinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.students_KhamidullinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_зачетной_книжкиTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.специальностиTextBox = new System.Windows.Forms.TextBox();
            this.курсTextBox = new System.Windows.Forms.TextBox();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.биографияTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            номер_зачетной_книжкиLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            специальностиLabel = new System.Windows.Forms.Label();
            курсLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            биографияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_KhamidullinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_KhamidullinBindingNavigator)).BeginInit();
            this.students_KhamidullinBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_зачетной_книжкиLabel
            // 
            номер_зачетной_книжкиLabel.AutoSize = true;
            номер_зачетной_книжкиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            номер_зачетной_книжкиLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            номер_зачетной_книжкиLabel.Location = new System.Drawing.Point(21, 144);
            номер_зачетной_книжкиLabel.Name = "номер_зачетной_книжкиLabel";
            номер_зачетной_книжкиLabel.Size = new System.Drawing.Size(218, 20);
            номер_зачетной_книжкиLabel.TabIndex = 2;
            номер_зачетной_книжкиLabel.Text = "Номер зачетной книжки:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            фамилияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            фамилияLabel.Location = new System.Drawing.Point(147, 195);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(92, 20);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            имяLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            имяLabel.Location = new System.Drawing.Point(192, 246);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(47, 20);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            отчествоLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            отчествоLabel.Location = new System.Drawing.Point(143, 297);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(96, 20);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // специальностиLabel
            // 
            специальностиLabel.AutoSize = true;
            специальностиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            специальностиLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            специальностиLabel.Location = new System.Drawing.Point(94, 351);
            специальностиLabel.Name = "специальностиLabel";
            специальностиLabel.Size = new System.Drawing.Size(145, 20);
            специальностиLabel.TabIndex = 10;
            специальностиLabel.Text = "Специальность:";
            // 
            // курсLabel
            // 
            курсLabel.AutoSize = true;
            курсLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            курсLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            курсLabel.Location = new System.Drawing.Point(187, 405);
            курсLabel.Name = "курсLabel";
            курсLabel.Size = new System.Drawing.Size(52, 20);
            курсLabel.TabIndex = 12;
            курсLabel.Text = "Курс:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            группаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            группаLabel.Location = new System.Drawing.Point(167, 455);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(72, 20);
            группаLabel.TabIndex = 14;
            группаLabel.Text = "Группа:";
            // 
            // биографияLabel
            // 
            биографияLabel.AutoSize = true;
            биографияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            биографияLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            биографияLabel.Location = new System.Drawing.Point(129, 513);
            биографияLabel.Name = "биографияLabel";
            биографияLabel.Size = new System.Drawing.Size(110, 20);
            биографияLabel.TabIndex = 16;
            биографияLabel.Text = "Биография:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(166, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_KhamidullinDataSet
            // 
            this.education_KhamidullinDataSet.DataSetName = "Education_KhamidullinDataSet";
            this.education_KhamidullinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_KhamidullinBindingSource
            // 
            this.students_KhamidullinBindingSource.DataMember = "Students_Khamidullin";
            this.students_KhamidullinBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // students_KhamidullinTableAdapter
            // 
            this.students_KhamidullinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_KhamidullinTableAdapter = this.students_KhamidullinTableAdapter;
            this.tableAdapterManager.Subjects_KhamidullinTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KhamidullinTableAdapter = null;
            // 
            // students_KhamidullinBindingNavigator
            // 
            this.students_KhamidullinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_KhamidullinBindingNavigator.BindingSource = this.students_KhamidullinBindingSource;
            this.students_KhamidullinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_KhamidullinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_KhamidullinBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.students_KhamidullinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.students_KhamidullinBindingNavigatorSaveItem});
            this.students_KhamidullinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_KhamidullinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_KhamidullinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_KhamidullinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_KhamidullinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_KhamidullinBindingNavigator.Name = "students_KhamidullinBindingNavigator";
            this.students_KhamidullinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_KhamidullinBindingNavigator.Size = new System.Drawing.Size(549, 31);
            this.students_KhamidullinBindingNavigator.TabIndex = 1;
            this.students_KhamidullinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // students_KhamidullinBindingNavigatorSaveItem
            // 
            this.students_KhamidullinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_KhamidullinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_KhamidullinBindingNavigatorSaveItem.Image")));
            this.students_KhamidullinBindingNavigatorSaveItem.Name = "students_KhamidullinBindingNavigatorSaveItem";
            this.students_KhamidullinBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.students_KhamidullinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.students_KhamidullinBindingNavigatorSaveItem.Click += new System.EventHandler(this.students_KhamidullinBindingNavigatorSaveItem_Click);
            // 
            // номер_зачетной_книжкиTextBox
            // 
            this.номер_зачетной_книжкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Номер зачетной книжки", true));
            this.номер_зачетной_книжкиTextBox.Location = new System.Drawing.Point(258, 142);
            this.номер_зачетной_книжкиTextBox.Name = "номер_зачетной_книжкиTextBox";
            this.номер_зачетной_книжкиTextBox.Size = new System.Drawing.Size(157, 22);
            this.номер_зачетной_книжкиTextBox.TabIndex = 3;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(258, 193);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(157, 22);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(258, 244);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(157, 22);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(258, 295);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(157, 22);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // специальностиTextBox
            // 
            this.специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Специальности", true));
            this.специальностиTextBox.Location = new System.Drawing.Point(258, 349);
            this.специальностиTextBox.Name = "специальностиTextBox";
            this.специальностиTextBox.Size = new System.Drawing.Size(157, 22);
            this.специальностиTextBox.TabIndex = 11;
            // 
            // курсTextBox
            // 
            this.курсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Курс", true));
            this.курсTextBox.Location = new System.Drawing.Point(258, 403);
            this.курсTextBox.Name = "курсTextBox";
            this.курсTextBox.Size = new System.Drawing.Size(157, 22);
            this.курсTextBox.TabIndex = 13;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(258, 453);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(157, 22);
            this.группаTextBox.TabIndex = 15;
            // 
            // биографияTextBox
            // 
            this.биографияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_KhamidullinBindingSource, "Биография", true));
            this.биографияTextBox.Location = new System.Drawing.Point(258, 511);
            this.биографияTextBox.Name = "биографияTextBox";
            this.биографияTextBox.Size = new System.Drawing.Size(157, 22);
            this.биографияTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(151, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(биографияLabel);
            this.Controls.Add(this.биографияTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(курсLabel);
            this.Controls.Add(this.курсTextBox);
            this.Controls.Add(специальностиLabel);
            this.Controls.Add(this.специальностиTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(номер_зачетной_книжкиLabel);
            this.Controls.Add(this.номер_зачетной_книжкиTextBox);
            this.Controls.Add(this.students_KhamidullinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.Text = " Студенты_<Хамидуллин>";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_KhamidullinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_KhamidullinBindingNavigator)).EndInit();
            this.students_KhamidullinBindingNavigator.ResumeLayout(false);
            this.students_KhamidullinBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_KhamidullinDataSet education_KhamidullinDataSet;
        private System.Windows.Forms.BindingSource students_KhamidullinBindingSource;
        private Education_KhamidullinDataSetTableAdapters.Students_KhamidullinTableAdapter students_KhamidullinTableAdapter;
        private Education_KhamidullinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_KhamidullinBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton students_KhamidullinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_зачетной_книжкиTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox специальностиTextBox;
        private System.Windows.Forms.TextBox курсTextBox;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox биографияTextBox;
        private System.Windows.Forms.Button button1;
    }
}