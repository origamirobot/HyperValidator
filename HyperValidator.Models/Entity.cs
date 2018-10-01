using HyperValidator.Models.Annotations;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HyperValidator.Models
{

	/// <summary>
	/// Base abstract class that all entities in the library must implement.
	/// </summary>
	public abstract class Entity : INotifyPropertyChanged
	{

		#region PUBLIC EVENTS


		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;


		#endregion PUBLIC EVENTS

		#region PROTECTED EVENT HANDLERS


		/// <summary>
		/// Called when a property is changed in this object.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		#endregion PROTECTED EVENT HANDLERS



	}

}
