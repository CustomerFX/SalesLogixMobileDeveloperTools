#region License Information
/* 

    SalesLogix Mobile Developer Tools
    Copyright (C) 2012  Customer FX Corporation - http://customerfx.com/

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
	
	ADDITIONAL TERMS: 
	The "Customer FX" link to customerfx.com on the main form must 
	remain visible and in-tact on any forks or use of this source code.

    Contact Information:
    
    Ryan Farley 
    Customer FX Corporation
    http://customerfx.com/
    2324 University Avenue West, Suite 115
    Saint Paul, Minnesota 55114
    Tel: 651.646.7777  Fax: 651.846.5185
    
    This copyright must remain intact
    
*/
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FX.Mobile.DeveloperTools.Controls
{
	public enum ActionButtonSize
	{
		Normal,
		Wide
	}

	public partial class ActionButton : UserControl
	{
		public event EventHandler ActionClicked;

		public ActionButton()
		{
			InitializeComponent();
		}

		public Image MainImage
		{
			get { return imageMain.Image; }
			set { imageMain.Image = value; }
		}

		public Image HoverImage
		{
			get { return imageHover.Image; }
			set { imageHover.Image = value; }
		}

		public string MainImageUrl
		{
			get { return imageMain.ImageLocation; }
			set { imageMain.ImageLocation = value; }
		}

		public string HoverImageUrl
		{
			get { return imageHover.ImageLocation; }
			set { imageHover.ImageLocation = value; }
		}

		public ActionButtonSize ActionButtonSize
		{
			get { return (this.Width == 274 ? ActionButtonSize.Normal : ActionButtonSize.Wide); }
			set
			{
				if (value == ActionButtonSize.Wide)
				{
					this.Size = new Size(555, 85);
					this.MinimumSize = new Size(555, 85);
					this.MaximumSize = new Size(555, 85);
					imageMain.Size = new Size(555, 85);
					imageHover.Size = new Size(555, 85);
				}
				else
				{
					this.Size = new Size(274, 85);
					this.MinimumSize = new Size(274, 85);
					this.MaximumSize = new Size(274, 85);
					imageMain.Size = new Size(274, 85);
					imageHover.Size = new Size(274, 85);
				}
			}
		}

		private void imageMain_Click(object sender, EventArgs e)
		{
			if (ActionClicked != null)
				ActionClicked(this, EventArgs.Empty);
		}

		private void imageButton_MouseEnterLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(imageMain.ImageLocation))
			{
				Image img = imageMain.Image;
				imageMain.Image = imageHover.Image;
				imageHover.Image = img;
			}
			else
			{
				string imgLoc = imageMain.ImageLocation;
				imageMain.ImageLocation = imageHover.ImageLocation;
				imageHover.ImageLocation = imgLoc;
			}
		}
	}
}
