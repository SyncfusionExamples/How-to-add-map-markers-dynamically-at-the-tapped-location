# How-to-add-map-markers-dynamically-at-the-tapped-location
A small cross-platform Xamarin.Forms sample that demonstrates adding map markers dynamically at the tapped location.

## Project Overview
This repository contains a runnable sample showing how to handle map tap events and place markers (pins) at the tapped coordinates. The solution includes shared `Xamarin.Forms` code and platform projects for Android, iOS and UWP. Custom renderers provide platform-specific map behavior where needed.

## Features
- Place a marker/pin at the map location where the user taps
- Cross-platform support: Android, iOS, UWP
- Uses custom renderers for native map behavior

## Prerequisites
- Visual Studio with the Xamarin workload installed
- Restore NuGet packages referenced by the solution

## Installation
1. Clone the repository.
2. Open the solution in Visual Studio (`MapMarker_Cooridnate.sln`).
3. Restore NuGet packages and select a target platform.
4. Build and deploy to the emulator or device.

## Usage
- Run the app and tap on the map to add a marker at the tapped coordinates.
- Inspect platform projects for renderer implementations and platform-specific adjustments.

## Contributing
Contributions and improvements are welcome. Please follow the existing project style and submit pull requests with clear descriptions.

---
This README summarizes the sample behavior and workflow for developers exploring dynamic map marker placement across platforms.
