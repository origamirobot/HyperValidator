using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class OptimizerSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private CpuPriority _cpuPriority;
		private Boolean _level2Artworks;
		private Boolean _level1Artworks;
		private Boolean _animatedArtworks;
		private Boolean _waitForSpecial;
		private Boolean _specialBackgrounds;
		private Boolean _level4Backgrounds;
		private Boolean _level3Backgrounds;
		private Boolean _level2Backgrounds;
		private Boolean _level1Backgrounds;
		private Boolean _interBackgrounds;
		private Boolean _animatedBackgrounds;
		private Boolean _imageSmoothing;
		private Quality _quality;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the cpu priority.
		/// </summary>
		public CpuPriority CpuPriority
		{
			get => _cpuPriority;
			set
			{
				if (value == _cpuPriority) return;
				_cpuPriority = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the quality.
		/// </summary>
		public Quality Quality
		{
			get => _quality;
			set
			{
				if (value == _quality) return;
				_quality = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [image smoothing].
		/// </summary>
		public Boolean ImageSmoothing
		{
			get => _imageSmoothing;
			set
			{
				if (value == _imageSmoothing) return;
				_imageSmoothing = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [animated backgrounds].
		/// </summary>
		public Boolean AnimatedBackgrounds
		{
			get => _animatedBackgrounds;
			set
			{
				if (value == _animatedBackgrounds) return;
				_animatedBackgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [inter backgrounds].
		/// </summary>
		public Boolean InterBackgrounds
		{
			get => _interBackgrounds;
			set
			{
				if (value == _interBackgrounds) return;
				_interBackgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level1 backgrounds].
		/// </summary>
		public Boolean Level1Backgrounds
		{
			get => _level1Backgrounds;
			set
			{
				if (value == _level1Backgrounds) return;
				_level1Backgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level2 backgrounds].
		/// </summary>
		public Boolean Level2Backgrounds
		{
			get => _level2Backgrounds;
			set
			{
				if (value == _level2Backgrounds) return;
				_level2Backgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level3 backgrounds].
		/// </summary>
		public Boolean Level3Backgrounds
		{
			get => _level3Backgrounds;
			set
			{
				if (value == _level3Backgrounds) return;
				_level3Backgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level4 backgrounds].
		/// </summary>
		public Boolean Level4Backgrounds
		{
			get => _level4Backgrounds;
			set
			{
				if (value == _level4Backgrounds) return;
				_level4Backgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [special backgrounds].
		/// </summary>
		public Boolean SpecialBackgrounds
		{
			get => _specialBackgrounds;
			set
			{
				if (value == _specialBackgrounds) return;
				_specialBackgrounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [wait for special].
		/// </summary>
		public Boolean WaitForSpecial
		{
			get => _waitForSpecial;
			set
			{
				if (value == _waitForSpecial) return;
				_waitForSpecial = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [animated artworks].
		/// </summary>
		public Boolean AnimatedArtworks
		{
			get => _animatedArtworks;
			set
			{
				if (value == _animatedArtworks) return;
				_animatedArtworks = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level1 artworks].
		/// </summary>
		public Boolean Level1Artworks
		{
			get => _level1Artworks;
			set
			{
				if (value == _level1Artworks) return;
				_level1Artworks = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [level2 artworks].
		/// </summary>
		public Boolean Level2Artworks
		{
			get => _level2Artworks;
			set
			{
				if (value == _level2Artworks) return;
				_level2Artworks = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
