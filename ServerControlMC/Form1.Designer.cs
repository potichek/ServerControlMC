namespace ServerControl
{
    partial class ServerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerControl));
            moveButton = new Button();
            textBoxFrom = new TextBox();
            labelFrom = new Label();
            labelTo = new Label();
            textBoxTo = new TextBox();
            configNameTextBox = new TextBox();
            configNameLabel = new Label();
            deleteConfigCheckBox = new CheckBox();
            startServerButton = new Button();
            serverJarFilePathTextBox = new TextBox();
            serverJarFilePathLabel = new Label();
            fileToRunLabel = new Label();
            fileToRunTextBox = new TextBox();
            SuspendLayout();
            // 
            // moveButton
            // 
            moveButton.Font = new Font("Microsoft Sans Serif", 12.32F, FontStyle.Regular, GraphicsUnit.Point);
            moveButton.Location = new Point(14, 449);
            moveButton.Margin = new Padding(4, 3, 4, 3);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(350, 69);
            moveButton.TabIndex = 0;
            moveButton.Text = "Move";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(14, 53);
            textBoxFrom.Margin = new Padding(4, 3, 4, 3);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(397, 23);
            textBoxFrom.TabIndex = 1;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelFrom.Location = new Point(14, 10);
            labelFrom.Margin = new Padding(4, 0, 4, 0);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(70, 32);
            labelFrom.TabIndex = 2;
            labelFrom.Text = "from";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
            labelTo.Location = new Point(14, 133);
            labelTo.Margin = new Padding(4, 0, 4, 0);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(47, 32);
            labelTo.TabIndex = 3;
            labelTo.Text = "To";
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(14, 173);
            textBoxTo.Margin = new Padding(4, 3, 4, 3);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(397, 23);
            textBoxTo.TabIndex = 4;
            // 
            // configNameTextBox
            // 
            configNameTextBox.Location = new Point(14, 299);
            configNameTextBox.Margin = new Padding(4, 3, 4, 3);
            configNameTextBox.Name = "configNameTextBox";
            configNameTextBox.Size = new Size(397, 23);
            configNameTextBox.TabIndex = 5;
            // 
            // configNameLabel
            // 
            configNameLabel.AutoSize = true;
            configNameLabel.Font = new Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
            configNameLabel.Location = new Point(14, 242);
            configNameLabel.Margin = new Padding(4, 0, 4, 0);
            configNameLabel.Name = "configNameLabel";
            configNameLabel.Size = new Size(175, 32);
            configNameLabel.TabIndex = 6;
            configNameLabel.Text = "Config name";
            // 
            // deleteConfigCheckBox
            // 
            deleteConfigCheckBox.Font = new Font("Microsoft Sans Serif", 20.4F, FontStyle.Regular, GraphicsUnit.Point);
            deleteConfigCheckBox.Location = new Point(14, 347);
            deleteConfigCheckBox.Margin = new Padding(4, 3, 4, 3);
            deleteConfigCheckBox.Name = "deleteConfigCheckBox";
            deleteConfigCheckBox.Size = new Size(237, 44);
            deleteConfigCheckBox.TabIndex = 7;
            deleteConfigCheckBox.Text = "delete config";
            deleteConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // startServerButton
            // 
            startServerButton.Font = new Font("Microsoft Sans Serif", 12.32F, FontStyle.Regular, GraphicsUnit.Point);
            startServerButton.Location = new Point(551, 449);
            startServerButton.Margin = new Padding(4, 3, 4, 3);
            startServerButton.Name = "startServerButton";
            startServerButton.Size = new Size(350, 69);
            startServerButton.TabIndex = 8;
            startServerButton.Text = "Start server";
            startServerButton.UseVisualStyleBackColor = true;
            startServerButton.Click += startServerButton_Click;
            // 
            // serverJarFilePathTextBox
            // 
            serverJarFilePathTextBox.Location = new Point(551, 52);
            serverJarFilePathTextBox.Margin = new Padding(4, 3, 4, 3);
            serverJarFilePathTextBox.Name = "serverJarFilePathTextBox";
            serverJarFilePathTextBox.Size = new Size(349, 23);
            serverJarFilePathTextBox.TabIndex = 9;
            // 
            // serverJarFilePathLabel
            // 
            serverJarFilePathLabel.AutoSize = true;
            serverJarFilePathLabel.Font = new Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
            serverJarFilePathLabel.Location = new Point(544, 10);
            serverJarFilePathLabel.Margin = new Padding(4, 0, 4, 0);
            serverJarFilePathLabel.Name = "serverJarFilePathLabel";
            serverJarFilePathLabel.Size = new Size(244, 32);
            serverJarFilePathLabel.TabIndex = 10;
            serverJarFilePathLabel.Text = "Server jar file path";
            // 
            // fileToRunLabel
            // 
            fileToRunLabel.AutoSize = true;
            fileToRunLabel.Font = new Font("Microsoft Sans Serif", 20.5F, FontStyle.Regular, GraphicsUnit.Point);
            fileToRunLabel.Location = new Point(544, 133);
            fileToRunLabel.Margin = new Padding(4, 0, 4, 0);
            fileToRunLabel.Name = "fileToRunLabel";
            fileToRunLabel.Size = new Size(140, 32);
            fileToRunLabel.TabIndex = 11;
            fileToRunLabel.Text = "File to run";
            // 
            // fileToRunTextBox
            // 
            fileToRunTextBox.Location = new Point(545, 173);
            fileToRunTextBox.Margin = new Padding(4, 3, 4, 3);
            fileToRunTextBox.Name = "fileToRunTextBox";
            fileToRunTextBox.Size = new Size(356, 23);
            fileToRunTextBox.TabIndex = 12;
            // 
            // ServerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(fileToRunTextBox);
            Controls.Add(fileToRunLabel);
            Controls.Add(serverJarFilePathLabel);
            Controls.Add(serverJarFilePathTextBox);
            Controls.Add(startServerButton);
            Controls.Add(deleteConfigCheckBox);
            Controls.Add(configNameLabel);
            Controls.Add(configNameTextBox);
            Controls.Add(textBoxTo);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Controls.Add(textBoxFrom);
            Controls.Add(moveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ServerControl";
            Text = "Server Control";
            FormClosing += form1_Close;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button moveButton;
        private TextBox textBoxFrom;
        private Label labelFrom;
        private Label labelTo;
        private TextBox textBoxTo;
        private TextBox configNameTextBox;
        private Label configNameLabel;
        private CheckBox deleteConfigCheckBox;
        private Button startServerButton;
        private TextBox serverJarFilePathTextBox;
        private Label serverJarFilePathLabel;
        private Label fileToRunLabel;
        private TextBox fileToRunTextBox;
    }
}

