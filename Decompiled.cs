    .method public hidebysig instance void b () cil managed 
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [mscorlib]System.Type) = (
            01 00 19 41 73 79 6e 63 41 77 61 69 74 2e 43 6c
            61 73 73 31 2b 3c 62 3e 64 5f 5f 31 00 00
        )
        .custom instance void [mscorlib]System.Diagnostics.DebuggerStepThroughAttribute::.ctor() = (
            01 00 00 00
        )
        .locals init (
            [0] class AsyncAwait.Class1/'<b>d__1' V_0,
            [1] valuetype [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder V_1
        )

        IL_0000: newobj instance void AsyncAwait.Class1/'<b>d__1'::.ctor()
        IL_0005: stloc.0
        IL_0006: ldloc.0
        IL_0007: ldarg.0
        IL_0008: stfld class AsyncAwait.Class1 AsyncAwait.Class1/'<b>d__1'::'<>4__this'
        IL_000d: ldloc.0
        IL_000e: call valuetype [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder::Create()
        IL_0013: stfld valuetype [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder AsyncAwait.Class1/'<b>d__1'::'<>t__builder'
        IL_0018: ldloc.0
        IL_0019: ldc.i4.m1
        IL_001a: stfld int32 AsyncAwait.Class1/'<b>d__1'::'<>1__state'
        IL_001f: ldloc.0
        IL_0020: ldfld valuetype [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder AsyncAwait.Class1/'<b>d__1'::'<>t__builder'
        IL_0025: stloc.1
        IL_0026: ldloca.s V_1
        IL_0028: ldloca.s V_0
        IL_002a: call instance void [mscorlib]System.Runtime.CompilerServices.AsyncVoidMethodBuilder::Start<class AsyncAwait.Class1/'<b>d__1'>(!!0&)
        IL_002f: ret
    }
