﻿#region ● Namespace declaration

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

#endregion

namespace Bizentro.App.UI.HR.H4019Q2_CKO055
{
    [SmartPart]
    public partial class ModuleViewer : ViewBase
    {

        #region ▶ 1. Declaration part

        #region ■ 1.1 Program information
        /// <TemplateVersion>0.0.1.0</TemplateVersion>
        /// <NameSpace>①namespace</NameSpace>
        /// <Module>②module name</Module>
        /// <Class>③class name</Class>
        /// <Desc>④
        ///   This part describe the summary information about class 
        /// </Desc>
        /// <History>⑤
        ///   <FirstCreated>
        ///     <history name="creator" Date="created date">Make …</history>
        ///   </FirstCreated>
        ///   <Lastmodified>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///     <history name="modifier"  Date="modified date"> contents </history>
        ///   </Lastmodified>
        /// </History>
        /// <Remarks>⑥
        ///   <remark name="modifier"  Date="modified date">… </remark>
        ///   <remark name="modifier"  Date="modified date">… </remark>
        /// </Remarks>

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
            uniDateTime date = dtYearMonth;
            DateTime dBServerDateTime = uniBase.UDate.GetDBServerDateTime();
            date.Value = dBServerDateTime.Date;
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
            SetDayOfWeek(uniGrid1);
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

            int i;
            int num;
            DsList.E_H4019Q2_KODataTable eH4019Q2KO = cqtdsList.E_H4019Q2_KO;
            uniGrid1.SSSetEdit(eH4019Q2KO.TEXT_01Column.ColumnName, "Work Group", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.TEXT_02Column.ColumnName, "Entrance Day", 80, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.TYPEColumn.ColumnName, "Day", 72, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_16Column.ColumnName, "Data 16", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_17Column.ColumnName, "Data 17", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_18Column.ColumnName, "Data 18", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_19Column.ColumnName, "Data 19", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_20Column.ColumnName, "Data 20", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_21Column.ColumnName, "Data 21", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_22Column.ColumnName, "Data 22", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_23Column.ColumnName, "Data 23", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_24Column.ColumnName, "Data 24", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_25Column.ColumnName, "Data 25", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_26Column.ColumnName, "Data 26", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_27Column.ColumnName, "Data 27", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_28Column.ColumnName, "Data 28", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_29Column.ColumnName, "Data 29", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_30Column.ColumnName, "Data 30", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_31Column.ColumnName, "Data 31", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_01Column.ColumnName, "Data 1", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_02Column.ColumnName, "Data 2", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_03Column.ColumnName, "Data 3", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_04Column.ColumnName, "Data 4", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_05Column.ColumnName, "Data 5", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_06Column.ColumnName, "Data 6", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_07Column.ColumnName, "Data 7", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_08Column.ColumnName, "Data 8", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_09Column.ColumnName, "Data 9", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_10Column.ColumnName, "Data 10", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_11Column.ColumnName, "Data 11", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_12Column.ColumnName, "Data 12", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_13Column.ColumnName, "Data 13", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_14Column.ColumnName, "Data 14", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.DATA_15Column.ColumnName, "Data 15", 40, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);
            uniGrid1.SSSetEdit(eH4019Q2KO.TOTALColumn.ColumnName, "Total", 50, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Center);

            #endregion

            #region ■■ 3.1.2 Formatting grid information

            uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.Yes);
            uniGrid1.DisplayLayout.Override.HeaderClickAction = HeaderClickAction.Select;

            #endregion

            #region ■■ 3.1.3 Setting etc grid

            AddLabelColumn(uniGrid1, "grpEmpNo", "Employee ID");
            AddLabelColumn(uniGrid1, "grpName", "Name");
            AddLabelColumn(uniGrid1, "grpDept", "Department");
            AddLabelColumn(uniGrid1, "grpPayCd", "Payroll ID");
            AddLabelColumn(uniGrid1, "grpAttendance", "Attendance Details");
            AddLabelColumn(uniGrid1, "grpDate", "Date");

            for (i = 15; i < 31; i++)
            {
                uniGrid _uniGrid = uniGrid1;
                num = i + 1;
                string str = string.Format("grpDate{0}", num.ToString().PadLeft(2, Convert.ToChar("0")));
                num = i + 1;
                AddLabelColumn(_uniGrid, str, num.ToString());
            }

            for (i = 0; i < 15; i++)
            {
                uniGrid _uniGrid1 = uniGrid1;
                num = i + 1;
                string str1 = string.Format("grpDate{0}", num.ToString().PadLeft(2, Convert.ToChar("0")));
                num = i + 1;
                AddLabelColumn(_uniGrid1, str1, num.ToString());
            }

