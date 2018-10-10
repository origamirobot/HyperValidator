using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Terminal
{

	/// <summary>
	/// 
	/// </summary>
	public class ConsoleMenuList
	{


		#region PRIVATE PROPERTIES


		/// <summary>
		/// Gets or sets the ammount of columns to display for menu items
		/// </summary>
		private Int32 _gridWidth = 3;

		/// <summary>
		/// An item matrix used to display the grid of menu items
		/// </summary>
		private ConsoleListItem[][] _itemMatrix;

		/// <summary>
		/// A list of all items in this menu
		/// </summary>
		private List<ConsoleListItem> _items = new List<ConsoleListItem>();

		/// <summary>
		/// The style of the border to display when rendering this control
		/// </summary>
		private ConsoleBorderStyle _borderStyle;

		/// <summary>
		/// The cursor position at the top of this control
		/// </summary>
		private Int32 _top = 0;

		/// <summary>
		/// The cursor position at the bottom of this control
		/// </summary>
		private Int32 _bottom = 0;

		/// <summary>
		/// The width to make each idividual item
		/// </summary>
		private Int32 _itemWidth = 20;

		/// <summary>
		/// The index of the selected item
		/// </summary>
		private Int32 _selectedIndex;

		/// <summary>
		/// The background color of the selected item
		/// </summary>
		private ConsoleColor _selectedBackColor = ConsoleColor.DarkBlue;

		/// <summary>
		/// The foreground color of the selected item
		/// </summary>
		private ConsoleColor _selectedForeColor = ConsoleColor.White;

		/// <summary>
		/// The background color of the control
		/// </summary>
		private ConsoleColor _backColor = ConsoleColor.Black;

		/// <summary>
		/// The foreground color of the each non selected item
		/// </summary>
		private ConsoleColor _itemForeColor = ConsoleColor.White;

		/// <summary>
		/// The background color of the each non selected item
		/// </summary>
		private ConsoleColor _itemBackColor = ConsoleColor.Black;

		/// <summary>
		/// The foreground color of the title
		/// </summary>
		private ConsoleColor _titleForeColor = ConsoleColor.White;

		/// <summary>
		/// The background color of the title
		/// </summary>
		private ConsoleColor _titleBackColor = ConsoleColor.DarkBlue;

		/// <summary>
		/// The color of the border
		/// </summary>
		private ConsoleColor _borderColor = ConsoleColor.White;

		/// <summary>
		/// The color of the foreground
		/// </summary>
		private ConsoleColor _foreColor = ConsoleColor.White;


		#endregion PRIVATE PROPERTIES


		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets the selected item in this list
		/// </summary>
		public ConsoleListItem SelectedItem
		{
			get { return this._items[this._selectedIndex]; }
		}

		/// <summary>
		/// Gets or sets the ammount of columns to display for menu items
		/// </summary>
		public Int32 GridWidth
		{
			get { return _gridWidth; }
			set { _gridWidth = value; }
		}

		/// <summary>
		/// The style of the border to render
		/// </summary>
		public ConsoleBorderStyle BorderStyle
		{
			get { return _borderStyle; }
			set { _borderStyle = value; }
		}

		/// <summary>
		/// The width to make each idividual item
		/// </summary>
		public Int32 ItemWidth
		{
			get { return _itemWidth; }
			set { _itemWidth = value; }
		}

		/// <summary>
		/// A collection of ConsoleListItems in this control
		/// </summary>
		public List<ConsoleListItem> Items
		{
			get { return this._items; }
		}

		/// <summary>
		/// The index of the selected item
		/// </summary>
		public Int32 SelectedIndex
		{
			get { return _selectedIndex; }
			set { _selectedIndex = value; }
		}

		/// <summary>
		/// Gets the Value of the selected item
		/// </summary>
		public Object SelectedValue
		{
			get { return this._items[this._selectedIndex].Value; }
		}

		/// <summary>
		/// Gets or sets the background color of the selected item
		/// </summary>
		public ConsoleColor SelectedBackColor
		{
			get { return _selectedBackColor; }
			set { _selectedBackColor = value; }
		}

		/// <summary>
		/// Gets or sets the foreground color of the selected item
		/// </summary>
		public ConsoleColor SelectedForeColor
		{
			get { return _selectedForeColor; }
			set { _selectedForeColor = value; }
		}

		/// <summary>
		/// Gets or sets the background color of the each non selected item
		/// </summary>
		public ConsoleColor ItemBackColor
		{
			get { return _itemBackColor; }
			set { _itemBackColor = value; }
		}

		/// <summary>
		/// Gets or sets the foreground color of the each non selected item
		/// </summary>
		public ConsoleColor ItemForeColor
		{
			get { return _itemForeColor; }
			set { _itemForeColor = value; }
		}

		/// <summary>
		/// Gets or sets the background color of the title
		/// </summary>
		public ConsoleColor TitleBackColor
		{
			get { return _titleBackColor; }
			set { _titleBackColor = value; }
		}

		/// <summary>
		/// Gets or sets the foreground color of the title
		/// </summary>
		public ConsoleColor TitleForeColor
		{
			get { return _titleForeColor; }
			set { _titleForeColor = value; }
		}

		/// <summary>
		/// Gets or sets the background color of the control
		/// </summary>
		public ConsoleColor BackColor
		{
			get { return _backColor; }
			set { _backColor = value; }
		}

		/// <summary>
		/// Gets or sets the color of the border
		/// </summary>
		public ConsoleColor BorderColor
		{
			get { return _borderColor; }
			set { _borderColor = value; }
		}

		/// <summary>
		/// Gets or sets the forecolor of this control
		/// </summary>
		public ConsoleColor ForeColor
		{
			get { return _foreColor; }
			set { _foreColor = value; }
		}


		#endregion PUBLIC ACCESSORS


		#region CONSTRUCTORS


		/// <summary>
		/// Creates an instance of the ConsoleMenuList class
		/// </summary>
		public ConsoleMenuList()
		{

		}


		#endregion CONSTRUCTORS


		#region PRIVATE METHODS


		/// <summary>
		/// Takes the items in the item list and creates a matrix using the GridWidth property
		/// </summary>
		private void BuildItemMatrix()
		{
			List<ConsoleListItem[]> items = new List<ConsoleListItem[]>();
			Boolean flag = true;
			Int32 count = 0;
			while (flag)
			{
				List<ConsoleListItem> row = new List<ConsoleListItem>();
				for (Int32 i = 0; i < this.GridWidth; i++)
				{
					if (count == this.SelectedIndex)
						this._items[count].Selected = true;
					else
						this._items[count].Selected = false;
					row.Add(this._items[count]);
					if ((count + 1) == this._items.Count)
					{
						flag = false;
						break;
					}
					count++;
				}
				items.Add(row.ToArray());
			}
			this._itemMatrix = items.ToArray();
		}

		/// <summary>
		/// Builds the table to store all the items in
		/// </summary>
		private void BuildLayout()
		{
			this._top = System.Console.CursorTop;
			System.Console.BackgroundColor = this.BackColor;
			System.Console.ForegroundColor = this.BorderColor;

			BorderCharList list = new BorderCharList(this.BorderStyle);
			Int32 width = (this.GridWidth * this.ItemWidth) + (this.GridWidth - 1);

			if (this._itemMatrix.Length == 0)
				return;


			// LOOP THE ROWS IN THE ITEM MATRIX
			for (Int32 i = 0; i < this._itemMatrix.Length; i++)
			{
				// CHECK IF THIS IS THE FIRST ROW
				if (i == 0)
				{
					System.Console.Write(list.UpperLeft);
					// LOOP EACH ITEM IN THIS ROW
					for (Int32 k = 0; k < this._gridWidth; k++)
					{
						for (Int32 j = 0; j < ItemWidth; j++)
							System.Console.Write(list.OuterHorizontal);
						if ((k + 1) != this._gridWidth)
							System.Console.Write(list.OuterBreakDown);
					}
					System.Console.Write(list.UpperRight + "\n");
				}

				// LOOP THE ITEMS IN THIS ROW
				for (Int32 j = 0; j < this.GridWidth; j++)
				{
					if (j == 0)
						System.Console.Write(list.OuterVertical);

					for (Int32 l = 0; l < this.ItemWidth; l++)
						System.Console.Write(" ");

					if ((j + 1) == this.GridWidth)
						System.Console.Write(list.OuterVertical + "\n");
					else
						System.Console.Write(list.InnerVertical);
				}


				// CHECK IF THIS IS THE LAST ROW
				if ((i + 1) == this._itemMatrix.Length)
				{
					System.Console.Write(list.LowerLeft);
					// LOOP EACH ITEM IN THIS ROW
					for (Int32 k = 0; k < this._gridWidth; k++)
					{
						for (Int32 j = 0; j < ItemWidth; j++)
							System.Console.Write(list.OuterHorizontal);
						if ((k + 1) != this._gridWidth)
							System.Console.Write(list.OuterBreakUp);
					}
					System.Console.Write(list.LowerRight + "\n");
				}
				else
				{
					System.Console.Write(list.OuterBreakRight);
					// LOOP EACH ITEM IN THIS ROW
					for (Int32 k = 0; k < this._gridWidth; k++)
					{
						for (Int32 j = 0; j < ItemWidth; j++)
							System.Console.Write(list.InnerHorizontal);
						if ((k + 1) != this._gridWidth)
							System.Console.Write(list.CrossSection);
					}
					System.Console.Write(list.OuterBreakLeft + "\n");
				}
			}
			this._bottom = System.Console.CursorTop;

		}

		/// <summary>
		/// Places the items in the boxes
		/// </summary>
		private void PlaceItems()
		{
			System.Console.CursorTop = this._top + 1;
			System.Console.CursorLeft = 2;
			// LOOP ITEM ROWS
			for (Int32 i = 0; i < this._itemMatrix.Length; i++)
			{
				System.Console.CursorLeft = 1;
				// LOOP ITEM COLUMNS
				for (Int32 j = 0; j < this._itemMatrix[i].Length; j++)
				{
					Int32 left = System.Console.CursorLeft;

					if (this._itemMatrix[i][j].Selected)
					{
						System.Console.BackgroundColor = this.SelectedBackColor;
						System.Console.ForegroundColor = this.SelectedForeColor;
					}
					else
					{
						System.Console.BackgroundColor = this.ItemBackColor;
						System.Console.ForegroundColor = this.ItemForeColor;
					}
					if (this._itemMatrix[i][j].Text.Length > this.ItemWidth)
						System.Console.Write(this._itemMatrix[i][j].Text.Substring(0, this.ItemWidth));
					else
						System.Console.Write(this._itemMatrix[i][j].Text.PadRight(this.ItemWidth));
					System.Console.CursorLeft = left + ItemWidth + 1;

				}
				System.Console.CursorTop += 2;
				System.Console.BackgroundColor = this.ItemBackColor;
				System.Console.ForegroundColor = this.ItemForeColor;
			}


		}

		/// <summary>
		/// Cleans up the console
		/// </summary>
		private void CleanUp()
		{
			System.Console.CursorTop = this._bottom;
			System.Console.BackgroundColor = System.ConsoleColor.Black;
			System.Console.ForegroundColor = System.ConsoleColor.White;
		}


		#endregion PRIVATE METHODS


		#region PUBLIC METHODS


		/// <summary>
		/// Executes this control in the console
		/// </summary>
		public void Execute()
		{
			System.Console.CursorVisible = false;
			BuildItemMatrix();
			BuildLayout();
			PlaceItems();
			// TRAP USER INPUT
			while (true)
			{
				ConsoleKeyInfo info = System.Console.ReadKey();
				switch (info.Key)
				{
					case System.ConsoleKey.RightArrow:
						// RIGHT ARROW IS SelectedIndex + 1
						SelectedIndex += 1;
						break;
					case System.ConsoleKey.LeftArrow:
						// LEFT ARROW IS SelectedIndex - 1
						SelectedIndex -= 1;
						break;
					case System.ConsoleKey.UpArrow:
						SelectedIndex -= GridWidth;
						break;
					case System.ConsoleKey.DownArrow:
						SelectedIndex += GridWidth;
						break;
					case System.ConsoleKey.Enter:
						CleanUp();
						return;

				}
				// CHECK TO MAKE SURE WE HAVENT NAVIGATED OUTSIDE THE BOUNDS OF THE ITEM MATRIX
				if ((SelectedIndex + 1) > this._items.Count)
					SelectedIndex = (this._items.Count - 1);
				if (SelectedIndex < 0)
					SelectedIndex = 0;

				BuildItemMatrix();
				PlaceItems();
			}
		}


		#endregion PUBLIC METHODS

	}
}
