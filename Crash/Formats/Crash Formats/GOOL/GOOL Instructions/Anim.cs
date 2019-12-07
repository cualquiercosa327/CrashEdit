﻿namespace Crash.GOOLIns
{
    [GOOLInstruction(131,GameVersion.Crash1)]
    [GOOLInstruction(131,GameVersion.Crash1Beta1995)]
    [GOOLInstruction(131,GameVersion.Crash1BetaMAR08)]
    [GOOLInstruction(131,GameVersion.Crash1BetaMAY11)]
    [GOOLInstruction(56,GameVersion.Crash2)]
    [GOOLInstruction(56,GameVersion.Crash3)]
    public sealed class Anim : GOOLInstruction
    {
        public Anim(int value,GOOLEntry gool) : base(value,gool) { }

        public override string Name => "ANIM";
        public override string Format => "FFFFFFF SSSSSSSSS TTTTTT HH";
        public override string Comment => $"play anim &{GetArg('S')} frame {GetArg('F')} @{GetArg('T')}fps (flip {GetArg('H')})";
    }
}
