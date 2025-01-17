﻿using PostSharp.Aspects;
using PostSharp.Patterns.Model;
using PostSharp.Serialization;

namespace CH09_AopWithPostSharp.Aspects;

[PSerializable]
public class LoggingAspect : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        Console.WriteLine("The {0} method has been entered.", args.Method.Name);
    }

    public override void OnSuccess(MethodExecutionArgs args)
    {
        Console.WriteLine("The {0} method executed successfully.", args.Method.Name);
    }

    public override void OnException(MethodExecutionArgs args)
    {
        Console.WriteLine("An exception was thrown in {0}.", args.Method.Name);
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        Console.WriteLine("The {0} method has exited.", args.Method.Name);
    }
}
