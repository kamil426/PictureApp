namespace PictureApp
{
    partial class Main
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
            btAdd = new Button();
            btRemove = new Button();
            pictureBox = new PictureBox();
            panel = new Panel();
            btRotateR90 = new Button();
            btRotateL90 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btAdd.Location = new Point(9, 445);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 1;
            btAdd.Text = "Dodaj";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btRemove.Location = new Point(112, 445);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 29);
            btRemove.TabIndex = 2;
            btRemove.Text = "Usuń";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Visible = false;
            btRemove.Click += btRemove_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Control;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(300, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.BackColor = SystemColors.Control;
            panel.Controls.Add(pictureBox);
            panel.Location = new Point(9, 12);
            panel.Name = "panel";
            panel.Size = new Size(823, 427);
            panel.TabIndex = 5;
            // 
            // btRotateR90
            // 
            btRotateR90.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btRotateR90.Location = new Point(797, 445);
            btRotateR90.Name = "btRotateR90";
            btRotateR90.Size = new Size(35, 35);
            btRotateR90.TabIndex = 6;
            btRotateR90.Text = "↻";
            btRotateR90.UseVisualStyleBackColor = true;
            btRotateR90.Click += btRotateR90_Click;
            // 
            // btRotateL90
            // 
            btRotateL90.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btRotateL90.Location = new Point(756, 445);
            btRotateL90.Name = "btRotateL90";
            btRotateL90.Size = new Size(35, 35);
            btRotateL90.TabIndex = 7;
            btRotateL90.Text = "↺";
            btRotateL90.UseVisualStyleBackColor = true;
            btRotateL90.Click += btRotateL90_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 486);
            Controls.Add(btRotateL90);
            Controls.Add(btRotateR90);
            Controls.Add(panel);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Name = "Main";
            Text = "Picture App";
            FormClosing += Main_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btAdd;
        private Button btRemove;
        private PictureBox pictureBox;
        private Panel panel;
        private Button btRotateR90;
        private Button btRotateL90;
    }
}