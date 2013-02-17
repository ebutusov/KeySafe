using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeySafe
{
	class DataGridViewPasswordColumn : DataGridViewColumn
	{
		public DataGridViewPasswordColumn()
		{
			this.CellTemplate = new DataGridViewPasswordCell();
		}
	}
}
