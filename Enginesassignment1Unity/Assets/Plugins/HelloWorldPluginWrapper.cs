using UnityEngine;
using System.Runtime.InteropServices;

public class HelloWorldPluginWrapper : MonoBehaviour
{
    const string DLL_NAME = "HelloWorldPlugin";

    [DllImport(DLL_NAME)]
    private static extern System.IntPtr SayHello();

    [DllImport(DLL_NAME)]
    private static extern void SetGreeting(string greeting);

    [DllImport(DLL_NAME)]
    private static extern int Add(int first, int second);

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            print(Add(7, 3));
            string greeting = "Hello world!";
            SetGreeting(greeting);
            System.IntPtr intPtr = SayHello();
            string message = Marshal.PtrToStringAnsi(intPtr);

            print(message);
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {
            SetGreeting("Goodbye!");
            string message = Marshal.PtrToStringAnsi(SayHello());

            print(message);
        }
    }
}
