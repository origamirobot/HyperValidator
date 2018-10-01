using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings  for the pointer that points to the selected game
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class Pointer : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _isAnimated;
		private Int32 _x;
		private Int32 _y;
		

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this instance is animated.
		/// </summary>
		public Boolean IsAnimated
		{
			get => _isAnimated;
			set
			{
				if (value == _isAnimated) return;
				_isAnimated = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the x.
		/// </summary>
		public Int32 X
		{
			get => _x;
			set
			{
				if (value == _x) return;
				_x = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the y.
		/// </summary>
		public Int32 Y
		{
			get => _y;
			set
			{
				if (value == _y) return;
				_y = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
