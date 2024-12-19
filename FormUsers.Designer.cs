namespace LB4_AnimeTitlesApp
{
    partial class FormUsers
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelFill = new Panel();
            dataGridViewUsers = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(button1);
            flowLayoutPanelTop.Controls.Add(button2);
            flowLayoutPanelTop.Controls.Add(button3);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1257, 100);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(169, 13);
            button2.Name = "button2";
            button2.Size = new Size(150, 41);
            button2.TabIndex = 2;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(325, 13);
            button3.Name = "button3";
            button3.Size = new Size(150, 41);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewUsers);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 100);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1257, 650);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(1237, 630);
            dataGridViewUsers.TabIndex = 0;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormUsers";
            Text = "FormUsers";
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panelFill;
        private DataGridView dataGridViewUsers;
    }
}
