using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Terminal
{


	/// <summary>
	/// Creates a banner of text in the console using ASCII text
	/// </summary>
	public class ConsoleBanner
	{


		#region PRIVATE PROPERTIES


		/// <summary>
		/// The foreground color of the console when this control is being executed
		/// </summary>
		/// <value>ConsoleColor.White</value>
		private ConsoleColor _foreColor = ConsoleColor.White;

		/// <summary>
		/// The background color of the console when this control is being executed
		/// </summary>
		/// <value>ConsoleColor.Black</value>
		private ConsoleColor _backColor = ConsoleColor.Black;

		/// <summary>
		/// The text to be rendered in the console as a banner
		/// </summary>
		/// <value>string.Empty</value>
		private String _text = String.Empty;

		/// <summary>
		/// The pallet of characters to use when rendering this text to the console as a banner
		/// </summary>
		private Char[] _pallet = new Char[] { '█', ' ' };

		/// <summary>
		/// The font used when rendering the text as ASCII in the console
		/// </summary>
		/// <value>Arial, 9, FontStyle.Regular, GraphicsUnit.Pixel</value>
		private Font _font = new Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Pixel);

		/// <summary>
		/// The width of this banner in characters
		/// </summary>
		private Int32 _width = 60;

		/// <summary>
		/// The height of this banner in characters
		/// </summary>
		private Int32 _height = 12;

		/// <summary>
		/// 
		/// </summary>
		private Boolean _fontBold = true;


		#endregion PRIVATE PROPERTIES


		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the foreground color of the console when this control is being executed
		/// </summary>
		/// <value>ConsoleColor.White</value>
		public ConsoleColor ForeColor
		{
			get { return _foreColor; }
			set { _foreColor = value; }
		}

		/// <summary>
		/// Gets or sets the background color of the console when this control is being executed
		/// </summary>
		/// <value>ConsoleColor.Black</value>
		public ConsoleColor BackColor
		{
			get { return _backColor; }
			set { _backColor = value; }
		}

		/// <summary>
		/// Gets or sets the text to be rendered in the console as a banner
		/// </summary>
		/// <value>string.Empty</value>
		public String Text
		{
			get { return _text; }
			set { _text = value; }
		}

		/// <summary>
		/// Gets or sets the pallet of characters to use when rendering this text to the console as a banner
		/// </summary>
		public Char[] Pallet
		{
			get { return _pallet; }
			set { _pallet = value; }
		}

		/// <summary>
		/// Gets or sets the font used when rendering the text as ASCII in the console
		/// </summary>
		/// <value>Arial, 9, FontStyle.Regular, GraphicsUnit.Pixel</value>
		public Font Font
		{
			get { return _font; }
			set { _font = value; }
		}

		/// <summary>
		/// Gets or sets the width of this banner in characters
		/// </summary>
		public Int32 Width
		{
			get { return _width; }
			set { _width = value; }
		}

		/// <summary>
		/// Gets or sets the height of this banner in characters
		/// </summary>
		public Int32 Height
		{
			get { return _height; }
			set { _height = value; }
		}


		#endregion PUBLIC ACCESSORS


		#region CONSTRUCTORS


		/// <summary>
		/// Creates an instance of he console banner control
		/// </summary>
		public ConsoleBanner()
		{

		}

		/// <summary>
		/// Creates an instance of he console banner control
		/// </summary>
		public ConsoleBanner(String text)
		{
			this.Text = text;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleBanner"/> class.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <param name="fontSize">Size of the font.</param>
		/// <param name="fontStyle">The font style.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		public ConsoleBanner(String text, String fontFamily, Single fontSize, FontStyle fontStyle, Int32 width, Int32 height)
		{
			this._text = text;
			this.Font = new Font(fontFamily, fontSize, fontStyle);
			this._width = width;
			this._height = height;
		}


		#endregion CONSTRUCTORS


		#region PUBLIC METHODS


		/// <summary>
		/// Executes this control in the console window
		/// </summary>
		public void Execute()
		{
			// CREATE A BLANK IMAGE TO THE SIZE OF THIS CONTROL
			Bitmap map = new Bitmap(this.Width, this.Height);
			Graphics g = Graphics.FromImage(map);
			Brush fillBrush = new SolidBrush(Color.White);
			g.FillRectangle(fillBrush, 0, 0, this.Width, this.Height);
			Brush brush = new SolidBrush(Color.Black);
			Int32 xPos = 0;
			Int32 yPos = 0;
			// DRAW THE STRING ONTO THE BLANK CANVAS
			g.DrawString(this.Text, this.Font, brush, xPos, yPos);
			// DISPOSE OF THE GRAPHICS OBJECT
			g.Dispose();

			String art = String.Empty;
			String line = String.Empty;
			Int32 width = this.Width;
			Int32 height = this.Height;

			Int32 countW = 0;
			Int32 countH = 0;
			// LOOP THE IMAGE PIXEL MATRIX VERTICALLY
			for (countH = 0; countH < height; countH++)
			{
				line = "";
				// LOOP THE IMAGE PIXEL MATRIX HORIZONTALLY
				for (countW = 0; countW < width; countW++)
				{
					// GET THE BRIGHTNESS OF THE CURRENT PIXEL
					Int32 pixelBrightness = Convert.ToInt32(map.GetPixel(countW, countH).GetBrightness() * 100);
					// STEP IS THE PERCENT EACH CHARACTER TAKES IN THE PALLET
					Int32 step = Convert.ToInt32(100 / Pallet.Length);
					Int32 count = 0;
					Char selectedChar = ' ';
					// LOOP OVER ALL THE CHARACTERS IN THE PALLET
					foreach (Char palletValue in Pallet)
					{
						Int32 currentValue = count * step;
						if (currentValue > pixelBrightness)
							break;
						else
							selectedChar = palletValue;
						count++;
					}
					line += selectedChar.ToString();
				}
				//File.AppendAllText(@"C:\Output.txt", line + "\n");
				art += line + "\n";
			}

			// WRITE THE FINISHED ASCII ART TO THE CONSOLE
			System.Console.ForegroundColor = this.ForeColor;
			System.Console.BackgroundColor = this.BackColor;
			System.Console.Write(art);
			// RESET THE CONSOLE COLOR BACK TO THE DEFAULTS
			System.Console.ForegroundColor = ConsoleColor.White;
			System.Console.BackgroundColor = ConsoleColor.Black;
			// DISPOSE OF THE TEMPORARY IMAGE
			map.Dispose();
		}


		#endregion PUBLIC METHODS




	}
}
