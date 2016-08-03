namespace PokemonGo.RocketAPI.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbItemsInventory = new System.Windows.Forms.Label();
            this.lbPokemonsInventory = new System.Windows.Forms.Label();
            this.lbExperience = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxPokemonName = new System.Windows.Forms.TextBox();
            this.boxPokestopCount = new System.Windows.Forms.TextBox();
            this.boxPokemonCaughtProb = new System.Windows.Forms.TextBox();
            this.boxPokestopInit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxPokestopName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snipePokemonsBetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceRemoveBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyPokemonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evolveAllPokemonwCandyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferDuplicatePokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luckyEgg0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incence0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recycleItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expProgressBar = new System.Windows.Forms.ProgressBar();
            this.boxPokemonCount = new System.Windows.Forms.TextBox();
            this.boxInventoryCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxLuckyEggsCount = new System.Windows.Forms.TextBox();
            this.boxIncencesCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxStatsPkmnTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxStatsPkmnHour = new System.Windows.Forms.TextBox();
            this.boxStatsTimeElapsed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxStatsExpHour = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbItemsInventory
            // 
            this.lbItemsInventory.AutoSize = true;
            this.lbItemsInventory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemsInventory.Location = new System.Drawing.Point(8, 86);
            this.lbItemsInventory.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lbItemsInventory.Name = "lbItemsInventory";
            this.lbItemsInventory.Size = new System.Drawing.Size(118, 30);
            this.lbItemsInventory.TabIndex = 4;
            this.lbItemsInventory.Text = "Инвентарь";
            // 
            // lbPokemonsInventory
            // 
            this.lbPokemonsInventory.AutoSize = true;
            this.lbPokemonsInventory.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPokemonsInventory.Location = new System.Drawing.Point(8, 46);
            this.lbPokemonsInventory.Margin = new System.Windows.Forms.Padding(5, 15, 3, 0);
            this.lbPokemonsInventory.Name = "lbPokemonsInventory";
            this.lbPokemonsInventory.Size = new System.Drawing.Size(115, 30);
            this.lbPokemonsInventory.TabIndex = 3;
            this.lbPokemonsInventory.Text = "Покемоны";
            // 
            // lbExperience
            // 
            this.lbExperience.AutoSize = true;
            this.lbExperience.BackColor = System.Drawing.Color.Transparent;
            this.lbExperience.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbExperience.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExperience.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbExperience.Location = new System.Drawing.Point(623, 105);
            this.lbExperience.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbExperience.Name = "lbExperience";
            this.lbExperience.Size = new System.Drawing.Size(67, 32);
            this.lbExperience.TabIndex = 2;
            this.lbExperience.Text = "Опыт";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLevel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbLevel.Location = new System.Drawing.Point(371, 105);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(96, 32);
            this.lbLevel.TabIndex = 1;
            this.lbLevel.Text = "Уровень";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbName.Location = new System.Drawing.Point(368, 55);
            this.lbName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(330, 47);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Имя Покемастера";
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(685, 164);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.Size = new System.Drawing.Size(347, 438);
            this.dGrid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxPokemonName);
            this.groupBox2.Controls.Add(this.boxPokestopCount);
            this.groupBox2.Controls.Add(this.boxPokemonCaughtProb);
            this.groupBox2.Controls.Add(this.boxPokestopInit);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.boxPokestopName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(340, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текущий покестоп";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 30);
            this.label11.TabIndex = 19;
            this.label11.Text = "Процент поимки %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "из";
            // 
            // boxPokemonName
            // 
            this.boxPokemonName.Enabled = false;
            this.boxPokemonName.Location = new System.Drawing.Point(136, 125);
            this.boxPokemonName.Name = "boxPokemonName";
            this.boxPokemonName.Size = new System.Drawing.Size(185, 35);
            this.boxPokemonName.TabIndex = 11;
            this.boxPokemonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxPokestopCount
            // 
            this.boxPokestopCount.Enabled = false;
            this.boxPokestopCount.Location = new System.Drawing.Point(262, 85);
            this.boxPokestopCount.Name = "boxPokestopCount";
            this.boxPokestopCount.Size = new System.Drawing.Size(59, 35);
            this.boxPokestopCount.TabIndex = 8;
            this.boxPokestopCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxPokemonCaughtProb
            // 
            this.boxPokemonCaughtProb.Enabled = false;
            this.boxPokemonCaughtProb.Location = new System.Drawing.Point(205, 167);
            this.boxPokemonCaughtProb.Name = "boxPokemonCaughtProb";
            this.boxPokemonCaughtProb.Size = new System.Drawing.Size(116, 35);
            this.boxPokemonCaughtProb.TabIndex = 18;
            this.boxPokemonCaughtProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxPokestopInit
            // 
            this.boxPokestopInit.Enabled = false;
            this.boxPokestopInit.Location = new System.Drawing.Point(136, 85);
            this.boxPokestopInit.Name = "boxPokestopInit";
            this.boxPokestopInit.Size = new System.Drawing.Size(57, 35);
            this.boxPokestopInit.TabIndex = 3;
            this.boxPokestopInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 125);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 30);
            this.label15.TabIndex = 10;
            this.label15.Text = "Покемон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Покестоп №";
            // 
            // boxPokestopName
            // 
            this.boxPokestopName.Enabled = false;
            this.boxPokestopName.Location = new System.Drawing.Point(11, 45);
            this.boxPokestopName.Name = "boxPokestopName";
            this.boxPokestopName.Size = new System.Drawing.Size(310, 35);
            this.boxPokestopName.TabIndex = 1;
            this.boxPokestopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.MainMap);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox5.Location = new System.Drawing.Point(340, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 223);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Локация";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.SystemColors.Control;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(3, 31);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 2;
            this.MainMap.MinZoom = 2;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(333, 189);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0D;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.myPokemonToolStripMenuItem,
            this.myInventoryToolStripMenuItem,
            this.newLocationToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1044, 23);
            this.mainMenuStrip.Stretch = false;
            this.mainMenuStrip.TabIndex = 9;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farmingToolStripMenuItem,
            this.snipePokemonsBetaToolStripMenuItem,
            this.forceRemoveBanToolStripMenuItem,
            this.displayConsoleToolStripMenuItem,
            this.showStatisticsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.applicationToolStripMenuItem.Text = "Меню";
            // 
            // farmingToolStripMenuItem
            // 
            this.farmingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.farmingToolStripMenuItem.Name = "farmingToolStripMenuItem";
            this.farmingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.farmingToolStripMenuItem.Text = "Фарм";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startToolStripMenuItem.Text = "Начать";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.stopToolStripMenuItem.Text = "Приостановить";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // snipePokemonsBetaToolStripMenuItem
            // 
            this.snipePokemonsBetaToolStripMenuItem.Name = "snipePokemonsBetaToolStripMenuItem";
            this.snipePokemonsBetaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.snipePokemonsBetaToolStripMenuItem.Text = "Точечный отлов покемонов";
            this.snipePokemonsBetaToolStripMenuItem.Click += new System.EventHandler(this.snipePokemonsBetaToolStripMenuItem_Click);
            // 
            // forceRemoveBanToolStripMenuItem
            // 
            this.forceRemoveBanToolStripMenuItem.Name = "forceRemoveBanToolStripMenuItem";
            this.forceRemoveBanToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.forceRemoveBanToolStripMenuItem.Text = "Разбан";
            this.forceRemoveBanToolStripMenuItem.Click += new System.EventHandler(this.forceRemoveBanToolStripMenuItem_Click);
            // 
            // displayConsoleToolStripMenuItem
            // 
            this.displayConsoleToolStripMenuItem.Name = "displayConsoleToolStripMenuItem";
            this.displayConsoleToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.displayConsoleToolStripMenuItem.Text = "Открыть консоль";
            this.displayConsoleToolStripMenuItem.Click += new System.EventHandler(this.displayConsoleToolStripMenuItem_Click);
            // 
            // showStatisticsToolStripMenuItem
            // 
            this.showStatisticsToolStripMenuItem.Name = "showStatisticsToolStripMenuItem";
            this.showStatisticsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.showStatisticsToolStripMenuItem.Text = "Вывести статистику";
            this.showStatisticsToolStripMenuItem.Click += new System.EventHandler(this.showStatisticsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myPokemonToolStripMenuItem
            // 
            this.myPokemonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyPokemonsToolStripMenuItem,
            this.evolveAllPokemonwCandyToolStripMenuItem,
            this.transferDuplicatePokemonToolStripMenuItem});
            this.myPokemonToolStripMenuItem.Name = "myPokemonToolStripMenuItem";
            this.myPokemonToolStripMenuItem.Size = new System.Drawing.Size(105, 19);
            this.myPokemonToolStripMenuItem.Text = "Мои покемоны";
            // 
            // viewMyPokemonsToolStripMenuItem
            // 
            this.viewMyPokemonsToolStripMenuItem.Name = "viewMyPokemonsToolStripMenuItem";
            this.viewMyPokemonsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.viewMyPokemonsToolStripMenuItem.Text = "Открыть рюкзак";
            this.viewMyPokemonsToolStripMenuItem.Click += new System.EventHandler(this.viewMyPokemonsToolStripMenuItem_Click);
            // 
            // evolveAllPokemonwCandyToolStripMenuItem
            // 
            this.evolveAllPokemonwCandyToolStripMenuItem.Name = "evolveAllPokemonwCandyToolStripMenuItem";
            this.evolveAllPokemonwCandyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.evolveAllPokemonwCandyToolStripMenuItem.Text = "Эволвнуть всех покемонов";
            this.evolveAllPokemonwCandyToolStripMenuItem.Click += new System.EventHandler(this.evolveAllPokemonwCandyToolStripMenuItem_Click);
            // 
            // transferDuplicatePokemonToolStripMenuItem
            // 
            this.transferDuplicatePokemonToolStripMenuItem.Name = "transferDuplicatePokemonToolStripMenuItem";
            this.transferDuplicatePokemonToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.transferDuplicatePokemonToolStripMenuItem.Text = "Трансфер дубликатов";
            this.transferDuplicatePokemonToolStripMenuItem.Click += new System.EventHandler(this.transferDuplicatePokemonToolStripMenuItem_Click);
            // 
            // myInventoryToolStripMenuItem
            // 
            this.myInventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useItemsToolStripMenuItem,
            this.recycleItemsToolStripMenuItem});
            this.myInventoryToolStripMenuItem.Name = "myInventoryToolStripMenuItem";
            this.myInventoryToolStripMenuItem.Size = new System.Drawing.Size(104, 19);
            this.myInventoryToolStripMenuItem.Text = "Мой инвентарь";
            this.myInventoryToolStripMenuItem.Click += new System.EventHandler(this.myInventoryToolStripMenuItem_Click);
            // 
            // useItemsToolStripMenuItem
            // 
            this.useItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luckyEgg0ToolStripMenuItem,
            this.incence0ToolStripMenuItem});
            this.useItemsToolStripMenuItem.Name = "useItemsToolStripMenuItem";
            this.useItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.useItemsToolStripMenuItem.Text = "Использовать";
            // 
            // luckyEgg0ToolStripMenuItem
            // 
            this.luckyEgg0ToolStripMenuItem.Name = "luckyEgg0ToolStripMenuItem";
            this.luckyEgg0ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.luckyEgg0ToolStripMenuItem.Text = "Буст ";
            this.luckyEgg0ToolStripMenuItem.Click += new System.EventHandler(this.luckyEgg0ToolStripMenuItem_Click);
            // 
            // incence0ToolStripMenuItem
            // 
            this.incence0ToolStripMenuItem.Name = "incence0ToolStripMenuItem";
            this.incence0ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incence0ToolStripMenuItem.Text = "Приманку";
            this.incence0ToolStripMenuItem.Click += new System.EventHandler(this.incence0ToolStripMenuItem_Click);
            // 
            // recycleItemsToolStripMenuItem
            // 
            this.recycleItemsToolStripMenuItem.Name = "recycleItemsToolStripMenuItem";
            this.recycleItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recycleItemsToolStripMenuItem.Text = "Выкинуть";
            this.recycleItemsToolStripMenuItem.Click += new System.EventHandler(this.recycleItemsToolStripMenuItem_Click);
            // 
            // newLocationToolStripMenuItem
            // 
            this.newLocationToolStripMenuItem.Name = "newLocationToolStripMenuItem";
            this.newLocationToolStripMenuItem.Size = new System.Drawing.Size(158, 19);
            this.newLocationToolStripMenuItem.Text = "Выбрать новую локацию";
            this.newLocationToolStripMenuItem.Click += new System.EventHandler(this.newLocationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(107, 19);
            this.settingsToolStripMenuItem.Text = "Настройки бота";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.aboutToolStripMenuItem.Text = "Об авторе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // expProgressBar
            // 
            this.expProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.expProgressBar.Location = new System.Drawing.Point(0, 23);
            this.expProgressBar.Name = "expProgressBar";
            this.expProgressBar.Size = new System.Drawing.Size(1044, 26);
            this.expProgressBar.TabIndex = 10;
            // 
            // boxPokemonCount
            // 
            this.boxPokemonCount.Cursor = System.Windows.Forms.Cursors.No;
            this.boxPokemonCount.Enabled = false;
            this.boxPokemonCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPokemonCount.Location = new System.Drawing.Point(182, 46);
            this.boxPokemonCount.Name = "boxPokemonCount";
            this.boxPokemonCount.Size = new System.Drawing.Size(123, 35);
            this.boxPokemonCount.TabIndex = 11;
            this.boxPokemonCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxInventoryCount
            // 
            this.boxInventoryCount.Enabled = false;
            this.boxInventoryCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInventoryCount.Location = new System.Drawing.Point(182, 86);
            this.boxInventoryCount.Name = "boxInventoryCount";
            this.boxInventoryCount.Size = new System.Drawing.Size(123, 35);
            this.boxInventoryCount.TabIndex = 12;
            this.boxInventoryCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Буст xp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Приманки";
            // 
            // boxLuckyEggsCount
            // 
            this.boxLuckyEggsCount.Enabled = false;
            this.boxLuckyEggsCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLuckyEggsCount.Location = new System.Drawing.Point(182, 126);
            this.boxLuckyEggsCount.Name = "boxLuckyEggsCount";
            this.boxLuckyEggsCount.Size = new System.Drawing.Size(123, 35);
            this.boxLuckyEggsCount.TabIndex = 15;
            this.boxLuckyEggsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxIncencesCount
            // 
            this.boxIncencesCount.Enabled = false;
            this.boxIncencesCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIncencesCount.Location = new System.Drawing.Point(182, 166);
            this.boxIncencesCount.Name = "boxIncencesCount";
            this.boxIncencesCount.Size = new System.Drawing.Size(123, 35);
            this.boxIncencesCount.TabIndex = 16;
            this.boxIncencesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbPokemonsInventory);
            this.groupBox1.Controls.Add(this.boxIncencesCount);
            this.groupBox1.Controls.Add(this.lbItemsInventory);
            this.groupBox1.Controls.Add(this.boxLuckyEggsCount);
            this.groupBox1.Controls.Add(this.boxPokemonCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxInventoryCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Мой инвентарь";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.boxStatsPkmnTotal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.boxStatsPkmnHour);
            this.groupBox4.Controls.Add(this.boxStatsTimeElapsed);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.boxStatsExpHour);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox4.Location = new System.Drawing.Point(12, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 223);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статистика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Прошло времени";
            // 
            // boxStatsPkmnTotal
            // 
            this.boxStatsPkmnTotal.Enabled = false;
            this.boxStatsPkmnTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatsPkmnTotal.Location = new System.Drawing.Point(199, 167);
            this.boxStatsPkmnTotal.Name = "boxStatsPkmnTotal";
            this.boxStatsPkmnTotal.Size = new System.Drawing.Size(123, 35);
            this.boxStatsPkmnTotal.TabIndex = 16;
            this.boxStatsPkmnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Опыта в час";
            // 
            // boxStatsPkmnHour
            // 
            this.boxStatsPkmnHour.Enabled = false;
            this.boxStatsPkmnHour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatsPkmnHour.Location = new System.Drawing.Point(199, 127);
            this.boxStatsPkmnHour.Name = "boxStatsPkmnHour";
            this.boxStatsPkmnHour.Size = new System.Drawing.Size(123, 35);
            this.boxStatsPkmnHour.TabIndex = 15;
            this.boxStatsPkmnHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxStatsTimeElapsed
            // 
            this.boxStatsTimeElapsed.Enabled = false;
            this.boxStatsTimeElapsed.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatsTimeElapsed.Location = new System.Drawing.Point(199, 46);
            this.boxStatsTimeElapsed.Name = "boxStatsTimeElapsed";
            this.boxStatsTimeElapsed.Size = new System.Drawing.Size(123, 35);
            this.boxStatsTimeElapsed.TabIndex = 11;
            this.boxStatsTimeElapsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Всего покемонов";
            // 
            // boxStatsExpHour
            // 
            this.boxStatsExpHour.Enabled = false;
            this.boxStatsExpHour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatsExpHour.Location = new System.Drawing.Point(199, 87);
            this.boxStatsExpHour.Name = "boxStatsExpHour";
            this.boxStatsExpHour.Size = new System.Drawing.Size(123, 35);
            this.boxStatsExpHour.TabIndex = 12;
            this.boxStatsExpHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Покемонов в час";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 621);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbExperience);
            this.Controls.Add(this.expProgressBar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxPokestopCount;
        private System.Windows.Forms.TextBox boxPokestopInit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxPokestopName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxPokemonName;
        private System.Windows.Forms.TextBox boxPokemonCaughtProb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbExperience;
        private System.Windows.Forms.Label lbItemsInventory;
        private System.Windows.Forms.Label lbPokemonsInventory;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myPokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyPokemonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evolveAllPokemonwCandyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferDuplicatePokemonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luckyEgg0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incence0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recycleItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar expProgressBar;
        private System.Windows.Forms.ToolStripMenuItem showStatisticsToolStripMenuItem;
        private System.Windows.Forms.TextBox boxPokemonCount;
        private System.Windows.Forms.TextBox boxInventoryCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxLuckyEggsCount;
        private System.Windows.Forms.TextBox boxIncencesCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxStatsPkmnTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxStatsPkmnHour;
        private System.Windows.Forms.TextBox boxStatsTimeElapsed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxStatsExpHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem displayConsoleToolStripMenuItem;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.ToolStripMenuItem forceRemoveBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snipePokemonsBetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}

