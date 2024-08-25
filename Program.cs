using System;
using System.Diagnostics.CodeAnalysis;

using ScreepsDotNet.API.World;

namespace ScreepsDotNet {
public static partial class Program {
    private static IGame? game;

    [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(Program))]
    public static void Main() {}

    [System.Runtime.Versioning.SupportedOSPlatform("wasi")]
    public static void Init() {
        game = new Native.World.NativeGame();
    }

    [System.Runtime.Versioning.SupportedOSPlatform("wasi")]
    public static void Loop() {
        if (game == null) {
            return;
        }

        game.Tick();
        Console.WriteLine($"Hello world from C#, the current tick is {game.Time}");
    }
}
}
