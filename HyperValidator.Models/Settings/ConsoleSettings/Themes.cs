using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings for the theme that this console uses when it's selected.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class Themes : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _useParentVideos;
		private Boolean _useParentThemes;
		private Boolean _animateOutDefault;
		private Boolean _reloadBackground;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether [use parent videos].
		/// </summary>
		public Boolean UseParentVideos
		{
			get => _useParentVideos;
			set
			{
				if (value == _useParentVideos) return;
				_useParentVideos = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use parent themes].
		/// </summary>
		public Boolean UseParentThemes
		{
			get => _useParentThemes;
			set
			{
				if (value == _useParentThemes) return;
				_useParentThemes = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [animate out default].
		/// </summary>
		public Boolean AnimateOutDefault
		{
			get => _animateOutDefault;
			set
			{
				if (value == _animateOutDefault) return;
				_animateOutDefault = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [reload background].
		/// </summary>
		public Boolean ReloadBackground
		{
			get => _reloadBackground;
			set
			{
				if (value == _reloadBackground) return;
				_reloadBackground = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
