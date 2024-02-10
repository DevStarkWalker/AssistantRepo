# Assistant Application

The Assistant Application is a customizable application launcher that helps you manage your preferred apps and links for different "launch" modes, such as Game Mode and Work Mode.

## Features

- **Application Launcher:** Quickly launch your specified applications with a single click.
- **Customizable Links:** Add and manage your favorite links for easy access.
- **Mode Switching:** Easily switch between different modes, each with its set of applications and links.
- **Settings Persistence:** Save and load your preferred settings to maintain consistency across sessions.

## Getting Started

1. **Installation:**
    - Clone the repository to your local machine.
    - Open the solution in Visual Studio.

2. **Dependencies:**
    - This project utilizes the MaterialSkin library. Make sure it's installed via NuGet.

3. **Building and Running:**
    - Build and run the project in Visual Studio.

4. **Usage:**
    - Launch the application and customize your preferred apps and links in the settings.
  or
    - Launch the .exe

## Configuration

### Folder Structure

- The application expects a specific folder structure for storing settings.
    ```
    Project Root
    │
    ├── L&P
    │   ├── GameModeLinks.txt
    │   ├── GameModeApps.txt
    │   ├── WorkModeLinks.txt
    │   ├── WorkModeApps.txt
    ```

### Modifying Settings

- Open the Settings Form from the main application.
- Add or remove applications and links for Game Mode and Work Mode.
- Save settings to persist changes.

## Contributing

Feel free to contribute to the project by opening issues or submitting pull requests.


## Acknowledgments

- Thanks to the MaterialSkin library contr
