namespace Sudocu {
	partial class FormMain {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent ( ) {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.imageListButons = new System.Windows.Forms.ImageList(this.components);
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.gridTable = new System.Windows.Forms.DataGridView();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonHelp = new System.Windows.Forms.Button();
			this.buttonSolve = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.gridNumbers = new System.Windows.Forms.DataGridView();
			this.buttonCheck = new System.Windows.Forms.Button();
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
			this.imageListButons.Images.SetKeyName(3, "Solve.png");
			this.imageListButons.Images.SetKeyName(4, "Check.png");
			this.imageListButons.Images.SetKeyName(5, "Help.png");
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonSave.ImageIndex = 2;
			this.buttonSave.ImageList = this.imageListButons;
			this.buttonSave.Location = new System.Drawing.Point(204, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(93, 88);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "&Сохранить";
			this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonLoad
			// 
			this.buttonLoad.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonLoad.ImageIndex = 1;
			this.buttonLoad.ImageList = this.imageListButons;
			this.buttonLoad.Location = new System.Drawing.Point(105, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(93, 88);
			this.buttonLoad.TabIndex = 1;
			this.buttonLoad.Text = "&Загрузить";
			this.buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonLoad.UseVisualStyleBackColor = false;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonNew.ImageIndex = 0;
			this.buttonNew.ImageList = this.imageListButons;
			this.buttonNew.Location = new System.Drawing.Point(6, 3);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(93, 88);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "&Новая";
			this.buttonNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonNew.UseVisualStyleBackColor = false;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
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
			this.gridTable.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTable_CellMouseMove);
			this.gridTable.SelectionChanged += new System.EventHandler(this.gridTable_SelectionChanged);
			this.gridTable.Paint += new System.Windows.Forms.PaintEventHandler(this.gridTable_Paint);
			this.gridTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridTable_KeyDown);
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
			this.splitContainer.Panel1.Controls.Add(this.buttonCheck);
			this.splitContainer.Panel1.Controls.Add(this.buttonHelp);
			this.splitContainer.Panel1.Controls.Add(this.buttonSolve);
			this.splitContainer.Panel1.Controls.Add(this.buttonNew);
			this.splitContainer.Panel1.Controls.Add(this.buttonLoad);
			this.splitContainer.Panel1.Controls.Add(this.buttonSave);
			this.splitContainer.Panel1.Controls.Add(this.panel);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.gridNumbers);
			this.splitContainer.Panel2.Controls.Add(this.gridTable);
			this.splitContainer.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer_Panel2_MouseMove);
			this.splitContainer.Size = new System.Drawing.Size(603, 587);
			this.splitContainer.SplitterDistance = 98;
			this.splitContainer.TabIndex = 4;
			// 
			// buttonHelp
			// 
			this.buttonHelp.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonHelp.ImageIndex = 5;
			this.buttonHelp.ImageList = this.imageListButons;
			this.buttonHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonHelp.Location = new System.Drawing.Point(501, 3);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new System.Drawing.Size(93, 88);
			this.buttonHelp.TabIndex = 6;
			this.buttonHelp.Text = "&Справка";
			this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonHelp.UseVisualStyleBackColor = false;
			this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
			// 
			// buttonSolve
			// 
			this.buttonSolve.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonSolve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonSolve.ImageIndex = 3;
			this.buttonSolve.ImageList = this.imageListButons;
			this.buttonSolve.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonSolve.Location = new System.Drawing.Point(303, 3);
			this.buttonSolve.Name = "buttonSolve";
			this.buttonSolve.Size = new System.Drawing.Size(93, 88);
			this.buttonSolve.TabIndex = 3;
			this.buttonSolve.Text = "&Решить";
			this.buttonSolve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonSolve.UseVisualStyleBackColor = false;
			this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
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
			this.gridNumbers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNumbers_CellClick);
			this.gridNumbers.Paint += new System.Windows.Forms.PaintEventHandler(this.gridNumbers_Paint);
			// 
			// buttonCheck
			// 
			this.buttonCheck.BackColor = System.Drawing.Color.LightSteelBlue;
			this.buttonCheck.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.buttonCheck.ImageIndex = 4;
			this.buttonCheck.ImageList = this.imageListButons;
			this.buttonCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.buttonCheck.Location = new System.Drawing.Point(402, 3);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new System.Drawing.Size(93, 88);
			this.buttonCheck.TabIndex = 5;
			this.buttonCheck.Text = "&Проверить";
			this.buttonCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonCheck.UseVisualStyleBackColor = false;
			this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
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
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Судоку";
			this.Load += new System.EventHandler(this.FormMain_Load);
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
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.ImageList imageListButons;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Button buttonSolve;
		private System.Windows.Forms.DataGridView gridNumbers;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.Button buttonCheck;
	}
}

