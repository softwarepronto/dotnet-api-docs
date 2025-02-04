﻿using System;
using System.Data;
using System.Diagnostics;

public class Form1
{
    // <Snippet1>
    //Class-level declaration.
    /* Create a TraceSwitch to use in the entire application.*/
    static TraceSwitch mySwitch = new TraceSwitch("General", "Entire Application");

    static public void MyMethod()
    {
        // Write the message if the TraceSwitch level is set to Info or higher.
        if (mySwitch.TraceInfo)
            Console.WriteLine("My error message.");

        // Write the message if the TraceSwitch level is set to Verbose.
        if (mySwitch.TraceVerbose)
            Console.WriteLine("My second error message.");
    }

    public static void Main(string[] args)
    {
        // Run the method that prints error messages based on the switch level.
        MyMethod();
    }

    // </Snippet1>
}
