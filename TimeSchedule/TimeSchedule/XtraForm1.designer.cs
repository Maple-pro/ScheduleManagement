namespace TimeSchedule
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.overviewTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.staticsTileBarItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.overviewNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.overviewLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.staticsNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.frequentSceneLabel = new DevExpress.XtraEditors.LabelControl();
            this.totalTimeLabel = new DevExpress.XtraEditors.LabelControl();
            this.longestTimeLabel = new DevExpress.XtraEditors.LabelControl();
            this.maxFocusOneLabel = new DevExpress.XtraEditors.LabelControl();
            this.focusDayLabel = new DevExpress.XtraEditors.LabelControl();
            this.focusTimeLabel = new DevExpress.XtraEditors.LabelControl();
            this.registerTimeLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.staticsLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.timeScheduleDBDataSet1 = new TimeSchedule.TimeScheduleDBDataSet();
            this.timeScheduleDBDataSet2 = new TimeSchedule.TimeScheduleDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.overviewNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.staticsNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tileBar.MaxId = 3;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 152);
            this.tileBar.MinimumSize = new System.Drawing.Size(134, 152);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(39, 15, 39, 15);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.overviewTileBarItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1046, 152);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.overviewTileBarItem);
            this.tileBarGroupTables.Items.Add(this.staticsTileBarItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // overviewTileBarItem
            // 
            this.overviewTileBarItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.overviewTileBarItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.overviewTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.Text = "总览图";
            this.overviewTileBarItem.Elements.Add(tileItemElement1);
            this.overviewTileBarItem.Name = "overviewTileBarItem";
            this.overviewTileBarItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.overviewTileBarItem_ItemClick);
            this.overviewTileBarItem.ItemPress += new DevExpress.XtraEditors.TileItemClickEventHandler(this.overviewTileBarItem_ItemPress);
            // 
            // staticsTileBarItem
            // 
            this.staticsTileBarItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "详细信息";
            this.staticsTileBarItem.Elements.Add(tileItemElement2);
            this.staticsTileBarItem.Id = 2;
            this.staticsTileBarItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.staticsTileBarItem.Name = "staticsTileBarItem";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.overviewNavigationPage);
            this.navigationFrame.Controls.Add(this.staticsNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 152);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.overviewNavigationPage,
            this.staticsNavigationPage});
            this.navigationFrame.SelectedPage = this.overviewNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(1046, 625);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // overviewNavigationPage
            // 
            this.overviewNavigationPage.Caption = "overviewNavigationPage";
            this.overviewNavigationPage.Controls.Add(this.panelControl1);
            this.overviewNavigationPage.Controls.Add(this.overviewLabelControl);
            this.overviewNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.overviewNavigationPage.Name = "overviewNavigationPage";
            this.overviewNavigationPage.Size = new System.Drawing.Size(1195, 804);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1195, 804);
            this.panelControl1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(15, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "查看数据示图";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "专注次数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "注册天数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "专注天数";
            // 
            // overviewLabelControl
            // 
            this.overviewLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.overviewLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.overviewLabelControl.Appearance.Options.UseFont = true;
            this.overviewLabelControl.Appearance.Options.UseForeColor = true;
            this.overviewLabelControl.Appearance.Options.UseTextOptions = true;
            this.overviewLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.overviewLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.overviewLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.overviewLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewLabelControl.Location = new System.Drawing.Point(0, 0);
            this.overviewLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.overviewLabelControl.Name = "overviewLabelControl";
            this.overviewLabelControl.Size = new System.Drawing.Size(1195, 804);
            this.overviewLabelControl.TabIndex = 2;
            this.overviewLabelControl.Text = "Overview";
            // 
            // staticsNavigationPage
            // 
            this.staticsNavigationPage.Caption = "staticsNavigationPage";
            this.staticsNavigationPage.Controls.Add(this.tablePanel1);
            this.staticsNavigationPage.Controls.Add(this.staticsLabelControl);
            this.staticsNavigationPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staticsNavigationPage.Name = "staticsNavigationPage";
            this.staticsNavigationPage.Size = new System.Drawing.Size(1195, 804);
            // 
            // tablePanel1
            // 
            this.tablePanel1.AllowTouchScroll = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8.33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.67F)});
            this.tablePanel1.Controls.Add(this.frequentSceneLabel);
            this.tablePanel1.Controls.Add(this.totalTimeLabel);
            this.tablePanel1.Controls.Add(this.longestTimeLabel);
            this.tablePanel1.Controls.Add(this.maxFocusOneLabel);
            this.tablePanel1.Controls.Add(this.focusDayLabel);
            this.tablePanel1.Controls.Add(this.focusTimeLabel);
            this.tablePanel1.Controls.Add(this.registerTimeLabel);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.ShowGrid = DevExpress.Utils.DefaultBoolean.True;
            this.tablePanel1.Size = new System.Drawing.Size(1195, 804);
            this.tablePanel1.TabIndex = 3;
            // 
            // frequentSceneLabel
            // 
            this.tablePanel1.SetColumn(this.frequentSceneLabel, 1);
            this.frequentSceneLabel.Location = new System.Drawing.Point(169, 205);
            this.frequentSceneLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frequentSceneLabel.Name = "frequentSceneLabel";
            this.tablePanel1.SetRow(this.frequentSceneLabel, 6);
            this.frequentSceneLabel.Size = new System.Drawing.Size(98, 18);
            this.frequentSceneLabel.TabIndex = 13;
            this.frequentSceneLabel.Text = "frequent scene";
            // 
            // totalTimeLabel
            // 
            this.tablePanel1.SetColumn(this.totalTimeLabel, 1);
            this.totalTimeLabel.Location = new System.Drawing.Point(169, 172);
            this.totalTimeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.tablePanel1.SetRow(this.totalTimeLabel, 5);
            this.totalTimeLabel.Size = new System.Drawing.Size(61, 18);
            this.totalTimeLabel.TabIndex = 12;
            this.totalTimeLabel.Text = "total time";
            // 
            // longestTimeLabel
            // 
            this.tablePanel1.SetColumn(this.longestTimeLabel, 1);
            this.longestTimeLabel.Location = new System.Drawing.Point(169, 139);
            this.longestTimeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.longestTimeLabel.Name = "longestTimeLabel";
            this.tablePanel1.SetRow(this.longestTimeLabel, 4);
            this.longestTimeLabel.Size = new System.Drawing.Size(79, 18);
            this.longestTimeLabel.TabIndex = 11;
            this.longestTimeLabel.Text = "longest time";
            // 
            // maxFocusOneLabel
            // 
            this.tablePanel1.SetColumn(this.maxFocusOneLabel, 1);
            this.maxFocusOneLabel.Location = new System.Drawing.Point(169, 106);
            this.maxFocusOneLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxFocusOneLabel.Name = "maxFocusOneLabel";
            this.tablePanel1.SetRow(this.maxFocusOneLabel, 3);
            this.maxFocusOneLabel.Size = new System.Drawing.Size(126, 18);
            this.maxFocusOneLabel.TabIndex = 10;
            this.maxFocusOneLabel.Text = "max focus in a day";
            // 
            // focusDayLabel
            // 
            this.tablePanel1.SetColumn(this.focusDayLabel, 1);
            this.focusDayLabel.Location = new System.Drawing.Point(169, 73);
            this.focusDayLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.focusDayLabel.Name = "focusDayLabel";
            this.tablePanel1.SetRow(this.focusDayLabel, 2);
            this.focusDayLabel.Size = new System.Drawing.Size(64, 18);
            this.focusDayLabel.TabIndex = 9;
            this.focusDayLabel.Text = "focus day";
            // 
            // focusTimeLabel
            // 
            this.tablePanel1.SetColumn(this.focusTimeLabel, 1);
            this.focusTimeLabel.Location = new System.Drawing.Point(169, 40);
            this.focusTimeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.focusTimeLabel.Name = "focusTimeLabel";
            this.tablePanel1.SetRow(this.focusTimeLabel, 1);
            this.focusTimeLabel.Size = new System.Drawing.Size(68, 18);
            this.focusTimeLabel.TabIndex = 8;
            this.focusTimeLabel.Text = "focus time";
            // 
            // registerTimeLabel
            // 
            this.tablePanel1.SetColumn(this.registerTimeLabel, 1);
            this.registerTimeLabel.Location = new System.Drawing.Point(169, 7);
            this.registerTimeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerTimeLabel.Name = "registerTimeLabel";
            this.tablePanel1.SetRow(this.registerTimeLabel, 0);
            this.registerTimeLabel.Size = new System.Drawing.Size(81, 18);
            this.registerTimeLabel.TabIndex = 7;
            this.registerTimeLabel.Text = "register time";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(3, 205);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 6);
            this.labelControl7.Size = new System.Drawing.Size(90, 18);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "最常专注场景";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 172);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 5);
            this.labelControl6.Size = new System.Drawing.Size(90, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "累计专注时长";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 0);
            this.labelControl5.Location = new System.Drawing.Point(3, 139);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(90, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "最长专注时间";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 106);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(120, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "单天最多专注次数";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 73);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(60, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "专注天数";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 40);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "专注次数";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "注册时间";
            // 
            // staticsLabelControl
            // 
            this.staticsLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.staticsLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.staticsLabelControl.Appearance.Options.UseFont = true;
            this.staticsLabelControl.Appearance.Options.UseForeColor = true;
            this.staticsLabelControl.Appearance.Options.UseTextOptions = true;
            this.staticsLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.staticsLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.staticsLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.staticsLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staticsLabelControl.Location = new System.Drawing.Point(0, 0);
            this.staticsLabelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staticsLabelControl.Name = "staticsLabelControl";
            this.staticsLabelControl.Size = new System.Drawing.Size(1195, 804);
            this.staticsLabelControl.TabIndex = 2;
            this.staticsLabelControl.Text = "Statics";
            // 
            // timeScheduleDBDataSet1
            // 
            this.timeScheduleDBDataSet1.DataSetName = "TimeScheduleDBDataSet";
            this.timeScheduleDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeScheduleDBDataSet2
            // 
            this.timeScheduleDBDataSet2.DataSetName = "TimeScheduleDBDataSet";
            this.timeScheduleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XtraForm1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 777);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.HtmlText = "Achievement";
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("XtraForm1.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.overviewNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.staticsNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem overviewTileBarItem;
        private DevExpress.XtraBars.Navigation.TileBarItem staticsTileBarItem;
        private DevExpress.XtraBars.Navigation.NavigationPage overviewNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage staticsNavigationPage;
        private DevExpress.XtraEditors.LabelControl overviewLabelControl;
        private DevExpress.XtraEditors.LabelControl staticsLabelControl;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private TimeScheduleDBDataSet timeScheduleDBDataSet1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl frequentSceneLabel;
        private DevExpress.XtraEditors.LabelControl totalTimeLabel;
        private DevExpress.XtraEditors.LabelControl longestTimeLabel;
        private DevExpress.XtraEditors.LabelControl maxFocusOneLabel;
        private DevExpress.XtraEditors.LabelControl focusDayLabel;
        private DevExpress.XtraEditors.LabelControl focusTimeLabel;
        private DevExpress.XtraEditors.LabelControl registerTimeLabel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private TimeScheduleDBDataSet timeScheduleDBDataSet2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}