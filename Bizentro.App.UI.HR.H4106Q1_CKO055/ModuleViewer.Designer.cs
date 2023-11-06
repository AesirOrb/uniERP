﻿using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace Bizentro.App.UI.HR.H4106Q1_CKO055
{
    public class ModuleInitializer : Bizentro.AppFramework.UI.Module.Module
    {
        [InjectionConstructor]
        public ModuleInitializer([ServiceDependency] WorkItem rootWorkItem) : base(rootWorkItem) { }

        protected override void RegisterModureViewer()
        {
            base.AddModule<ModuleViewer>();
        }
    }

    partial class ModuleViewer
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
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance activeBorder = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance control = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance controlLight = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance controlLightLight = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance grayText = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance silver = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance window = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance window1 = new Infragistics.Win.Appearance();

            this.uniTBL_OuterMost = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainReference = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainCondition = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainData = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainBatch = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblYearMonth = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.dtYearMonth = new Bizentro.AppFramework.UI.Controls.uniDateTime(this.components);
            this.lblDeptCd = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.popDeptCd = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.txtInternalCd = new Bizentro.AppFramework.UI.Controls.uniTextBox(this.components);
            this.lblEmpNo = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.popEmpNo = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.lblBizAreaCd = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.cboBizAreaCd = new Bizentro.AppFramework.UI.Controls.uniCombo(this.components);
            this.uniTableLayoutPanel1 = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new Bizentro.AppFramework.UI.Controls.uniGrid(this.components);

            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainData.SuspendLayout();
            this.uniTBL_MainCondition.SuspendLayout();
            this.uniTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.uniGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dtYearMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.txtInternalCd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.cboBizAreaCd).BeginInit();
            base.SuspendLayout();

            this.uniLabel_Path.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.PathInfo;
            this.uniLabel_Path.Size = new System.Drawing.Size(500, 14);

            this.uniTBL_OuterMost.AutoFit = false;
            this.uniTBL_OuterMost.AutoFitColumnCount = 4;
            this.uniTBL_OuterMost.AutoFitRowCount = 4;
            this.uniTBL_OuterMost.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_OuterMost.ColumnCount = 1;
            this.uniTBL_OuterMost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainReference, 0, 0);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainCondition, 0, 2);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainData, 0, 4);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainBatch, 0, 6);
            this.uniTBL_OuterMost.DefaultRowSize = 23;
            this.uniTBL_OuterMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_OuterMost.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_OuterMost.Location = new System.Drawing.Point(1, 10);
            this.uniTBL_OuterMost.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_OuterMost.Name = "uniTBL_OuterMost";
            this.uniTBL_OuterMost.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_OuterMost.RowCount = 8;
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6f));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6f));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6f));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6f));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6f));
            this.uniTBL_OuterMost.Size = new System.Drawing.Size(851, 566);
            this.uniTBL_OuterMost.TabIndex = 0;
            this.uniTBL_OuterMost.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_OuterMost.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.uniTBL_MainReference.AutoFit = false;
            this.uniTBL_MainReference.AutoFitColumnCount = 4;
            this.uniTBL_MainReference.AutoFitRowCount = 4;
            this.uniTBL_MainReference.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainReference.ColumnCount = 3;
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainReference.DefaultRowSize = 23;
            this.uniTBL_MainReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainReference.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainReference.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainReference.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainReference.Name = "uniTBL_MainReference";
            this.uniTBL_MainReference.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainReference.RowCount = 1;
            this.uniTBL_MainReference.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainReference.Size = new System.Drawing.Size(851, 21);
            this.uniTBL_MainReference.TabIndex = 2;
            this.uniTBL_MainReference.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainReference.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 2;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(228, 236, 248);
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40f));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40f));
            this.uniTBL_MainCondition.Controls.Add(this.lblYearMonth, 0, 0);
            this.uniTBL_MainCondition.Controls.Add(this.dtYearMonth, 1, 0);
            this.uniTBL_MainCondition.Controls.Add(this.lblBizAreaCd, 2, 0);
            this.uniTBL_MainCondition.Controls.Add(this.cboBizAreaCd, 3, 0);
            this.uniTBL_MainCondition.Controls.Add(this.lblDeptCd, 0, 1);
            this.uniTBL_MainCondition.Controls.Add(this.uniTableLayoutPanel1, 1, 1);
            this.uniTBL_MainCondition.Controls.Add(this.lblEmpNo, 2, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popEmpNo, 3, 1);
            this.uniTBL_MainCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainCondition.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainCondition.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainCondition.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.uniTBL_MainCondition.Name = "uniTBL_MainCondition";
            this.uniTBL_MainCondition.Padding = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainCondition.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Condition;
            this.uniTBL_MainCondition.RowCount = 2;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(851, 46);
            this.uniTBL_MainCondition.TabIndex = 1;
            this.uniTBL_MainCondition.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainData.ColumnCount = 1;
            this.uniTBL_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainData.Controls.Add(this.uniGrid1, 0, 0);
            this.uniTBL_MainData.DefaultRowSize = 23;
            this.uniTBL_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainData.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 120);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainData.Size = new System.Drawing.Size(851, 414);
            this.uniTBL_MainData.TabIndex = 0;
            this.uniTBL_MainData.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainData.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.uniTBL_MainBatch.AutoFit = false;
            this.uniTBL_MainBatch.AutoFitColumnCount = 4;
            this.uniTBL_MainBatch.AutoFitRowCount = 4;
            this.uniTBL_MainBatch.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainBatch.ColumnCount = 5;
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.uniTBL_MainBatch.DefaultRowSize = 23;
            this.uniTBL_MainBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainBatch.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainBatch.Location = new System.Drawing.Point(0, 537);
            this.uniTBL_MainBatch.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainBatch.Name = "uniTBL_MainBatch";
            this.uniTBL_MainBatch.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainBatch.RowCount = 1;
            this.uniTBL_MainBatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTBL_MainBatch.Size = new System.Drawing.Size(851, 28);
            this.uniTBL_MainBatch.TabIndex = 3;
            this.uniTBL_MainBatch.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainBatch.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.uniGrid1.AddEmptyRow = false;
            this.uniGrid1.DirectPaste = false;
            appearance.BackColor = System.Drawing.SystemColors.Window;
            appearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            activeBorder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            activeBorder.BackColor2 = System.Drawing.SystemColors.ControlDark;
            activeBorder.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            activeBorder.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = activeBorder;
            grayText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = grayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            controlLightLight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            controlLightLight.BackColor2 = System.Drawing.SystemColors.Control;
            controlLightLight.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            controlLightLight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = controlLightLight;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            window.BackColor = System.Drawing.SystemColors.Window;
            window.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = window;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance1;
            silver.BorderColor = System.Drawing.Color.Silver;
            silver.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = silver;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            control.BackColor = System.Drawing.SystemColors.Control;
            control.BackColor2 = System.Drawing.SystemColors.ControlDark;
            control.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            control.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            control.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = control;
            appearance2.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance2;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            window1.BackColor = System.Drawing.SystemColors.Window;
            window1.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = window1;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            controlLight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = controlLight;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridInfoContextMenu = true;
            this.uniGrid1.ExceptInExcel = false;
            this.uniGrid1.Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.uniGrid1.gComNumDec = Bizentro.AppFramework.UI.Variables.enumDef.ComDec.Decimal;
            this.uniGrid1.GridStyle = Bizentro.AppFramework.UI.Variables.enumDef.GridStyle.Master;
            this.uniGrid1.Location = new System.Drawing.Point(0, 0);
            this.uniGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.uniGrid1.Name = "uniGrid1";
            this.uniGrid1.OutlookGroupBy = Bizentro.AppFramework.UI.Variables.enumDef.IsOutlookGroupBy.No;
            this.uniGrid1.PopupDeleteMenuVisible = true;
            this.uniGrid1.PopupInsertMenuVisible = true;
            this.uniGrid1.PopupUndoMenuVisible = true;
            this.uniGrid1.Search = Bizentro.AppFramework.UI.Variables.enumDef.IsSearch.Yes;
            this.uniGrid1.ShowHeaderCheck = true;
            this.uniGrid1.Size = new System.Drawing.Size(851, 414);
            this.uniGrid1.StyleSetName = "uniGrid_Query";
            this.uniGrid1.TabIndex = 0;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;

            appearance3.TextHAlignAsString = "Left";
            appearance3.TextVAlignAsString = "Middle";
            appearance4.TextHAlignAsString = "Center";
            appearance4.TextVAlignAsString = "Middle";

            this.lblYearMonth.Appearance = appearance3;
            this.lblYearMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYearMonth.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblYearMonth.Location = new System.Drawing.Point(0, 0);
            this.lblYearMonth.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblYearMonth.Name = "lblYearMonth";
            this.lblYearMonth.Size = new System.Drawing.Size(80, 21);
            this.lblYearMonth.StyleSetName = "Default";
            this.lblYearMonth.TabIndex = 0;
            this.lblYearMonth.Text = "조회년월";
            this.lblYearMonth.UseMnemonic = false;

            this.dtYearMonth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtYearMonth.Appearance = appearance4;
            this.dtYearMonth.DateTime = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            this.dtYearMonth.DateType = Bizentro.AppFramework.UI.Variables.enumDef.DateType.YYYY_MM;
            this.dtYearMonth.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never;
            this.dtYearMonth.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.NotNull;
            this.dtYearMonth.Location = new System.Drawing.Point(0, 0);
            this.dtYearMonth.LockedField = false;
            this.dtYearMonth.Margin = new System.Windows.Forms.Padding(0);
            this.dtYearMonth.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtYearMonth.Name = "dtYearMonth";
            this.dtYearMonth.QueryIfEnterKeyPressed = true;
            this.dtYearMonth.RequiredField = false;
            this.dtYearMonth.Size = new System.Drawing.Size(80, 21);
            this.dtYearMonth.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.dtYearMonth.Style = Bizentro.AppFramework.UI.Controls.DateTime_Style.YYYYMM;
            this.dtYearMonth.StyleSetName = "Default";
            this.dtYearMonth.TabIndex = 1;
            this.dtYearMonth.uniALT = "Year & Month";
            this.dtYearMonth.uniValue = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);
            this.dtYearMonth.Value = new System.DateTime(2015, 4, 1, 0, 0, 0, 0);

            this.lblBizAreaCd.Appearance = appearance3;
            this.lblBizAreaCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBizAreaCd.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblBizAreaCd.Location = new System.Drawing.Point(0, 0);
            this.lblBizAreaCd.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblBizAreaCd.Name = "lblBizAreaCd";
            this.lblBizAreaCd.Size = new System.Drawing.Size(80, 21);
            this.lblBizAreaCd.StyleSetName = "Default";
            this.lblBizAreaCd.TabIndex = 10;
            this.lblBizAreaCd.Text = "사업장";
            this.lblBizAreaCd.UseMnemonic = false;

            this.cboBizAreaCd.AddEmptyRow = true;
            this.cboBizAreaCd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboBizAreaCd.ComboFrom = "";
            this.cboBizAreaCd.ComboMajorCd = "";
            this.cboBizAreaCd.ComboSelect = "";
            this.cboBizAreaCd.ComboType = Bizentro.AppFramework.UI.Variables.enumDef.ComboType.MajorCode;
            this.cboBizAreaCd.ComboWhere = "";
            this.cboBizAreaCd.DropDownListWidth = -1;
            this.cboBizAreaCd.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboBizAreaCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.cboBizAreaCd.Location = new System.Drawing.Point(0, 0);
            this.cboBizAreaCd.LockedField = false;
            this.cboBizAreaCd.Margin = new System.Windows.Forms.Padding(0);
            this.cboBizAreaCd.Name = "cboBizAreaCd";
            this.cboBizAreaCd.RequiredField = false;
            this.cboBizAreaCd.Size = new System.Drawing.Size(120, 21);
            this.cboBizAreaCd.Style = Bizentro.AppFramework.UI.Controls.Combo_Style.Default;
            this.cboBizAreaCd.StyleSetName = "Default";
            this.cboBizAreaCd.TabIndex = 11;
            this.cboBizAreaCd.uniALT = "Business Area";

            this.lblDeptCd.Appearance = appearance3;
            this.lblDeptCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeptCd.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblDeptCd.Location = new System.Drawing.Point(0, 0);
            this.lblDeptCd.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblDeptCd.Name = "lblDeptCd";
            this.lblDeptCd.Size = new System.Drawing.Size(80, 21);
            this.lblDeptCd.StyleSetName = "Default";
            this.lblDeptCd.TabIndex = 4;
            this.lblDeptCd.Text = "부서";
            this.lblDeptCd.UseMnemonic = false;

            this.uniTableLayoutPanel1.AutoFit = false;
            this.uniTableLayoutPanel1.AutoFitColumnCount = 4;
            this.uniTableLayoutPanel1.AutoFitRowCount = 4;
            this.uniTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uniTableLayoutPanel1.ColumnCount = 2;
            this.uniTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274f));
            this.uniTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTableLayoutPanel1.Controls.Add(this.popDeptCd, 0, 0);
            this.uniTableLayoutPanel1.Controls.Add(this.txtInternalCd, 1, 0);
            this.uniTableLayoutPanel1.DefaultRowSize = 23;
            this.uniTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTableLayoutPanel1.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uniTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uniTableLayoutPanel1.Name = "uniTableLayoutPanel1";
            this.uniTableLayoutPanel1.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTableLayoutPanel1.RowCount = 1;
            this.uniTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.uniTableLayoutPanel1.Size = new System.Drawing.Size(300, 21);
            this.uniTableLayoutPanel1.TabIndex = 5;
            this.uniTableLayoutPanel1.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTableLayoutPanel1.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;

            this.popDeptCd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.popDeptCd.AutoPopupCodeParameter = null;
            this.popDeptCd.AutoPopupID = null;
            this.popDeptCd.AutoPopupNameParameter = null;
            this.popDeptCd.CodeMaxLength = 10;
            this.popDeptCd.CodeName = "";
            this.popDeptCd.CodeSize = 100;
            this.popDeptCd.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popDeptCd.CodeTextBoxName = null;
            this.popDeptCd.CodeValue = "";
            this.popDeptCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popDeptCd.Location = new System.Drawing.Point(0, 0);
            this.popDeptCd.LockedField = false;
            this.popDeptCd.Margin = new System.Windows.Forms.Padding(0);
            this.popDeptCd.Name = "popDeptCd";
            this.popDeptCd.NameDisplay = true;
            this.popDeptCd.NameId = null;
            this.popDeptCd.NameMaxLength = 50;
            this.popDeptCd.NamePopup = false;
            this.popDeptCd.NameSize = 200;
            this.popDeptCd.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.CodeName;
            this.popDeptCd.Parameter = null;
            this.popDeptCd.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popDeptCd.PopupId = null;
            this.popDeptCd.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popDeptCd.QueryIfEnterKeyPressed = true;
            this.popDeptCd.RequiredField = false;
            this.popDeptCd.Size = new System.Drawing.Size(300, 21);
            this.popDeptCd.TabIndex = 0;
            this.popDeptCd.uniALT = "Department";
            this.popDeptCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popDeptCd.UseDynamicFormat = false;
            this.popDeptCd.ValueTextBoxName = null;
            this.popDeptCd.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.PopDeptCd_BeforePopupOpen);
            this.popDeptCd.OnExitEditCode += new Bizentro.AppFramework.UI.Controls.Popup.OnExitEditCodeEventHandler(this.PopDeptCd_OnExitEditCode);
            this.popDeptCd.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.PopDeptCd_AfterPopupClosed);
            this.txtInternalCd.Anchor = System.Windows.Forms.AnchorStyles.Left;

            this.txtInternalCd.Appearance = appearance3;
            this.txtInternalCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.txtInternalCd.Location = new System.Drawing.Point(0, 0);
            this.txtInternalCd.LockedField = false;
            this.txtInternalCd.Margin = new System.Windows.Forms.Padding(0);
            this.txtInternalCd.Name = "txtInternalCd";
            this.txtInternalCd.QueryIfEnterKeyPressed = true;
            this.txtInternalCd.RequiredField = false;
            this.txtInternalCd.Size = new System.Drawing.Size(200, 21);
            this.txtInternalCd.Style = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.txtInternalCd.StyleSetName = "Default";
            this.txtInternalCd.TabIndex = 1;
            this.txtInternalCd.TabStop = false;
            this.txtInternalCd.uniALT = null;
            this.txtInternalCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInternalCd.UseDynamicFormat = false;
            this.txtInternalCd.Visible = false;

            this.lblEmpNo.Appearance = appearance3;
            this.lblEmpNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpNo.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblEmpNo.Location = new System.Drawing.Point(0, 0);
            this.lblEmpNo.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(80, 21);
            this.lblEmpNo.StyleSetName = "Default";
            this.lblEmpNo.TabIndex = 6;
            this.lblEmpNo.Text = "사번";
            this.lblEmpNo.UseMnemonic = false;

            this.popEmpNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.popEmpNo.AutoPopupCodeParameter = null;
            this.popEmpNo.AutoPopupID = null;
            this.popEmpNo.AutoPopupNameParameter = null;
            this.popEmpNo.CodeMaxLength = 9;
            this.popEmpNo.CodeName = "";
            this.popEmpNo.CodeSize = 100;
            this.popEmpNo.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popEmpNo.CodeTextBoxName = null;
            this.popEmpNo.CodeValue = "";
            this.popEmpNo.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popEmpNo.Location = new System.Drawing.Point(0, 0);
            this.popEmpNo.LockedField = false;
            this.popEmpNo.Margin = new System.Windows.Forms.Padding(0);
            this.popEmpNo.Name = "popEmpNo";
            this.popEmpNo.NameDisplay = true;
            this.popEmpNo.NameId = null;
            this.popEmpNo.NameMaxLength = 50;
            this.popEmpNo.NamePopup = false;
            this.popEmpNo.NameSize = 200;
            this.popEmpNo.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.CodeName;
            this.popEmpNo.Parameter = null;
            this.popEmpNo.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popEmpNo.PopupId = null;
            this.popEmpNo.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popEmpNo.QueryIfEnterKeyPressed = true;
            this.popEmpNo.RequiredField = false;
            this.popEmpNo.Size = new System.Drawing.Size(300, 21);
            this.popEmpNo.TabIndex = 7;
            this.popEmpNo.uniALT = "Employee ID";
            this.popEmpNo.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popEmpNo.UseDynamicFormat = false;
            this.popEmpNo.ValueTextBoxName = null;
            this.popEmpNo.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.PopEmpNo_BeforePopupOpen);
            this.popEmpNo.OnExitEditCode += new Bizentro.AppFramework.UI.Controls.Popup.OnExitEditCodeEventHandler(this.PopEmpNo_OnExitEditCode);
            this.popEmpNo.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.PopEmpNo_AfterPopupClosed);

            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            base.Controls.Add(this.uniTBL_OuterMost);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            base.Name = "ModuleViewer";
            base.Size = new System.Drawing.Size(862, 586);
            base.Controls.SetChildIndex(this.uniTBL_OuterMost, 0);
            base.Controls.SetChildIndex(this.uniLabel_Path, 0);
            this.uniTBL_OuterMost.ResumeLayout(false);
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.uniGrid1).EndInit();
            this.uniTBL_MainCondition.ResumeLayout(false);
            this.uniTBL_MainCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dtYearMonth).EndInit();
            this.uniTableLayoutPanel1.ResumeLayout(false);
            this.uniTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.txtInternalCd).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.cboBizAreaCd).EndInit();
            base.ResumeLayout(false);
        }

        #endregion

        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_OuterMost;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainData;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainCondition;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainReference;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainBatch;
        private Bizentro.AppFramework.UI.Controls.uniGrid uniGrid1;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblYearMonth;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblDeptCd;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblEmpNo;
        private Bizentro.AppFramework.UI.Controls.uniLabel lblBizAreaCd;
        private Bizentro.AppFramework.UI.Controls.uniDateTime dtYearMonth;
        private Bizentro.AppFramework.UI.Controls.uniCombo cboBizAreaCd;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTableLayoutPanel1;
        private Bizentro.AppFramework.UI.Controls.uniOpenPopup popDeptCd;
        private Bizentro.AppFramework.UI.Controls.uniOpenPopup popEmpNo;
        private Bizentro.AppFramework.UI.Controls.uniTextBox txtInternalCd;
    }
}
