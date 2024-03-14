using System.Diagnostics;
using System.Runtime.InteropServices;

Console.WriteLine(StartProcess());

int StartProcess()
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    
    static extern Process process1();
    process1().Start();

    Console.WriteLine("1 - wait till the end of the process");
    Console.WriteLine("2 - abort the process");
    int ans = Convert.ToInt32(Console.ReadLine());
    if (ans == 1)
    {
        process1().WaitForExit();
    }
    else if (ans == 2)
    {
        process1().Kill();
    }
    Console.WriteLine(process1().ExitCode);
    return process1().ExitCode;
}
