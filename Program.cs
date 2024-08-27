using System;
using System.Diagnostics.CodeAnalysis;
using ScreepsDotNet.API.World;



namespace ScreepsDotNet {
public static partial class Program {
    static IGame? _game;

    [DynamicDependency(DynamicallyAccessedMemberTypes.PublicMethods, typeof(Program))]
    public static void Main() {}

    [System.Runtime.Versioning.SupportedOSPlatform("wasi")]
    public static void Init() {
        _game = new Native.World.NativeGame();
        ScreepsMachine.Init(_game);
    }

    [System.Runtime.Versioning.SupportedOSPlatform("wasi")]
    public static void Loop() {
        if (_game == null) {
            return;
        }

        _game.Tick();
        ScreepsMachine.Loop();
    }
}
}
