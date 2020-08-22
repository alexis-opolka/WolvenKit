using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModStoryBoardAnimationModeStateSbUi_ActorAnimation : CModSbListViewWorkModeStateSbUi_FilteredListSelect
	{
		[RED("actor")] 		public CHandle<CModStoryBoardActor> Actor { get; set;}

		[RED("newAnimation")] 		public SStoryBoardAnimationSettings NewAnimation { get; set;}

		[RED("animStateCallback")] 		public CHandle<CModSbUiAnimModeAnimStateCallback> AnimStateCallback { get; set;}

		public CModStoryBoardAnimationModeStateSbUi_ActorAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModStoryBoardAnimationModeStateSbUi_ActorAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}