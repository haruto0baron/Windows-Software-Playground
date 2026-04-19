namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lb1helloworld = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(350, 150);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "click this";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb1helloworld
            // 
            lb1helloworld.AutoSize = true;
            lb1helloworld.Location = new Point(350, 250);
            lb1helloworld.Name = "lb1helloworld";
            lb1helloworld.Size = new Size(30, 20);
            lb1helloworld.TabIndex = 1;
            lb1helloworld.Text = "lb1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lb1helloworld);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lb1helloworld;
    }
}
