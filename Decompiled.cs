    .method public hidebysig instance void g () cil managed 
    {
        .locals init (
            [0] class [mscorlib]System.Action action
        )

        IL_0000: nop
        IL_0001: ldsfld class [mscorlib]System.Action AsyncAwait.Class1/'<>c'::'<>9__6_0'
        IL_0006: dup
        IL_0007: brtrue.s IL_0020

        IL_0009: pop
        IL_000a: ldsfld class AsyncAwait.Class1/'<>c' AsyncAwait.Class1/'<>c'::'<>9'
        IL_000f: ldftn instance void AsyncAwait.Class1/'<>c'::'<g>b__6_0'()
        IL_0015: newobj instance void [mscorlib]System.Action::.ctor(object,  native int)
        IL_001a: dup
        IL_001b: stsfld class [mscorlib]System.Action AsyncAwait.Class1/'<>c'::'<>9__6_0'

        IL_0020: stloc.0
        IL_0021: ret
    }
