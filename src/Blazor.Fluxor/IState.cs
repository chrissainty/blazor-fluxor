﻿using Microsoft.AspNetCore.Blazor.Components;
using System;

namespace Blazor.Fluxor
{
	/// <summary>
	/// An interface that is injected into Blazor Components / pages for accessing
	/// the state of an <see cref="IFeature{TState}"/>
	/// </summary>
	public interface IState
	{
		/// <summary>
		/// Registers a component to be re-rendered whenever the state changes
		/// </summary>
		/// <param name="subscriber">The component that will have <see cref="BlazorComponent.StateHasChanged"/> executed when the state changes</param>
		void Subscribe(BlazorComponent subscriber);
	}

	/// <summary>
	/// An interface that is injected into Blazor Components / pages for accessing
	/// the state of an <see cref="IFeature{TState}"/>
	/// </summary>
	/// <typeparam name="TState">The type of the state</typeparam>
	public interface IState<TState> : IState
	{
		/// <summary>
		/// Returns the current state of the feature
		/// </summary>
		TState Value { get; }
	}
}
