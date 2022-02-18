using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckEquippedWeaponType : AIItemHandlingCondition
	{
		[Ordinal(0)] 
		[RED("weaponTypeToCheck")] 
		public CName WeaponTypeToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}