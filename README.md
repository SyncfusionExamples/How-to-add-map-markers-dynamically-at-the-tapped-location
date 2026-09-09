# How to add map markers dynamically at the tapped location

In [.NET MAUI SfMaps](https://www.syncfusion.com/maui-controls/maui-maps), you can dynamically add map the map tapped interaction and placing markers at the selected geographic coordinates. This functionality is useful for location selection, point-of-interest mapping, tracking applications, and other interactive map scenarios.

This implementation demonstrates how to capture latitude and longitude values from the tapped location, create map markers dynamically, and update the map layer in real time. The newly added markers are immediately displayed on the map, providing an intuitive and interactive user experience.

**Output**

<img width="404" height="400" alt="xamarin-26649_img1" src="https://github.com/user-attachments/assets/1bc45fc7-ba42-4df2-a65e-dcd5fe02ed4e" />

## Troubleshooting

**Markers are not displayed after tapping the map**

If markers are not visible after tapping the map, ensure that:

- The `Markers` collection is properly initialized.
- The map tap event is correctly subscribed.
- Valid latitude and longitude values are assigned to the marker.
- The marker template is configured correctly.

**Map tiles are not loading**

If the map tiles are not displayed, verify that the tile layer URL template is configured correctly and that the device has an active internet connection.

**Platform-specific permissions**

If your application uses location-related features, ensure that the required permissions are properly configured for the target platform.
