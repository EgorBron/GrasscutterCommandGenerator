﻿namespace GrasscutterTools.Pages
{
    partial class PageScene
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageScene));
            this.RbListDungeons = new System.Windows.Forms.RadioButton();
            this.RbListScene = new System.Windows.Forms.RadioButton();
            this.TxtSceneFilter = new System.Windows.Forms.TextBox();
            this.ChkIncludeSceneId = new System.Windows.Forms.CheckBox();
            this.LblTpZ = new System.Windows.Forms.Label();
            this.LblTpY = new System.Windows.Forms.Label();
            this.BtnTeleport = new System.Windows.Forms.Button();
            this.LblTpX = new System.Windows.Forms.Label();
            this.NUDTpZ = new System.Windows.Forms.NumericUpDown();
            this.NUDTpY = new System.Windows.Forms.NumericUpDown();
            this.NUDTpX = new System.Windows.Forms.NumericUpDown();
            this.CmbClimateType = new System.Windows.Forms.ComboBox();
            this.LblClimateType = new System.Windows.Forms.Label();
            this.LblSceneDescription = new System.Windows.Forms.Label();
            this.ListScenes = new System.Windows.Forms.ListBox();
            this.LblTp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpX)).BeginInit();
            this.SuspendLayout();
            // 
            // RbListDungeons
            // 
            resources.ApplyResources(this.RbListDungeons, "RbListDungeons");
            this.RbListDungeons.Name = "RbListDungeons";
            this.RbListDungeons.UseVisualStyleBackColor = true;
            this.RbListDungeons.CheckedChanged += new System.EventHandler(this.RbListDungeons_CheckedChanged);
            // 
            // RbListScene
            // 
            resources.ApplyResources(this.RbListScene, "RbListScene");
            this.RbListScene.Checked = true;
            this.RbListScene.Name = "RbListScene";
            this.RbListScene.TabStop = true;
            this.RbListScene.UseVisualStyleBackColor = true;
            this.RbListScene.CheckedChanged += new System.EventHandler(this.RbListScene_CheckedChanged);
            // 
            // TxtSceneFilter
            // 
            resources.ApplyResources(this.TxtSceneFilter, "TxtSceneFilter");
            this.TxtSceneFilter.Name = "TxtSceneFilter";
            this.TxtSceneFilter.TextChanged += new System.EventHandler(this.TxtSceneFilter_TextChanged);
            // 
            // ChkIncludeSceneId
            // 
            resources.ApplyResources(this.ChkIncludeSceneId, "ChkIncludeSceneId");
            this.ChkIncludeSceneId.Name = "ChkIncludeSceneId";
            this.ChkIncludeSceneId.UseVisualStyleBackColor = true;
            // 
            // LblTpZ
            // 
            resources.ApplyResources(this.LblTpZ, "LblTpZ");
            this.LblTpZ.Name = "LblTpZ";
            // 
            // LblTpY
            // 
            resources.ApplyResources(this.LblTpY, "LblTpY");
            this.LblTpY.Name = "LblTpY";
            // 
            // BtnTeleport
            // 
            resources.ApplyResources(this.BtnTeleport, "BtnTeleport");
            this.BtnTeleport.Name = "BtnTeleport";
            this.BtnTeleport.UseVisualStyleBackColor = true;
            this.BtnTeleport.Click += new System.EventHandler(this.BtnTeleport_Click);
            // 
            // LblTpX
            // 
            resources.ApplyResources(this.LblTpX, "LblTpX");
            this.LblTpX.Name = "LblTpX";
            // 
            // NUDTpZ
            // 
            resources.ApplyResources(this.NUDTpZ, "NUDTpZ");
            this.NUDTpZ.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDTpZ.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDTpZ.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDTpZ.Name = "NUDTpZ";
            // 
            // NUDTpY
            // 
            resources.ApplyResources(this.NUDTpY, "NUDTpY");
            this.NUDTpY.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDTpY.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDTpY.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDTpY.Name = "NUDTpY";
            this.NUDTpY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // NUDTpX
            // 
            resources.ApplyResources(this.NUDTpX, "NUDTpX");
            this.NUDTpX.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUDTpX.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NUDTpX.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.NUDTpX.Name = "NUDTpX";
            // 
            // CmbClimateType
            // 
            this.CmbClimateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClimateType.FormattingEnabled = true;
            resources.ApplyResources(this.CmbClimateType, "CmbClimateType");
            this.CmbClimateType.Name = "CmbClimateType";
            this.CmbClimateType.SelectedIndexChanged += new System.EventHandler(this.CmbClimateType_SelectedIndexChanged);
            // 
            // LblClimateType
            // 
            resources.ApplyResources(this.LblClimateType, "LblClimateType");
            this.LblClimateType.Name = "LblClimateType";
            // 
            // LblSceneDescription
            // 
            resources.ApplyResources(this.LblSceneDescription, "LblSceneDescription");
            this.LblSceneDescription.Name = "LblSceneDescription";
            // 
            // ListScenes
            // 
            resources.ApplyResources(this.ListScenes, "ListScenes");
            this.ListScenes.FormattingEnabled = true;
            this.ListScenes.Name = "ListScenes";
            this.ListScenes.SelectedIndexChanged += new System.EventHandler(this.ListScenes_SelectedIndexChanged);
            // 
            // LblTp
            // 
            resources.ApplyResources(this.LblTp, "LblTp");
            this.LblTp.Name = "LblTp";
            // 
            // PageScene
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RbListDungeons);
            this.Controls.Add(this.RbListScene);
            this.Controls.Add(this.TxtSceneFilter);
            this.Controls.Add(this.ChkIncludeSceneId);
            this.Controls.Add(this.LblTpZ);
            this.Controls.Add(this.LblTpY);
            this.Controls.Add(this.BtnTeleport);
            this.Controls.Add(this.LblTpX);
            this.Controls.Add(this.NUDTpZ);
            this.Controls.Add(this.NUDTpY);
            this.Controls.Add(this.NUDTpX);
            this.Controls.Add(this.CmbClimateType);
            this.Controls.Add(this.LblClimateType);
            this.Controls.Add(this.LblSceneDescription);
            this.Controls.Add(this.ListScenes);
            this.Controls.Add(this.LblTp);
            this.Name = "PageScene";
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTpX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbListDungeons;
        private System.Windows.Forms.RadioButton RbListScene;
        private System.Windows.Forms.TextBox TxtSceneFilter;
        private System.Windows.Forms.CheckBox ChkIncludeSceneId;
        private System.Windows.Forms.Label LblTpZ;
        private System.Windows.Forms.Label LblTpY;
        private System.Windows.Forms.Button BtnTeleport;
        private System.Windows.Forms.Label LblTpX;
        private System.Windows.Forms.NumericUpDown NUDTpZ;
        private System.Windows.Forms.NumericUpDown NUDTpY;
        private System.Windows.Forms.NumericUpDown NUDTpX;
        private System.Windows.Forms.ComboBox CmbClimateType;
        private System.Windows.Forms.Label LblClimateType;
        private System.Windows.Forms.Label LblSceneDescription;
        private System.Windows.Forms.ListBox ListScenes;
        private System.Windows.Forms.Label LblTp;
    }
}
