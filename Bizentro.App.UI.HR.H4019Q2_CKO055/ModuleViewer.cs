#region ● Namespace declaration

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI.SmartParts;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

using Bizentro.AppFramework.UI.Controls;
using Bizentro.AppFramework.UI.Module;
using Bizentro.AppFramework.UI.Variables;
using Bizentro.AppFramework.UI.Common.Exceptions;

#endregion

namespace Bizentro.App.UI.HR.H4019Q2_CKO055
{
    [SmartPart]
    public partial class ModuleViewer : ViewBase
    {

        #region ▶ 1. Declaration part

        #region ■ 1.1 Program information

        #endregion

        #region ■ 1.2. Class global constants (common)

        #endregion

        #region ■ 1.3. Class global variables (common)

        #endregion

        #region ■ 1.4 Class global constants (grid)


        #endregion

        #region ■ 1.5 Class global variables (grid)

        // change your code
        private DsList cqtdsList = new DsList();

        #endregion

        #endregion

        #region ▶ 2. Initialization part

        #region ■ 2.1 Constructor(common)

        public ModuleViewer()
        {
            InitializeComponent();
        }

        #endregion

        #region ■ 2.2 Form_Load(common)

        protected override void Form_Load()
        {
            uniBase.UData.SetWorkingDataSet(cqtdsList);
            uniBase.UCommon.SetViewType(enumDef.ViewType.T02_Multi);
            uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Query, enumDef.ModuleInformation.PersonnelPayRollManagement);
            LoadCustomInfTB19029();                                                   // Load custoqm numeric format
        }

        protected override void Form_Load_Completed()
        {
            dtYearMonth.Focus();
            //uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.DeleteRow, false);
        }

        #endregion

        #region ■ 2.3 Initializatize local global variables

        protected override void InitLocalVariables()
        {
            // init Dataset Row : change your code
            cqtdsList.Clear();
        }

        #endregion

        #region ■ 2.4 Set local global default variables

        protected override void SetLocalDefaultValue()
        {
            // Assign default value to controls
            DateTime CurrentDate = uniBase.UDate.GetDBServerDateTime();
            dtYearMonth.uniDateTimeF.DateTime = new DateTime(CurrentDate.Year, CurrentDate.AddMonths(-1).Month, 16);
            dtYearMonth.uniDateTimeT.DateTime = new DateTime(CurrentDate.Year, CurrentDate.Month, 15);
            cboPayCd.SelectedIndex = 0;
            uniOpenPopup _uniOpenPopup = popDeptCd;
            uniOpenPopup _uniOpenPopup1 = popDeptCd;
            uniTextBox _uniTextBox = txtInternalCd;
            string empty = string.Empty;
            string str = empty;
            _uniTextBox.Text = empty;
            string str1 = str;
            str = str1;
            _uniOpenPopup1.CodeName = str1;
            _uniOpenPopup.CodeValue = str;
            uniOpenPopup _uniOpenPopup2 = popEmpNo;
            uniOpenPopup _uniOpenPopup3 = popEmpNo;
            string empty1 = string.Empty;
            str = empty1;
            _uniOpenPopup3.CodeName = empty1;
            _uniOpenPopup2.CodeValue = str;
            cboWkType.SelectedIndex = 0;
            cboBizAreaCd.SelectedIndex = 0;
            SetDayOfWeek();
            dtYearMonth.Focus();

            return;
        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData)

        protected override void GatheringComboData()
        {
            uniBase.UData.ComboMajorAdd(cboPayCd.Name, "H0005");
            uniBase.UData.ComboMajorAdd(cboWkType.Name, "H0047");
            uniBase.UData.ComboCustomAdd(cboBizAreaCd.Name, " B_BIZ_AREA.BIZ_AREA_CD CODE, B_BIZ_AREA.BIZ_AREA_NM NAME ", string.Format("B_BIZ_AREA INNER JOIN dbo.ufn_AuthBizAreaCD_byUsrID('{0}') AUTH ON B_BIZ_AREA.BIZ_AREA_CD = AUTH.BIZ_AREA_CD", CommonVariable.gUsrID), "1=1");
        }

        #endregion

        #region ■ 2.6 Define user defined numeric info

