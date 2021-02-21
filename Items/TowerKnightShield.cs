using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSouls.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class TowerKnightShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded accessory."
				+ "\n" + Language.GetTextValue("CommonItemTooltip.PercentIncreasedDamage", 1900)
				+ "\nOnly equip if your character's name is bluemagic123");
		}

		public override void SetDefaults()
		{
			item.width = 50;
			item.height = 10;
			item.value = 10000;
			item.rare = 11;
			item.accessory = true;
			item.defense = 40;
		}

	}
}

