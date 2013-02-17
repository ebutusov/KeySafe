using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeySafe
{
	class DataGridViewPasswordCell : DataGridViewTextBoxCell
	{
		protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			Point cursorPos = this.DataGridView.PointToClient(Cursor.Position);
			//if (cellBounds.Contains(cursorPos))			
			if (Selected)
				base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
			else
			{
				graphics.FillRectangle(Brushes.LightGray, cellBounds);
			}
		}

		protected override void OnMouseEnter(int rowIndex)
		{
			//base.OnMouseEnter(rowIndex);
			this.DataGridView.InvalidateCell(this);
		}

		protected override void OnMouseLeave(int rowIndex)
		{
			//base.OnMouseLeave(rowIndex);
			this.DataGridView.InvalidateCell(this);
		}
	}
}
