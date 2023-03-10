namespace displayNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textVirtualBoxVersion = new System.Windows.Forms.Label();
            this.textVirtualBoxInstall = new System.Windows.Forms.Label();
            this.textVmwVersion = new System.Windows.Forms.Label();
            this.textVmWareInstall = new System.Windows.Forms.Label();
            this.textInternetConnection = new System.Windows.Forms.Label();
            this.textMacAddress = new System.Windows.Forms.Label();
            this.textSsidStatus = new System.Windows.Forms.Label();
            this.textSsid = new System.Windows.Forms.Label();
            this.textHostname = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.Label();
            this.textIpGateway = new System.Windows.Forms.Label();
            this.textIpHost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 39);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network  Display";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.textVirtualBoxVersion);
            this.panel2.Controls.Add(this.textVirtualBoxInstall);
            this.panel2.Controls.Add(this.textVmwVersion);
            this.panel2.Controls.Add(this.textVmWareInstall);
            this.panel2.Controls.Add(this.textInternetConnection);
            this.panel2.Controls.Add(this.textMacAddress);
            this.panel2.Controls.Add(this.textSsidStatus);
            this.panel2.Controls.Add(this.textSsid);
            this.panel2.Controls.Add(this.textHostname);
            this.panel2.Controls.Add(this.textUsername);
            this.panel2.Controls.Add(this.textIpGateway);
            this.panel2.Controls.Add(this.textIpHost);
            this.panel2.Location = new System.Drawing.Point(12, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 142);
            this.panel2.TabIndex = 2;
            // 
            // textVirtualBoxVersion
            // 
            this.textVirtualBoxVersion.AutoSize = true;
            this.textVirtualBoxVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVirtualBoxVersion.Location = new System.Drawing.Point(859, 99);
            this.textVirtualBoxVersion.Name = "textVirtualBoxVersion";
            this.textVirtualBoxVersion.Size = new System.Drawing.Size(31, 20);
            this.textVirtualBoxVersion.TabIndex = 11;
            this.textVirtualBoxVersion.Text = "Ip: ";
            // 
            // textVirtualBoxInstall
            // 
            this.textVirtualBoxInstall.AutoSize = true;
            this.textVirtualBoxInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVirtualBoxInstall.Location = new System.Drawing.Point(859, 58);
            this.textVirtualBoxInstall.Name = "textVirtualBoxInstall";
            this.textVirtualBoxInstall.Size = new System.Drawing.Size(31, 20);
            this.textVirtualBoxInstall.TabIndex = 10;
            this.textVirtualBoxInstall.Text = "Ip: ";
            // 
            // textVmwVersion
            // 
            this.textVmwVersion.AutoSize = true;
            this.textVmwVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVmwVersion.Location = new System.Drawing.Point(859, 16);
            this.textVmwVersion.Name = "textVmwVersion";
            this.textVmwVersion.Size = new System.Drawing.Size(31, 20);
            this.textVmwVersion.TabIndex = 9;
            this.textVmwVersion.Text = "Ip: ";
            // 
            // textVmWareInstall
            // 
            this.textVmWareInstall.AutoSize = true;
            this.textVmWareInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVmWareInstall.Location = new System.Drawing.Point(555, 99);
            this.textVmWareInstall.Name = "textVmWareInstall";
            this.textVmWareInstall.Size = new System.Drawing.Size(31, 20);
            this.textVmWareInstall.TabIndex = 8;
            this.textVmWareInstall.Text = "Ip: ";
            // 
            // textInternetConnection
            // 
            this.textInternetConnection.AutoSize = true;
            this.textInternetConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInternetConnection.Location = new System.Drawing.Point(555, 58);
            this.textInternetConnection.Name = "textInternetConnection";
            this.textInternetConnection.Size = new System.Drawing.Size(31, 20);
            this.textInternetConnection.TabIndex = 7;
            this.textInternetConnection.Text = "Ip: ";
            // 
            // textMacAddress
            // 
            this.textMacAddress.AutoSize = true;
            this.textMacAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMacAddress.Location = new System.Drawing.Point(555, 16);
            this.textMacAddress.Name = "textMacAddress";
            this.textMacAddress.Size = new System.Drawing.Size(31, 20);
            this.textMacAddress.TabIndex = 6;
            this.textMacAddress.Text = "Ip: ";
            // 
            // textSsidStatus
            // 
            this.textSsidStatus.AutoSize = true;
            this.textSsidStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSsidStatus.Location = new System.Drawing.Point(257, 99);
            this.textSsidStatus.Name = "textSsidStatus";
            this.textSsidStatus.Size = new System.Drawing.Size(31, 20);
            this.textSsidStatus.TabIndex = 5;
            this.textSsidStatus.Text = "Ip: ";
            // 
            // textSsid
            // 
            this.textSsid.AutoSize = true;
            this.textSsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSsid.Location = new System.Drawing.Point(257, 58);
            this.textSsid.Name = "textSsid";
            this.textSsid.Size = new System.Drawing.Size(31, 20);
            this.textSsid.TabIndex = 4;
            this.textSsid.Text = "Ip: ";
            // 
            // textHostname
            // 
            this.textHostname.AutoSize = true;
            this.textHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHostname.Location = new System.Drawing.Point(257, 16);
            this.textHostname.Name = "textHostname";
            this.textHostname.Size = new System.Drawing.Size(31, 20);
            this.textHostname.TabIndex = 3;
            this.textHostname.Text = "Ip: ";
            // 
            // textUsername
            // 
            this.textUsername.AutoSize = true;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(16, 99);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(31, 20);
            this.textUsername.TabIndex = 2;
            this.textUsername.Text = "Ip: ";
            // 
            // textIpGateway
            // 
            this.textIpGateway.AutoSize = true;
            this.textIpGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIpGateway.Location = new System.Drawing.Point(16, 58);
            this.textIpGateway.Name = "textIpGateway";
            this.textIpGateway.Size = new System.Drawing.Size(31, 20);
            this.textIpGateway.TabIndex = 1;
            this.textIpGateway.Text = "Ip: ";
            // 
            // textIpHost
            // 
            this.textIpHost.AutoSize = true;
            this.textIpHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIpHost.Location = new System.Drawing.Point(16, 16);
            this.textIpHost.Name = "textIpHost";
            this.textIpHost.Size = new System.Drawing.Size(31, 20);
            this.textIpHost.TabIndex = 0;
            this.textIpHost.Text = "Ip: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1170, 211);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label textIpHost;
        private System.Windows.Forms.Label textIpGateway;
        private System.Windows.Forms.Label textUsername;
        private System.Windows.Forms.Label textHostname;
        private System.Windows.Forms.Label textSsid;
        private System.Windows.Forms.Label textSsidStatus;
        private System.Windows.Forms.Label textMacAddress;
        private System.Windows.Forms.Label textInternetConnection;
        private System.Windows.Forms.Label textVmWareInstall;
        private System.Windows.Forms.Label textVmwVersion;
        private System.Windows.Forms.Label textVirtualBoxInstall;
        private System.Windows.Forms.Label textVirtualBoxVersion;
    }
}

