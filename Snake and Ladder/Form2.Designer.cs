namespace Snake_and_Ladder
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.CurrentPlayer = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.Player1Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(1009, 192);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(173, 39);
            this.Player1Name.TabIndex = 54;
            this.Player1Name.Text = "Name Here";
            this.Player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2Name
            // 
            this.Player2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.Player2Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.Location = new System.Drawing.Point(1009, 231);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(173, 39);
            this.Player2Name.TabIndex = 55;
            this.Player2Name.Text = "Name Here";
            this.Player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(228)))), ((int)(((byte)(254)))));
            this.CurrentPlayer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayer.Location = new System.Drawing.Point(1045, 404);
            this.CurrentPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(135, 26);
            this.CurrentPlayer.TabIndex = 67;
            this.CurrentPlayer.Text = "Name Here";
            this.CurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.BackgroundImage = global::Snake_and_Ladder.Properties.Resources.p1;
            this.Player2.Location = new System.Drawing.Point(53, 633);
            this.Player2.Margin = new System.Windows.Forms.Padding(4);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(33, 31);
            this.Player2.TabIndex = 66;
            this.Player2.TabStop = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.BackgroundImage = global::Snake_and_Ladder.Properties.Resources.p2;
            this.Player1.Location = new System.Drawing.Point(53, 684);
            this.Player1.Margin = new System.Windows.Forms.Padding(4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(33, 31);
            this.Player1.TabIndex = 65;
            this.Player1.TabStop = false;
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Snake_and_Ladder.Properties.Resources.rolldice;
            this.button2.Location = new System.Drawing.Point(991, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 58);
            this.button2.TabIndex = 64;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::Snake_and_Ladder.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(1003, 684);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 34);
            this.Exit.TabIndex = 63;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.Image = global::Snake_and_Ladder.Properties.Resources.reset;
            this.Reset.Location = new System.Drawing.Point(1103, 684);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(92, 34);
            this.Reset.TabIndex = 62;
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Board.Image = ((System.Drawing.Image)(resources.GetObject("Board.Image")));
            this.Board.Location = new System.Drawing.Point(1, 0);
            this.Board.Margin = new System.Windows.Forms.Padding(4);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(1213, 753);
            this.Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 757);
            this.Controls.Add(this.CurrentPlayer);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Board);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Snake And Ladder";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Player1Name;
        public System.Windows.Forms.Label Player2Name;
        public System.Windows.Forms.PictureBox Board;
        public System.Windows.Forms.Button Reset;
        public System.Windows.Forms.Button Exit;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox Player1;
        public System.Windows.Forms.PictureBox Player2;
        public System.Windows.Forms.Label CurrentPlayer;
    }
}