            uniGrid1.SetMerge("grpEmpNo", 1, 0, 1, 1);
            uniGrid1.SetMerge("grpDept", 1, 1, 1, 1);
            uniGrid1.SetMerge(eH4019Q2KO.TEXT_01Column.ColumnName, 1, 2, 1, 1);
            uniGrid1.SetMerge("grpName", 2, 0, 1, 1);
            uniGrid1.SetMerge("grpPayCd", 2, 1, 1, 1);
            uniGrid1.SetMerge(eH4019Q2KO.TEXT_02Column.ColumnName, 2, 2, 1, 1);
            uniGrid1.SetMerge("grpAttendance", 3, 0, 32, 1);
            uniGrid1.SetMerge("grpDate", 3, 1, 1, 1);
            uniGrid1.SetMerge(eH4019Q2KO.TYPEColumn.ColumnName, 3, 2, 1, 1);

            int num1 = 3;

            for (i = 15; i < 31; i++)
            {
                num = i + 1;
                uniGrid1.SetMerge(string.Format("grpDate{0}", num.ToString().PadLeft(2, Convert.ToChar("0"))), ++num1, 1, 1, 1);
                num = i + 1;
                uniGrid1.SetMerge(string.Format("DATA_{0}", num.ToString().PadLeft(2, Convert.ToChar("0"))), num1, 2, 1, 1);
            }
            for (i = 0; i < 15; i++)
            {
                num = i + 1;
                uniGrid1.SetMerge(string.Format("grpDate{0}", num.ToString().PadLeft(2, Convert.ToChar("0"))), ++num1, 1, 1, 1);
                num = i + 1;
                uniGrid1.SetMerge(string.Format("DATA_{0}", num.ToString().PadLeft(2, Convert.ToChar("0"))), num1, 2, 1, 1);
            }

