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
	public class HyperSpinSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private MainSettings _main;
		private ResolutionSettings _resolution;
		private OptimizerSettings _optimizer;
		private IntroVideoSettings _introVideo;
		private SoundSettings _sound;
		private AttractModeSettings _attractMode;
		private KeyboardSettings _keyboard;
		private ControlSettings _p1Controls;
		private ControlSettings _p2Controls;
		private JoyStickSettings _p1JoyStick;
		private JoyStickSettings _p2JoyStick;
		private TrackBallSettings _trackBall;
		private SpinnerSettings _spinner;
		private ProgramSettings _startupProgram;
		private ProgramSettings _exitProgram;
		private HiScoreSettings _hiScore;
		private HyperLaunchSettings _hyperLaunch;
		private LedBlinkySettings _ledBlinky;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the main.
		/// </summary>
		public MainSettings Main
		{
			get => _main;
			set
			{
				if (Equals(value, _main)) return;
				_main = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the resolution.
		/// </summary>
		public ResolutionSettings Resolution
		{
			get => _resolution;
			set
			{
				if (Equals(value, _resolution)) return;
				_resolution = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the optimizer.
		/// </summary>
		public OptimizerSettings Optimizer
		{
			get => _optimizer;
			set
			{
				if (Equals(value, _optimizer)) return;
				_optimizer = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the intro video.
		/// </summary>
		public IntroVideoSettings IntroVideo
		{
			get => _introVideo;
			set
			{
				if (Equals(value, _introVideo)) return;
				_introVideo = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the sound.
		/// </summary>
		public SoundSettings Sound
		{
			get => _sound;
			set
			{
				if (Equals(value, _sound)) return;
				_sound = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the attract mode.
		/// </summary>
		public AttractModeSettings AttractMode
		{
			get => _attractMode;
			set
			{
				if (Equals(value, _attractMode)) return;
				_attractMode = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the keyboard.
		/// </summary>
		public KeyboardSettings Keyboard
		{
			get => _keyboard;
			set
			{
				if (Equals(value, _keyboard)) return;
				_keyboard = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the p1 controls.
		/// </summary>
		public ControlSettings P1Controls
		{
			get => _p1Controls;
			set
			{
				if (Equals(value, _p1Controls)) return;
				_p1Controls = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the p2 controls.
		/// </summary>
		public ControlSettings P2Controls
		{
			get => _p2Controls;
			set
			{
				if (Equals(value, _p2Controls)) return;
				_p2Controls = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the p1 joy stick.
		/// </summary>
		public JoyStickSettings P1JoyStick
		{
			get => _p1JoyStick;
			set
			{
				if (Equals(value, _p1JoyStick)) return;
				_p1JoyStick = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the p2 joy stick.
		/// </summary>
		public JoyStickSettings P2JoyStick
		{
			get => _p2JoyStick;
			set
			{
				if (Equals(value, _p2JoyStick)) return;
				_p2JoyStick = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the track ball.
		/// </summary>
		public TrackBallSettings TrackBall
		{
			get => _trackBall;
			set
			{
				if (Equals(value, _trackBall)) return;
				_trackBall = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the spinner.
		/// </summary>
		public SpinnerSettings Spinner
		{
			get => _spinner;
			set
			{
				if (Equals(value, _spinner)) return;
				_spinner = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the startup program.
		/// </summary>
		public ProgramSettings StartupProgram
		{
			get => _startupProgram;
			set
			{
				if (Equals(value, _startupProgram)) return;
				_startupProgram = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the exit program.
		/// </summary>
		public ProgramSettings ExitProgram
		{
			get => _exitProgram;
			set
			{
				if (Equals(value, _exitProgram)) return;
				_exitProgram = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the led blinky.
		/// </summary>
		public LedBlinkySettings LedBlinky
		{
			get => _ledBlinky;
			set
			{
				if (Equals(value, _ledBlinky)) return;
				_ledBlinky = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the hi score.
		/// </summary>
		public HiScoreSettings HiScore
		{
			get => _hiScore;
			set
			{
				if (Equals(value, _hiScore)) return;
				_hiScore = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the hyper launch.
		/// </summary>
		public HyperLaunchSettings HyperLaunch
		{
			get => _hyperLaunch;
			set
			{
				if (Equals(value, _hyperLaunch)) return;
				_hyperLaunch = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="HyperSpinSettings" /> class.
		/// </summary>
		public HyperSpinSettings()
		{
			this.AttractMode = new AttractModeSettings();
			this.ExitProgram = new ProgramSettings();
			this.HiScore = new HiScoreSettings();
			this.HyperLaunch = new HyperLaunchSettings();
			this.IntroVideo = new IntroVideoSettings();
			this.Keyboard = new KeyboardSettings();
			this.LedBlinky = new LedBlinkySettings();
			this.Main = new MainSettings();
			this.Optimizer = new OptimizerSettings();
			this.P1Controls = new ControlSettings();
			this.P1JoyStick = new JoyStickSettings();
			this.P2Controls = new ControlSettings();
			this.P2JoyStick = new JoyStickSettings();
			this.Resolution = new ResolutionSettings();
			this.Sound = new SoundSettings();
			this.Spinner = new SpinnerSettings();
			this.StartupProgram = new ProgramSettings();
			this.TrackBall = new TrackBallSettings();
		}


		#endregion CONSTRUCTORS

	}

}
