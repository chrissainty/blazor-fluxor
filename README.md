# Blazor-Fluxor
Blazor-Fluxor is a low (zero) boilerplate Flux/Redux library for the new [Microsoft aspdotnet Blazor project]. 

The aim of Fluxor is to create a single-state store approach to front-end development in Blazor without the headaches typically associated with other implementations, such as the overwhelming amount of boiler-plate code required just to add a very basic feature.

## Installation
You can download the latest release / pre-release NuGet packages from the [official Blazor-Fluxor nuget page].

Install the dependencies and devDependencies and start the server.

## Getting started
The easiest way to get started is to look at the [Sample projects]. They are numbered in an order recommended for learning Blazor-Fluxor. Each will have a `readme` file that explains how the sample was created.

### Sample projects
More sample projects will be added as the framework develops.
  - [Counter sample] - Fluxorizes `Counter` page in the standard Visual Studio Blazor sample in order to show how to switch to a Redux/Flux pattern application using Fluxor.
  - [Effects sample] - Fluxorizes `FetchData` page in the standard Visual Studio Blazor sample in order to demonstrate asynchronous reactions to actions that are dispatched.

### New in 0.0.4
  - Changed side-effects to return an array of actions to dispatch rather than limiting it to a single action
  
### New in 0.0.3
  - Added side-effects for calling out to async routines such as HTTP requests
  - Added a sample application to the [Sample projects]
  
### New in 0.0.2
  - Automatic discovery of store, features, and reducers via dependency injection.

### New in 0.0.1
  - Basic store / feature / reducer implementation
  
# License
MIT

   [Official Blazor-Fluxor nuget page]: <https://www.nuget.org/packages/Blazor.Fluxor>
   [Microsoft aspdotnet blazor project]: <https://github.com/aspnet/Blazor>
   [Counter sample]: <https://github.com/mrpmorris/blazor-fluxor/tree/master/samples/01-CounterSample>
   [Effects sample]: <https://github.com/mrpmorris/blazor-fluxor/tree/master/samples/02-WeatherForecastSample>
   [Sample projects]: <https://github.com/mrpmorris/blazor-fluxor/tree/master/samples>
