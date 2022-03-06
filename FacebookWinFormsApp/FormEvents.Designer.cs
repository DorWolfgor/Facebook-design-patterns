
namespace BasicFacebookFeatures
{
    partial class FormEvents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventDateStartTime = new System.Windows.Forms.Label();
            this.eventLocaition = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 121);
            this.panel1.TabIndex = 2;
            // 
            // labelEvents
            // 
            this.labelEvents.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.Color.Navy;
            this.labelEvents.Location = new System.Drawing.Point(300, 26);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(262, 80);
            this.labelEvents.TabIndex = 57;
            this.labelEvents.Text = "Events";
            this.labelEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(0, 127);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(228, 324);
            this.listBoxEvents.TabIndex = 3;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // eventDateStartTime
            // 
            this.eventDateStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateStartTime.Location = new System.Drawing.Point(626, 135);
            this.eventDateStartTime.Name = "eventDateStartTime";
            this.eventDateStartTime.Size = new System.Drawing.Size(135, 42);
            this.eventDateStartTime.TabIndex = 5;
            this.eventDateStartTime.Text = "Start";
            this.eventDateStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLocaition
            // 
            this.eventLocaition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocaition.Location = new System.Drawing.Point(626, 254);
            this.eventLocaition.Name = "eventLocaition";
            this.eventLocaition.Size = new System.Drawing.Size(135, 42);
            this.eventLocaition.TabIndex = 7;
            this.eventLocaition.Text = "Locaition";
            this.eventLocaition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(314, 135);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(271, 295);
            this.pictureBoxEvent.TabIndex = 4;
            this.pictureBoxEvent.TabStop = false;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 470);
            this.Controls.Add(this.eventLocaition);
            this.Controls.Add(this.eventDateStartTime);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.panel1);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label eventDateStartTime;
        private System.Windows.Forms.Label eventLocaition;
    }
}