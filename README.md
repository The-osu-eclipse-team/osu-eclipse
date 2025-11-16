# osu! eclipse Mobile (Android Entry)

This project enables osu! eclipse on Android devices, with full touch support using osu.Framework.

## Setup & Build

1. **Dependencies**:  
   - .NET 8 SDK  
   - Android workload for .NET 8  
   - Visual Studio 2022+ (Windows) or JetBrains Rider

2. **Directory Structure**
```
osu-eclipse/
├── osu.Eclipse.Mobile/
│   ├── MainActivity.cs
│   ├── Properties/AndroidManifest.xml
│   └── Resources/
│         └── values/styles.xml
│         └── mipmap-*/icon.png
├── osu.Eclipse.Game/    # Shared game logic
...
```

3. **Build & Run**
   - Open `osu.Eclipse.sln` in Visual Studio.
   - Set `osu.Eclipse.Mobile` as startup project.
   - Deploy to Android device or emulator.

4. **Customizing Icons**
   - Replace the placeholder `icon.png` files and launcher XML with your branding.

5. **Extending**
   - Add mobile-only permissions/resources to `AndroidManifest.xml` as needed.
   - Use `MainActivity.OnCreate` for additional mobile init.

## Notes

- All core game logic should live in `osu.Eclipse.Game`.
- Platform-specific features or permissions (storage, audio, etc.) must be declared in `AndroidManifest.xml`.
