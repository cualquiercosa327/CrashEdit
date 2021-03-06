﻿namespace Crash.GOOLIns
{
    [GOOLInstruction(39,GameVersion.Crash1)]
    [GOOLInstruction(39,GameVersion.Crash1Beta1995)]
    [GOOLInstruction(39,GameVersion.Crash1BetaMAR08)]
    [GOOLInstruction(39,GameVersion.Crash1BetaMAY11)]
    [GOOLInstruction(39,GameVersion.Crash2)]
    [GOOLInstruction(39,GameVersion.Crash3)]
    public sealed class Anis : GOOLInstruction
    {
        public Anis(int value,GOOLEntry gool) : base(value,gool) { }

        public override string Name => "ANIS";
        public override string Format => DefaultFormatDS;
        public override string Comment => $"{GetArg('D')} = &anim[{GetArg('S')}]";
    }
}
