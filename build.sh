#!/bin/bash

SERVER="screeps.com"
if [ "$2" == 'local' ]; then
    echo a
    SERVER='127_0_0_1___21025'
fi

WASI_SDK_PATH='wasi-sdk-15.0' dotnet publish -c "$1"
cp bin/"$1"/net8.0/wasi-wasm/AppBundle/world/* ~/.config/Screeps/scripts/"$SERVER"/the-screeps-machine/
