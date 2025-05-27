
# VSCode Keyboard-Centric Cheatsheet

> **How to View This File:**
>
> 1. Open the Command Palette: `Ctrl + Shift + P`
> 2. Search for and select: `Markdown: Open Preview to the Side`
> 3. A new tab will open with this document rendered nicely.

---

### Debugging

*Controls for the debugging process. These are active when a debug session is running.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Start Debugging** | `F5` | Launches the debugger for the startup project. |
| **Toggle Breakpoint** | `F9` | Adds or removes a breakpoint on the current line. |
| **Continue** | `F5` | Resumes execution until the next breakpoint or program end. |
| **Step Over** | `F10` | Executes the current line and moves to the next, without entering functions. |
| **Step Into** | `F11` | If the current line is a function call, it moves the debugger inside that function. |
| **Step Out** | `Shift` + `F11` | Finishes executing the current function and stops at the line after the function call. |
| **Stop Debugging** | `Shift` + `F5` | Completely terminates the debugging session. |

---

### General Editing & Navigation (Neovim Mode)

*These commands work when you are in Normal Mode in the editor.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Navigate Autocomplete**| `j` / `k` | Moves up/down in the IntelliSense suggestion list. |
| **Clear Search Highlight**| `Alt` + `C` | Clears the yellow highlight after using `/` to search. |
| **Show Hover Info** | `K` (Shift + k) | Shows type definitions/errors for the symbol under the cursor. |

### Window & Split Management

*Used to manage the editor layout.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Split Vertically (Right)** | `Ctrl` + `Alt` + `L` | Creates a new editor group to the right. |
| **Split Horizontally (Down)**| `Ctrl` + `Alt` + `J` | Creates a new editor group below. |
| **Focus Pane Left/Right/Up/Down** | `Ctrl` + `h`/`l`/`k`/`j` | Navigates between different splits. |
| **Close Active Pane** | `Ctrl` + `Q` | Closes the currently focused editor/split. |

### Fuzzy Finding & "Go To" (Command Palette)

*Your replacement for Telescope. The most important native VSCode navigation tools.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Go to File...** | `Ctrl` + `P` | Fuzzy search for any file in your project. |
| **Go to Symbol in Workspace...**| `Ctrl` + `T` | The "Go to All". Finds any symbol project-wide. |
| **Go to Symbol in Current File...** | `Ctrl` + `Shift` + `O` | Fuzzy search for symbols (methods, etc.) in the open file. |
| **Show All Commands...** | `Ctrl` + `Shift` + `P` | Access and run any VSCode command. |

### Code Diagnostics & IntelliSense

*For interacting with errors, warnings, and suggestions.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Go to Next Problem** | `Alt` + `J` | Jumps to the next error or warning in the file. |
| **Go to Previous Problem** | `Alt` + `K` | Jumps to the previous error or warning in the file. |
| **Show Quick Fixes** | `Ctrl` + `.` or `Alt` + `A` | Opens the code action menu (the lightbulb). |

### File Explorer Management

*These shortcuts are active **only** when the File Explorer sidebar is focused.*

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Focus File Explorer** | `Ctrl` + `N` | Moves focus from the editor to the explorer. |
| **New File** | `a` | *add* a file in the selected directory. |
| **New Folder** | `Shift` + `A` | *Add* a folder in the selected directory. |
| **Rename** | `r` | *rename* the selected file or folder. |
| **Delete** | `d` | *delete* the selected file or folder (asks for confirmation).|
| **Open File & Focus Editor** | `Enter` | Opens the selected file and moves focus to the editor. |

### Code Formatting

| Action | Shortcut | Notes |
| :--- | :--- | :--- |
| **Format Document** | `Alt` + `F` | Formats the entire file according to the configured rules. |