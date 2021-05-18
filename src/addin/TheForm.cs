using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Visio_Multi_Page_Layer_Selector.Helper;
using Visio = Microsoft.Office.Interop.Visio;

namespace Visio_Multi_Page_Layer_Selector
{
    public partial class TheForm : Form
    {
        private readonly Visio.Window _window;
        private bool sortAscending = false;
        private bool sortFavoritesAscending = false;
        private bool sortFavoritesDateTimeAscending = false;
        private bool sortDefaultsAscending = false;
        private Dictionary<int, bool> headerToggleCheckboxes = new Dictionary<int, bool>();

        /// </summary>
        /// <param name="window">Parent Visio diagram window</param>
        public TheForm(Visio.Window window)
        {
            _window = window;

            InitializeComponent();
            Initialize_Translation();

            MyVisio.App.CellChanged += new Visio.EApplication_CellChangedEventHandler(LayerChangeListener);

            Initialize_tabControl();

            lbVersion.Text = string.Format("{0}: {1}", Properties.Resources.loc_version, typeof(ThisAddIn).Assembly.GetName().Version.ToString());
        }

        private void LayerChangeListener(Visio.Cell Cell)
        {
            if (Cell.LocalName.StartsWith("Layers.Name"))
            {
                Initialize_dgvLayerSelector();
            }
        }

        private void ChangeLayerSettings(List<MyLayer> list)
        {
            foreach (Visio.Page page in MyVisio.App.ActiveDocument.Pages)
            {
                foreach (Visio.Layer layer in page.Layers)
                {
                    MyLayer item = list.Find(x => x.Name.Equals(layer.Name));

                    if (item != null)
                    {

                        if (MyDocumentProperties.ShowVisible)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerVisible].Formula = item.Visible == true ? "1" : "0";
                        }

                        if (MyDocumentProperties.ShowPrint)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerPrint].Formula = item.Print == true ? "1" : "0";
                        }

