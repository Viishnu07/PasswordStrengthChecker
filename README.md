
# Password Strength Checker

## Overview

The Password Strength Checker is a Windows Forms application developed in VB.NET. It evaluates the strength of a password based on various criteria and provides real-time feedback to the user through a progress bar and descriptive labels.

## Features

- **Password Strength Evaluation**: Checks password complexity based on:
  - Presence of lowercase letters
  - Presence of uppercase letters
  - Inclusion of numbers
  - Inclusion of special characters
  - Length of the password
- **Real-Time Feedback**: Provides instant feedback on password strength as the user types.
- **Color-Coded Strength Indicator**: Displays the strength level using color codes ranging from red (weak) to dark green (strong).

## Project Setup

### Prerequisites

- Visual Studio with VB.NET support

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Viishnu07/PasswordStrengthChecker.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd PasswordStrengthChecker
   ```
3. **Open the solution in Visual Studio:**
   - Open the `PasswordStrengthChecker.sln` file.
4. **Restore NuGet packages:**
   - In Visual Studio, go to `Tools` > `NuGet Package Manager` > `Package Manager Console` and run:
   ```bash
   Update-Package -reinstall
   ```
5. **Build the solution:**
   - Press `Ctrl + Shift + B` or select `Build` > `Build Solution` from the menu.

## Usage

To run the Password Strength Checker:

1. **Launch the application:**
   - Press `F5` or select `Debug` > `Start Debugging` in Visual Studio.
2. **Enter a password in the input field** on the form.
3. **View the password strength:**
   - The strength of the password will be displayed in the progress bar and with a descriptive label.

### Password Strength Levels

The strength of a password is evaluated based on the following criteria:

- **Score is incremented by 1** if the password contains any lowercase letter.
- **Score is incremented by 1** if the password contains any uppercase letter.
- **Score is incremented by 1** if the password contains any number.
- **Score is incremented by 1** if the password contains any special character.
- **Score is incremented by 1** if the password length is more than 6 characters.
- **Score is incremented by 1** if the password length is more than 10 characters.
- **Score is incremented by 1** if the password length is more than 15 characters.

The calculated score corresponds to one of the following levels:

- **Invalid**
- **Very Weak**
- **Weak**
- **Better**
- **Medium**
- **Strong**
- **Perfect**

### Color-Coding:

The password strength is visually represented with the following color codes:

- **0-1 (Invalid/Very Weak)**: Red
- **2 (Weak)**: Purple
- **3 (Better)**: Light Green
- **4 (Medium)**: Medium Sea Green
- **5 (Strong)**: Green
- **6 (Perfect)**: Dark Green

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a Pull Request.

## License

This project is licensed under the MIT License.

## Contact

For any questions or feedback, please reach out at viishnu_sreeganesh@yahoo.com
