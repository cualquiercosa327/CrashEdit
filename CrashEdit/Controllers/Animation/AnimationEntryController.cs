using Crash;
using System.Windows.Forms;

namespace CrashEdit
{
    public sealed class AnimationEntryController : EntryController
    {
        public AnimationEntryController(EntryChunkController entrychunkcontroller,AnimationEntry animationentry) : base(entrychunkcontroller,animationentry)
        {
            AnimationEntry = animationentry;
            foreach (Frame frame in animationentry.Frames)
            {
                AddNode(new FrameController(this,frame));
            }
            InvalidateNode();
            InvalidateNodeImage();
        }

        public override void InvalidateNode()
        {
            Node.Text = string.Format("Animation ({0})",AnimationEntry.EName);
        }

        public override void InvalidateNodeImage()
        {
            Node.ImageKey = "limeb";
            Node.SelectedImageKey = "limeb";
        }

        protected override Control CreateEditor()
        {
            ModelEntry modelentry = FindEID<ModelEntry>(AnimationEntry.Frames[0].ModelEID);
            TextureChunk[] texturechunks = new TextureChunk[modelentry.TPAGCount];
            for (int i = 0; i < texturechunks.Length; ++i)
            {
                texturechunks[i] = FindEID<TextureChunk>(BitConv.FromInt32(modelentry.Info,0xC+i*4));
            }
            return new UndockableControl(new AnimationEntryViewer(AnimationEntry.Frames,modelentry,texturechunks));
        }

        public AnimationEntry AnimationEntry { get; }
    }
}
