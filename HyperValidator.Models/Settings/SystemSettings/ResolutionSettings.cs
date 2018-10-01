using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class ResolutionSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Decimal _scanLinesAlpha;
		private Int32 _scanLinesScale;
		private String _scanLinesImage;
		private Boolean _scanLinesActive;
		private Int32 _height;
		private Int32 _width;
		private Boolean _fullScreen;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether [full screen].
		/// </summary>
		public Boolean FullScreen
		{
			get => _fullScreen;
			set
			{
				if (value == _fullScreen) return;
				_fullScreen = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		public Int32 Width
		{
			get => _width;
			set
			{
				if (value == _width) return;
				_width = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		public Int32 Height
		{
			get => _height;
			set
			{
				if (value == _height) return;
				_height = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [scan lines active].
		/// </summary>
		public Boolean ScanLinesActive
		{
			get => _scanLinesActive;
			set
			{
				if (value == _scanLinesActive) return;
				_scanLinesActive = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the scan lines image.
		/// </summary>
		public String ScanLinesImage
		{
			get => _scanLinesImage;
			set
			{
				if (value == _scanLinesImage) return;
				_scanLinesImage = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the scan lines scale.
		/// </summary>
		public Int32 ScanLinesScale
		{
			get => _scanLinesScale;
			set
			{
				if (value == _scanLinesScale) return;
				_scanLinesScale = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the scan lines alpha.
		/// </summary>
		public Decimal ScanLinesAlpha
		{
			get => _scanLinesAlpha;
			set
			{
				if (value == _scanLinesAlpha) return;
				_scanLinesAlpha = value;
				OnPropertyChanged();
			}
		}

		#endregion PUBLIC ACCESSORS

	}

}