                        if (MyDocumentProperties.ShowActive)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerActive].Formula = item.Active == true ? "1" : "0";
                        }

                        if (MyDocumentProperties.ShowLock)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerLock].Formula = item.Lock == true ? "1" : "0";
                        }

                        if (MyDocumentProperties.ShowSnap)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerSnap].Formula = item.Snap == true ? "1" : "0";
                        }

                        if (MyDocumentProperties.ShowGlue)
                        {
                            layer.CellsC[(int)Visio.VisCellIndices.visLayerGlue].Formula = item.Glue == true ? "1" : "0";
                        }
                    }
                }
            }
        }

        private void Initialize_Translation()
        {
            //this.Text = Properties.Resources.loc_Set_layer_properties_for_all_pages;

            tabLayerSelector.Text = Properties.Resources.loc_layers;
            tabFavorites.Text = Properties.Resources.loc_Favorites;
            tabDefaults.Text = Properties.Resources.loc_defaults;
            tabSettings.Text = Properties.Resources.loc_Settings;

            linkDonate.Text = Properties.Resources.loc_Buy_me_a_coffee;

            btnApply.Text = Properties.Resources.loc_btnApply;
            btnFavorites.Text = Properties.Resources.loc_Save_as_favorite;
        }

        private void LinkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VWAXSTS634G88&source=url");
        }

        #region TabControl
        private void Initialize_tabControl()
        {
            ImageList imageList1 = new ImageList();
            imageList1.Images.Add(nameof(Properties.Resources.img_layers), Properties.Resources.img_layers);
            imageList1.Images.Add(nameof(Properties.Resources.img_favorites), Properties.Resources.img_favorites);
            imageList1.Images.Add(nameof(Properties.Resources.img_subCategories), Properties.Resources.img_subCategories);
            imageList1.Images.Add(nameof(Properties.Resources.img_defaults), Properties.Resources.img_defaults);
            imageList1.Images.Add(nameof(Properties.Resources.img_settings), Properties.Resources.img_settings);

            tabControl.ImageList = imageList1;
            tabLayerSelector.ImageKey = nameof(Properties.Resources.img_layers);
            tabFavorites.ImageKey = nameof(Properties.Resources.img_favorites);
            tabDefaults.ImageKey = nameof(Properties.Resources.img_defaults);
            tabSettings.ImageKey = nameof(Properties.Resources.img_settings);

            Initialize_tabLayerSelector();
            Initialize_tabFavorites();
            Initialize_tabDefaults();
            Initialize_tabSettings();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == tabControl.TabPages.IndexOf(tabLayerSelector))
            {
                Initialize_dgvLayerSelector();
            }
            else if (tabControl.SelectedIndex == tabControl.TabPages.IndexOf(tabFavorites))
            {

            }
            else if (tabControl.SelectedIndex == tabControl.TabPages.IndexOf(tabDefaults))
            {

            }
            else if (tabControl.SelectedIndex == tabControl.TabPages.IndexOf(tabSettings))
            {

            }
        }
        #endregion

        #region Tab LayerSelector
        private void Initialize_tabLayerSelector()
        {
            Initialize_dgvLayerSelector();
        }

        private void Initialize_dgvLayerSelector(string filter = null)
        {
            if (string.IsNullOrEmpty(filter))
            {
                dgvLayerSelector.DataSource = MyLayer.GetList();
            }
            else
            {
                dgvLayerSelector.DataSource = MyLayer.GetList().FindAll(x => x.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }


            dgvLayerSelector.Columns["imgAddToDefault"].HeaderText = "";
            dgvLayerSelector.Columns["imgAddToDefault"].MinimumWidth = 24;
            dgvLayerSelector.Columns["imgAddToDefault"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvLayerSelector.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLayerSelector.Columns["Name"].ReadOnly = true;
            dgvLayerSelector.Columns["Name"].HeaderText = Properties.Resources.loc_name;

            dgvLayerSelector.Columns["Visible"].HeaderText = Properties.Resources.loc_visible;
            dgvLayerSelector.Columns["Visible"].Visible = MyDocumentProperties.ShowVisible;

            dgvLayerSelector.Columns["Print"].HeaderText = Properties.Resources.loc_print;
            dgvLayerSelector.Columns["Print"].Visible = MyDocumentProperties.ShowPrint;

            dgvLayerSelector.Columns["Active"].HeaderText = Properties.Resources.loc_active;
            dgvLayerSelector.Columns["Active"].Visible = MyDocumentProperties.ShowActive;

            dgvLayerSelector.Columns["Lock"].HeaderText = Properties.Resources.loc_lock;
            dgvLayerSelector.Columns["Lock"].Visible = MyDocumentProperties.ShowLock;

            dgvLayerSelector.Columns["Snap"].HeaderText = Properties.Resources.loc_snap;
            dgvLayerSelector.Columns["Snap"].Visible = MyDocumentProperties.ShowSnap;

            dgvLayerSelector.Columns["Glue"].HeaderText = Properties.Resources.loc_glue;
            dgvLayerSelector.Columns["Glue"].Visible = MyDocumentProperties.ShowGlue;

            dgvLayerSelector.Columns["isDefault"].Visible = false;
        }

        private void CheckboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DgvLayerSelector_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvLayerSelector.Rows.Count > 0)
            {
                if (e.ColumnIndex == dgvLayerSelector.Columns["Name"].Index)
                {
                    {
                        if (sortAscending)
                        {
                            dgvLayerSelector.DataSource = MyLayer.GetList().OrderBy(i => i.Name).ToList();
                        }
                        else
                        {
                            dgvLayerSelector.DataSource = MyLayer.GetList().OrderBy(i => i.Name).Reverse().ToList();
                        }
                        sortAscending = !sortAscending;
                    }
                }
                else if (e.ColumnIndex >= dgvLayerSelector.Columns["Visible"].Index)
                {
                    for (int i = 0; i < dgvLayerSelector.RowCount; i++)
                    {
                        if (!(bool)dgvLayerSelector["isDefault", i].Value)
                        {
                            if (headerToggleCheckboxes.ContainsKey(e.ColumnIndex))
                            {
                                dgvLayerSelector[e.ColumnIndex, i].Value = !headerToggleCheckboxes[e.ColumnIndex];
                                if (dgvLayerSelector.Rows.Count - 1 == i)
                                {
                                    headerToggleCheckboxes[e.ColumnIndex] = !headerToggleCheckboxes[e.ColumnIndex];
                                }
                            }
                            else
                            {
                                dgvLayerSelector[e.ColumnIndex, i].Value = true;
                                if (dgvLayerSelector.Rows.Count - 1 == i)
                                {
                                    headerToggleCheckboxes.Add(e.ColumnIndex, true);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DgvLayerSelector_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cellAddToDefaults = dgvLayerSelector.Rows[e.RowIndex].Cells[dgvLayerSelector.Columns["imgAddToDefault"].Index];
            cellAddToDefaults.ToolTipText = Properties.Resources.loc_add_to_defaults_list;

            if (e.ColumnIndex >= dgvLayerSelector.Columns["Name"].Index)
            {
                var cell = dgvLayerSelector.Rows[e.RowIndex].Cells[e.ColumnIndex];

                MyLayer item = (MyLayer)dgvLayerSelector.Rows[e.RowIndex].DataBoundItem;
                if (item.IsDefault)
                {
                    dgvLayerSelector.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#e3fbe3");
                    dgvLayerSelector.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#e3fbe3");
                    dgvLayerSelector.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = dgvLayerSelector.DefaultCellStyle.ForeColor;

                    dgvLayerSelector.Rows[e.RowIndex].ReadOnly = true;
                }
                else
                {
                    cell.Style.SelectionBackColor = dgvLayerSelector.DefaultCellStyle.BackColor;
                    cell.Style.SelectionForeColor = dgvLayerSelector.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void DgvLayerSelector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLayerSelector.Columns["imgAddToDefault"].Index)
            {
                MyLayer item = (MyLayer)dgvLayerSelector.Rows[e.RowIndex].DataBoundItem;

                if (!item.IsDefault)
                {
                    ((List<MyDefaults>)dgvDefaults.DataSource).Add(new MyDefaults(item.Name, item.Visible, item.Print, item.Active, item.Lock, item.Snap, item.Glue));

                    MyDefaults.SaveList((List<MyDefaults>)dgvDefaults.DataSource);
                    Initialize_dgvDefaults();

                    item.IsDefault = true;
                    dgvLayerSelector.Update();
                    dgvLayerSelector.Refresh();
                }
            }
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            Initialize_dgvLayerSelector(tbFilter.Text);
        }

        private void BtnFilterClear_Click(object sender, EventArgs e)
        {
            tbFilter.Text = "";
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ChangeLayerSettings((List<MyLayer>)dgvLayerSelector.DataSource);
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            Ookii.Dialogs.WinForms.InputDialog inputDialog = new Ookii.Dialogs.WinForms.InputDialog
            {
                MainInstruction = Properties.Resources.loc_save_current_selection_as_favourite,
                Content = Properties.Resources.loc_Enter_the_name_under_which_the_favorite_should_be_saved,
                WindowTitle = Properties.Resources.loc_save_favorites
            };
            inputDialog.ShowDialog();

            if (!string.IsNullOrEmpty(inputDialog.Input))
            {
                if (((List<MyFavorites>)dgvFavorites.DataSource).FindIndex(x => x.Name.Equals(inputDialog.Input, StringComparison.InvariantCultureIgnoreCase)) < 0)
                {
                    ((List<MyFavorites>)dgvFavorites.DataSource).Add(new MyFavorites(inputDialog.Input, DateTime.Now, (List<MyLayer>)dgvLayerSelector.DataSource));

                    MyFavorites.SaveList((List<MyFavorites>)dgvFavorites.DataSource);
                    Initialize_dgvFavorites();
                }
                else
                {
                    Ookii.Dialogs.WinForms.TaskDialog taskDialog = new Ookii.Dialogs.WinForms.TaskDialog();
                    taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Yes));
                    taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Cancel));

                    taskDialog.Content = Properties.Resources.loc_Do_you_want_to_overwrite_the_favorite;
                    taskDialog.MainInstruction = string.Format(Properties.Resources.loc_The_favorite_already_exists, "'" + inputDialog.Input + "'");
                    taskDialog.WindowTitle = Properties.Resources.loc_save_favorites;
                    taskDialog.AllowDialogCancellation = true;
                    taskDialog.MainIcon = Ookii.Dialogs.WinForms.TaskDialogIcon.Warning;

                    var msgResult = taskDialog.ShowDialog(this);

                    if (msgResult.ButtonType == Ookii.Dialogs.WinForms.ButtonType.Yes)
                    {
                        List<MyFavorites> list = (List<MyFavorites>)dgvFavorites.DataSource;
                        int itemIndex = list.FindIndex(x => x.Name.Equals(inputDialog.Input, StringComparison.InvariantCultureIgnoreCase));

                        list[itemIndex].DateTime = DateTime.Now;
                        list[itemIndex].Layers = (List<MyLayer>)dgvLayerSelector.DataSource;

                        MyFavorites.SaveList(list);
                        Initialize_dgvFavorites();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        #endregion

        #region Tab Favorites
        private void Initialize_tabFavorites()
        {
            Initialize_dgvFavorites();
        }

        private void Initialize_dgvFavorites()
        {
            dgvFavorites.DataSource = MyFavorites.GetList();

            dgvFavorites.Columns["imgCheck"].HeaderText = "";
            dgvFavorites.Columns["imgCheck"].MinimumWidth = 24;
            dgvFavorites.Columns["imgCheck"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvFavorites.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFavorites.Columns["Name"].ReadOnly = true;
            dgvFavorites.Columns["Name"].HeaderText = Properties.Resources.loc_name;

            dgvFavorites.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvFavorites.Columns["DateTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvFavorites.Columns["DateTime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvFavorites.Columns["imgDelete"].HeaderText = "";
            dgvFavorites.Columns["imgDelete"].MinimumWidth = 24;
            dgvFavorites.Columns["imgDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void DgvFavorites_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFavorites.Rows[e.RowIndex].Cells.Count > 0)
            {
                if (e.ColumnIndex == dgvFavorites.Columns["Name"].Index || e.ColumnIndex == dgvFavorites.Columns["DateTime"].Index)
                {
                    var cell = dgvFavorites.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.Style.SelectionBackColor = dgvFavorites.DefaultCellStyle.BackColor;
                    cell.Style.SelectionForeColor = dgvFavorites.DefaultCellStyle.ForeColor;
                }

                var cellLayersApply = dgvFavorites.Rows[e.RowIndex].Cells[dgvFavorites.Columns["imgCheck"].Index];
                cellLayersApply.ToolTipText = Properties.Resources.loc_Apply_layers_settings_from_favorite;

                var cellDeleteBtn = dgvFavorites.Rows[e.RowIndex].Cells[dgvFavorites.Columns["imgDelete"].Index];
                cellDeleteBtn.ToolTipText = Properties.Resources.loc_Delete_entry;
            }
        }

        private void DgvFavorites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFavorites.Columns["imgCheck"].Index)
            {
                ChangeLayerSettings(((MyFavorites)dgvFavorites.Rows[e.RowIndex].DataBoundItem).Layers);
            }

            if (e.ColumnIndex == dgvFavorites.Columns["imgDelete"].Index)
            {
                MyFavorites item = (MyFavorites)dgvFavorites.Rows[e.RowIndex].DataBoundItem;

                Ookii.Dialogs.WinForms.TaskDialog taskDialog = new Ookii.Dialogs.WinForms.TaskDialog();
                taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Yes));
                taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Cancel));

                taskDialog.MainInstruction = Properties.Resources.loc_Do_you_really_want_to_delete;
                taskDialog.WindowTitle = Properties.Resources.loc_title_delete;
                taskDialog.Content = item.Name;
                taskDialog.AllowDialogCancellation = true;
                taskDialog.MainIcon = Ookii.Dialogs.WinForms.TaskDialogIcon.Warning;

                var msgResult = taskDialog.ShowDialog(this);

                if (msgResult.ButtonType == Ookii.Dialogs.WinForms.ButtonType.Yes)
                {
                    List<MyFavorites> list = (List<MyFavorites>)dgvFavorites.DataSource;

                    list.RemoveAt(e.RowIndex);
                    MyFavorites.SaveList(list);

                    Initialize_dgvFavorites();
                }
            }
        }

        private void DgvFavorites_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFavorites.Rows.Count > 0)
            {
                if (e.ColumnIndex == dgvFavorites.Columns["Name"].Index)
                {
                    {
                        if (sortFavoritesAscending)
                        {
                            dgvFavorites.DataSource = MyFavorites.GetList().OrderBy(i => i.Name).ToList();
                        }
                        else
                        {
                            dgvFavorites.DataSource = MyFavorites.GetList().OrderBy(i => i.Name).Reverse().ToList();
                        }
                        sortFavoritesAscending = !sortFavoritesAscending;
                    }
                }
                else if (e.ColumnIndex >= dgvFavorites.Columns["DateTime"].Index)
                {
                    if (sortFavoritesDateTimeAscending)
                    {
                        dgvFavorites.DataSource = MyFavorites.GetList().OrderBy(i => i.DateTime).ToList();
                    }
                    else
                    {
                        dgvFavorites.DataSource = MyFavorites.GetList().OrderBy(i => i.DateTime).Reverse().ToList();
                    }
                    sortFavoritesDateTimeAscending = !sortFavoritesDateTimeAscending;
                }
            }
        }

        #endregion

        #region Tab Defaults
        private void Initialize_tabDefaults()
        {
            Initialize_dgvDefaults();
        }

        private void Initialize_dgvDefaults()
        {
            dgvDefaults.DataSource = MyDefaults.getList();

            dgvDefaults.Columns["imgDelete"].HeaderText = "";
            dgvDefaults.Columns["imgDelete"].MinimumWidth = 24;
            dgvDefaults.Columns["imgDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDefaults.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDefaults.Columns["Name"].ReadOnly = true;
            dgvDefaults.Columns["Name"].HeaderText = Properties.Resources.loc_name;

            dgvDefaults.Columns["Visible"].HeaderText = Properties.Resources.loc_visible;
            dgvDefaults.Columns["Visible"].Visible = MyDocumentProperties.ShowVisible;

            dgvDefaults.Columns["Print"].HeaderText = Properties.Resources.loc_print;
            dgvDefaults.Columns["Print"].Visible = MyDocumentProperties.ShowPrint;

            dgvDefaults.Columns["Active"].HeaderText = Properties.Resources.loc_active;
            dgvDefaults.Columns["Active"].Visible = MyDocumentProperties.ShowActive;

            dgvDefaults.Columns["Lock"].HeaderText = Properties.Resources.loc_lock;
            dgvDefaults.Columns["Lock"].Visible = MyDocumentProperties.ShowLock;

            dgvDefaults.Columns["Snap"].HeaderText = Properties.Resources.loc_snap;
            dgvDefaults.Columns["Snap"].Visible = MyDocumentProperties.ShowSnap;

            dgvDefaults.Columns["Glue"].HeaderText = Properties.Resources.loc_glue;
            dgvDefaults.Columns["Glue"].Visible = MyDocumentProperties.ShowGlue;
        }

        private void DgvDefaults_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dgvDefaults.Columns["Name"].Index)
            {
                {
                    if (sortDefaultsAscending)
                    {
                        dgvDefaults.DataSource = MyDefaults.getList().OrderBy(i => i.Name).ToList();
                    }
                    else
                    {
                        dgvDefaults.DataSource = MyDefaults.getList().OrderBy(i => i.Name).Reverse().ToList();
                    }
                    sortDefaultsAscending = !sortDefaultsAscending;
                }
            }
        }

        private void DgvDefaults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= dgvDefaults.Columns["Visible"].Index)
            {
                MyDefaults.SaveList((List<MyDefaults>)dgvDefaults.DataSource);
            }
        }

        private void DgvDefaults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDefaults.Columns["imgDelete"].Index)
            {
                MyDefaults item = (MyDefaults)dgvDefaults.Rows[e.RowIndex].DataBoundItem;

                Ookii.Dialogs.WinForms.TaskDialog taskDialog = new Ookii.Dialogs.WinForms.TaskDialog();
                taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Yes));
                taskDialog.Buttons.Add(new Ookii.Dialogs.WinForms.TaskDialogButton(Ookii.Dialogs.WinForms.ButtonType.Cancel));

                taskDialog.MainInstruction = Properties.Resources.loc_Do_you_really_want_to_delete;
                taskDialog.WindowTitle = Properties.Resources.loc_title_delete;
                taskDialog.Content = item.Name;
                taskDialog.AllowDialogCancellation = true;
                taskDialog.MainIcon = Ookii.Dialogs.WinForms.TaskDialogIcon.Warning;

                var msgResult = taskDialog.ShowDialog(this);

                if (msgResult.ButtonType == Ookii.Dialogs.WinForms.ButtonType.Yes)
                {
                    List<MyDefaults> list = (List<MyDefaults>)dgvDefaults.DataSource;

                    list.Remove(item);
                    MyDefaults.SaveList(list);

                    Initialize_dgvDefaults();
                }
            }
        }

        private void DgvDefaults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDefaults.Rows[e.RowIndex].Cells.Count > 0)
            {
                if (e.ColumnIndex >= dgvDefaults.Columns["Name"].Index)
                {
                    var cell = dgvDefaults.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cell.Style.SelectionBackColor = dgvDefaults.DefaultCellStyle.BackColor;
                    cell.Style.SelectionForeColor = dgvDefaults.DefaultCellStyle.ForeColor;
                }

                var cellDeleteBtn = dgvDefaults.Rows[e.RowIndex].Cells[dgvDefaults.Columns["imgDelete"].Index];
                cellDeleteBtn.ToolTipText = Properties.Resources.loc_Delete_entry;
            }
        }

        #endregion

        #region Tab Settings
        private void Initialize_tabSettings()
        {
            cbSettingsVisible.Checked = MyDocumentProperties.ShowVisible;
            cbSettingsVisible.Text = Properties.Resources.loc_show_visible_column;

            cbSettingsPrint.Checked = MyDocumentProperties.ShowPrint;
            cbSettingsPrint.Text = Properties.Resources.loc_show_print_column;

            cbSettingsActive.Checked = MyDocumentProperties.ShowActive;
            cbSettingsActive.Text = Properties.Resources.loc_show_active_column;

            cbSettingsLock.Checked = MyDocumentProperties.ShowLock;
            cbSettingsLock.Text = Properties.Resources.loc_show_lock_column;

            cbSettingsSnap.Checked = MyDocumentProperties.ShowSnap;
            cbSettingsSnap.Text = Properties.Resources.loc_show_snap_column;

            cbSettingsGlue.Checked = MyDocumentProperties.ShowGlue;
            cbSettingsGlue.Text = Properties.Resources.loc_show_glue_column;
        }

        private void CbSettingsVisible_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowVisible = cbSettingsVisible.Checked;
            SaveSettings();
        }

        private void CbSettingsPrint_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowPrint = cbSettingsPrint.Checked;
            SaveSettings();
        }

        private void CbSettingsActive_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowActive = cbSettingsActive.Checked;
            SaveSettings();
        }

        private void CbSettingsLock_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowLock = cbSettingsLock.Checked;
            SaveSettings();
        }

        private void CbSettingsSnap_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowSnap = cbSettingsSnap.Checked;
            SaveSettings();
        }

        private void CbSettingsGlue_CheckedChanged(object sender, EventArgs e)
        {
            MyDocumentProperties.ShowGlue = cbSettingsGlue.Checked;
            SaveSettings();
        }

        private void SaveSettings()
        {
            Initialize_dgvLayerSelector();
            Initialize_dgvDefaults();
        }









        #endregion


    }
}
