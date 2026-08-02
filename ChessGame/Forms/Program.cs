/*
 * FILE: Program.cs
 * PURPOSE: The standard entry point for the Windows Forms application. It simply launches the MenuForm to start the program.
 * OOP CONCEPT: This follows the principle of Single Responsibility.
 */

namespace ChessGame;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MenuForm());
    }    
}
