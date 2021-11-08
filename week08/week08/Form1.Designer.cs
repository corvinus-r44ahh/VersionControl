
namespace week08
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNext = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.Button();
            this.ball = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.ball);
            this.mainPanel.Controls.Add(this.car);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Location = new System.Drawing.Point(2, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(798, 449);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(34, 289);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Coming next:";
            // 
            // car
            // 
            this.car.Location = new System.Drawing.Point(142, 289);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(75, 23);
            this.car.TabIndex = 1;
            this.car.Text = "car";
            this.car.UseVisualStyleBackColor = true;
            this.car.Click += new System.EventHandler(this.car_Click);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(240, 289);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(75, 23);
            this.ball.TabIndex = 2;
            this.ball.Text = "ball";
            this.ball.UseVisualStyleBackColor = true;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(346, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button car;
        private System.Windows.Forms.Button button1;
    }
}

