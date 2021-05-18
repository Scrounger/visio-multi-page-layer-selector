using System;
using System.Windows.Forms;

namespace Visio_Multi_Page_Layer_Selector
{
    partial class TheForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLayerSelector = new System.Windows.Forms.TabPage();
            this.dgvLayerSelector = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbDivider = new System.Windows.Forms.Label();
            this.panel_LayerSelector_Filter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.panelFilter_Clear_Button = new System.Windows.Forms.Panel();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.lbFilter = new System.Windows.Forms.Label();
            this.tabFavorites = new System.Windows.Forms.TabPage();
            this.dgvFavorites = new System.Windows.Forms.DataGridView();
            this.tabDefaults = new System.Windows.Forms.TabPage();
            this.dgvDefaults = new System.Windows.Forms.DataGridView();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cbSettingsGlue = new System.Windows.Forms.CheckBox();
            this.cbSettingsSnap = new System.Windows.Forms.CheckBox();
            this.cbSettingsLock = new System.Windows.Forms.CheckBox();
            this.cbSettingsActive = new System.Windows.Forms.CheckBox();
            this.cbSettingsPrint = new System.Windows.Forms.CheckBox();
            this.cbSettingsVisible = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkDonate = new System.Windows.Forms.LinkLabel();
            this.tabControl.SuspendLayout();
            this.tabLayerSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayerSelector)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_LayerSelector_Filter.SuspendLayout();
            this.panelFilter_Clear_Button.SuspendLayout();
            this.tabFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            this.tabDefaults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaults)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLayerSelector);
            this.tabControl.Controls.Add(this.tabFavorites);
            this.tabControl.Controls.Add(this.tabDefaults);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 36);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(10, 10);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(602, 386);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabLayerSelector
            // 
            this.tabLayerSelector.Controls.Add(this.dgvLayerSelector);
            this.tabLayerSelector.Controls.Add(this.tableLayoutPanel1);
            this.tabLayerSelector.Controls.Add(this.panel_LayerSelector_Filter);
            this.tabLayerSelector.Location = new System.Drawing.Point(4, 36);
            this.tabLayerSelector.Margin = new System.Windows.Forms.Padding(2);
            this.tabLayerSelector.Name = "tabLayerSelector";
            this.tabLayerSelector.Padding = new System.Windows.Forms.Padding(2);
            this.tabLayerSelector.Size = new System.Drawing.Size(594, 346);
            this.tabLayerSelector.TabIndex = 0;
            this.tabLayerSelector.Text = "Layer Selector";
            this.tabLayerSelector.UseVisualStyleBackColor = true;
            // 
            // dgvLayerSelector
            // 
            this.dgvLayerSelector.AllowUserToAddRows = false;
            this.dgvLayerSelector.AllowUserToDeleteRows = false;
            this.dgvLayerSelector.AllowUserToResizeColumns = false;
            this.dgvLayerSelector.AllowUserToResizeRows = false;
            this.dgvLayerSelector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvLayerSelector.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLayerSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayerSelector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLayerSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLayerSelector.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLayerSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLayerSelector.Location = new System.Drawing.Point(2, 36);
            this.dgvLayerSelector.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLayerSelector.Name = "dgvLayerSelector";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLayerSelector.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLayerSelector.RowHeadersVisible = false;
            this.dgvLayerSelector.RowTemplate.Height = 24;
            this.dgvLayerSelector.Size = new System.Drawing.Size(590, 264);
            this.dgvLayerSelector.TabIndex = 0;
            this.dgvLayerSelector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLayerSelector_CellClick);
            this.dgvLayerSelector.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLayerSelector_CellContentClick);
            this.dgvLayerSelector.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvLayerSelector_CellFormatting);
            this.dgvLayerSelector.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLayerSelector_ColumnHeaderMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnFavorites, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnApply, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDivider, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 44);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavorites.FlatAppearance.BorderSize = 0;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Location = new System.Drawing.Point(298, 9);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(289, 32);
            this.btnFavorites.TabIndex = 3;
            this.btnFavorites.Text = "btnFavorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(3, 9);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(289, 32);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // lbDivider
            // 
            this.lbDivider.AutoSize = true;
            this.lbDivider.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDivider, 2);
            this.lbDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDivider.Location = new System.Drawing.Point(3, 5);
            this.lbDivider.Name = "lbDivider";
            this.lbDivider.Size = new System.Drawing.Size(584, 1);
            this.lbDivider.TabIndex = 4;
            // 
            // panel_LayerSelector_Filter
            // 
            this.panel_LayerSelector_Filter.Controls.Add(this.tbFilter);
            this.panel_LayerSelector_Filter.Controls.Add(this.panelFilter_Clear_Button);
            this.panel_LayerSelector_Filter.Controls.Add(this.lbFilter);
            this.panel_LayerSelector_Filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LayerSelector_Filter.Location = new System.Drawing.Point(2, 2);
            this.panel_LayerSelector_Filter.Name = "panel_LayerSelector_Filter";
            this.panel_LayerSelector_Filter.Padding = new System.Windows.Forms.Padding(5);
            this.panel_LayerSelector_Filter.Size = new System.Drawing.Size(590, 34);
            this.panel_LayerSelector_Filter.TabIndex = 1;
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(62, 5);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(498, 22);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.TextChanged += new System.EventHandler(this.TbFilter_TextChanged);
            // 
            // panelFilter_Clear_Button
            // 
            this.panelFilter_Clear_Button.Controls.Add(this.btnFilterClear);
            this.panelFilter_Clear_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFilter_Clear_Button.Location = new System.Drawing.Point(560, 5);
            this.panelFilter_Clear_Button.Name = "panelFilter_Clear_Button";
            this.panelFilter_Clear_Button.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.panelFilter_Clear_Button.Size = new System.Drawing.Size(25, 24);
            this.panelFilter_Clear_Button.TabIndex = 2;
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterClear.FlatAppearance.BorderSize = 0;
            this.btnFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterClear.Location = new System.Drawing.Point(1, 0);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(24, 22);
            this.btnFilterClear.TabIndex = 0;
            this.btnFilterClear.Text = "x";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.BtnFilterClear_Click);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(5, 5);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Padding = new System.Windows.Forms.Padding(0, 2, 20, 0);
            this.lbFilter.Size = new System.Drawing.Size(57, 18);
            this.lbFilter.TabIndex = 0;
            this.lbFilter.Text = "Filter";
            // 
            // tabFavorites
            // 
            this.tabFavorites.Controls.Add(this.dgvFavorites);
            this.tabFavorites.Location = new System.Drawing.Point(4, 36);
            this.tabFavorites.Name = "tabFavorites";
            this.tabFavorites.Size = new System.Drawing.Size(594, 346);
            this.tabFavorites.TabIndex = 4;
            this.tabFavorites.Text = "Favorites";
            this.tabFavorites.UseVisualStyleBackColor = true;
            // 
            // dgvFavorites
            // 
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.AllowUserToDeleteRows = false;
            this.dgvFavorites.AllowUserToResizeColumns = false;
            this.dgvFavorites.AllowUserToResizeRows = false;
            this.dgvFavorites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFavorites.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFavorites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavorites.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFavorites.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFavorites.Location = new System.Drawing.Point(0, 0);
            this.dgvFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFavorites.Name = "dgvFavorites";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFavorites.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFavorites.RowHeadersVisible = false;
            this.dgvFavorites.RowTemplate.Height = 24;
            this.dgvFavorites.Size = new System.Drawing.Size(594, 346);
            this.dgvFavorites.TabIndex = 2;
            this.dgvFavorites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFavorites_CellContentClick);
            this.dgvFavorites.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvFavorites_CellFormatting);
            this.dgvFavorites.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFavorites_ColumnHeaderMouseClick);
            // 
            // tabDefaults
            // 
            this.tabDefaults.Controls.Add(this.dgvDefaults);
            this.tabDefaults.Location = new System.Drawing.Point(4, 36);
            this.tabDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.tabDefaults.Name = "tabDefaults";
            this.tabDefaults.Size = new System.Drawing.Size(594, 346);
            this.tabDefaults.TabIndex = 3;
            this.tabDefaults.Text = "Defaults";
            this.tabDefaults.UseVisualStyleBackColor = true;
            // 
            // dgvDefaults
            // 
            this.dgvDefaults.AllowUserToAddRows = false;
            this.dgvDefaults.AllowUserToDeleteRows = false;
            this.dgvDefaults.AllowUserToResizeColumns = false;
            this.dgvDefaults.AllowUserToResizeRows = false;
            this.dgvDefaults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDefaults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDefaults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefaults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDefaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefaults.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefaults.Location = new System.Drawing.Point(0, 0);
            this.dgvDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDefaults.Name = "dgvDefaults";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefaults.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDefaults.RowHeadersVisible = false;
            this.dgvDefaults.RowTemplate.Height = 24;
            this.dgvDefaults.Size = new System.Drawing.Size(594, 346);
            this.dgvDefaults.TabIndex = 1;
            this.dgvDefaults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefaults_CellClick);
            this.dgvDefaults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDefaults_CellContentClick);
            this.dgvDefaults.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDefaults_CellEndEdit);
            this.dgvDefaults.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvDefaults_CellFormatting);
            this.dgvDefaults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDefaults_ColumnHeaderMouseClick);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cbSettingsGlue);
            this.tabSettings.Controls.Add(this.cbSettingsSnap);
            this.tabSettings.Controls.Add(this.cbSettingsLock);
            this.tabSettings.Controls.Add(this.cbSettingsActive);
            this.tabSettings.Controls.Add(this.cbSettingsPrint);
            this.tabSettings.Controls.Add(this.cbSettingsVisible);
            this.tabSettings.Location = new System.Drawing.Point(4, 36);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(594, 346);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // cbSettingsGlue
            // 
            this.cbSettingsGlue.AutoSize = true;
            this.cbSettingsGlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsGlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsGlue.Location = new System.Drawing.Point(0, 150);
            this.cbSettingsGlue.Name = "cbSettingsGlue";
            this.cbSettingsGlue.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsGlue.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsGlue.TabIndex = 5;
            this.cbSettingsGlue.Text = "cbGlue";
            this.cbSettingsGlue.UseVisualStyleBackColor = true;
            this.cbSettingsGlue.CheckedChanged += new System.EventHandler(this.CbSettingsGlue_CheckedChanged);
            // 
            // cbSettingsSnap
            // 
            this.cbSettingsSnap.AutoSize = true;
            this.cbSettingsSnap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsSnap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsSnap.Location = new System.Drawing.Point(0, 120);
            this.cbSettingsSnap.Name = "cbSettingsSnap";
            this.cbSettingsSnap.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsSnap.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsSnap.TabIndex = 4;
            this.cbSettingsSnap.Text = "cbSnap";
            this.cbSettingsSnap.UseVisualStyleBackColor = true;
            this.cbSettingsSnap.CheckedChanged += new System.EventHandler(this.CbSettingsSnap_CheckedChanged);
            // 
            // cbSettingsLock
            // 
            this.cbSettingsLock.AutoSize = true;
            this.cbSettingsLock.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsLock.Location = new System.Drawing.Point(0, 90);
            this.cbSettingsLock.Name = "cbSettingsLock";
            this.cbSettingsLock.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsLock.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsLock.TabIndex = 3;
            this.cbSettingsLock.Text = "cbLock";
            this.cbSettingsLock.UseVisualStyleBackColor = true;
            this.cbSettingsLock.CheckedChanged += new System.EventHandler(this.CbSettingsLock_CheckedChanged);
            // 
            // cbSettingsActive
            // 
            this.cbSettingsActive.AutoSize = true;
            this.cbSettingsActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsActive.Location = new System.Drawing.Point(0, 60);
            this.cbSettingsActive.Name = "cbSettingsActive";
            this.cbSettingsActive.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsActive.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsActive.TabIndex = 2;
            this.cbSettingsActive.Text = "cbActive";
            this.cbSettingsActive.UseVisualStyleBackColor = true;
            this.cbSettingsActive.CheckedChanged += new System.EventHandler(this.CbSettingsActive_CheckedChanged);
            // 
            // cbSettingsPrint
            // 
            this.cbSettingsPrint.AutoSize = true;
            this.cbSettingsPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsPrint.Location = new System.Drawing.Point(0, 30);
            this.cbSettingsPrint.Name = "cbSettingsPrint";
            this.cbSettingsPrint.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsPrint.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsPrint.TabIndex = 1;
            this.cbSettingsPrint.Text = "cbPrint";
            this.cbSettingsPrint.UseVisualStyleBackColor = true;
            this.cbSettingsPrint.CheckedChanged += new System.EventHandler(this.CbSettingsPrint_CheckedChanged);
            // 
            // cbSettingsVisible
            // 
            this.cbSettingsVisible.AutoSize = true;
            this.cbSettingsVisible.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSettingsVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSettingsVisible.Location = new System.Drawing.Point(0, 0);
            this.cbSettingsVisible.Name = "cbSettingsVisible";
            this.cbSettingsVisible.Padding = new System.Windows.Forms.Padding(5);
            this.cbSettingsVisible.Size = new System.Drawing.Size(594, 30);
            this.cbSettingsVisible.TabIndex = 0;
            this.cbSettingsVisible.Text = "cbVisible";
            this.cbSettingsVisible.UseVisualStyleBackColor = true;
            this.cbSettingsVisible.CheckedChanged += new System.EventHandler(this.CbSettingsVisible_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbVersion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkDonate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.panel1.Size = new System.Drawing.Size(602, 36);
            this.panel1.TabIndex = 1;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbVersion.Location = new System.Drawing.Point(1, 3);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Padding = new System.Windows.Forms.Padding(5);
            this.lbVersion.Size = new System.Drawing.Size(60, 23);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "lbVersion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Image = global::Visio_Multi_Page_Layer_Selector.Properties.Resources.img_coffee;
            this.label1.Location = new System.Drawing.Point(520, 3);
            this.label1.MinimumSize = new System.Drawing.Size(16, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 0;
            // 
            // linkDonate
            // 
            this.linkDonate.AutoSize = true;
            this.linkDonate.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkDonate.Location = new System.Drawing.Point(536, 3);
            this.linkDonate.Name = "linkDonate";
            this.linkDonate.Padding = new System.Windows.Forms.Padding(5);
            this.linkDonate.Size = new System.Drawing.Size(65, 23);
            this.linkDonate.TabIndex = 1;
            this.linkDonate.TabStop = true;
            this.linkDonate.Text = "linkLabel1";
            this.linkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDonate_LinkClicked);
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 422);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TheForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Multi Page Layer Selector";
            this.tabControl.ResumeLayout(false);
            this.tabLayerSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayerSelector)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_LayerSelector_Filter.ResumeLayout(false);
            this.panel_LayerSelector_Filter.PerformLayout();
            this.panelFilter_Clear_Button.ResumeLayout(false);
            this.tabFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            this.tabDefaults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaults)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLayerSelector;
        private System.Windows.Forms.DataGridView dgvLayerSelector;
        private TabPage tabSettings;
        private TabPage tabDefaults;
        private TabPage tabFavorites;
        private CheckBox cbSettingsGlue;
        private CheckBox cbSettingsSnap;
        private CheckBox cbSettingsLock;
        private CheckBox cbSettingsActive;
        private CheckBox cbSettingsPrint;
        private CheckBox cbSettingsVisible;
        private DataGridView dgvDefaults;
        private Panel panel_LayerSelector_Filter;
        private TextBox tbFilter;
        private Label lbFilter;
        private Button btnApply;
        private Button btnFavorites;
        private DataGridView dgvFavorites;
        private Panel panelFilter_Clear_Button;
        private Button btnFilterClear;
        private Panel panel1;
        private Label label1;
        private LinkLabel linkDonate;
        private Label lbVersion;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbDivider;
    }
}