            uniGrid1.SetCellMerge("TEXT_01", enumDef.VAlign.Middle);
            uniGrid1.SetCellMerge("TEXT_02", enumDef.VAlign.Middle);
            uniGrid1.SetMerge(eH4019Q2KO.TOTALColumn.ColumnName, ++num1, 0, 1, 3);
            uniGrid1.DisplayLayout.Bands[0].Override.AllowRowFiltering = DefaultableBoolean.False;
            uniGrid1.DisplayLayout.Override.RowSizing = RowSizing.Fixed;
            uniGrid1.DisplayLayout.Override.DefaultRowHeight = 20;

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
            uniGrid1.uniGridSetDataBinding(cqtdsList.E_H4019Q2_KO);
        }
        #endregion

        #endregion

        #region ▶ 4. Toolbar method part

        #region ■ 4.1 Common Fnction group

        #region ■■ 4.1.1 OnFncQuery(old:FncQuery)

        protected override bool OnFncQuery()
        {
            //TO-DO : code business oriented logic
            return DBQuery();
        }

        #endregion

        #region ■■ 4.1.2 OnFncSave(old:FncSave)

        protected override bool OnFncSave()
        {
            //TO-DO : code business oriented logic
            return DBSave();
        }

        #endregion

        #endregion

        #region ■ 4.2 Single Fnction group

        #region ■■ 4.2.1 OnFncNew(old:FncNew)

        protected override bool OnFncNew()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.2 OnFncDelete(old:FncDelete)

        protected override bool OnFncDelete()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.3 OnFncCopy(old:FncCopy)

        protected override bool OnFncCopy()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.4 OnFncFirst(No implementation)

        #endregion

        #region ■■ 4.2.5 OnFncPrev(old:FncPrev)

        protected override bool OnFncPrev()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.6 OnFncNext(old:FncNext)

        protected override bool OnFncNext()
        {
            //TO-DO : code business oriented logic
            return true;
        }

        #endregion

        #region ■■ 4.2.7 OnFncLast(No implementation)

        #endregion

        #endregion

        #region ■ 4.3 Grid Fnction group

        #region ■■ 4.3.1 OnFncInsertRow(old:FncInsertRow)
        protected override bool OnFncInsertRow()
        {
            //TO-DO : code business oriented logic
            //if (this.uniGrid1.ActiveRow != null)
            //{
            //    this.uniGrid1.ActiveRow.Cells["DATE_COL"].Value = uniBase.UDate.GetDBServerDateTime();
            //}
            return true;
        }
        #endregion

        #region ■■ 4.3.2 OnFncDeleteRow(old:FncDeleteRow)
        protected override bool OnFncDeleteRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.3 OnFncCancel(old:FncCancel)
        protected override bool OnFncCancel()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #region ■■ 4.3.4 OnFncCopyRow(old:FncCopy)
        protected override bool OnFncCopyRow()
        {
            //TO-DO : code business oriented logic
            return true;
        }
        #endregion

        #endregion

        #region ■ 4.4 Db function group

        #region ■■ 4.4.1 DBQuery(Common)

        private bool DBQuery()
        {
            try
            {
                AppFramework.DataBridge.uniCommand storedProcCommand = uniBase.UDatabase.GetStoredProcCommand("dbo.usp_H_H4019Q2_CKO055");

                uniBase.UDatabase.AddInParameter(storedProcCommand, "@YYMM", SqlDbType.NVarChar, 6, dtYearMonth.uniValue.ToString(CommonVariable.CDT_YYYYMM));
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@PAY_CD", SqlDbType.NVarChar, 1, cboPayCd.SelectedItem == null ? string.Empty : cboPayCd.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@INTERNAL_CD", SqlDbType.NVarChar, 30, txtInternalCd.Text);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@EMP_NO", SqlDbType.NVarChar, 13, popEmpNo.CodeValue);
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@WK_TYPE", SqlDbType.NVarChar, 1, cboWkType.SelectedItem == null ? string.Empty : cboWkType.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@BIZ_AREA_CD", SqlDbType.NVarChar, 10, cboBizAreaCd.SelectedItem == null ? string.Empty : cboBizAreaCd.SelectedItem.DataValue.ToString());
                uniBase.UDatabase.AddInParameter(storedProcCommand, "@USER_ID", SqlDbType.NVarChar, 13, CommonVariable.gUsrID);

                DataSet ds = uniBase.UDatabase.ExecuteDataSet(storedProcCommand);

                if (ds.Tables[0].Rows.Count < 0)
                {
                    uniBase.UMessage.DisplayMessageBox("900014", MessageBoxButtons.OK);
                    dtYearMonth.Focus();
                    return false;
                }

                cqtdsList.E_H4019Q2_KO.Merge(ds.Tables[0], false, MissingSchemaAction.Ignore);

                uniGrid1.BeginUpdate();

                for (int i = 0; i < uniGrid1.Rows.Count; i++)
                    uniGrid1.Rows[i].Appearance.BackColor = uniGrid1.Rows[i].Cells["TYPE"].Value as string != "비고" ? Color.White : Color.FromArgb(255, 240, 240, 240);

                uniGrid1.EndUpdate();

                SetDayOfWeek(uniGrid1);
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

        #endregion

        #region ■ 5.2 Grid   control event implementation group

        #region ■■ 5.2.1 ButtonClicked >>> ClickCellButton
        /// <summary>
        /// Cell 내의 버튼을 클릭했을때의 일련작업들을 수행합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_ClickCellButton(object sender, CellEventArgs e)
        {

        }
        #endregion ■■ ButtonClicked >>> ClickCellButton

        #region ■■ 5.2.2 Change >>> CellChange
        /// <summary>
        /// fpSpread의 Change 이벤트는 UltraGrid의 BeforeExitEditMode 또는 AfterExitEditMode 이벤트로 대체됩니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void popDeptCd_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            if (e.ResultData.Data != null)
            {
                DataSet dataSet = (DataSet)e.ResultData.Data;
                popDeptCd.CodeValue = dataSet.Tables[0].Rows[0]["dept_cd"].ToString();
                popDeptCd.CodeName = dataSet.Tables[0].Rows[0]["dept_nm"].ToString();
                txtInternalCd.Text = dataSet.Tables[0].Rows[0]["internal_cd"].ToString();
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
                DataSet dataSet = (DataSet)e.ResultData.Data;
                popEmpNo.CodeValue = dataSet.Tables[0].Rows[0]["emp_no"].ToString();
                popEmpNo.CodeName = dataSet.Tables[0].Rows[0]["name"].ToString();
            }
        }

        #endregion

        #endregion

        #region ▶ 7. User-defined method part

        #region ■ 7.1 User-defined function group

        private void AddLabelColumn(uniGrid grid, string sColumn, string sCaption)
        {
            grid.DisplayLayout.Bands[0].Columns.Add(sColumn, sCaption);
            grid.DisplayLayout.Bands[0].Columns[sColumn].RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
        }

        private void SetDayOfWeek(uniGrid grid)
        {
            grid.SSSetColHidden("DATA_29", false);
            grid.SSSetColHidden("DATA_30", false);
            grid.SSSetColHidden("DATA_31", false);

            for (int i = 1; i <= 31; i++)
            {
                grid.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 0);
                grid.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 0);
                DayOfWeek _dayOfWeek = Convert.ToDateTime(dtYearMonth.uniValue.AddMonths(i >= 16 ? -1 : 0).ToString("yyyy-MM-01")).AddDays(i - 1).DayOfWeek;
                string sDayOfWeek = string.Empty;

                switch (_dayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        sDayOfWeek = "일";
                        grid.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 255, 0, 0);
                        grid.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 255, 0, 0);
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
                        grid.DisplayLayout.Bands[0].Columns[string.Format("grpDate{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 255);
                        grid.DisplayLayout.Bands[0].Columns[string.Format("DATA_{0}", i.ToString().PadLeft(2, '0'))].Header.Appearance.ForeColor = Color.FromArgb(255, 0, 0, 255);
                        break;
                }

                grid.setColumnHeader(string.Format("DATA_{0}", i.ToString().PadLeft(2, '0')), sDayOfWeek);
            }

            switch (dtYearMonth.uniValue.AddMonths(-1).Month)
            {
                case 2:
                    if (!DateTime.IsLeapYear(dtYearMonth.uniValue.Year))
                    {
                        grid.SSSetColHidden("DATA_29", true);
                        grid.SSSetColHidden("DATA_30", true);
                        grid.SSSetColHidden("DATA_31", true);
                    }
                    else
                    {
                        grid.SSSetColHidden("DATA_30", true);
                        grid.SSSetColHidden("DATA_31", true);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    grid.SSSetColHidden("DATA_31", true);
                    break;
            }
        }

        #endregion

        #endregion

    }
}