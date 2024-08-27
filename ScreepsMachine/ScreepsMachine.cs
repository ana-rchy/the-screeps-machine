using System;
using ScreepsDotNet.API.World;

public struct Screep {
    public Role Role;
}

public static class ScreepsMachine {
    static IGame? _game;

    public static void Init(IGame game) {
        _game = game;
    }

    public static void Loop() {

    }
}
