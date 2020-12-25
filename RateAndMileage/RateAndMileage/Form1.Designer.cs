
namespace RateAndMileage
{
    partial class RateAndMileage
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
            this.RemoveCarBtn = new System.Windows.Forms.Button();
            this.UpdateMileageBtn = new System.Windows.Forms.Button();
            this.mileageTxtBox = new System.Windows.Forms.TextBox();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.UpdateRateBtn = new System.Windows.Forms.Button();
            this.rateTxtBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.CarInfoLV = new System.Windows.Forms.ListView();
            this.make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mileage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerInfoLV = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custInfoLabel = new System.Windows.Forms.Label();
            this.carInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveCarBtn
            // 
            this.RemoveCarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCarBtn.Location = new System.Drawing.Point(1048, 515);
            this.RemoveCarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveCarBtn.Name = "RemoveCarBtn";
            this.RemoveCarBtn.Size = new System.Drawing.Size(489, 90);
            this.RemoveCarBtn.TabIndex = 18;
            this.RemoveCarBtn.Text = "Remove Selected Car";
            this.RemoveCarBtn.UseVisualStyleBackColor = true;
            this.RemoveCarBtn.Click += new System.EventHandler(this.RemoveCarBtn_Click);
            // 
            // UpdateMileageBtn
            // 
            this.UpdateMileageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMileageBtn.Location = new System.Drawing.Point(563, 515);
            this.UpdateMileageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateMileageBtn.Name = "UpdateMileageBtn";
            this.UpdateMileageBtn.Size = new System.Drawing.Size(477, 41);
            this.UpdateMileageBtn.TabIndex = 17;
            this.UpdateMileageBtn.Text = "Update Mileage";
            this.UpdateMileageBtn.UseVisualStyleBackColor = true;
            this.UpdateMileageBtn.Click += new System.EventHandler(this.UpdateMileageBtn_Click);
            // 
            // mileageTxtBox
            // 
            this.mileageTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageTxtBox.Location = new System.Drawing.Point(227, 515);
            this.mileageTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mileageTxtBox.Name = "mileageTxtBox";
            this.mileageTxtBox.Size = new System.Drawing.Size(316, 36);
            this.mileageTxtBox.TabIndex = 16;
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileageLabel.Location = new System.Drawing.Point(57, 515);
            this.mileageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(162, 30);
            this.mileageLabel.TabIndex = 15;
            this.mileageLabel.Text = "New Mileage";
            // 
            // UpdateRateBtn
            // 
            this.UpdateRateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRateBtn.Location = new System.Drawing.Point(563, 564);
            this.UpdateRateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateRateBtn.Name = "UpdateRateBtn";
            this.UpdateRateBtn.Size = new System.Drawing.Size(477, 41);
            this.UpdateRateBtn.TabIndex = 14;
            this.UpdateRateBtn.Text = "Update Rate";
            this.UpdateRateBtn.UseVisualStyleBackColor = true;
            this.UpdateRateBtn.Click += new System.EventHandler(this.UpdateRateBtn_Click);
            // 
            // rateTxtBox
            // 
            this.rateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxtBox.Location = new System.Drawing.Point(227, 564);
            this.rateTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateTxtBox.Name = "rateTxtBox";
            this.rateTxtBox.Size = new System.Drawing.Size(316, 36);
            this.rateTxtBox.TabIndex = 13;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(93, 564);
            this.rateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(126, 30);
            this.rateLabel.TabIndex = 12;
            this.rateLabel.Text = "New Rate";
            // 
            // CarInfoLV
            // 
            this.CarInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.make,
            this.model,
            this.year,
            this.mileage,
            this.rate});
            this.CarInfoLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInfoLV.FullRowSelect = true;
            this.CarInfoLV.GridLines = true;
            this.CarInfoLV.HideSelection = false;
            this.CarInfoLV.Location = new System.Drawing.Point(767, 70);
            this.CarInfoLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CarInfoLV.Name = "CarInfoLV";
            this.CarInfoLV.Size = new System.Drawing.Size(810, 392);
            this.CarInfoLV.TabIndex = 11;
            this.CarInfoLV.UseCompatibleStateImageBehavior = false;
            this.CarInfoLV.View = System.Windows.Forms.View.Details;
            // 
            // make
            // 
            this.make.Text = "Make";
            this.make.Width = 120;
            // 
            // model
            // 
            this.model.Text = "Model";
            this.model.Width = 120;
            // 
            // year
            // 
            this.year.Text = "Year";
            this.year.Width = 100;
            // 
            // mileage
            // 
            this.mileage.Text = "Mileage";
            this.mileage.Width = 120;
            // 
            // rate
            // 
            this.rate.Text = "Rate";
            this.rate.Width = 120;
            // 
            // CustomerInfoLV
            // 
            this.CustomerInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName,
            this.phoneNumber});
            this.CustomerInfoLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoLV.FullRowSelect = true;
            this.CustomerInfoLV.GridLines = true;
            this.CustomerInfoLV.HideSelection = false;
            this.CustomerInfoLV.Location = new System.Drawing.Point(27, 70);
            this.CustomerInfoLV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerInfoLV.Name = "CustomerInfoLV";
            this.CustomerInfoLV.Size = new System.Drawing.Size(705, 392);
            this.CustomerInfoLV.TabIndex = 10;
            this.CustomerInfoLV.UseCompatibleStateImageBehavior = false;
            this.CustomerInfoLV.View = System.Windows.Forms.View.Details;
            this.CustomerInfoLV.SelectedIndexChanged += new System.EventHandler(this.CustomerInfoLV_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 180;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 180;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone";
            this.phoneNumber.Width = 180;
            // 
            // custInfoLabel
            // 
            this.custInfoLabel.AutoSize = true;
            this.custInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custInfoLabel.Location = new System.Drawing.Point(209, 35);
            this.custInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custInfoLabel.Name = "custInfoLabel";
            this.custInfoLabel.Size = new System.Drawing.Size(250, 30);
            this.custInfoLabel.TabIndex = 19;
            this.custInfoLabel.Text = "Customer Infomation";
            // 
            // carInfoLabel
            // 
            this.carInfoLabel.AutoSize = true;
            this.carInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carInfoLabel.Location = new System.Drawing.Point(1112, 35);
            this.carInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carInfoLabel.Name = "carInfoLabel";
            this.carInfoLabel.Size = new System.Drawing.Size(180, 30);
            this.carInfoLabel.TabIndex = 20;
            this.carInfoLabel.Text = "Car Infomation";
            // 
            // RateAndMileage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 663);
            this.Controls.Add(this.carInfoLabel);
            this.Controls.Add(this.custInfoLabel);
            this.Controls.Add(this.RemoveCarBtn);
            this.Controls.Add(this.UpdateMileageBtn);
            this.Controls.Add(this.mileageTxtBox);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.UpdateRateBtn);
            this.Controls.Add(this.rateTxtBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.CarInfoLV);
            this.Controls.Add(this.CustomerInfoLV);
            this.Name = "RateAndMileage";
            this.Text = "Customer Info: Rate and Mileage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveCarBtn;
        private System.Windows.Forms.Button UpdateMileageBtn;
        private System.Windows.Forms.TextBox mileageTxtBox;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Button UpdateRateBtn;
        private System.Windows.Forms.TextBox rateTxtBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.ListView CarInfoLV;
        private System.Windows.Forms.ColumnHeader make;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader mileage;
        private System.Windows.Forms.ColumnHeader rate;
        private System.Windows.Forms.ListView CustomerInfoLV;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.Label custInfoLabel;
        private System.Windows.Forms.Label carInfoLabel;
    }
}

