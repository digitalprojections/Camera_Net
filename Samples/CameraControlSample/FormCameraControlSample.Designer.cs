namespace CameraControlSample
{
    partial class FormCameraControlSample
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
            this.labelResolutionTitle = new System.Windows.Forms.Label();
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.cameraControl = new Camera_NET.CameraControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelResolutionTitle
            // 
            this.labelResolutionTitle.AutoSize = true;
            this.labelResolutionTitle.Location = new System.Drawing.Point(11, 40);
            this.labelResolutionTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelResolutionTitle.Name = "labelResolutionTitle";
            this.labelResolutionTitle.Size = new System.Drawing.Size(111, 12);
            this.labelResolutionTitle.TabIndex = 7;
            this.labelResolutionTitle.Text = "Resolution selection:";
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(11, 14);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(96, 12);
            this.labelCameraTitle.TabIndex = 4;
            this.labelCameraTitle.Text = "Camera selection:";
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(128, 10);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(369, 20);
            this.comboBoxCameraList.TabIndex = 3;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxResolutionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolutionList.FormattingEnabled = true;
            this.comboBoxResolutionList.Location = new System.Drawing.Point(128, 36);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(369, 20);
            this.comboBoxResolutionList.TabIndex = 6;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.labelCameraTitle, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.labelResolutionTitle, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxCameraList, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxResolutionList, 1, 1);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanelForm.RowCount = 3;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(508, 74);
            this.tableLayoutPanelForm.TabIndex = 0;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(11, 80);
            this.cameraControl.MinimumSize = new System.Drawing.Size(1, 1);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(486, 217);
            this.cameraControl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(58, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FormCameraControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Controls.Add(this.cameraControl);
            this.Name = "FormCameraControlSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple camera sample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraControlSample_Load);
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Label labelCameraTitle;
        private System.Windows.Forms.Label labelResolutionTitle;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.ComboBox comboBoxResolutionList;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Label label1;
    }
}

