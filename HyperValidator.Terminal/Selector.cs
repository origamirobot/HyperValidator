using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Terminal
{

	/// <summary>
	/// Represents a select list in the console
	/// </summary>
	public class ConsoleSelectList
	{


		#region PRIVATE PROPERTIES

		private Int32 _firstLine = 0;
		private Int32 _lastLine = 0;
		private ConsoleColor _originalFore = System.Console.ForegroundColor;
		private ConsoleColor _originalBack = System.Console.BackgroundColor;

		#endregion PRIVATE PROPERTIES


		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets the selected item from the list of items in this control
		/// </summary>
		public ConsoleListItem SelectedItem => this.Items[this.SelectedIndex];

		/// <summary>
		/// Gets or sets the background color of the selected item
		/// </summary>
		public ConsoleColor SelectedBackColor { get; set; } = ConsoleColor.DarkBlue;

		/// <summary>
		/// Gets or sets the foreground color of the selected item
		/// </summary>
		public ConsoleColor SelectedForeColor { get; set; } = ConsoleColor.White;

		/// <summary>
		/// Gets or sets the background color of the each non selected item
		/// </summary>
		public ConsoleColor ItemBackColor { get; set; } = ConsoleColor.Black;

		/// <summary>
		/// Gets or sets the foreground color of the each non selected item
		/// </summary>
		public ConsoleColor ItemForeColor { get; set; } = ConsoleColor.White;

		/// <summary>
		/// Gets or sets the background color of the title
		/// </summary>
		public ConsoleColor TitleBackColor { get; set; } = ConsoleColor.DarkBlue;

		/// <summary>
		/// Gets or sets the foreground color of the title
		/// </summary>
		public ConsoleColor TitleForeColor { get; set; } = ConsoleColor.White;

		/// <summary>
		/// Gets or sets the background color of the control
		/// </summary>
		public ConsoleColor BackColor { get; set; } = ConsoleColor.Black;

		/// <summary>
		/// Gets or sets the color of the border
		/// </summary>
		public ConsoleColor BorderColor { get; set; } = ConsoleColor.White;

		/// <summary>
		/// A list of select list items in this control
		/// </summary>
		public List<ConsoleListItem> Items { get; set; } = new List<ConsoleListItem>();

		/// <summary>
		/// The index of the selected item
		/// </summary>
		public Int32 SelectedIndex { get; set; } = 0;

		/// <summary>
		/// The width in characters to display this object
		/// </summary>
		public Int32 Width { get; set; } = 60;

		/// <summary>
		/// Gets or sets the style of the border 
		/// </summary>
		public ConsoleBorderStyle BorderStyle { get; set; } = ConsoleBorderStyle.SingleDouble;

		/// <summary>
		/// Gets the selected items value
		/// </summary>
		public Object SelectedValue => this.Items[SelectedIndex].Value;

		/// <summary>
		/// Gets or sets a value indicating if the title should be shown
		/// </summary>
		public Boolean ShowTitle { get; set; } = false;

		/// <summary>
		/// Gets or sets the title to show at the top of this control
		/// </summary>
		public String Title { get; set; } = String.Empty;

		/// <summary>
		/// Gets or sets the forecolor of this control
		/// </summary>
		public ConsoleColor ForeColor { get; set; } = ConsoleColor.White;


		#endregion PUBLIC ACCESSORS


		#region CONSTRUCTORS


		/// <summary>
		/// Creates an instance of the select list
		/// </summary>
		public ConsoleSelectList()
		{

		}


		#endregion CONSTRUCTORS


		#region PRIVATE METHODS


		/// <summary>
		/// Creates the table that holds the items
		/// </summary>
		private void CreateTable()
		{
			BorderCharList list = new BorderCharList(this.BorderStyle);
			System.Console.ForegroundColor = this.BorderColor;
			System.Console.BackgroundColor = this.BackColor;

			System.Console.Write(list.UpperLeft);
			for (Int32 j = 0; j < this.Width; j++)
				System.Console.Write(list.OuterHorizontal);
			System.Console.Write(list.UpperRight + "\n");

			if (ShowTitle)
			{
				System.Console.Write(list.OuterVertical);
				System.Console.BackgroundColor = this.TitleBackColor;
				System.Console.ForegroundColor = this.TitleForeColor;
				for (Int32 i = 0; i < this.Width; i++)
					System.Console.Write(" ");
				System.Console.CursorLeft = FindCenter(this.Title);
				System.Console.Write(this.Title);
				System.Console.CursorLeft = (this.Width + 1);

				System.Console.ForegroundColor = this.BorderColor;
				System.Console.BackgroundColor = this.BackColor;
				System.Console.Write(list.OuterVertical + "\n");

				System.Console.Write(list.OuterBreakRight);
				for (Int32 j = 0; j < this.Width; j++)
					System.Console.Write(list.InnerHorizontal);
				System.Console.Write(list.OuterBreakLeft + "\n");
			}

			for (Int32 i = 0; i < this.Items.Count; i++)
			{
				System.Console.Write(list.OuterVertical.ToString());
				for (Int32 j = 0; j < this.Width; j++)
					System.Console.Write(" ");
				System.Console.Write(list.OuterVertical + "\n");
				if ((i + 1) != this.Items.Count)
				{
					System.Console.Write(list.OuterBreakRight);
					for (Int32 j = 0; j < this.Width; j++)
						System.Console.Write(list.InnerHorizontal);
					System.Console.Write(list.OuterBreakLeft + "\n");
				}

			}

			System.Console.Write(list.LowerLeft);
			for (Int32 j = 0; j < this.Width; j++)
				System.Console.Write(list.OuterHorizontal);
			System.Console.Write(list.LowerRight + "\n");
			this._lastLine = System.Console.CursorTop;

		}

		/// <summary>
		/// Places the items into the created table
		/// </summary>
		private void PlaceItems()
		{
			System.Console.CursorTop = this._firstLine;
			// LOOP EACH ITEM IN THE ITEMS LIST
			for (Int32 i = 0; i < this.Items.Count; i++)
			{
				System.Console.CursorTop = (i * 2) + this._firstLine + 1;
				System.Console.CursorLeft = 1;
				if (ShowTitle)
					System.Console.CursorTop += 2;
				// CHECK IF THIS IS THE SELECTED ITEM
				if (this.SelectedIndex == i)
				{
					System.Console.BackgroundColor = this.SelectedBackColor;
					System.Console.ForegroundColor = this.SelectedForeColor;
					for (Int32 j = 0; j < this.Width; j++)
						System.Console.Write(" ");
					System.Console.CursorLeft = 1;
					System.Console.Write(" " + this.Items[i].Text);
				}
				else
				{
					System.Console.BackgroundColor = this.ItemBackColor;
					System.Console.ForegroundColor = this.ItemForeColor;
					System.Console.Write(" " + this.Items[i].Text.PadRight((this.Width - 1)));
					System.Console.CursorLeft = 1;
				}
			}
		}

		/// <summary>
		/// Cleans up the console, and returns it back to its original settings
		/// before this control was executed
		/// </summary>
		private void CleanUp()
		{
			// RESET THE CURSOR
			System.Console.CursorVisible = true;
			System.Console.CursorTop = this._lastLine + 2;

			// RESET COLORS BACK TO ORIGINAL COLORS
			System.Console.BackgroundColor = this._originalBack;
			System.Console.ForegroundColor = this._originalFore;
		}

		/// <summary>
		/// Finds the position to put the text in the title
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private Int32 FindCenter(String text)
		{
			Int32 width = this.Width;
			Int32 size = text.Length;
			return Convert.ToInt32(Math.Ceiling(((Double)width / 2)) - Math.Ceiling(((Double)size / 2)));
		}


		#endregion PRIVATE METHODS


		#region PUBLIC METHODS


		/// <summary>
		/// Renders this control to the console
		/// </summary>
		public void Execute()
		{
			this._firstLine = System.Console.CursorTop;
			System.Console.CursorVisible = false;
			// CREATE THE TABLE
			CreateTable();
			// RENDER THE ITEMS
			PlaceItems();
			// TRAP THE KEY STROKES
			while (true)
			{
				// CAPTURE THE KEY THAT WAS PRESSED AND FIND OUT WHAT IT WAS
				System.ConsoleKey key = System.Console.ReadKey().Key;
				switch (key)
				{
					case ConsoleKey.UpArrow: SelectedIndex--; break;
					case ConsoleKey.DownArrow: SelectedIndex++; break;
					case ConsoleKey.RightArrow: SelectedIndex++; break;
					case ConsoleKey.LeftArrow: SelectedIndex--; break;
					case ConsoleKey.Enter:
						CleanUp();
						return;
				}
				// KEEP THE INDEX WITHIN THE RANGE NEEDED
				if ((SelectedIndex + 1) > this.Items.Count)
					SelectedIndex = 0;
				if (SelectedIndex < 0)
					SelectedIndex = this.Items.Count - 1;
				PlaceItems();
			}

		}


		#endregion PUBLIC METHODS


	}


	/// <summary>
	/// Represents a single item in a Console List
	/// </summary>
	public class ConsoleListItem : IComparable<ConsoleListItem>
	{

		#region PRIVATE PROPERTIES


		/// <summary>
		/// The text that is displayed when this item is rendered
		/// </summary>
		private String _text;

		/// <summary>
		/// The value of this item
		/// </summary>
		private Object _value;

		/// <summary>
		/// The width of this list item
		/// </summary>
		private Int32 _width;

		/// <summary>
		/// A value indicating if this item is selected
		/// </summary>
		private Boolean _selected = false;


		#endregion PRIVATE PROPERTIES


		#region PUBLIC ACCESSORS


		/// <summary>
		/// The text that is displayed when this item is rendered
		/// </summary>
		public String Text
		{
			get => _text;
			set => _text = value;
		}

		/// <summary>
		/// The value of this item
		/// </summary>
		public Object Value
		{
			get => _value;
			set => _value = value;
		}

		/// <summary>
		/// The width of this list item
		/// </summary>
		public Int32 Width
		{
			get => _width;
			set => _width = value;
		}

		/// <summary>
		/// Gets or sets a value indicating if this item is selected
		/// </summary>
		public Boolean Selected
		{
			get => _selected;
			set => _selected = value;
		}


		#endregion PUBLIC ACCESSORS


		#region CONSTRUCTORS


		/// <summary>
		/// Creates an instance of the console select item class
		/// </summary>
		public ConsoleListItem()
		{

		}

		/// <summary>
		/// Creates an instance of the console select item class
		/// </summary>
		/// <param name="text">The value to set this instances Text property</param>
		public ConsoleListItem(String text)
		{
			this.Text = text;
		}

		/// <summary>
		/// Creates an instance of the console select item class
		/// </summary>
		/// <param name="text">The value to set this instances Text property</param>
		/// <param name="value">The value to set this instances Value property</param>
		public ConsoleListItem(String text, Object value)
		{
			this.Text = text;
			this.Value = value;
		}


		#endregion CONSTRUCTORS


		#region OVERRIDDEN METHODS


		/// <summary>
		/// Returns a System.String that represents this ConsoleListItem
		/// </summary>
		/// <returns>A System.String that represents this ConsoleListItem</returns>
		public override String ToString()
		{
			return this.Text;
		}


		/// <summary>
		/// Compares the current object with another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		/// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other"/> parameter.Zero This object is equal to <paramref name="other"/>. Greater than zero This object is greater than <paramref name="other"/>.
		/// </returns>
		public Int32 CompareTo(ConsoleListItem other)
		{
			return this.Text.CompareTo(other.Text);
		}



		#endregion OVERRIDDEN METHODS




	}

	/// <summary>
	/// Contains a collection of characters to use when creating borders
	/// </summary>
	public struct BorderCharList
	{


		#region PRIVATE PROPERTIES

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Upper left corner of the outside border
		/// </summary>
		public Char UpperLeft { get; set; }

		/// <summary>
		/// Upper right corner of the outside border
		/// </summary>
		public Char UpperRight { get; set; }

		/// <summary>
		/// Lower left corner of the outside border
		/// </summary>
		public Char LowerLeft { get; set; }

		/// <summary>
		/// Lower right corner of the outside border
		/// </summary>
		public Char LowerRight { get; set; }

		/// <summary>
		/// Vertical outside border
		/// </summary>
		public Char OuterVertical { get; set; }

		/// <summary>
		/// Horizontal outside border
		/// </summary>
		public Char OuterHorizontal { get; set; }

		/// <summary>
		/// Inner vertical border
		/// </summary>
		public Char InnerVertical { get; set; }

		/// <summary>
		/// Inner horizontal border
		/// </summary>
		public Char InnerHorizontal { get; set; }

		/// <summary>
		/// Inner cross section that breaks upward
		/// </summary>
		public Char CrossBreakUp { get; set; }

		/// <summary>
		/// Inner cross section that breaks to the right
		/// </summary>
		public Char CrossBreakRight { get; set; }

		/// <summary>
		/// Inner cross section that breaks to the left
		/// </summary>
		public Char CrossBreakLeft { get; set; }

		/// <summary>
		/// Inner cross section that breaks downward
		/// </summary>
		public Char CrossBreakDown { get; set; }

		/// <summary>
		/// Inner cross section breaking in all four ways
		/// </summary>
		public Char CrossSection { get; set; }

		/// <summary>
		/// Outer border that breaks right
		/// </summary>
		public Char OuterBreakRight { get; set; }

		/// <summary>
		/// Outer border that breaks left
		/// </summary>
		public Char OuterBreakLeft { get; set; }

		/// <summary>
		/// Outer border that breaks downward
		/// </summary>
		public Char OuterBreakDown { get; set; }

		/// <summary>
		/// Outer border that breaks upward
		/// </summary>
		public Char OuterBreakUp { get; set; }

		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Creates an instance of the BorderCharList
		/// </summary>
		/// <param name="style">The style of the border to create a charlist for</param>
		public BorderCharList(ConsoleBorderStyle style)
		{
			switch (style)
			{
				case ConsoleBorderStyle.BlockLine:
					this.CrossBreakDown = '█';
					this.CrossBreakLeft = '█';
					this.CrossBreakRight = '█';
					this.CrossBreakUp = '█';
					this.CrossSection = '█';
					this.InnerHorizontal = '█';
					this.InnerVertical = '█';
					this.LowerLeft = '█';
					this.LowerRight = '█';
					this.OuterHorizontal = '█';
					this.OuterVertical = '█';
					this.UpperLeft = '█';
					this.UpperRight = '█';
					this.OuterBreakRight = '█';
					this.OuterBreakDown = '█';
					this.OuterBreakLeft = '█';
					this.OuterBreakUp = '█';
					break;
				case ConsoleBorderStyle.DoubleLine:
					this.CrossBreakDown = '╦';
					this.CrossBreakLeft = '╣';
					this.CrossBreakRight = '╠';
					this.CrossBreakUp = '╩';
					this.CrossSection = '╬';
					this.InnerHorizontal = '═';
					this.InnerVertical = '║';
					this.LowerLeft = '╚';
					this.LowerRight = '╝';
					this.OuterHorizontal = '═';
					this.OuterVertical = '║';
					this.UpperLeft = '╔';
					this.UpperRight = '╗';
					this.OuterBreakRight = '╠';
					this.OuterBreakDown = '╦';
					this.OuterBreakLeft = '╣';
					this.OuterBreakUp = '╩';
					break;
				case ConsoleBorderStyle.SingleDouble:
					this.CrossBreakDown = '┬';
					this.CrossBreakLeft = '┤';
					this.CrossBreakRight = '├';
					this.CrossBreakUp = '┴';
					this.CrossSection = '┼';
					this.InnerHorizontal = '─';
					this.InnerVertical = '│';
					this.LowerLeft = '╚';
					this.LowerRight = '╝';
					this.OuterHorizontal = '═';
					this.OuterVertical = '║';
					this.UpperLeft = '╔';
					this.UpperRight = '╗';
					this.OuterBreakRight = '╟';
					this.OuterBreakDown = '╤';
					this.OuterBreakLeft = '╢';
					this.OuterBreakUp = '╧';
					break;
				case ConsoleBorderStyle.SingleLine:
					this.CrossBreakDown = '┬';
					this.CrossBreakLeft = '┤';
					this.CrossBreakRight = '├';
					this.CrossBreakUp = '┴';
					this.CrossSection = '┼';
					this.InnerHorizontal = '─';
					this.InnerVertical = '│';
					this.LowerLeft = '└';
					this.LowerRight = '┘';
					this.OuterHorizontal = '─';
					this.OuterVertical = '│';
					this.UpperLeft = '┌';
					this.UpperRight = '┐';
					this.OuterBreakRight = '├';
					this.OuterBreakDown = '┬';
					this.OuterBreakLeft = '┤';
					this.OuterBreakUp = '┴';
					break;
				case ConsoleBorderStyle.None:
					this.CrossBreakDown = ' ';
					this.CrossBreakLeft = ' ';
					this.CrossBreakRight = ' ';
					this.CrossBreakUp = ' ';
					this.CrossSection = ' ';
					this.InnerHorizontal = ' ';
					this.InnerVertical = ' ';
					this.LowerLeft = ' ';
					this.LowerRight = ' ';
					this.OuterHorizontal = ' ';
					this.OuterVertical = ' ';
					this.UpperLeft = ' ';
					this.UpperRight = ' ';
					this.OuterBreakRight = ' ';
					this.OuterBreakDown = ' ';
					this.OuterBreakLeft = ' ';
					this.OuterBreakUp = ' ';
					break;
				default:
					this.CrossBreakDown = '█';
					this.CrossBreakLeft = '█';
					this.CrossBreakRight = '█';
					this.CrossBreakUp = '█';
					this.CrossSection = '█';
					this.InnerHorizontal = '█';
					this.InnerVertical = '█';
					this.LowerLeft = '█';
					this.LowerRight = '█';
					this.OuterHorizontal = '█';
					this.OuterVertical = '█';
					this.UpperLeft = '█';
					this.UpperRight = '█';
					this.OuterBreakRight = '█';
					this.OuterBreakDown = '█';
					this.OuterBreakLeft = '█';
					this.OuterBreakUp = '█';
					break;

			}
		}


		#endregion CONSTRUCTORS

	}

	/// <summary>
	/// 
	/// </summary>
	public enum ConsoleBorderStyle
	{
		None,
		SingleLine,
		SingleDouble,
		DoubleLine,
		BlockLine
	}

}


