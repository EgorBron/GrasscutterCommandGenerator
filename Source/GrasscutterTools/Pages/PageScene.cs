﻿/**
 *  Grasscutter Tools
 *  Copyright (C) 2022 jie65535
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published
 *  by the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *
 **/

using System;

using GrasscutterTools.Game;
using GrasscutterTools.Properties;
using GrasscutterTools.Utils;

namespace GrasscutterTools.Pages
{
    internal partial class PageScene : BasePage
    {
        public PageScene()
        {
            InitializeComponent();
        }

        private string[] _scenes;

        private string[] Scenes
        {
            get => _scenes;
            set
            {
                if (_scenes == value)
                    return;
                _scenes = value;
                ListScenes.Items.Clear();
                ListScenes.Items.AddRange(value);
            }
        }

        /// <summary>
        /// 初始化场景列表
        /// </summary>
        public override void OnLoad()
        {
            Scenes = GameData.Scenes.Lines;
            CmbClimateType.Items.Clear();
            CmbClimateType.Items.AddRange(Resources.ClimateType.Split(','));
        }

        /// <summary>
        /// 选中场景时触发
        /// </summary>
        private void RbListScene_CheckedChanged(object sender, EventArgs e)
        {
            if (RbListScene.Checked)
                Scenes = GameData.Scenes.Lines;
        }

        /// <summary>
        /// 选中秘境时触发
        /// </summary>
        private void RbListDungeons_CheckedChanged(object sender, EventArgs e)
        {
            if (RbListDungeons.Checked)
                Scenes = GameData.Dungeons.Lines;
        }

        /// <summary>
        /// 场景列表过滤器输入项改变时触发
        /// </summary>
        private void TxtSceneFilter_TextChanged(object sender, EventArgs e)
        {
            UIUtil.ListBoxFilter(ListScenes, Scenes, TxtSceneFilter.Text);
        }

        /// <summary>
        /// 场景列表选中项改变时触发
        /// </summary>
        private void ListScenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListScenes.SelectedIndex < 0)
            {
                ChkIncludeSceneId.Enabled = false;
                return;
            }
            ChkIncludeSceneId.Enabled = true;

            // 可以直接弃用 scene 命令
            var name = ListScenes.SelectedItem as string;
            var id = ItemMap.ToId(name);
            if (RbListScene.Checked)
            {
                if (CommandVersion.Check(CommandVersion.V1_2_2))
                {
                    SetCommand("/scene", id.ToString());
                }
                else
                {
                    SetCommand("/tp ~ ~ ~", id.ToString());
                }
            }
            else if (RbListDungeons.Checked)
            {
                SetCommand("/dungeon", id.ToString());
            }
        }

        /// <summary>
        /// 气候类型列表
        /// </summary>
        private static readonly string[] climateTypes = { "none", "sunny", "cloudy", "rain", "thunderstorm", "snow", "mist" };

        /// <summary>
        /// 气候类型下拉框选中项改变时触发
        /// </summary>
        private void CmbClimateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbClimateType.SelectedIndex < 0)
                return;
            if (CommandVersion.Check(CommandVersion.V1_2_2))
                SetCommand("/weather", CmbClimateType.SelectedIndex < climateTypes.Length ? climateTypes[CmbClimateType.SelectedIndex] : "none");
            else
                SetCommand("/weather", $"0 {CmbClimateType.SelectedIndex}");
        }

        /// <summary>
        /// 点击传送按钮时触发
        /// </summary>
        private void BtnTeleport_Click(object sender, EventArgs e)
        {
            string args = $"{NUDTpX.Value} {NUDTpY.Value} {NUDTpZ.Value}";
            if (ChkIncludeSceneId.Checked && RbListScene.Checked && ListScenes.SelectedIndex != -1)
                args += $" {GameData.Scenes.Ids[ListScenes.SelectedIndex]}";
            SetCommand("/tp", args);
        }
    }
}