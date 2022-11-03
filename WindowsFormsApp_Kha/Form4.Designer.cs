namespace WindowsFormsApp_Kha
{
    partial class Uspev
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
            System.Windows.Forms.Label оценкаLabel1;
            System.Windows.Forms.Label предметLabel1;
            System.Windows.Forms.Label студентLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            this.label1 = new System.Windows.Forms.Label();
            this.education_KhamidullinDataSet = new WindowsFormsApp_Kha.Education_KhamidullinDataSet();
            this.uspev_KhamidullinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_KhamidullinTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Uspev_KhamidullinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager();
            this.students_KhamidullinTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Students_KhamidullinTableAdapter();
            this.subjects_KhamidullinTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Subjects_KhamidullinTableAdapter();
            this.uspev_KhamidullinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uspev_KhamidullinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.students_uspevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_uspevTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Students_uspevTableAdapter();
            this.оценкаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.предметComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsKhamidullinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsKhamidullinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентComboBox = new System.Windows.Forms.ComboBox();
            оценкаLabel1 = new System.Windows.Forms.Label();
            предметLabel1 = new System.Windows.Forms.Label();
            студентLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KhamidullinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KhamidullinBindingNavigator)).BeginInit();
            this.uspev_KhamidullinBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsKhamidullinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsKhamidullinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // оценкаLabel1
            // 
            оценкаLabel1.AutoSize = true;
            оценкаLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            оценкаLabel1.ForeColor = System.Drawing.Color.Blue;
            оценкаLabel1.Location = new System.Drawing.Point(111, 244);
            оценкаLabel1.Name = "оценкаLabel1";
            оценкаLabel1.Size = new System.Drawing.Size(87, 25);
            оценкаLabel1.TabIndex = 7;
            оценкаLabel1.Text = "Оценка:";
            // 
            // предметLabel1
            // 
            предметLabel1.AutoSize = true;
            предметLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            предметLabel1.ForeColor = System.Drawing.Color.Blue;
            предметLabel1.Location = new System.Drawing.Point(92, 189);
            предметLabel1.Name = "предметLabel1";
            предметLabel1.Size = new System.Drawing.Size(106, 25);
            предметLabel1.TabIndex = 8;
            предметLabel1.Text = "Предмет:";
            // 
            // студентLabel1
            // 
            студентLabel1.AutoSize = true;
            студентLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            студентLabel1.ForeColor = System.Drawing.Color.Blue;
            студентLabel1.Location = new System.Drawing.Point(100, 133);
            студентLabel1.Name = "студентLabel1";
            студентLabel1.Size = new System.Drawing.Size(98, 25);
            студентLabel1.TabIndex = 9;
            студентLabel1.Text = "Студент:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(110, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Успеваемость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_KhamidullinDataSet
            // 
            this.education_KhamidullinDataSet.DataSetName = "Education_KhamidullinDataSet";
            this.education_KhamidullinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspev_KhamidullinBindingSource
            // 
            this.uspev_KhamidullinBindingSource.DataMember = "Uspev_Khamidullin";
            this.uspev_KhamidullinBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // uspev_KhamidullinTableAdapter
            // 
            this.uspev_KhamidullinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_KhamidullinTableAdapter = this.students_KhamidullinTableAdapter;
            this.tableAdapterManager.Subjects_KhamidullinTableAdapter = this.subjects_KhamidullinTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KhamidullinTableAdapter = this.uspev_KhamidullinTableAdapter;
            // 
            // students_KhamidullinTableAdapter
            // 
            this.students_KhamidullinTableAdapter.ClearBeforeFill = true;
            // 
            // subjects_KhamidullinTableAdapter
            // 
            this.subjects_KhamidullinTableAdapter.ClearBeforeFill = true;
            // 
            // uspev_KhamidullinBindingNavigator
            // 
            this.uspev_KhamidullinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspev_KhamidullinBindingNavigator.BindingSource = this.uspev_KhamidullinBindingSource;
            this.uspev_KhamidullinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspev_KhamidullinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspev_KhamidullinBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uspev_KhamidullinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uspev_KhamidullinBindingNavigatorSaveItem});
            this.uspev_KhamidullinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspev_KhamidullinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspev_KhamidullinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspev_KhamidullinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspev_KhamidullinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspev_KhamidullinBindingNavigator.Name = "uspev_KhamidullinBindingNavigator";
            this.uspev_KhamidullinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspev_KhamidullinBindingNavigator.Size = new System.Drawing.Size(511, 27);
            this.uspev_KhamidullinBindingNavigator.TabIndex = 1;
            this.uspev_KhamidullinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            // uspev_KhamidullinBindingNavigatorSaveItem
            // 
            this.uspev_KhamidullinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspev_KhamidullinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspev_KhamidullinBindingNavigatorSaveItem.Image")));
            this.uspev_KhamidullinBindingNavigatorSaveItem.Name = "uspev_KhamidullinBindingNavigatorSaveItem";
            this.uspev_KhamidullinBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.uspev_KhamidullinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspev_KhamidullinBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspev_KhamidullinBindingNavigatorSaveItem_Click);
            // 
            // students_uspevBindingSource
            // 
            this.students_uspevBindingSource.DataMember = "Students_uspev";
            this.students_uspevBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // students_uspevTableAdapter
            // 
            this.students_uspevTableAdapter.ClearBeforeFill = true;
            // 
            // оценкаMaskedTextBox
            // 
            this.оценкаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_uspevBindingSource, "Оценка", true));
            this.оценкаMaskedTextBox.Location = new System.Drawing.Point(223, 244);
            this.оценкаMaskedTextBox.Mask = "0";
            this.оценкаMaskedTextBox.Name = "оценкаMaskedTextBox";
            this.оценкаMaskedTextBox.Size = new System.Drawing.Size(168, 22);
            this.оценкаMaskedTextBox.TabIndex = 8;
            // 
            // предметComboBox
            // 
            this.предметComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_KhamidullinBindingSource, "Предмет", true));
            this.предметComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectsKhamidullinBindingSource, "Название предмета", true));
            this.предметComboBox.DataSource = this.subjectsKhamidullinBindingSource;
            this.предметComboBox.DisplayMember = "Название предмета";
            this.предметComboBox.FormattingEnabled = true;
            this.предметComboBox.Location = new System.Drawing.Point(223, 190);
            this.предметComboBox.Name = "предметComboBox";
            this.предметComboBox.Size = new System.Drawing.Size(168, 24);
            this.предметComboBox.TabIndex = 9;
            this.предметComboBox.ValueMember = "Название предмета";
            // 
            // subjectsKhamidullinBindingSource
            // 
            this.subjectsKhamidullinBindingSource.DataMember = "Subjects_Khamidullin";
            this.subjectsKhamidullinBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // studentsKhamidullinBindingSource
            // 
            this.studentsKhamidullinBindingSource.DataMember = "Students_Khamidullin";
            this.studentsKhamidullinBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // студентComboBox
            // 
            this.студентComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_KhamidullinBindingSource, "Студент", true));
            this.студентComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentsKhamidullinBindingSource, "Фамилия", true));
            this.студентComboBox.DataSource = this.studentsKhamidullinBindingSource;
            this.студентComboBox.DisplayMember = "Фамилия";
            this.студентComboBox.FormattingEnabled = true;
            this.студентComboBox.Location = new System.Drawing.Point(223, 134);
            this.студентComboBox.Name = "студентComboBox";
            this.студентComboBox.Size = new System.Drawing.Size(168, 24);
            this.студентComboBox.TabIndex = 10;
            this.студентComboBox.ValueMember = "Фамилия";
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 327);
            this.Controls.Add(студентLabel1);
            this.Controls.Add(this.студентComboBox);
            this.Controls.Add(предметLabel1);
            this.Controls.Add(this.предметComboBox);
            this.Controls.Add(оценкаLabel1);
            this.Controls.Add(this.оценкаMaskedTextBox);
            this.Controls.Add(this.uspev_KhamidullinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Uspev";
            this.Text = "Успеваемость_<Хамидуллин>";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KhamidullinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_KhamidullinBindingNavigator)).EndInit();
            this.uspev_KhamidullinBindingNavigator.ResumeLayout(false);
            this.uspev_KhamidullinBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsKhamidullinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsKhamidullinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_KhamidullinDataSet education_KhamidullinDataSet;
        private System.Windows.Forms.BindingSource uspev_KhamidullinBindingSource;
        private Education_KhamidullinDataSetTableAdapters.Uspev_KhamidullinTableAdapter uspev_KhamidullinTableAdapter;
        private Education_KhamidullinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspev_KhamidullinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uspev_KhamidullinBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource students_uspevBindingSource;
        private Education_KhamidullinDataSetTableAdapters.Students_uspevTableAdapter students_uspevTableAdapter;
        private System.Windows.Forms.MaskedTextBox оценкаMaskedTextBox;
        private System.Windows.Forms.ComboBox предметComboBox;
        private Education_KhamidullinDataSetTableAdapters.Students_KhamidullinTableAdapter students_KhamidullinTableAdapter;
        private System.Windows.Forms.BindingSource studentsKhamidullinBindingSource;
        private Education_KhamidullinDataSetTableAdapters.Subjects_KhamidullinTableAdapter subjects_KhamidullinTableAdapter;
        private System.Windows.Forms.BindingSource subjectsKhamidullinBindingSource;
        private System.Windows.Forms.ComboBox студентComboBox;
    }
}