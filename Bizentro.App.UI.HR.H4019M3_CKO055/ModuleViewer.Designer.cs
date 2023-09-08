using Bizentro.AppFramework.UI.Module;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace Bizentro.App.UI.HR.H4019M3_CKO055
{

    public class ModuleInitializer : Bizentro.AppFramework.UI.Module.Module
    {
        [InjectionConstructor]
        public ModuleInitializer([ServiceDependency] WorkItem rootWorkItem)
            : base(rootWorkItem) { }

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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            this.uniTBL_OuterMost = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainData = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new Bizentro.AppFramework.UI.Controls.uniGrid(this.components);
            this.uniTBL_MainCondition = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniLabel1 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel2 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel3 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel4 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel5 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel6 = new Bizentro.AppFramework.UI.Controls.uniLabel(this.components);
            this.dtConYear = new Bizentro.AppFramework.UI.Controls.uniDateTime(this.components);
            this.cboConBizAreaCd = new Bizentro.AppFramework.UI.Controls.uniCombo(this.components);
            this.cboConPayCd = new Bizentro.AppFramework.UI.Controls.uniCombo(this.components);
            this.popConDeptCd = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.popConEmpNo = new Bizentro.AppFramework.UI.Controls.uniOpenPopup();
            this.chkConRetireFlag = new Bizentro.AppFramework.UI.Controls.uniCheckBox(this.components);
            this.uniTBL_MainReference = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainBatch = new Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).BeginInit();
            this.uniTBL_MainCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboConBizAreaCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboConPayCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConRetireFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // uniLabel_Path
            // 
            this.uniLabel_Path.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.PathInfo;
            this.uniLabel_Path.Size = new System.Drawing.Size(500, 14);
            // 
            // uniTBL_OuterMost
            // 
            this.uniTBL_OuterMost.AutoFit = false;
            this.uniTBL_OuterMost.AutoFitColumnCount = 4;
            this.uniTBL_OuterMost.AutoFitRowCount = 4;
            this.uniTBL_OuterMost.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_OuterMost.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_OuterMost.ColumnCount = 1;
            this.uniTBL_OuterMost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainData, 0, 4);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainCondition, 0, 2);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainReference, 0, 0);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainBatch, 0, 6);
            this.uniTBL_OuterMost.DefaultRowSize = 23;
            this.uniTBL_OuterMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_OuterMost.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_OuterMost.HEIGHT_TYPE_00_REFERENCE = 21F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01 = 6F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01_CONDITION = 38F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03_BOTTOM = 28F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_04 = 1F;
            this.uniTBL_OuterMost.Location = new System.Drawing.Point(1, 10);
            this.uniTBL_OuterMost.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_OuterMost.Name = "uniTBL_OuterMost";
            this.uniTBL_OuterMost.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_OuterMost.RowCount = 8;
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.uniTBL_OuterMost.Size = new System.Drawing.Size(842, 575);
            this.uniTBL_OuterMost.SizeTD5 = 14F;
            this.uniTBL_OuterMost.SizeTD6 = 36F;
            this.uniTBL_OuterMost.TabIndex = 0;
            this.uniTBL_OuterMost.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainData
            // 
            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainData.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainData.ColumnCount = 1;
            this.uniTBL_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Controls.Add(this.uniGrid1, 0, 0);
            this.uniTBL_MainData.DefaultRowSize = 23;
            this.uniTBL_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainData.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainData.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainData.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainData.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainData.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainData.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainData.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainData.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainData.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 113);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Size = new System.Drawing.Size(842, 430);
            this.uniTBL_MainData.SizeTD5 = 14F;
            this.uniTBL_MainData.SizeTD6 = 36F;
            this.uniTBL_MainData.TabIndex = 0;
            this.uniTBL_MainData.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniGrid1
            // 
            this.uniGrid1.AddEmptyRow = false;
            this.uniGrid1.DirectPaste = false;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance1;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance7.BorderColor = System.Drawing.Color.Silver;
            appearance7.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = appearance7;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance8.BackColor = System.Drawing.SystemColors.Control;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance8.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance8.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance8;
            appearance9.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance9;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = appearance10;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance11;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridFilterMenu = false;
            this.uniGrid1.EnableGridInfoContextMenu = true;
            this.uniGrid1.ExceptInExcel = false;
            this.uniGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.uniGrid1.Size = new System.Drawing.Size(842, 430);
            this.uniGrid1.StyleSetName = "uniGrid_Query";
            this.uniGrid1.TabIndex = 0;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;
            this.uniGrid1.AfterExitEditMode += new System.EventHandler(this.uniGrid1_AfterExitEditMode_1);
            // 
            // uniTBL_MainCondition
            // 
            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 4;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.uniTBL_MainCondition.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel1, 0, 0);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel2, 0, 1);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel3, 0, 2);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel4, 2, 2);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel5, 2, 1);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel6, 2, 0);
            this.uniTBL_MainCondition.Controls.Add(this.dtConYear, 1, 0);
            this.uniTBL_MainCondition.Controls.Add(this.cboConBizAreaCd, 3, 0);
            this.uniTBL_MainCondition.Controls.Add(this.cboConPayCd, 1, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popConDeptCd, 3, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popConEmpNo, 1, 2);
            this.uniTBL_MainCondition.Controls.Add(this.chkConRetireFlag, 3, 2);
            this.uniTBL_MainCondition.DefaultRowSize = 23;
            this.uniTBL_MainCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainCondition.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainCondition.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainCondition.Location = new System.Drawing.Point(0, 27);
            this.uniTBL_MainCondition.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainCondition.Name = "uniTBL_MainCondition";
            this.uniTBL_MainCondition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.uniTBL_MainCondition.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Condition;
            this.uniTBL_MainCondition.RowCount = 4;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(842, 77);
            this.uniTBL_MainCondition.SizeTD5 = 14F;
            this.uniTBL_MainCondition.SizeTD6 = 36F;
            this.uniTBL_MainCondition.TabIndex = 1;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniLabel1
            // 
            appearance12.TextHAlignAsString = "Left";
            appearance12.TextVAlignAsString = "Middle";
            this.uniLabel1.Appearance = appearance12;
            this.uniLabel1.AutoPopupID = null;
            this.uniLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel1.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel1.Location = new System.Drawing.Point(15, 6);
            this.uniLabel1.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel1.Name = "uniLabel1";
            this.uniLabel1.Size = new System.Drawing.Size(102, 22);
            this.uniLabel1.StyleSetName = "Default";
            this.uniLabel1.TabIndex = 0;
            this.uniLabel1.Text = "연차년도";
            this.uniLabel1.UseMnemonic = false;
            // 
            // uniLabel2
            // 
            appearance13.TextHAlignAsString = "Left";
            appearance13.TextVAlignAsString = "Middle";
            this.uniLabel2.Appearance = appearance13;
            this.uniLabel2.AutoPopupID = null;
            this.uniLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel2.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel2.Location = new System.Drawing.Point(15, 29);
            this.uniLabel2.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel2.Name = "uniLabel2";
            this.uniLabel2.Size = new System.Drawing.Size(102, 22);
            this.uniLabel2.StyleSetName = "Default";
            this.uniLabel2.TabIndex = 0;
            this.uniLabel2.Text = "급여구분";
            this.uniLabel2.UseMnemonic = false;
            // 
            // uniLabel3
            // 
            appearance14.TextHAlignAsString = "Left";
            appearance14.TextVAlignAsString = "Middle";
            this.uniLabel3.Appearance = appearance14;
            this.uniLabel3.AutoPopupID = null;
            this.uniLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel3.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel3.Location = new System.Drawing.Point(15, 52);
            this.uniLabel3.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel3.Name = "uniLabel3";
            this.uniLabel3.Size = new System.Drawing.Size(102, 22);
            this.uniLabel3.StyleSetName = "Default";
            this.uniLabel3.TabIndex = 0;
            this.uniLabel3.Text = "사번";
            this.uniLabel3.UseMnemonic = false;
            // 
            // uniLabel4
            // 
            appearance15.TextHAlignAsString = "Left";
            appearance15.TextVAlignAsString = "Middle";
            this.uniLabel4.Appearance = appearance15;
            this.uniLabel4.AutoPopupID = null;
            this.uniLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel4.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel4.Location = new System.Drawing.Point(435, 52);
            this.uniLabel4.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel4.Name = "uniLabel4";
            this.uniLabel4.Size = new System.Drawing.Size(102, 22);
            this.uniLabel4.StyleSetName = "Default";
            this.uniLabel4.TabIndex = 0;
            this.uniLabel4.Text = "퇴직자포함";
            this.uniLabel4.UseMnemonic = false;
            // 
            // uniLabel5
            // 
            appearance16.TextHAlignAsString = "Left";
            appearance16.TextVAlignAsString = "Middle";
            this.uniLabel5.Appearance = appearance16;
            this.uniLabel5.AutoPopupID = null;
            this.uniLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel5.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel5.Location = new System.Drawing.Point(435, 29);
            this.uniLabel5.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel5.Name = "uniLabel5";
            this.uniLabel5.Size = new System.Drawing.Size(102, 22);
            this.uniLabel5.StyleSetName = "Default";
            this.uniLabel5.TabIndex = 0;
            this.uniLabel5.Text = "부서";
            this.uniLabel5.UseMnemonic = false;
            // 
            // uniLabel6
            // 
            appearance17.TextHAlignAsString = "Left";
            appearance17.TextVAlignAsString = "Middle";
            this.uniLabel6.Appearance = appearance17;
            this.uniLabel6.AutoPopupID = null;
            this.uniLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel6.LabelType = Bizentro.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel6.Location = new System.Drawing.Point(435, 6);
            this.uniLabel6.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel6.Name = "uniLabel6";
            this.uniLabel6.Size = new System.Drawing.Size(102, 22);
            this.uniLabel6.StyleSetName = "Default";
            this.uniLabel6.TabIndex = 0;
            this.uniLabel6.Text = "사업장";
            this.uniLabel6.UseMnemonic = false;
            // 
            // dtConYear
            // 
            this.dtConYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance18.TextHAlignAsString = "Center";
            this.dtConYear.Appearance = appearance18;
            this.dtConYear.DateTime = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtConYear.DateType = Bizentro.AppFramework.UI.Variables.enumDef.DateType.YYYY;
            this.dtConYear.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never;
            this.dtConYear.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.NotNull;
            this.dtConYear.Location = new System.Drawing.Point(117, 7);
            this.dtConYear.LockedField = false;
            this.dtConYear.Margin = new System.Windows.Forms.Padding(0);
            this.dtConYear.MaxDate = new System.DateTime(9998, 1, 1, 0, 0, 0, 0);
            this.dtConYear.Name = "dtConYear";
            this.dtConYear.QueryIfEnterKeyPressed = true;
            this.dtConYear.RequiredField = false;
            this.dtConYear.Size = new System.Drawing.Size(70, 21);
            this.dtConYear.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always;
            this.dtConYear.Style = Bizentro.AppFramework.UI.Controls.DateTime_Style.YYYY;
            this.dtConYear.StyleSetName = "Default";
            this.dtConYear.TabIndex = 1;
            this.dtConYear.uniALT = "년도";
            this.dtConYear.uniValue = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtConYear.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // cboConBizAreaCd
            // 
            this.cboConBizAreaCd.AddEmptyRow = true;
            this.cboConBizAreaCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConBizAreaCd.ComboFrom = "B_BIZ_AREA";
            this.cboConBizAreaCd.ComboMajorCd = "";
            this.cboConBizAreaCd.ComboSelect = "BIZ_AREA_CD AS CODE, BIZ_AREA_NM AS NAME";
            this.cboConBizAreaCd.ComboType = Bizentro.AppFramework.UI.Variables.enumDef.ComboType.Query;
            this.cboConBizAreaCd.ComboWhere = "";
            this.cboConBizAreaCd.DropDownListWidth = -1;
            this.cboConBizAreaCd.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboConBizAreaCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.cboConBizAreaCd.Location = new System.Drawing.Point(537, 7);
            this.cboConBizAreaCd.LockedField = false;
            this.cboConBizAreaCd.Margin = new System.Windows.Forms.Padding(0);
            this.cboConBizAreaCd.Name = "cboConBizAreaCd";
            this.cboConBizAreaCd.RequiredField = false;
            this.cboConBizAreaCd.Size = new System.Drawing.Size(144, 21);
            this.cboConBizAreaCd.Style = Bizentro.AppFramework.UI.Controls.Combo_Style.Default;
            this.cboConBizAreaCd.StyleSetName = "Default";
            this.cboConBizAreaCd.TabIndex = 2;
            this.cboConBizAreaCd.uniALT = "사업장";
            // 
            // cboConPayCd
            // 
            this.cboConPayCd.AddEmptyRow = true;
            this.cboConPayCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboConPayCd.ComboFrom = "";
            this.cboConPayCd.ComboMajorCd = "H0005";
            this.cboConPayCd.ComboSelect = "";
            this.cboConPayCd.ComboType = Bizentro.AppFramework.UI.Variables.enumDef.ComboType.MajorCode;
            this.cboConPayCd.ComboWhere = "";
            this.cboConPayCd.DropDownListWidth = -1;
            this.cboConPayCd.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.cboConPayCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.cboConPayCd.Location = new System.Drawing.Point(117, 30);
            this.cboConPayCd.LockedField = false;
            this.cboConPayCd.Margin = new System.Windows.Forms.Padding(0);
            this.cboConPayCd.Name = "cboConPayCd";
            this.cboConPayCd.RequiredField = false;
            this.cboConPayCd.Size = new System.Drawing.Size(144, 21);
            this.cboConPayCd.Style = Bizentro.AppFramework.UI.Controls.Combo_Style.Default;
            this.cboConPayCd.StyleSetName = "Default";
            this.cboConPayCd.TabIndex = 2;
            this.cboConPayCd.uniALT = "급여구분";
            // 
            // popConDeptCd
            // 
            this.popConDeptCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popConDeptCd.AutoPopupCodeParameter = null;
            this.popConDeptCd.AutoPopupID = null;
            this.popConDeptCd.AutoPopupNameParameter = null;
            this.popConDeptCd.CodeMaxLength = 100;
            this.popConDeptCd.CodeName = "";
            this.popConDeptCd.CodeSize = 100;
            this.popConDeptCd.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popConDeptCd.CodeTextBoxName = null;
            this.popConDeptCd.CodeValue = "";
            this.popConDeptCd.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popConDeptCd.Location = new System.Drawing.Point(537, 30);
            this.popConDeptCd.LockedField = false;
            this.popConDeptCd.Margin = new System.Windows.Forms.Padding(0);
            this.popConDeptCd.Name = "popConDeptCd";
            this.popConDeptCd.NameDisplay = true;
            this.popConDeptCd.NameId = null;
            this.popConDeptCd.NameMaxLength = 50;
            this.popConDeptCd.NamePopup = false;
            this.popConDeptCd.NameSize = 150;
            this.popConDeptCd.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popConDeptCd.Parameter = null;
            this.popConDeptCd.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popConDeptCd.PopupId = null;
            this.popConDeptCd.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popConDeptCd.QueryIfEnterKeyPressed = true;
            this.popConDeptCd.RequiredField = false;
            this.popConDeptCd.Size = new System.Drawing.Size(271, 21);
            this.popConDeptCd.TabIndex = 3;
            this.popConDeptCd.uniALT = "부서";
            this.popConDeptCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popConDeptCd.UseDynamicFormat = false;
            this.popConDeptCd.ValueTextBoxName = null;
            this.popConDeptCd.OnChange += new System.EventHandler(this.popConDeptCd_OnChange);
            this.popConDeptCd.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popConDeptCd_BeforePopupOpen);
            this.popConDeptCd.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popConDeptCd_AfterPopupClosed);
            // 
            // popConEmpNo
            // 
            this.popConEmpNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popConEmpNo.AutoPopupCodeParameter = null;
            this.popConEmpNo.AutoPopupID = null;
            this.popConEmpNo.AutoPopupNameParameter = null;
            this.popConEmpNo.CodeMaxLength = 100;
            this.popConEmpNo.CodeName = "";
            this.popConEmpNo.CodeSize = 100;
            this.popConEmpNo.CodeStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popConEmpNo.CodeTextBoxName = null;
            this.popConEmpNo.CodeValue = "";
            this.popConEmpNo.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popConEmpNo.Location = new System.Drawing.Point(117, 53);
            this.popConEmpNo.LockedField = false;
            this.popConEmpNo.Margin = new System.Windows.Forms.Padding(0);
            this.popConEmpNo.Name = "popConEmpNo";
            this.popConEmpNo.NameDisplay = true;
            this.popConEmpNo.NameId = null;
            this.popConEmpNo.NameMaxLength = 50;
            this.popConEmpNo.NamePopup = false;
            this.popConEmpNo.NameSize = 150;
            this.popConEmpNo.NameStyle = Bizentro.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popConEmpNo.Parameter = null;
            this.popConEmpNo.PopupButtonEnable = Bizentro.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popConEmpNo.PopupId = null;
            this.popConEmpNo.PopupType = Bizentro.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popConEmpNo.QueryIfEnterKeyPressed = true;
            this.popConEmpNo.RequiredField = false;
            this.popConEmpNo.Size = new System.Drawing.Size(271, 21);
            this.popConEmpNo.TabIndex = 4;
            this.popConEmpNo.uniALT = "사번";
            this.popConEmpNo.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popConEmpNo.UseDynamicFormat = false;
            this.popConEmpNo.ValueTextBoxName = null;
            this.popConEmpNo.OnChange += new System.EventHandler(this.popConEmpNo_OnChange);
            this.popConEmpNo.BeforePopupOpen += new Bizentro.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popConEmpNo_BeforePopupOpen);
            this.popConEmpNo.AfterPopupClosed += new Bizentro.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popConEmpNo_AfterPopupClosed);
            // 
            // chkConRetireFlag
            // 
            this.chkConRetireFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkConRetireFlag.FieldType = Bizentro.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.chkConRetireFlag.Location = new System.Drawing.Point(537, 55);
            this.chkConRetireFlag.LockedField = false;
            this.chkConRetireFlag.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.chkConRetireFlag.Name = "chkConRetireFlag";
            this.chkConRetireFlag.RequiredField = false;
            this.chkConRetireFlag.Size = new System.Drawing.Size(120, 19);
            this.chkConRetireFlag.StyleSetName = "Default";
            this.chkConRetireFlag.TabIndex = 5;
            this.chkConRetireFlag.uniALT = null;
            // 
            // uniTBL_MainReference
            // 
            this.uniTBL_MainReference.AutoFit = false;
            this.uniTBL_MainReference.AutoFitColumnCount = 4;
            this.uniTBL_MainReference.AutoFitRowCount = 4;
            this.uniTBL_MainReference.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainReference.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainReference.ColumnCount = 3;
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.DefaultRowSize = 23;
            this.uniTBL_MainReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainReference.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainReference.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainReference.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainReference.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainReference.Name = "uniTBL_MainReference";
            this.uniTBL_MainReference.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainReference.RowCount = 1;
            this.uniTBL_MainReference.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.Size = new System.Drawing.Size(842, 21);
            this.uniTBL_MainReference.SizeTD5 = 14F;
            this.uniTBL_MainReference.SizeTD6 = 36F;
            this.uniTBL_MainReference.TabIndex = 2;
            this.uniTBL_MainReference.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniTBL_MainBatch
            // 
            this.uniTBL_MainBatch.AutoFit = false;
            this.uniTBL_MainBatch.AutoFitColumnCount = 4;
            this.uniTBL_MainBatch.AutoFitRowCount = 4;
            this.uniTBL_MainBatch.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainBatch.BizentroTableLayout = Bizentro.AppFramework.UI.Controls.BizentroTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainBatch.ColumnCount = 5;
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.DefaultRowSize = 23;
            this.uniTBL_MainBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainBatch.EasyBaseBatchType = Bizentro.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainBatch.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainBatch.Location = new System.Drawing.Point(0, 546);
            this.uniTBL_MainBatch.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainBatch.Name = "uniTBL_MainBatch";
            this.uniTBL_MainBatch.PanelType = Bizentro.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainBatch.RowCount = 1;
            this.uniTBL_MainBatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.Size = new System.Drawing.Size(842, 28);
            this.uniTBL_MainBatch.SizeTD5 = 14F;
            this.uniTBL_MainBatch.SizeTD6 = 36F;
            this.uniTBL_MainBatch.TabIndex = 3;
            this.uniTBL_MainBatch.uniLR_SPACE_TYPE = Bizentro.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // ModuleViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uniTBL_OuterMost);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "ModuleViewer";
            this.Size = new System.Drawing.Size(853, 595);
            this.Controls.SetChildIndex(this.uniTBL_OuterMost, 0);
            this.Controls.SetChildIndex(this.uniLabel_Path, 0);
            this.uniTBL_OuterMost.ResumeLayout(false);
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).EndInit();
            this.uniTBL_MainCondition.ResumeLayout(false);
            this.uniTBL_MainCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtConYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboConBizAreaCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboConPayCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConRetireFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_OuterMost;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainData;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainCondition;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainReference;
        private Bizentro.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainBatch;
        private Bizentro.AppFramework.UI.Controls.uniGrid uniGrid1;
        private AppFramework.UI.Controls.uniLabel uniLabel1;
        private AppFramework.UI.Controls.uniLabel uniLabel2;
        private AppFramework.UI.Controls.uniLabel uniLabel3;
        private AppFramework.UI.Controls.uniLabel uniLabel4;
        private AppFramework.UI.Controls.uniLabel uniLabel5;
        private AppFramework.UI.Controls.uniLabel uniLabel6;
        private AppFramework.UI.Controls.uniDateTime dtConYear;
        private AppFramework.UI.Controls.uniCombo cboConBizAreaCd;
        private AppFramework.UI.Controls.uniCombo cboConPayCd;
        private AppFramework.UI.Controls.uniOpenPopup popConDeptCd;
        private AppFramework.UI.Controls.uniOpenPopup popConEmpNo;
        private AppFramework.UI.Controls.uniCheckBox chkConRetireFlag;
    }
}
