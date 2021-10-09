namespace Ex05.FourInARow.UI
{
    partial class GameSettings
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.namePlayer1 = new System.Windows.Forms.TextBox();
            this.namePlayer2 = new System.Windows.Forms.TextBox();
            this.Players = new System.Windows.Forms.Label();
            this.textNamePlayer1 = new System.Windows.Forms.Label();
            this.boardSize = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.Label();
            this.cols = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.numberOfRows = new System.Windows.Forms.NumericUpDown();
            this.numberOfCols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCols)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(17, 289);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(329, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // namePlayer1
            // 
            this.namePlayer1.Location = new System.Drawing.Point(187, 69);
            this.namePlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.namePlayer1.Name = "namePlayer1";
            this.namePlayer1.Size = new System.Drawing.Size(146, 27);
            this.namePlayer1.TabIndex = 1;
            this.namePlayer1.TextChanged += new System.EventHandler(this.namePlayer1_TextChanged);
            // 
            // namePlayer2
            // 
            this.namePlayer2.BackColor = System.Drawing.Color.Gainsboro;
            this.namePlayer2.Enabled = false;
            this.namePlayer2.Location = new System.Drawing.Point(187, 117);
            this.namePlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.namePlayer2.Name = "namePlayer2";
            this.namePlayer2.Size = new System.Drawing.Size(146, 27);
            this.namePlayer2.TabIndex = 2;
            this.namePlayer2.Text = "[computer]";
            this.namePlayer2.TextChanged += new System.EventHandler(this.namePlayer2_TextChanged);
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Location = new System.Drawing.Point(13, 23);
            this.Players.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(70, 20);
            this.Players.TabIndex = 3;
            this.Players.Text = "Players:";
            // 
            // textNamePlayer1
            // 
            this.textNamePlayer1.AutoSize = true;
            this.textNamePlayer1.Location = new System.Drawing.Point(42, 69);
            this.textNamePlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textNamePlayer1.Name = "textNamePlayer1";
            this.textNamePlayer1.Size = new System.Drawing.Size(70, 20);
            this.textNamePlayer1.TabIndex = 4;
            this.textNamePlayer1.Text = "Player1:";
            this.textNamePlayer1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // boardSize
            // 
            this.boardSize.AutoSize = true;
            this.boardSize.Location = new System.Drawing.Point(13, 181);
            this.boardSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boardSize.Name = "boardSize";
            this.boardSize.Size = new System.Drawing.Size(97, 20);
            this.boardSize.TabIndex = 7;
            this.boardSize.Text = "Board Size:";
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Location = new System.Drawing.Point(42, 235);
            this.rows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(56, 20);
            this.rows.TabIndex = 8;
            this.rows.Text = "Rows:";
            // 
            // cols
            // 
            this.cols.AutoSize = true;
            this.cols.Location = new System.Drawing.Point(223, 235);
            this.cols.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(48, 20);
            this.cols.TabIndex = 9;
            this.cols.Text = "Cols:";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(45, 120);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(92, 24);
            this.checkBoxPlayer2.TabIndex = 12;
            this.checkBoxPlayer2.Text = "Player2:";
            this.checkBoxPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.Player2_CheckedChanged);
            // 
            // numberOfRows
            // 
            this.numberOfRows.Location = new System.Drawing.Point(105, 233);
            this.numberOfRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfRows.Name = "numberOfRows";
            this.numberOfRows.Size = new System.Drawing.Size(48, 27);
            this.numberOfRows.TabIndex = 13;
            this.numberOfRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfRows.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numberOfCols
            // 
            this.numberOfCols.Location = new System.Drawing.Point(278, 235);
            this.numberOfCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfCols.Name = "numberOfCols";
            this.numberOfCols.Size = new System.Drawing.Size(48, 27);
            this.numberOfCols.TabIndex = 14;
            this.numberOfCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfCols.ValueChanged += new System.EventHandler(this.numberOfCols_ValueChanged);
            // 
            // GameSettings
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 356);
            this.Controls.Add(this.numberOfCols);
            this.Controls.Add(this.numberOfRows);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.boardSize);
            this.Controls.Add(this.textNamePlayer1);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.namePlayer2);
            this.Controls.Add(this.namePlayer1);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.FourInARow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox namePlayer1;
        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label textNamePlayer1;
        private System.Windows.Forms.Label boardSize;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label cols;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.TextBox namePlayer2;
        private System.Windows.Forms.NumericUpDown numberOfRows;
        private System.Windows.Forms.NumericUpDown numberOfCols;
    }
}