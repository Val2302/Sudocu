namespace Sudocu.Src.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageListButons = new System.Windows.Forms.ImageList(this.components);
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.gridTable = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnCheckGame = new System.Windows.Forms.Button();
            this.btnShowHelp = new System.Windows.Forms.Button();
            this.btnSolveGame = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.gridNumbers = new System.Windows.Forms.DataGridView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListButons
            // 
            this.imageListButons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButons.ImageStream")));
            this.imageListButons.TransparentColor = System.Drawing.Color.White;
            this.imageListButons.Images.SetKeyName(0, "New.jpg");
            this.imageListButons.Images.SetKeyName(1, "Load.jpg");
            this.imageListButons.Images.SetKeyName(2, "Save.png");
            this.imageListButons.Images.SetKeyName(3, "Check.png");
            this.imageListButons.Images.SetKeyName(4, "Solve.png");
            this.imageListButons.Images.SetKeyName(5, "Help.png");
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSaveGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveGame.ImageIndex = 2;
            this.btnSaveGame.ImageList = this.imageListButons;
            this.btnSaveGame.Location = new System.Drawing.Point(204, 3);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(93, 88);
            this.btnSaveGame.TabIndex = 2;
            this.btnSaveGame.Text = "&Сохранить";
            this.btnSaveGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSaveGame, "Ctrl+S");
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.BtnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLoadGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadGame.ImageIndex = 1;
            this.btnLoadGame.ImageList = this.imageListButons;
            this.btnLoadGame.Location = new System.Drawing.Point(105, 3);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(93, 88);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "&Загрузить";
            this.btnLoadGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnLoadGame, "Ctrl+L");
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.BtnLoadGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewGame.ImageIndex = 0;
            this.btnNewGame.ImageList = this.imageListButons;
            this.btnNewGame.Location = new System.Drawing.Point(6, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(93, 88);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&Новая";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnNewGame, "Ctrl+N");
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // gridTable
            // 
            this.gridTable.AllowUserToAddRows = false;
            this.gridTable.AllowUserToDeleteRows = false;
            this.gridTable.AllowUserToResizeColumns = false;
            this.gridTable.AllowUserToResizeRows = false;
            this.gridTable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.gridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTable.GridColor = System.Drawing.Color.Navy;
            this.gridTable.Location = new System.Drawing.Point(101, 41);
            this.gridTable.Margin = new System.Windows.Forms.Padding(4);
            this.gridTable.MultiSelect = false;
            this.gridTable.Name = "gridTable";
            this.gridTable.RowHeadersVisible = false;
            this.gridTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridTable.RowTemplate.Height = 40;
            this.gridTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridTable.ShowCellErrors = false;
            this.gridTable.ShowCellToolTips = false;
            this.gridTable.ShowEditingIcon = false;
            this.gridTable.ShowRowErrors = false;
            this.gridTable.Size = new System.Drawing.Size(399, 401);
            this.gridTable.TabIndex = 2;
            this.gridTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridTable_CellMouseMove);
            this.gridTable.SelectionChanged += new System.EventHandler(this.GridTable_SelectionChanged);
            this.gridTable.Paint += new System.Windows.Forms.PaintEventHandler(this.GridTable_Paint);
            this.gridTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridTable_KeyDown);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer.Panel1.Controls.Add(this.btnCheckGame);
            this.splitContainer.Panel1.Controls.Add(this.btnShowHelp);
            this.splitContainer.Panel1.Controls.Add(this.btnSolveGame);
            this.splitContainer.Panel1.Controls.Add(this.btnNewGame);
            this.splitContainer.Panel1.Controls.Add(this.btnLoadGame);
            this.splitContainer.Panel1.Controls.Add(this.btnSaveGame);
            this.splitContainer.Panel1.Controls.Add(this.panel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gridNumbers);
            this.splitContainer.Panel2.Controls.Add(this.gridTable);
            this.splitContainer.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitContainer_Panel2_MouseMove);
            this.splitContainer.Size = new System.Drawing.Size(603, 587);
            this.splitContainer.SplitterDistance = 98;
            this.splitContainer.TabIndex = 4;
            // 
            // btnCheckGame
            // 
            this.btnCheckGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCheckGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckGame.ImageIndex = 4;
            this.btnCheckGame.ImageList = this.imageListButons;
            this.btnCheckGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckGame.Location = new System.Drawing.Point(303, 3);
            this.btnCheckGame.Name = "btnCheckGame";
            this.btnCheckGame.Size = new System.Drawing.Size(93, 88);
            this.btnCheckGame.TabIndex = 3;
            this.btnCheckGame.Text = "&Проверить";
            this.btnCheckGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnCheckGame, "Ctrl+C");
            this.btnCheckGame.UseVisualStyleBackColor = false;
            this.btnCheckGame.Click += new System.EventHandler(this.BtnCheckGame_Click);
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowHelp.ImageIndex = 5;
            this.btnShowHelp.ImageList = this.imageListButons;
            this.btnShowHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowHelp.Location = new System.Drawing.Point(501, 3);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(93, 88);
            this.btnShowHelp.TabIndex = 5;
            this.btnShowHelp.Text = "&Справка";
            this.btnShowHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnShowHelp, "F1");
            this.btnShowHelp.UseVisualStyleBackColor = false;
            this.btnShowHelp.Click += new System.EventHandler(this.BtnShowHelp_Click);
            // 
            // btnSolveGame
            // 
            this.btnSolveGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSolveGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSolveGame.ImageIndex = 3;
            this.btnSolveGame.ImageList = this.imageListButons;
            this.btnSolveGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSolveGame.Location = new System.Drawing.Point(402, 3);
            this.btnSolveGame.Name = "btnSolveGame";
            this.btnSolveGame.Size = new System.Drawing.Size(93, 88);
            this.btnSolveGame.TabIndex = 4;
            this.btnSolveGame.Text = "&Решить";
            this.btnSolveGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSolveGame, "Ctrl+R");
            this.btnSolveGame.UseVisualStyleBackColor = false;
            this.btnSolveGame.Click += new System.EventHandler(this.BtnSolveGame_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(369, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(11, 12);
            this.panel.TabIndex = 5;
            // 
            // gridNumbers
            // 
            this.gridNumbers.AllowUserToAddRows = false;
            this.gridNumbers.AllowUserToDeleteRows = false;
            this.gridNumbers.AllowUserToResizeColumns = false;
            this.gridNumbers.AllowUserToResizeRows = false;
            this.gridNumbers.BackgroundColor = System.Drawing.Color.Azure;
            this.gridNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNumbers.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNumbers.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridNumbers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridNumbers.EnableHeadersVisualStyles = false;
            this.gridNumbers.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.gridNumbers.Location = new System.Drawing.Point(269, 210);
            this.gridNumbers.MultiSelect = false;
            this.gridNumbers.Name = "gridNumbers";
            this.gridNumbers.RowHeadersVisible = false;
            this.gridNumbers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridNumbers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridNumbers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridNumbers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridNumbers.ShowCellErrors = false;
            this.gridNumbers.ShowCellToolTips = false;
            this.gridNumbers.ShowEditingIcon = false;
            this.gridNumbers.ShowRowErrors = false;
            this.gridNumbers.Size = new System.Drawing.Size(63, 63);
            this.gridNumbers.TabIndex = 3;
            this.gridNumbers.Visible = false;
            this.gridNumbers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridNumbers_CellClick);
            this.gridNumbers.Paint += new System.Windows.Forms.PaintEventHandler(this.GridNumbers_Paint);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.IsBalloon = true;
            this.toolTip.ShowAlways = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(603, 587);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судоку";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTable;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.ImageList imageListButons;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnSolveGame;
        private System.Windows.Forms.DataGridView gridNumbers;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnShowHelp;
        private System.Windows.Forms.Button btnCheckGame;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

