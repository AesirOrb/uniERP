using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI.SmartParts;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

using Bizentro.AppFramework.UI.Controls;
using Bizentro.AppFramework.UI.Module;
using Bizentro.AppFramework.UI.Variables;
using Bizentro.AppFramework.UI.Common.Exceptions;

namespace Bizentro.App.UI.HR.H4005M1_CKO055
{
    [SmartPart]
    public partial class ModuleViewer : ViewBase
    {
        private DsList cqtdsList = new DsList();

        public ModuleViewer() => InitializeComponent();

        protected override void Form_Load()
        {
            uniBase.UData.SetWorkingDataSet(cqtdsList);
            uniBase.UCommon.SetViewType(enumDef.ViewType.T02_Multi);
            uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.DeleteRow, false);
            uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Input, enumDef.ModuleInformation.PersonnelPayRollManagement);
            LoadCustomInfTB19029();
        }

        protected override void Form_Load_Completed() => dtYearMonth.Focus();

        protected override void InitLocalVariables() => cqtdsList.Clear();

        protected override void SetLocalDefaultValue()
        {
            dtYearMonth.Value = uniBase.UDate.GetDBServerDateTime();
            cboPayCd.SelectedIndex = 0;
            cboWkType.SelectedIndex = 0;
            cboBizAreaCd.SelectedIndex = 0;
            uniOpenPopup _uniOpenPopup = popDeptCd;
            uniOpenPopup _uniOpenPopup1 = popDeptCd;
            uniOpenPopup _uniOpenPopup2 = popEmpNo;
            uniOpenPopup _uniOpenPopup3 = popEmpNo;
            uniTextBox _uniTextBox = txtInternalCd;
            _uniOpenPopup.CodeValue = string.Empty;
            _uniOpenPopup1.CodeName = string.Empty;
            _uniOpenPopup2.CodeValue = string.Empty;
            _uniOpenPopup3.CodeName = string.Empty;
            _uniTextBox.Text = string.Empty;
            SetDayOfWeek();
            dtYearMonth.Focus();

            return;
        }

        protected override void GatheringComboData()
        {
            uniBase.UData.ComboMajorAdd(cboPayCd.Name, "H0005");
            uniBase.UData.ComboMajorAdd(cboWkType.Name, "H0047");
            uniBase.UData.ComboCustomAdd(cboBizAreaCd.Name, "A.BIZ_AREA_CD CODE, A.BIZ_AREA_NM NAME", string.Format("B_BIZ_AREA A JOIN dbo.ufn_AuthBizAreaCD_byUsrID('{0}') AUTH ON A.BIZ_AREA_CD = AUTH.BIZ_AREA_CD", CommonVariable.gUsrID), "1=1");
            //uniBase.UData.ComboCustomAdd("cboEmpWkType", "DISTINCT CODE = WK_TYPE, NAME = MINOR_NM", "B_MINOR A JOIN HCA030T B ON A.MAJOR_CD = 'H0047' AND A.MINOR_CD = B.WK_TYPE", "1=1");
        }

        public void LoadCustomInfTB19029()
        {
            //base.viewTB19029.ggUserDefined6.DecPoint = 0;
            //base.viewTB19029.ggUserDefined6.Integeral = 15;
        }

        private void InitSpreadSheet()
        {
            DsList.E_H4005M1_KODataTable eH4005M1KO = cqtdsList.E_H4005M1_KO;

            uniGrid1.SSSetEdit(eH4005M1KO.TEXT_01Column.ColumnName, "Department", 100, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4005M1KO.TEXT_02Column.ColumnName, "Name", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4005M1KO.EMP_NOColumn.ColumnName, "Employee ID", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4005M1KO.TYPEColumn.ColumnName, "Type", 80, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Center);

            for (var i = 1; i <= 31; i++)
            {
                string sColumnKey = eH4005M1KO.Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].ColumnName;
                uniGrid1.SSSetEdit(sColumnKey, string.Format("Data {0}", i), 40, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            }

            uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);
            uniGrid1.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.SortSingle;

            for (var i = 1; i <= 31; i++)
            {
                string sKey = string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'));
                string sCaption = i.ToString();
                uniGrid1.DisplayLayout.Bands[0].Columns.Add(sKey, sCaption).RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
            }

            uniGrid1.SetMerge(eH4005M1KO.TEXT_01Column.ColumnName, 0, 0, 1, 2);
            uniGrid1.SetMerge(eH4005M1KO.TEXT_02Column.ColumnName, 1, 0, 1, 2);
            uniGrid1.SetMerge(eH4005M1KO.EMP_NOColumn.ColumnName, 2, 0, 1, 2);
            uniGrid1.SetMerge(eH4005M1KO.TYPEColumn.ColumnName, 3, 0, 1, 2);

            for (var i = 1; i <= 31; i++)
            {
                uniGrid1.SetMerge(string.Format("grpDate{0}", i.ToString().PadLeft(2, '0')), i + 3, 0, 1, 1);
                uniGrid1.SetMerge(string.Format("DATA_{0}", i.ToString().PadLeft(2, '0')), i + 3, 1, 1, 1);
            }

            string[] strCols = { "EMP_NO", "TEXT_01", "TEXT_02" };
            //uniGrid1.SetCellHierarchyMerge(strCols, enumDef.VAlign.Middle);
            uniGrid1.DisplayLayout.Bands[0].Override.AllowRowFiltering = DefaultableBoolean.False;
            uniGrid1.DisplayLayout.Override.RowSizing = RowSizing.Fixed;
            uniGrid1.DisplayLayout.Override.DefaultRowHeight = 20;
        }

        private void InitData() { }

        private void SetSpreadColor(int pvStartRow, int pvEndRow) { }

        protected override void InitControlBinding()
        {
            InitSpreadSheet();
            uniGrid1.uniGridSetDataBinding(cqtdsList.E_H4005M1_KO);
        }

        protected override bool OnFncQuery() => DBQuery();

        protected override bool OnFncSave() => DBSave();

        protected override bool OnFncNew() => true;

        protected override bool OnFncDelete() => true;

        protected override bool OnFncCopy() => true;

        protected override bool OnFncPrev() => true;

        protected override bool OnFncNext() => true;

        protected override bool OnFncInsertRow() => true;

        protected override bool OnFncDeleteRow() => true;

        protected override bool OnFncCancel() => true;

        protected override bool OnFncCopyRow() => true;

        private bool DBQuery()
        {
            try
            {
                AppFramework.DataBridge.uniCommand storedProcCommand = uniBase.UDatabase.GetStoredProcCommand("dbo.usp_H_H4005M1_CKO055");

                uniBase.UDatabase.AddInParameter(storedProcCommand, "@YYMM", SqlDbType.NVarChar, 6, dtYearMonth.uniValue.ToString(CommonVariable.CDT_YYYYMM));
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@BIZ_AREA_CD", SqlDbType.NVarChar, 10, cboBizAreaCd.SelectedItem == null ? string.Empty : cboBizAreaCd.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@DEPT_CD", SqlDbType.NVarChar, 10, popDeptCd.CodeValue);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@INTERNAL_CD", SqlDbType.NVarChar, 10, txtInternalCd.Text);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@EMP_NO", SqlDbType.NVarChar, 13, popEmpNo.CodeValue);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@WK_TYPE", SqlDbType.NVarChar, 1, cboWkType.SelectedItem == null ? string.Empty : cboWkType.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@USER_ID", SqlDbType.NVarChar, 13, CommonVariable.gUsrID);

                DataSet ds = uniBase.UDatabase.ExecuteDataSet(storedProcCommand);

                if (ds.Tables[0].Rows.Count < 0)
                {
                    uniBase.UMessage.DisplayMessageBox("900014", MessageBoxButtons.OK);
                    dtYearMonth.Focus();
                    return false;
                }

                cqtdsList.E_H4005M1_KO.Merge(ds.Tables[0], false, MissingSchemaAction.Ignore);

                uniGrid1.BeginUpdate();

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

        private bool DBDelete() => true;

        private bool DBSave()
        {
            uniGrid1.UpdateData();

            try
            {

            }
            catch (Exception ex)
            {
                if (ExceptionControler.AutoProcessException(ex)) throw;

                return false;
            }

            return true;
        }

        private void popEmpNo_OnExitEditCode(object sender, EventArgs e)
        {
            if (popEmpNo.CodeValue == string.Empty) popEmpNo.CodeName = string.Empty;
        }

        private void popDeptCd_OnExitEditCode(object sender, EventArgs e)
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

        private void uniGrid1_ClickCellButton(object sender, CellEventArgs e) { }

        private void uniGrid1_BeforeExitEditMode(object sender, Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs e) { }

        private void uniGrid1_AfterExitEditMode(object sender, EventArgs e) { }

        private void uniGrid1_AfterSelectChange(object sender, AfterSelectChangeEventArgs e) { }

        private void uniGrid1_AfterCellActivate(object sender, EventArgs e) { }

        private void uniGrid1_AfterRowActivate(object sender, EventArgs e) { }

        private void uniGrid1_CellListSelect(object sender, CellEventArgs e) { }

        private void uniGrid1_ClickCell(object sender, ClickCellEventArgs e) { }

        private void uniGrid1_DoubleClickCell(object sender, DoubleClickCellEventArgs e) { }

        private void uniGrid1_MouseDown(object sender, MouseEventArgs e) { }

        private void uniGrid1_BeforeCellDeactivate(object sender, CancelEventArgs e) { }

        private void popDeptCd_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] codeValue = new string[] { popDeptCd.CodeValue, popDeptCd.CodeName, null, null };
            UDateClass uDate = uniBase.UDate;
            DateTime firstDay = dtYearMonth.uniValue;
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
            UCommonClass uCommonClass = uniBase.UCommon;
            firstDay = uniBase.UDate.GetDBServerDateTime().Date;
            codeValue[0] = uCommon.FilterVariable(firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD), "'1900-01-01'", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[1] = uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[2] = uCommonClass.FilterVariable(firstDay.ToString(CommonVariable.CDT_YYYY_MM_DD), "'1900-01-01'", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            codeValue[3] = uniBase.UCommon.FilterVariable(popDeptCd, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            popupPassData.UserParameters = codeValue;
            e.PopupPassData.Data = strArrays;
        }

        private void popDeptCd_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            if (e.ResultData.Data != null)
            {
                DataSet ds = (DataSet)e.ResultData.Data;
                popDeptCd.CodeValue = ds.Tables[0].Rows[0]["dept_cd"].ToString();
                popDeptCd.CodeName = ds.Tables[0].Rows[0]["dept_nm"].ToString();
                txtInternalCd.Text = ds.Tables[0].Rows[0]["internal_cd"].ToString();
            }
        }

        private void popEmpNo_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] codeValue = new string[] { popEmpNo.CodeValue, popEmpNo.CodeName, null, null, null, null, null, null };
            UDateClass uDate = uniBase.UDate;
            DateTime firstDay = dtYearMonth.uniValue;
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

        private void popEmpNo_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            if (e.ResultData.Data != null)
            {
                DataSet ds = (DataSet)e.ResultData.Data;
                popEmpNo.CodeValue = ds.Tables[0].Rows[0]["emp_no"].ToString();
                popEmpNo.CodeName = ds.Tables[0].Rows[0]["name"].ToString();
            }
        }

        private void SetDayOfWeek()
        {
            uniGrid1.SSSetColHidden("DATA_29", false);
            uniGrid1.SSSetColHidden("DATA_30", false);
            uniGrid1.SSSetColHidden("DATA_31", false);

            for (var i = 1; i <= 31; i++)
            {
                DayOfWeek _dayOfWeek = Convert.ToDateTime(dtYearMonth.uniValue.ToString("yyyy-MM-01")).AddDays(i - 1).DayOfWeek;
                uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 0);
                uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 0);
                string sDayOfWeek = string.Empty;

                switch (_dayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        sDayOfWeek = "일";
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 255, 0, 0);
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 255, 0, 0);
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
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 255);
                        uniGrid1.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 255);
                        break;
                }
                uniGrid1.setColumnHeader(string.Format("DATA_{0}", i.ToString().PadLeft(2, '0')), sDayOfWeek);
            }

            switch (dtYearMonth.uniValue.Month)
            {
                case 2:
                    if (!DateTime.IsLeapYear(dtYearMonth.uniValue.Year))
                    {
                        uniGrid1.SSSetColHidden("DATA_29", true);
                        uniGrid1.SSSetColHidden("DATA_30", true);
                        uniGrid1.SSSetColHidden("DATA_31", true);
                    }
                    else
                    {
                        uniGrid1.SSSetColHidden("DATA_30", true);
                        uniGrid1.SSSetColHidden("DATA_31", true);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    uniGrid1.SSSetColHidden("DATA_31", true);
                    break;
            }
        }
    }
}