        public void LoadCustomInfTB19029()
        {

            #region User Define Numeric Format Data Setting  ☆
            //base.viewTB19029.ggUserDefined6.DecPoint = 0;
            //base.viewTB19029.ggUserDefined6.Integeral = 15;
            #endregion
        }

        #endregion

        #endregion

        #region ▶ 3. Grid method part

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()
        {
            #region ■■ 3.1.1 Pre-setting grid information
            DsList.E_H4019Q2DataTable eH4019Q2 = cqtdsList.E_H4019Q2;

            uniGrid1.SSSetEdit(eH4019Q2.DEPTColumn.ColumnName, "부서", 128, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2.NAMEColumn.ColumnName, "이름", 60, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2.EMP_NOColumn.ColumnName, "사번", 72, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2.TYPEColumn.ColumnName, "구분", 64, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2.TOTALColumn.ColumnName, "합계", 50, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);

            for (var i = 0; i < 50; i++)
            {
                string sColumnKey = string.Format("D{0}", i.ToString().PadLeft(2, '0'));
                uniGrid1.SSSetEdit(sColumnKey, sColumnKey, 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            }

            #endregion

            #region ■■ 3.1.2 Formatting grid information

            uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.Yes);
            uniGrid1.DisplayLayout.Bands[0].Override.AllowRowFiltering = DefaultableBoolean.False;
            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.DEPTColumn.ColumnName].AllowRowFiltering = DefaultableBoolean.True;
            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.NAMEColumn.ColumnName].AllowRowFiltering = DefaultableBoolean.True;
            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.EMP_NOColumn.ColumnName].AllowRowFiltering = DefaultableBoolean.True;
            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.TYPEColumn.ColumnName].AllowRowFiltering = DefaultableBoolean.True;
            uniGrid1.DisplayLayout.Override.DefaultRowHeight = 20;
            uniGrid1.DisplayLayout.Override.RowSizing = RowSizing.Fixed;

            #endregion

            #region ■■ 3.1.3 Setting etc grid

            for (var i = 0; i < 50; i++)
            {
                AddLabelColumn(string.Format("DayName{0}", i.ToString().PadLeft(2, '0')), i.ToString().PadLeft(2, '0'));
            }

            uniGrid1.SetMerge(eH4019Q2.DEPTColumn.ColumnName, 0, 0, 1, 2);
            uniGrid1.SetMerge(eH4019Q2.NAMEColumn.ColumnName, 1, 0, 1, 2);
            uniGrid1.SetMerge(eH4019Q2.EMP_NOColumn.ColumnName, 2, 0, 1, 2);
            uniGrid1.SetMerge(eH4019Q2.TYPEColumn.ColumnName, 3, 0, 1, 2);

            for (int i = 0, j = 4; i < 50; i++, j++)
            {
                uniGrid1.SetMerge(string.Format("D{0}", i.ToString().PadLeft(2, '0')), j, 0, 1, 1);
                uniGrid1.SetMerge(string.Format("DayName{0}", i.ToString().PadLeft(2, '0')), j, 1, 1, 1);
            }

            uniGrid1.SetMerge(eH4019Q2.TOTALColumn.ColumnName, 54, 0, 1, 2);

            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.DEPTColumn.ColumnName].MergedCellStyle = MergedCellStyle.Always;
            uniGrid1.DisplayLayout.Bands[0].Columns[eH4019Q2.DEPTColumn.ColumnName].MergedCellEvaluator = new CustomMergedCellEvaluator();
            uniGrid1.SetCellMerge(eH4019Q2.NAMEColumn.ColumnName, enumDef.VAlign.Middle);
            uniGrid1.SetCellMerge(eH4019Q2.EMP_NOColumn.ColumnName, enumDef.VAlign.Middle);

            #endregion
        }
        #endregion

        #region ■ 3.2 InitData

        private void InitData()
        {
            // TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
            // SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
            // 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.
        }

        #endregion

        #region ■ 3.3 SetSpreadColor

        private void SetSpreadColor(int pvStartRow, int pvEndRow)
        {
            // TO-DO: InsertRow후 그리드 컬러 변경
            //uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
        }
        #endregion

        #region ■ 3.4 InitControlBinding
        protected override void InitControlBinding()
        {
            // Grid binding with global dataset variable.
            InitSpreadSheet();
            uniGrid1.uniGridSetDataBinding(cqtdsList.E_H4019Q2);
        }
        #endregion

        #endregion

        #region ▶ 4. Toolbar method part

        #region ■ 4.1 Common Fnction group

        #region ■■ 4.1.1 OnFncQuery(old:FncQuery)

        protected override bool OnFncQuery() => DBQuery();

        #endregion

        #region ■■ 4.1.2 OnFncSave(old:FncSave)

        protected override bool OnFncSave() => DBSave();

        #endregion

        #endregion

        #region ■ 4.2 Single Fnction group

        #region ■■ 4.2.1 OnFncNew(old:FncNew)

        protected override bool OnFncNew() => true;

        #endregion

        #region ■■ 4.2.2 OnFncDelete(old:FncDelete)

        protected override bool OnFncDelete() => true;

        #endregion

        #region ■■ 4.2.3 OnFncCopy(old:FncCopy)

        protected override bool OnFncCopy() => true;

        #endregion

        #region ■■ 4.2.4 OnFncFirst(No implementation)

        #endregion

        #region ■■ 4.2.5 OnFncPrev(old:FncPrev)

        protected override bool OnFncPrev() => true;

        #endregion

        #region ■■ 4.2.6 OnFncNext(old:FncNext)

        protected override bool OnFncNext() => true;

        #endregion

        #region ■■ 4.2.7 OnFncLast(No implementation)

        #endregion

        #endregion

        #region ■ 4.3 Grid Fnction group

        #region ■■ 4.3.1 OnFncInsertRow(old:FncInsertRow)

        protected override bool OnFncInsertRow() => true;

        #endregion

        #region ■■ 4.3.2 OnFncDeleteRow(old:FncDeleteRow)

        protected override bool OnFncDeleteRow() => true;

        #endregion

        #region ■■ 4.3.3 OnFncCancel(old:FncCancel)

        protected override bool OnFncCancel() => true;

        #endregion

        #region ■■ 4.3.4 OnFncCopyRow(old:FncCopy)

        protected override bool OnFncCopyRow() => true;

        #endregion

        #endregion

        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            try
            {
                AppFramework.DataBridge.uniCommand storedProcCommand = uniBase.UDatabase.GetStoredProcCommand("dbo.usp_H_H4019Q2_CKO055");

                uniBase.UDatabase.AddInParameter(storedProcCommand, "@FROM", SqlDbType.NVarChar, 10, dtYearMonth.uniFromValue.ToString(CommonVariable.CDT_YYYY_MM_DD));
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@TO", SqlDbType.NVarChar, 10, dtYearMonth.uniToValue.ToString(CommonVariable.CDT_YYYY_MM_DD));
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@BIZ_AREA_CD", SqlDbType.NVarChar, 10, cboBizAreaCd.SelectedItem == null ? string.Empty : cboBizAreaCd.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@DEPT_CD", SqlDbType.NVarChar, 10, popDeptCd.CodeValue);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@INTERNAL_CD", SqlDbType.NVarChar, 10, txtInternalCd.Text);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@EMP_NO", SqlDbType.NVarChar, 10, popEmpNo.CodeValue);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@WK_TYPE", SqlDbType.NVarChar, 1, cboWkType.SelectedItem == null ? string.Empty : cboWkType.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@USER_ID", SqlDbType.NVarChar, 10, CommonVariable.gUsrID);

                DataSet ds = uniBase.UDatabase.ExecuteDataSet(storedProcCommand);

                if (ds.Tables[0].Rows.Count < 0)
                {
                    uniBase.UMessage.DisplayMessageBox("900014", MessageBoxButtons.OK);
                    dtYearMonth.Focus();
                    return false;
                }

                cqtdsList.E_H4019Q2.Merge(ds.Tables[0], false, MissingSchemaAction.Ignore);

                uniGrid1.BeginUpdate();

                UpdateGrid();

                //uniGrid1.CreationFilter = new CustomCreationFilter();

                uniGrid1.EndUpdate();

                SetDayOfWeek();
            }
            catch (Exception ex)
            {
                if (ExceptionControler.AutoProcessException(ex)) throw;

                return false;
            }

            return true;
        }

        #endregion

        #region ■■ 4.4.2 DBDelete(Single)

        private bool DBDelete()
        {
            //TO-DO : code business oriented logic

            return true;
        }

        #endregion

        #region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {
            //TO-DO : code business oriented logic
            uniGrid1.UpdateData();

            //wsMyBizFL.TypedDataSet isettdsTypedDataSet = new wsMyBizFL.TypedDataSet();

            try
            {
                //wsMyBizFL.TypedDataSet.IESaveDTDataTable igettdtTypedDataSet =
                //    (wsMyBizFL.TypedDataSet.IESaveDTDataTable)this.cstdsTypedDataSet.IESaveDT.GetChanges();

                //using (wsMyBizFL.Service iwsMyBizFL = (wsMyBizFL.Service)uniBase.UConfig.SetWebServiceProxyEnv(new wsMyBizFL.Service()))
                //{
                //    isettdsTypedDataSet.IESaveDT.Merge(igettdtTypedDataSet, false, MissingSchemaAction.Ignore);
                //    iwsMyBizFL.SaveWebMethod(CommonVariable.gStrGlobalCollection, isettdsTypedDataSet);
                //}
            }
            catch (Exception ex)
            {
                if (ExceptionControler.AutoProcessException(ex)) throw;
                return false;
            }
            finally
            {
                //if (isettdsTypedDataSet != null) isettdsTypedDataSet.Dispose();
            }

            return true;

        }

        #endregion

        #endregion

        #endregion

        #region ▶ 5. Event method part

        #region ■ 5.1 Single control event implementation group

        private void PopEmpNo_OnExitEditCode(object sender, EventArgs e)
        {
            if (popEmpNo.CodeValue == string.Empty) popEmpNo.CodeName = string.Empty;
        }

        private void PopDeptCd_OnExitEditCode(object sender, EventArgs e)
        {
            if (popDeptCd.CodeValue == string.Empty)
            {
                uniOpenPopup _uniOpenPopup = popDeptCd;
                uniTextBox _uniTextBox = txtInternalCd;
                string empty = string.Empty;
                string str = empty;
                _uniTextBox.Text = empty;
                _uniOpenPopup.CodeName = str;
            }
        }

        #endregion

        #region ■ 5.2 Grid   control event implementation group

        #region ■■ 5.2.1 ButtonClicked >>> ClickCellButton
        private void uniGrid1_ClickCellButton(object sender, CellEventArgs e)
        {

        }
        #endregion ■■ ButtonClicked >>> ClickCellButton

        #region ■■ 5.2.2 Change >>> CellChange
        private void uniGrid1_BeforeExitEditMode(object sender, Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs e)
        {

        }

        private void uniGrid1_AfterExitEditMode(object sender, EventArgs e)
        {

        }
        #endregion ■■ Change >>> CellChange

        #region ■■ 5.2.3 Click >>> AfterCellActivate | AfterRowActivate | AfterSelectChange
        private void uniGrid1_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {

        }

        private void uniGrid1_AfterCellActivate(object sender, EventArgs e)
        {

        }

        private void uniGrid1_AfterRowActivate(object sender, EventArgs e)
        {

        }
        #endregion ■■ Click >>> AfterSelectChange

        #region ■■ 5.2.4 ComboSelChange >>> CellListSelect

        private void uniGrid1_CellListSelect(object sender, CellEventArgs e)
        {

        }
        #endregion ■■ ComboSelChange >>> CellListSelect

        #region ■■ 5.2.5 DblClick >>> DoubleClickCell

        private void uniGrid1_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {

        }
        #endregion ■■ DblClick >>> DoubleClickCell

        #region ■■ 5.2.6 MouseDown >>> MouseDown

        private void uniGrid1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        #endregion ■■ MouseDown >>> MouseDown

        #region ■■ 5.2.7 ScriptLeaveCell >>> BeforeCellDeactivate

        private void uniGrid1_BeforeCellDeactivate(object sender, CancelEventArgs e)
        {

        }
        #endregion ■■ ScriptLeaveCell >>> BeforeCellDeactivate

        #endregion

        #region ■ 5.3 TAB    control event implementation group

        #endregion

        #endregion

        #region ▶ 6. Popup method part

        #region ■ 6.1 Common popup implementation group

        #endregion

        #region ■ 6.2 User-defined popup implementation group

        private void PopDeptCd_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] codeValue = new string[] { popDeptCd.CodeValue, popDeptCd.CodeName, null, null };
            UDateClass uDate = uniBase.UDate;
            DateTime firstDay = dtYearMonth.uniFromValue;
            firstDay = uDate.GetFirstDay(firstDay.Date);
            firstDay = firstDay.Date;
            codeValue[2] = firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD);
            codeValue[3] = string.Empty;
            string[] strArrays = codeValue;
            e.PopupPassData.CalledPopupID = "Bizentro.App.UI.Popup.HDeptPopup";
            e.PopupPassData.PopupWinTitle = "Department Popup";
            e.PopupPassData.PopupWinWidth = 800;
            e.PopupPassData.PopupWinHeight = 700;
            AppFramework.UI.Controls.Popup.PopupPassData popupPassData = e.PopupPassData;
            codeValue = new string[4];
            UCommonClass uCommon = uniBase.UCommon;
            firstDay = uniBase.UDate.GetDBServerDateTime();
            firstDay = firstDay.Date;
            codeValue[0] = uCommon.FilterVariable(firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD), "'1900-01-01'", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[1] = uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            UCommonClass uCommonClass = uniBase.UCommon;
            firstDay = uniBase.UDate.GetDBServerDateTime();
            firstDay = firstDay.Date;
            codeValue[2] = uCommonClass.FilterVariable(firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD), "'1900-01-01'", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[3] = uniBase.UCommon.FilterVariable(popDeptCd, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            popupPassData.UserParameters = codeValue;
            e.PopupPassData.Data = strArrays;
        }

        private void PopDeptCd_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            if (e.ResultData.Data != null)
            {
                DataSet dataSet = (DataSet)e.ResultData.Data;
                popDeptCd.CodeValue = dataSet.Tables[0].Rows[0]["dept_cd"].ToString();
                popDeptCd.CodeName = dataSet.Tables[0].Rows[0]["dept_nm"].ToString();
                txtInternalCd.Text = dataSet.Tables[0].Rows[0]["internal_cd"].ToString();
            }
        }

        private void PopEmpNo_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] codeValue = new string[] { popEmpNo.CodeValue, popEmpNo.CodeName, null, null, null, null, null, null };
            UDateClass uDate = uniBase.UDate;
            DateTime firstDay = dtYearMonth.uniFromValue;
            firstDay = uDate.GetFirstDay(firstDay.Date);
            firstDay = firstDay.Date;
            codeValue[2] = firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD);
            codeValue[3] = "1";
            codeValue[4] = cboBizAreaCd.SelectedItem != null ? cboBizAreaCd.SelectedItem.DataValue.ToString() : string.Empty;
            codeValue[5] = "";
            codeValue[6] = txtInternalCd.Text;
            codeValue[7] = txtInternalCd.Text;
            string[] strArrays = codeValue;
            e.PopupPassData.CalledPopupID = "Bizentro.App.UI.Popup.EmpPopup";
            e.PopupPassData.PopupWinTitle = "Name/Employee No. Query Popup";
            e.PopupPassData.PopupWinWidth = 800;
            e.PopupPassData.PopupWinHeight = 700;
            AppFramework.UI.Controls.Popup.PopupPassData popupPassData = e.PopupPassData;
            codeValue = new string[] { uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true), null, null, null, null };
            UCommonClass uCommon = uniBase.UCommon;
            firstDay = uniBase.UDate.GetDBServerDateTime();
            firstDay = firstDay.Date;
            codeValue[1] = uCommon.FilterVariable(firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD), "'1900-01-01'", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[2] = uniBase.UCommon.FilterVariable(popEmpNo.CodeValue, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[3] = uniBase.UCommon.FilterVariable(popEmpNo.CodeValue, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[4] = cboBizAreaCd.SelectedItem == null ? string.Empty : string.Format("AND HAA010T.BIZ_AREA_CD = '{0}'", cboBizAreaCd.SelectedItem.DataValue.ToString());
            popupPassData.UserParameters = codeValue;
            e.PopupPassData.Data = strArrays;
        }

        private void PopEmpNo_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            if (e.ResultData.Data != null)
            {
                DataSet dataSet = (DataSet)e.ResultData.Data;
                popEmpNo.CodeValue = dataSet.Tables[0].Rows[0]["emp_no"].ToString();
                popEmpNo.CodeName = dataSet.Tables[0].Rows[0]["name"].ToString();
            }
        }

        #endregion

        #endregion

        #region ▶ 7. User-defined method part

        #region ■ 7.1 User-defined function group

        private void AddLabelColumn(string sColumn, string sCaption)
        {
            uniGrid1.DisplayLayout.Bands[0].Columns.Add(sColumn, sCaption);
            uniGrid1.DisplayLayout.Bands[0].Columns[sColumn].RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
        }

        private void SetDayOfWeek()
        {
            int days = (dtYearMonth.uniToValue - dtYearMonth.uniFromValue).Days + 1;
            days = days <= 50 ? days : 50;

            for (var i = 0; i < 50; i++)
            {
                uniGrid1.SSSetColHidden(string.Format("D{0}", i.ToString().PadLeft(2, '0')), true);
                uniGrid1.SSSetColHidden(string.Format("DayName{0}", i.ToString().PadLeft(2, '0')), true);
            }

            for (var i = 0; i < days; i++)
            {
                uniGrid1.SSSetColHidden(string.Format("D{0}", i.ToString().PadLeft(2, '0')), false);
                uniGrid1.SSSetColHidden(string.Format("DayName{0}", i.ToString().PadLeft(2, '0')), false);
                uniGrid1.setColumnHeader(string.Format("D{0}", i.ToString().PadLeft(2, '0')), dtYearMonth.uniFromValue.AddDays(i).Day.ToString().PadLeft(2, '0'));
                uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("D{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Black;
                uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DayName{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Black;

                DayOfWeek _dayOfWeek = dtYearMonth.uniFromValue.AddDays(i).DayOfWeek;
                string sDayOfWeek = string.Empty;

                switch (_dayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        sDayOfWeek = "일";
                        break;
                    case DayOfWeek.Monday:
                        sDayOfWeek = "월";
                        break;
                    case DayOfWeek.Tuesday:
                        sDayOfWeek = "화";
                        break;
                    case DayOfWeek.Wednesday:
                        sDayOfWeek = "수";
                        break;
                    case DayOfWeek.Thursday:
                        sDayOfWeek = "목";
                        break;
                    case DayOfWeek.Friday:
                        sDayOfWeek = "금";
                        break;
                    case DayOfWeek.Saturday:
                        sDayOfWeek = "토";
                        break;
                }

                uniGrid1.setColumnHeader(string.Format("DayName{0}", i.ToString().PadLeft(2, '0')), sDayOfWeek);
            }

            DataSet dsCalendar = GetCalendar();

            int index = 0;

            foreach (DataRow row in dsCalendar.Tables[0].Rows)
            {
                string _sHoliType = row["HOLI_TYPE"].ToString();

                switch (_sHoliType)
                {
                    case "S":
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("D{0}", index.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Blue;
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DayName{0}", index.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Blue;
                        break;

                    case "H":
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("D{0}", index.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Red;
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DayName{0}", index.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.Red;
                        break;
                }

                ++index;
            }
        }

        public DataSet GetCalendar()
        {
            string sSelect = "DATE, WEEK_DAY, HOLI_TYPE";
            string sFrom = "HCA020T";
            string sWhere = "BIZ_AREA_CD = 'UB00' AND DATE BETWEEN '"
                + dtYearMonth.uniFromValue.Date.ToString(CommonVariable.CDT_YYYY_MM_DD)
                + "' AND '"
                + dtYearMonth.uniToValue.ToString(CommonVariable.CDT_YYYY_MM_DD)
                + "'";
            DataSet dsCalendar = uniBase.UDataAccess.CommonQueryRs(sSelect, sFrom, sWhere);

            return dsCalendar;
        }

        private void UpdateGrid()
        {
            int days = (dtYearMonth.uniToValue - dtYearMonth.uniFromValue).Days + 1;
            days = days <= 50 ? days : 50;

            foreach (UltraGridRow Row in uniGrid1.Rows)
            {
                string _sType = Row.Cells["TYPE"].Value.ToString();

                switch (_sType)
                {
                    case "연장시간":
                    case "휴일근로":
                        Row.Appearance.BackColor = Color.FromArgb(255, 255, 255, 204);
                        break;
                    case "휴일연장":
                        Row.Appearance.BackColor = Color.FromArgb(255, 253, 233, 217);
                        break;
                    case "야간시간":
                    case "인정시간":
                        Row.Appearance.BackColor = Color.FromArgb(255, 242, 220, 219);
                        break;
                    case "비고":
                        Row.Appearance.BackColor = Color.FromArgb(255, 242, 242, 242);
                        break;
                    default:
                        Row.Appearance.BackColor = Color.White;
                        break;
                }

                switch (_sType)
                {
                    case "근로시간":
                    case "연장시간":
                    case "휴일근로":
                    case "휴일연장":
                    case "인정시간":
                    case "야간시간":
                        TimeSpan total = TimeSpan.Zero;

                        for (var i = 4; i < days + 4; i++)
                        {
                            string input = Row.Cells[i].Value.ToString() == "" || Row.Cells[i].Value.ToString() == null ? "00:00" : Row.Cells[i].Value.ToString();
                            TimeSpan TimeSpan = new TimeSpan(int.Parse(input.Split(':')[0]), int.Parse(input.Split(':')[1]), 0);
                            total = total.Add(TimeSpan);
                        }

                        string value = (total.Days * 24 + total.Hours).ToString("0").PadLeft(2, '0') + ':' + total.Minutes.ToString().PadLeft(2, '0');

                        Row.Cells["TOTAL"].SetValue(value, false);
                        break;
                }

                if (_sType == "근로시간")
                {
                    foreach (UltraGridCell Cell in Row.Cells)
                    {
                        if (Cell.Column.Index > 4 && Cell.Column.Index < days + 4 && Cell.Value != null && Cell.Value.ToString() != "08:00")
                        {
                            Cell.Appearance.FontData.Bold = DefaultableBoolean.True;
                            Cell.Appearance.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

    }


    class CustomMergedCellEvaluator : IMergedCellEvaluator
    {
        public bool ShouldCellsBeMerged(UltraGridRow row1, UltraGridRow row2, UltraGridColumn column)
        {
            return row1.Cells["EMP_NO"].Value.ToString() == row2.Cells["EMP_NO"].Value.ToString();
        }
    }


    class CustomCreationFilter : IUIElementCreationFilter
    {
        #region IUIElementCreationFilter Members

        public void AfterCreateChildElements(UIElement parent)
        {
            RowCellAreaUIElement row = parent as RowCellAreaUIElement;

            if (row != null && row.HasChildElements)
            {
                if (((CellUIElement)row.ChildElements[3]).Cell.Value.ToString() == "인정시간")
                {
                    List<CellUIElement> remcell = new List<CellUIElement>();
                    CellUIElement cell = (CellUIElement)row.ChildElements[0];

                    for (int i = 1; i < row.ChildElements.Count; i++)
                    {
                        if (!(row.ChildElements[i] is CellUIElement))
                            continue;

                        if (((CellUIElement)row.ChildElements[i]).Cell.Column.Key == "TEXT_01"
                         || ((CellUIElement)row.ChildElements[i]).Cell.Column.Key == "TEXT_02"
                         || ((CellUIElement)row.ChildElements[i]).Cell.Column.Key == "EMP_NO"
                         || ((CellUIElement)row.ChildElements[i]).Cell.Column.Key == "TYPE"
                         || ((CellUIElement)row.ChildElements[i]).Cell.Column.Key == "TOTAL"
                        ) continue;

                        CellUIElement nextCell = (CellUIElement)row.ChildElements[i];

                        string strNextCell = nextCell.Cell.Column.Header.Caption;

                        // if (cell.Cell.Value.ToString() == nextCell.Cell.Value.ToString())
                        if (strNextCell == "화" || strNextCell == "수" || strNextCell == "목" || strNextCell == "금")
                        {
                            Size s = cell.Rect.Size;
                            s.Width += nextCell.Rect.Width;
                            cell.Rect = new Rectangle(cell.Rect.Location, s);
                            nextCell.Rect = new Rectangle(0, 0, 0, 0);
                            remcell.Add(nextCell);
                        }
                        else
                        {
                            cell = nextCell;
                        }
                    }
                    foreach (CellUIElement rc in remcell)
                        row.ChildElements.Remove(rc);
                }
            }
        }

        public bool BeforeCreateChildElements(UIElement parent)
        {
            return false;
            //throw new NotImplementedException();
        }

        #endregion
    }
}