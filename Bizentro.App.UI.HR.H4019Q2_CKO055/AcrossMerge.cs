using System.Collections.Generic;
using System.Drawing;

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace Bizentro.App.UI.HR.H4019Q2_CKO055
{
    class AcrossMerge : IUIElementCreationFilter
    {
        #region IUIElementCreationFilter Members

        public void AfterCreateChildElements(UIElement parent)
        {
            RowCellAreaUIElement row = parent as RowCellAreaUIElement;

            if (row != null && row.HasChildElements)
            {
                List<CellUIElement> remcell = new List<CellUIElement>();
                CellUIElement cell = (CellUIElement)row.ChildElements[4];

                for (int i = 1; i < row.ChildElements.Count; i++)
                {
                    if (!(row.ChildElements[i] is CellUIElement))
                        continue;
                        
                    CellUIElement nextCell = (CellUIElement)row.ChildElements[i];

                    string strCell = cell.Cell.Column.Header.Caption;
                    string strNext = nextCell.Cell.Column.Header.Caption;

                    if (cell.Cell.Value.ToString() == nextCell.Cell.Value.ToString() && (strCell == "월" || strCell == "화" || strCell == "수" || strCell == "목" || strCell == "금"))
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

        public bool BeforeCreateChildElements(UIElement parent)
        {
            return false;
            //throw new NotImplementedException();
        }

        #endregion
    }
}
