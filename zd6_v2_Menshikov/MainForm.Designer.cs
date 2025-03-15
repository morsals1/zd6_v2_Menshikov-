namespace zd6_v2_Menshikov
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMassPerSquareMeter = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblContractor = new System.Windows.Forms.Label();
            this.lblStrengthCoefficient = new System.Windows.Forms.Label();
            this.lblWeatherCondition = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtMassPerSquareMeter = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtContractor = new System.Windows.Forms.TextBox();
            this.txtStrengthCoefficient = new System.Windows.Forms.TextBox();
            this.txtWeatherCondition = new System.Windows.Forms.TextBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.dateTimePickerCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddRoadWork = new System.Windows.Forms.Button();
            this.btnDisplayRoadWorks = new System.Windows.Forms.Button();
            this.btnRemoveRoadWork = new System.Windows.Forms.Button();
            this.listBoxRoadWorks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(13, 13);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(49, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Ширина:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(13, 39);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Длина:";
            // 
            // lblMassPerSquareMeter
            // 
            this.lblMassPerSquareMeter.AutoSize = true;
            this.lblMassPerSquareMeter.Location = new System.Drawing.Point(13, 65);
            this.lblMassPerSquareMeter.Name = "lblMassPerSquareMeter";
            this.lblMassPerSquareMeter.Size = new System.Drawing.Size(104, 13);
            this.lblMassPerSquareMeter.TabIndex = 2;
            this.lblMassPerSquareMeter.Text = "Масса на кв. метр:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(13, 91);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(60, 13);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "Материал:";
            // 
            // lblContractor
            // 
            this.lblContractor.AutoSize = true;
            this.lblContractor.Location = new System.Drawing.Point(13, 117);
            this.lblContractor.Name = "lblContractor";
            this.lblContractor.Size = new System.Drawing.Size(65, 13);
            this.lblContractor.TabIndex = 4;
            this.lblContractor.Text = "Подрядчик:";
            // 
            // lblStrengthCoefficient
            // 
            this.lblStrengthCoefficient.AutoSize = true;
            this.lblStrengthCoefficient.Location = new System.Drawing.Point(13, 143);
            this.lblStrengthCoefficient.Name = "lblStrengthCoefficient";
            this.lblStrengthCoefficient.Size = new System.Drawing.Size(135, 13);
            this.lblStrengthCoefficient.TabIndex = 5;
            this.lblStrengthCoefficient.Text = "Коэффициент прочности:";
            // 
            // lblWeatherCondition
            // 
            this.lblWeatherCondition.AutoSize = true;
            this.lblWeatherCondition.Location = new System.Drawing.Point(13, 169);
            this.lblWeatherCondition.Name = "lblWeatherCondition";
            this.lblWeatherCondition.Size = new System.Drawing.Size(105, 13);
            this.lblWeatherCondition.TabIndex = 6;
            this.lblWeatherCondition.Text = "Погодные условия:";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(13, 195);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(83, 13);
            this.lblSupervisor.TabIndex = 7;
            this.lblSupervisor.Text = "Надзирающий:";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(13, 221);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(101, 13);
            this.lblCompletionDate.TabIndex = 8;
            this.lblCompletionDate.Text = "Дата завершения:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(352, 13);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 9;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(352, 39);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 10;
            // 
            // txtMassPerSquareMeter
            // 
            this.txtMassPerSquareMeter.Location = new System.Drawing.Point(352, 65);
            this.txtMassPerSquareMeter.Name = "txtMassPerSquareMeter";
            this.txtMassPerSquareMeter.Size = new System.Drawing.Size(100, 20);
            this.txtMassPerSquareMeter.TabIndex = 11;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(352, 91);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 12;
            // 
            // txtContractor
            // 
            this.txtContractor.Location = new System.Drawing.Point(352, 117);
            this.txtContractor.Name = "txtContractor";
            this.txtContractor.Size = new System.Drawing.Size(100, 20);
            this.txtContractor.TabIndex = 13;
            // 
            // txtStrengthCoefficient
            // 
            this.txtStrengthCoefficient.Location = new System.Drawing.Point(352, 143);
            this.txtStrengthCoefficient.Name = "txtStrengthCoefficient";
            this.txtStrengthCoefficient.Size = new System.Drawing.Size(100, 20);
            this.txtStrengthCoefficient.TabIndex = 14;
            // 
            // txtWeatherCondition
            // 
            this.txtWeatherCondition.Location = new System.Drawing.Point(352, 169);
            this.txtWeatherCondition.Name = "txtWeatherCondition";
            this.txtWeatherCondition.Size = new System.Drawing.Size(100, 20);
            this.txtWeatherCondition.TabIndex = 15;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(352, 195);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(100, 20);
            this.txtSupervisor.TabIndex = 16;
            // 
            // dateTimePickerCompletionDate
            // 
            this.dateTimePickerCompletionDate.Location = new System.Drawing.Point(252, 221);
            this.dateTimePickerCompletionDate.Name = "dateTimePickerCompletionDate";
            this.dateTimePickerCompletionDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCompletionDate.TabIndex = 17;
            // 
            // btnAddRoadWork
            // 
            this.btnAddRoadWork.Location = new System.Drawing.Point(15, 250);
            this.btnAddRoadWork.Name = "btnAddRoadWork";
            this.btnAddRoadWork.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoadWork.TabIndex = 18;
            this.btnAddRoadWork.Text = "Add";
            this.btnAddRoadWork.UseVisualStyleBackColor = true;
            this.btnAddRoadWork.Click += new System.EventHandler(this.btnAddRoadWork_Click);
            // 
            // btnDisplayRoadWorks
            // 
            this.btnDisplayRoadWorks.Location = new System.Drawing.Point(207, 251);
            this.btnDisplayRoadWorks.Name = "btnDisplayRoadWorks";
            this.btnDisplayRoadWorks.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayRoadWorks.TabIndex = 19;
            this.btnDisplayRoadWorks.Text = "Display";
            this.btnDisplayRoadWorks.UseVisualStyleBackColor = true;
            this.btnDisplayRoadWorks.Click += new System.EventHandler(this.btnDisplayRoadWorks_Click);
            // 
            // btnRemoveRoadWork
            // 
            this.btnRemoveRoadWork.Location = new System.Drawing.Point(377, 251);
            this.btnRemoveRoadWork.Name = "btnRemoveRoadWork";
            this.btnRemoveRoadWork.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveRoadWork.TabIndex = 20;
            this.btnRemoveRoadWork.Text = "Remove";
            this.btnRemoveRoadWork.UseVisualStyleBackColor = true;
            this.btnRemoveRoadWork.Click += new System.EventHandler(this.btnRemoveRoadWork_Click);
            // 
            // listBoxRoadWorks
            // 
            this.listBoxRoadWorks.FormattingEnabled = true;
            this.listBoxRoadWorks.Location = new System.Drawing.Point(15, 280);
            this.listBoxRoadWorks.Name = "listBoxRoadWorks";
            this.listBoxRoadWorks.Size = new System.Drawing.Size(437, 134);
            this.listBoxRoadWorks.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 426);
            this.Controls.Add(this.listBoxRoadWorks);
            this.Controls.Add(this.btnRemoveRoadWork);
            this.Controls.Add(this.btnDisplayRoadWorks);
            this.Controls.Add(this.btnAddRoadWork);
            this.Controls.Add(this.dateTimePickerCompletionDate);
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.txtWeatherCondition);
            this.Controls.Add(this.txtStrengthCoefficient);
            this.Controls.Add(this.txtContractor);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtMassPerSquareMeter);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.lblWeatherCondition);
            this.Controls.Add(this.lblStrengthCoefficient);
            this.Controls.Add(this.lblContractor);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblMassPerSquareMeter);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Name = "MainForm";
            this.Text = "Road Works Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblMassPerSquareMeter;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblContractor;
        private System.Windows.Forms.Label lblStrengthCoefficient;
        private System.Windows.Forms.Label lblWeatherCondition;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtMassPerSquareMeter;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtContractor;
        private System.Windows.Forms.TextBox txtStrengthCoefficient;
        private System.Windows.Forms.TextBox txtWeatherCondition;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompletionDate;
        private System.Windows.Forms.Button btnAddRoadWork;
        private System.Windows.Forms.Button btnDisplayRoadWorks;
        private System.Windows.Forms.Button btnRemoveRoadWork;
        private System.Windows.Forms.ListBox listBoxRoadWorks;
    }
}
