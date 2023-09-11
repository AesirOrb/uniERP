#region ● Namespace declaration

using System;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Bizentro.AppFramework.DataBridge;
using Bizentro.AppFramework.UI.Common.Exceptions;
using Bizentro.AppFramework.UI.Module;
using Bizentro.AppFramework.UI.Variables;
using Microsoft.Practices.CompositeUI.SmartParts;
using Infragistics.Win.UltraWinGrid;

#endregion

namespace Bizentro.App.UI.HR.H4019M3_CKO055
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

        private dsListQuery cqtdsQuery = new dsListQuery();
        private string strInternalCd = "";

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
            //uniBase.UData.SetWorkingDataSet(this.cstdsTypedDataSet);
            uniBase.UCommon.SetViewType(enumDef.ViewType.T02_Multi);

            uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Input, enumDef.ModuleInformation.Common);  // Load company numeric format. I: Input Program, *: All Module
            LoadCustomInfTB19029();                                                   // Load custoqm numeric format
        }

        protected override void Form_Load_Completed()
        {
            dtConYear.Value = uniBase.UDate.GetDBServerDateTime();

            uniBase.UCommon.SetToolBarMultiAll(false);
            uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.Cancel, true);
        }

        #endregion

        #region ■ 2.3 Initializatize local global variables

        protected override void InitLocalVariables()
        {
            // init Dataset Row : change your code
            //dsAnyName.Clear();
        }

        #endregion

        #region ■ 2.4 Set local global default variables

        protected override void SetLocalDefaultValue()
        {
            // Assign default value to controls
            return;
        }

        #endregion

        #region ■ 2.5 Gathering combo data(GatheringComboData)

        protected override void GatheringComboData()
        {
            // Example: Set ComboBox List (Column Name, Select, From, Where)
            //uniBase.UData.ComboMajorAdd("TaxPolicy", "B0004");
            //uniBase.UData.ComboCustomAdd("MSG_TYPE", "MINOR_CD , MINOR_NM ", "B_MINOR", "MAJOR_CD='A1001'");
        }
        #endregion

        #region ■ 2.6 Define user defined numeric info

        public void LoadCustomInfTB19029()
        {
            #region User Define Numeric Format Data Setting  ☆
            viewTB19029.ggUserDefined6.DecPoint = 1;
            //base.viewTB19029.ggUserDefined6.Integeral = 15;
            #endregion
        }

        #endregion

        #region ▶ 3. Grid method part

        #endregion

        #region ■ 3.1 Initialize Grid (InitSpreadSheet)

        private void InitSpreadSheet()
        {
            #region ■■ 3.1.1 Pre-setting grid information

            dsListQuery.A_LIST_QUERY_UNIGRID1DataTable uniGridTB1 = cqtdsQuery.A_LIST_QUERY_UNIGRID1;

            uniGrid1.SSSetEdit(uniGridTB1.DEPT_NMColumn.ColumnName, "부서", 133, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Left);
            uniGrid1.SSSetEdit(uniGridTB1.BIZ_AREA_NMColumn.ColumnName, "사업장", 108, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Left);
            uniGrid1.SSSetEdit(uniGridTB1.NAMEColumn.ColumnName, "성명", 103, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, false, enumDef.HAlign.Left);
            uniGrid1.SSSetEdit(uniGridTB1.EMP_NOColumn.ColumnName, "사번", 122, enumDef.FieldType.ReadOnly, enumDef.CharCase.Default, true, enumDef.HAlign.Left);
            uniGrid1.SSSetDate(uniGridTB1.ENTR_DTColumn.ColumnName, "입사일", 131, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYY_MM_DD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB1.RETIRE_DTColumn.ColumnName, "최종근무일", 131, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYY_MM_DD, enumDef.HAlign.Center);
            uniGrid1.SSSetDate(uniGridTB1.ENTR_DT_1_YEARColumn.ColumnName, "입사1년 채우는날", 159, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYY_MM_DD, enumDef.HAlign.Center);
            uniGrid1.SSSetFloat(uniGridTB1.YEAR_SAVE_TOT_1Column.ColumnName, "발생", 91, viewTB19029.ggAmtOfMoney, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.YEAR_MONTH_1Column.ColumnName, "전기발생신입연차", 160, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.EXT1_TXTColumn.ColumnName, "전기(이월) 차감/사용연차", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.Default, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetDate(uniGridTB1.USE_STRT_DTColumn.ColumnName, "부여일자", 131, enumDef.FieldType.ReadOnly, CommonVariable.CDT_YYYY_MM_DD, enumDef.HAlign.Center);
            uniGrid1.SSSetFloat(uniGridTB1.YEAR_SAVE_TOT_2Column.ColumnName, "수량", 91, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.YEAR_MONTHColumn.ColumnName, "당기발생신입연차", 160, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.EXT2_TXTColumn.ColumnName, "당기발생차감수량", 100, viewTB19029.ggAmtOfMoney, enumDef.FieldType.Default, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.YEAR_SAVE_TOT_3Column.ColumnName, "사용가능연차", 135, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.CNTColumn.ColumnName, "사용누계", 110, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.TEMP_1Column.ColumnName, "사용가능잔여연차", 160, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);
            uniGrid1.SSSetFloat(uniGridTB1.TEMP_2Column.ColumnName, "당회기말사용만료잔여연차", 211, viewTB19029.ggUserDefined6, enumDef.FieldType.ReadOnly, enumDef.HAlign.Right, true, enumDef.PosZero.Default, int.MinValue, int.MaxValue, false);

            #endregion

            #region ■■ 3.1.2 Formatting grid information

            uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);
            uniGrid1.flagInformation("SELECTED_CHAR", "ROW_NUM");

            #endregion

            #region ■■ 3.1.3 Setting etc grid

            uniGrid1.SetMerge("DEPT_NM", 0, 0, 1, 3);
            uniGrid1.SetMerge("BIZ_AREA_NM", 1, 0, 1, 3);
            uniGrid1.SetMerge("NAME", 2, 0, 1, 3);
            uniGrid1.SetMerge("EMP_NO", 3, 0, 1, 3);
            uniGrid1.SetMerge("ENTR_DT", 4, 0, 1, 3);
            uniGrid1.SetMerge("RETIRE_DT", 5, 0, 1, 3);
            uniGrid1.SetMerge("ENTR_DT_1_YEAR", 6, 0, 1, 3);
            uniGrid1.DisplayLayout.Bands[0].Columns.Add("ICE_DEV_TEMP_COL1", "입사기준 최종연차");
            uniGrid1.DisplayLayout.Bands[0].Columns["ICE_DEV_TEMP_COL1"].RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
            uniGrid1.SetMerge("ICE_DEV_TEMP_COL1", 7, 0, 1, 1);
            uniGrid1.DisplayLayout.Bands[0].Columns.Add("ICE_DEV_TEMP_COL2", "현재 유효 연차 휴가 현황");
            uniGrid1.DisplayLayout.Bands[0].Columns["ICE_DEV_TEMP_COL2"].RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
            uniGrid1.SetMerge("ICE_DEV_TEMP_COL2", 8, 0, 7, 1);
            uniGrid1.SetMerge("CNT", 15, 0, 1, 3);
            uniGrid1.SetMerge("TEMP_1", 16, 0, 1, 3);
            uniGrid1.SetMerge("TEMP_2", 17, 0, 1, 3);
            uniGrid1.SetMerge("YEAR_SAVE_TOT_1", 7, 1, 1, 2);
            uniGrid1.SetMerge("YEAR_MONTH_1", 8, 1, 1, 2);
            uniGrid1.SetMerge("EXT1_TXT", 9, 1, 1, 2);
            uniGrid1.DisplayLayout.Bands[0].Columns.Add("ICE_DEV_TEMP_COL3", "당기초발생 회계연차");
            uniGrid1.DisplayLayout.Bands[0].Columns["ICE_DEV_TEMP_COL3"].RowLayoutColumnInfo.LabelPosition = LabelPosition.LabelOnly;
            uniGrid1.SetMerge("ICE_DEV_TEMP_COL3", 10, 1, 2, 1);
            uniGrid1.SetMerge("YEAR_MONTH", 12, 1, 1, 2);
            uniGrid1.SetMerge("EXT2_TXT", 13, 1, 1, 2);
            uniGrid1.SetMerge("YEAR_SAVE_TOT_3", 14, 1, 1, 2);
            uniGrid1.SetMerge("USE_STRT_DT", 10, 2, 1, 1);
            uniGrid1.SetMerge("YEAR_SAVE_TOT_2", 11, 2, 1, 1);

            uniGrid1.DisplayLayout.Override.DefaultRowHeight = 23;

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
            this.InitSpreadSheet();
            uniGrid1.uniGridSetDataBinding(cqtdsQuery.A_LIST_QUERY_UNIGRID1);
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
                StringBuilder sbSQL = new StringBuilder();
                DataSet ResultRs = new DataSet();
                uniCommand iuniCommand = null;

                iuniCommand = uniBase.UDatabase.GetStoredProcCommand("dbo.USP_H9201M1_CKO055_UNIGRID1");
                iuniCommand.CommandType = CommandType.StoredProcedure;

                uniBase.UDatabase.AddInParameter(iuniCommand, "@YEAR", SqlDbType.NVarChar, dtConYear.uniValue.ToString("yyyy"));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@BIZ_AREA_CD", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable(cboConBizAreaCd.Value.ToString(), "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@PAY_CD", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable(cboConPayCd.Value.ToString(), "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@DEPT_CD", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable(popConDeptCd, "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@EMP_NO", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable(popConEmpNo, "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@RETIRE_FLAG", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable((chkConRetireFlag.Checked ? "Y" : "N"), "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddInParameter(iuniCommand, "@USER_ID", SqlDbType.NVarChar, uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "%", enumDef.FilterVarType.NoBraceButReplSingleWithDoubleQuotation, true));
                uniBase.UDatabase.AddOutParameter(iuniCommand, "@MSG_CD", SqlDbType.NVarChar, 100);
                uniBase.UDatabase.AddOutParameter(iuniCommand, "@MSG_TEXT", SqlDbType.NVarChar, 255);

                uniBase.UDatabase.AddReturnParameter(iuniCommand, "@return", SqlDbType.VarChar, 4);

                ResultRs = uniBase.UDatabase.ExecuteDataSet(iuniCommand);

                int iReturnValue = (int)uniBase.UDatabase.GetParameterValue(iuniCommand, "@return");

                string strMSG_CD = uniBase.UDatabase.GetParameterValue(iuniCommand, "@MSG_CD").ToString();
                string strMSG_TEXT = uniBase.UDatabase.GetParameterValue(iuniCommand, "@MSG_TEXT").ToString();

                if (ResultRs == null || ResultRs.Tables[0].Rows.Count == 0)
                {
                    uniBase.UMessage.DisplayMessageBox(strMSG_CD, MessageBoxButtons.OK, strMSG_TEXT);
                    return false;
                }
                cqtdsQuery.A_LIST_QUERY_UNIGRID1.Merge(ResultRs.Tables[0], false, MissingSchemaAction.Ignore);
            }
            catch (Exception ex)
            {
                bool reThrow = ExceptionControler.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return false;
            }
            finally
            {
                //if (iqtdsTypedDataSet != null) iqtdsTypedDataSet.Dispose();
                //if (iqtdsICondition != null) iqtdsICondition.Dispose();
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
                StringBuilder sbSQL = new StringBuilder();
                DataSet ResultRs = new DataSet();
                uniCommand iuniCommand = null;

                iuniCommand = uniBase.UDatabase.GetStoredProcCommand("dbo.USP_H9201M1_CKO055_CUD");
                iuniCommand.CommandType = CommandType.StoredProcedure;

                dsListQuery.A_MANAGER_SAVE_UNIGRID1DataTable SendTB = new dsListQuery.A_MANAGER_SAVE_UNIGRID1DataTable();

                SendTB.Merge(cqtdsQuery.A_LIST_QUERY_UNIGRID1.GetChanges(), false, MissingSchemaAction.Ignore);

                uniBase.UDatabase.AddInParameter(iuniCommand, "@MAIN_TB", SqlDbType.Structured, SendTB.DefaultView.ToTable());
                uniBase.UDatabase.AddInParameter(iuniCommand, "@USER_ID", SqlDbType.NVarChar, CommonVariable.gUsrID);
                uniBase.UDatabase.AddOutParameter(iuniCommand, "@MSG_CD", SqlDbType.NVarChar, 100);
                uniBase.UDatabase.AddOutParameter(iuniCommand, "@MSG_TEXT", SqlDbType.NVarChar, 255);

                uniBase.UDatabase.AddReturnParameter(iuniCommand, "@return", SqlDbType.VarChar, 4);

                uniBase.UDatabase.ExecuteNonQuery(iuniCommand, false);

                int iReturnValue = (int)uniBase.UDatabase.GetParameterValue(iuniCommand, "@return");

                string strMSG_CD = uniBase.UDatabase.GetParameterValue(iuniCommand, "@MSG_CD").ToString();
                string strMSG_TEXT = uniBase.UDatabase.GetParameterValue(iuniCommand, "@MSG_TEXT").ToString();

                if (iReturnValue != 1)
                {
                    uniBase.UMessage.DisplayMessageBox(strMSG_CD, MessageBoxButtons.OK, strMSG_TEXT);
                    return false;
                }
            }
            catch (Exception ex)
            {
                bool reThrow = ExceptionControler.AutoProcessException(ex);
                if (reThrow)
                    throw;
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
        /// <summary>
        /// Cell 내의 콤보박스의 Item을 선택 변경했을때 이벤트가 발생합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_CellListSelect(object sender, CellEventArgs e)
        {
        }
        #endregion ■■ ComboSelChange >>> CellListSelect

        #region ■■ 5.2.5 DblClick >>> DoubleClickCell
        /// <summary>
        /// fpSpread의 DblClick이벤트는 UltraGrid의 DoubleClickCell이벤트로 변경 하실 수 있습니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
        }
        #endregion ■■ DblClick >>> DoubleClickCell

        #region ■■ 5.2.6 MouseDown >>> MouseDown
        /// <summary>
        /// 마우스 우측 버튼 클릭시 Context메뉴를 보여주는 일련의 작업들을 이 이벤트에서 수행합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniGrid1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        #endregion ■■ MouseDown >>> MouseDown

        #region ■■ 5.2.7 ScriptLeaveCell >>> BeforeCellDeactivate
        /// <summary>
        /// fpSpread의 ScripLeaveCell 이벤트는 UltraGrid의 
        /// BeforeCellDeactivate 이벤트와 AfterCellActivate 이벤트를 겸해서 사용합니다.
        /// BeforeCellDeactivate    : 기존Cell에서 새로운 Cell로 이동하기 전에 기존Cell위치에서 처리 할 일련의 작업들을 기술합니다.
        /// AfterCellActivate       : 새로운 Cell로 이동해서 처리할 일련의 작업들을 기술합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void OpenNumberingType(string iWhere)
        {
            #region ▶▶▶ 10.1.2.1 Popup Constructors
            //CommonPopup cp = new CommonUtil.CommonPopup(PopupType.AutoNumbering);

            //string[] arrRet = cp.showModalDialog(InputParam1);

            #endregion

            #region ▶▶▶ 10.1.2.2 Setting Returned Data

            //if (iWhere) 
            //{
            //    txtMinor.value = arrRet[0];
            //    txtMinorNm.value = arrRet[1];
            //}
            //else
            //{
            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.NumberingCd].value = arrRet[0];
            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.NumberingNm].value = arrRet[1];

            //    if (arrRet[2].Length > 0) 
            //        uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.MaxLen].value = arrRet[2];
            //    else
            //        uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.MaxLen].value = "18";

            //    uniGrid1.Rows[uniGrid1.ActiveRow][gridCol.PrefixCd].value = arrRet[0];

            //}

            #endregion

            //CommonVariable.lgBlnFlgChgValue = true;  // 사용자 액션 발생 알림
        }


        #endregion

        #endregion

        #region ▶ 7. User-defined method part

        #region ■ 7.1 User-defined function group

        #endregion

        #endregion

        private void popConDeptCd_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] param_array = new string[] { popConDeptCd.CodeValue, popConDeptCd.CodeName, "", cboConBizAreaCd.Value.ToString() };
            e.PopupPassData.CalledPopupID = "Bizentro.App.UI.Popup.HDeptPopup";
            e.PopupPassData.PopupWinTitle = "부서";
            e.PopupPassData.PopupWinWidth = 800;
            e.PopupPassData.PopupWinHeight = 700;
            e.PopupPassData.Data = param_array;
        }

        private void popConDeptCd_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popConDeptCd.CodeValue = iDataSet.Tables[0].Rows[0]["dept_cd"].ToString();
            popConDeptCd.CodeName = iDataSet.Tables[0].Rows[0]["dept_nm"].ToString();
            strInternalCd = iDataSet.Tables[0].Rows[0]["internal_cd"].ToString();
        }

        private void popConDeptCd_OnChange(object sender, EventArgs e)
        {
            if (popConDeptCd.CodeValue == "")
            {
                popConDeptCd.CodeName = "";
                strInternalCd = "";
                return;
            }

            string[] UNISqlId = new string[] { "ZN_HR_DEPT_NM" };
            string[][] UNIValue = new string[1][];
            UNIValue[0] = new string[5];

            // 0: DATE(IF '' DEFAULT GETDATE)
            // 1: USER ID
            // 2: DEPT CODE
            // 3: BIZ AREA CODE
            // 4: ADDITIONAL CONDITION

            UNIValue[0][0] = "''";
            UNIValue[0][1] = uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            UNIValue[0][2] = "'" + popConDeptCd.CodeValue + "'";
            UNIValue[0][3] = "'" + cboConBizAreaCd.Value.ToString() + "%'";
            UNIValue[0][4] = "";

            DataSet pDataSet = null;

            try
            {
                pDataSet = uniBase.UDataAccess.DBAgentQryRS(UNISqlId, UNIValue);

                if (pDataSet == null || pDataSet.Tables[0].Rows.Count == 0)
                {
                    strInternalCd = "";
                    popConDeptCd.CodeValue = "";
                    popConDeptCd.CodeName = "";
                    popConDeptCd.uniButton_Click(null, null);
                    popConDeptCd.Focus();
                    return;
                }
                popConDeptCd.CodeValue = pDataSet.Tables[0].Rows[0]["dept_cd"].ToString();
                popConDeptCd.CodeName = pDataSet.Tables[0].Rows[0]["dept_nm"].ToString();
                strInternalCd = pDataSet.Tables[0].Rows[0]["internal_cd"].ToString();

            }
            catch (Exception ex)
            {
                bool reThrow = uniBase.UExceptionController.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return;
            }
        }

        private void popConEmpNo_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            string[] param_array = new string[] { popConEmpNo.CodeValue, popConEmpNo.CodeName, "", "", this.cboConBizAreaCd.Value.ToString() };
            e.PopupPassData.CalledPopupID = "Bizentro.App.UI.Popup.EmpPopup";
            e.PopupPassData.PopupWinTitle = "사번";
            e.PopupPassData.PopupWinWidth = 800;
            e.PopupPassData.PopupWinHeight = 700;
            e.PopupPassData.Data = param_array;
        }

        private void popConEmpNo_AfterPopupClosed(object sender, AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popConEmpNo.CodeValue = iDataSet.Tables[0].Rows[0]["emp_no"].ToString();
            popConEmpNo.CodeName = iDataSet.Tables[0].Rows[0]["name"].ToString();
        }

        private void popConEmpNo_OnChange(object sender, EventArgs e)
        {
            if (popConEmpNo.CodeValue == "")
            {
                popConEmpNo.CodeName = "";
                return;
            }

            string[] UNISqlId = new string[] { "ZN_HR_EMP_NM2" };
            string[][] UNIValue = new string[1][];
            UNIValue[0] = new string[5];


            // 0: USER ID
            // 1: DATE(IF '' DEFAULT GETDATE)
            // 2: EMP NO
            // 3: ADDITIONAL CONDITION
            // string dt = dtPayDt.uniValue.ToString(CommonVariable.CDT_YYYYMMDD);
            UNIValue[0][0] = uniBase.UCommon.FilterVariable(CommonVariable.gUsrID, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            //UNIValue[0][1] = uniBase.UCommon.FilterVariable(dt, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);// "''";
            UNIValue[0][1] = "''";
            UNIValue[0][2] = uniBase.UCommon.FilterVariable(popConEmpNo.CodeValue, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            UNIValue[0][3] = uniBase.UCommon.FilterVariable(popConEmpNo.CodeValue, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
            UNIValue[0][4] = " and dept.biz_area_cd like  '" + cboConBizAreaCd.Value.ToString() + "'";

            DataSet pDataSet = null;

            try
            {
                pDataSet = uniBase.UDataAccess.DBAgentQryRS(UNISqlId, UNIValue);

                if (pDataSet == null || pDataSet.Tables[0].Rows.Count == 0)
                {
                    popConEmpNo.CodeValue = "";
                    popConEmpNo.CodeName = "";
                    popConEmpNo.uniButton_Click(null, null);
                    popConEmpNo.Focus();
                    return;

                }
                popConEmpNo.CodeValue = pDataSet.Tables[0].Rows[0]["emp_no"].ToString();
                popConEmpNo.CodeName = pDataSet.Tables[0].Rows[0]["name"].ToString();
            }
            catch (Exception ex)
            {
                bool reThrow = uniBase.UExceptionController.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return;
            }
        }

        private void uniGrid1_AfterExitEditMode_1(object sender, EventArgs e)
        {
            switch (uniGrid1.ActiveCell.Column.Key.ToUpper())
            {
                case "EXT1_TXT":
                case "EXT2_TXT":
                    if (uniGrid1.ActiveCell.Value.ToString() == "") uniGrid1.ActiveCell.Value = 0;

                    decimal dYearSaveTot = Convert.ToDecimal(uniGrid1.ActiveRow.Cells["YEAR_SAVE_TOT_1"].Value);
                    decimal dExt1Txt = Convert.ToDecimal(uniGrid1.ActiveRow.Cells["EXT1_TXT"].Value);
                    decimal dExt2Txt = Convert.ToDecimal(uniGrid1.ActiveRow.Cells["EXT2_TXT"].Value);
                    decimal dCnt = Convert.ToDecimal(uniGrid1.ActiveRow.Cells["CNT"].Value);

                    uniGrid1.ActiveRow.Cells["TEMP_1"].Value = dYearSaveTot - dExt1Txt - dExt2Txt - dCnt;
                    uniGrid1.ActiveRow.Cells["TEMP_2"].Value = dYearSaveTot - dExt1Txt - dExt2Txt - dCnt;
                    break;
            }
        }
    }
}