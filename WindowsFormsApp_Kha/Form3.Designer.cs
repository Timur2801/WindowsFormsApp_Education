namespace WindowsFormsApp_Kha
{
    partial class Subjects
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
            System.Windows.Forms.Label название_предметаLabel;
            System.Windows.Forms.Label название_кафедрыLabel;
            System.Windows.Forms.Label predm_IDLabel;
            System.Windows.Forms.Label количество_часовLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.label1 = new System.Windows.Forms.Label();
            this.education_KhamidullinDataSet = new WindowsFormsApp_Kha.Education_KhamidullinDataSet();
            this.subjects_KhamidullinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_KhamidullinTableAdapter = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.Subjects_KhamidullinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager();
            this.subjects_KhamidullinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjects_KhamidullinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_предметаTextBox = new System.Windows.Forms.TextBox();
            this.название_кафедрыTextBox = new System.Windows.Forms.TextBox();
            this.predm_IDTextBox = new System.Windows.Forms.TextBox();
            this.количество_часовMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            название_предметаLabel = new System.Windows.Forms.Label();
            название_кафедрыLabel = new System.Windows.Forms.Label();
            predm_IDLabel = new System.Windows.Forms.Label();
            количество_часовLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KhamidullinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KhamidullinBindingNavigator)).BeginInit();
            this.subjects_KhamidullinBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_предметаLabel
            // 
            название_предметаLabel.AutoSize = true;
            название_предметаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            название_предметаLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            название_предметаLabel.Location = new System.Drawing.Point(54, 206);
            название_предметаLabel.Name = "название_предметаLabel";
            название_предметаLabel.Size = new System.Drawing.Size(185, 20);
            название_предметаLabel.TabIndex = 2;
            название_предметаLabel.Text = "Название предмета:";
            // 
            // название_кафедрыLabel
            // 
            название_кафедрыLabel.AutoSize = true;
            название_кафедрыLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            название_кафедрыLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            название_кафедрыLabel.Location = new System.Drawing.Point(59, 322);
            название_кафедрыLabel.Name = "название_кафедрыLabel";
            название_кафедрыLabel.Size = new System.Drawing.Size(180, 20);
            название_кафедрыLabel.TabIndex = 6;
            название_кафедрыLabel.Text = "Название кафедры:";
            // 
            // predm_IDLabel
            // 
            predm_IDLabel.AutoSize = true;
            predm_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            predm_IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            predm_IDLabel.Location = new System.Drawing.Point(87, 150);
            predm_IDLabel.Name = "predm_IDLabel";
            predm_IDLabel.Size = new System.Drawing.Size(152, 20);
            predm_IDLabel.TabIndex = 8;
            predm_IDLabel.Text = "Идентификатор:";
            // 
            // количество_часовLabel1
            // 
            количество_часовLabel1.AutoSize = true;
            количество_часовLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            количество_часовLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            количество_часовLabel1.Location = new System.Drawing.Point(71, 263);
            количество_часовLabel1.Name = "количество_часовLabel1";
            количество_часовLabel1.Size = new System.Drawing.Size(168, 20);
            количество_часовLabel1.TabIndex = 9;
            количество_часовLabel1.Text = "Количество часов:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(95, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_KhamidullinDataSet
            // 
            this.education_KhamidullinDataSet.DataSetName = "Education_KhamidullinDataSet";
            this.education_KhamidullinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_KhamidullinBindingSource
            // 
            this.subjects_KhamidullinBindingSource.DataMember = "Subjects_Khamidullin";
            this.subjects_KhamidullinBindingSource.DataSource = this.education_KhamidullinDataSet;
            // 
            // subjects_KhamidullinTableAdapter
            // 
            this.subjects_KhamidullinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_KhamidullinTableAdapter = null;
            this.tableAdapterManager.Subjects_KhamidullinTableAdapter = this.subjects_KhamidullinTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_Kha.Education_KhamidullinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_KhamidullinTableAdapter = null;
            // 
            // subjects_KhamidullinBindingNavigator
            // 
            this.subjects_KhamidullinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_KhamidullinBindingNavigator.BindingSource = this.subjects_KhamidullinBindingSource;
            this.subjects_KhamidullinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_KhamidullinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_KhamidullinBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.subjects_KhamidullinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjects_KhamidullinBindingNavigatorSaveItem});
            this.subjects_KhamidullinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_KhamidullinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_KhamidullinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_KhamidullinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_KhamidullinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_KhamidullinBindingNavigator.Name = "subjects_KhamidullinBindingNavigator";
            this.subjects_KhamidullinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_KhamidullinBindingNavigator.Size = new System.Drawing.Size(515, 27);
            this.subjects_KhamidullinBindingNavigator.TabIndex = 1;
            this.subjects_KhamidullinBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // subjects_KhamidullinBindingNavigatorSaveItem
            // 
            this.subjects_KhamidullinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_KhamidullinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_KhamidullinBindingNavigatorSaveItem.Image")));
            this.subjects_KhamidullinBindingNavigatorSaveItem.Name = "subjects_KhamidullinBindingNavigatorSaveItem";
            this.subjects_KhamidullinBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.subjects_KhamidullinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_KhamidullinBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_KhamidullinBindingNavigatorSaveItem_Click);
            // 
            // название_предметаTextBox
            // 
            this.название_предметаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KhamidullinBindingSource, "Название предмета", true));
            this.название_предметаTextBox.Location = new System.Drawing.Point(262, 204);
            this.название_предметаTextBox.Name = "название_предметаTextBox";
            this.название_предметаTextBox.Size = new System.Drawing.Size(230, 22);
            this.название_предметаTextBox.TabIndex = 3;
            // 
            // название_кафедрыTextBox
            // 
            this.название_кафедрыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KhamidullinBindingSource, "Название кафедры", true));
            this.название_кафедрыTextBox.Location = new System.Drawing.Point(262, 320);
            this.название_кафедрыTextBox.Name = "название_кафедрыTextBox";
            this.название_кафедрыTextBox.Size = new System.Drawing.Size(230, 22);
            this.название_кафедрыTextBox.TabIndex = 7;
            // 
            // predm_IDTextBox
            // 
            this.predm_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KhamidullinBindingSource, "predm_ID", true));
            this.predm_IDTextBox.Location = new System.Drawing.Point(262, 148);
            this.predm_IDTextBox.Name = "predm_IDTextBox";
            this.predm_IDTextBox.Size = new System.Drawing.Size(230, 22);
            this.predm_IDTextBox.TabIndex = 9;
            // 
            // количество_часовMaskedTextBox
            // 
            this.количество_часовMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_KhamidullinBindingSource, "Количество часов", true));
            this.количество_часовMaskedTextBox.Location = new System.Drawing.Point(262, 261);
            this.количество_часовMaskedTextBox.Mask = "999";
            this.количество_часовMaskedTextBox.Name = "количество_часовMaskedTextBox";
            this.количество_часовMaskedTextBox.Size = new System.Drawing.Size(230, 22);
            this.количество_часовMaskedTextBox.TabIndex = 10;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 390);
            this.Controls.Add(количество_часовLabel1);
            this.Controls.Add(this.количество_часовMaskedTextBox);
            this.Controls.Add(predm_IDLabel);
            this.Controls.Add(this.predm_IDTextBox);
            this.Controls.Add(название_кафедрыLabel);
            this.Controls.Add(this.название_кафедрыTextBox);
            this.Controls.Add(название_предметаLabel);
            this.Controls.Add(this.название_предметаTextBox);
            this.Controls.Add(this.subjects_KhamidullinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subjects";
            this.Text = "Дисциплины_<Хамидуллин>";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_KhamidullinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KhamidullinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_KhamidullinBindingNavigator)).EndInit();
            this.subjects_KhamidullinBindingNavigator.ResumeLayout(false);
            this.subjects_KhamidullinBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_KhamidullinDataSet education_KhamidullinDataSet;
        private System.Windows.Forms.BindingSource subjects_KhamidullinBindingSource;
        private Education_KhamidullinDataSetTableAdapters.Subjects_KhamidullinTableAdapter subjects_KhamidullinTableAdapter;
        private Education_KhamidullinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_KhamidullinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjects_KhamidullinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_предметаTextBox;
        private System.Windows.Forms.TextBox название_кафедрыTextBox;
        private System.Windows.Forms.TextBox predm_IDTextBox;
        private System.Windows.Forms.MaskedTextBox количество_часовMaskedTextBox;
    }
}