using TerraSouls.Tiles
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace TerraSoulsMod.Items
{
    [AutoloadEqiup(EquipType.Shield)]
    public class TowerKnightsShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Щит Рыцаря Башни");
            Tooltip.SetDefault("Этот щит из тяжелого темного серебра принадлежал Рыцарю Башни - стражу замка Террарии." +
                "\nРыцарь Башни защищал Короля от иноземцев и врагов. Но однажды Рыцарь куда-то пропал, после чего замок Террарии" +
                "\nбыл штурмован нечистью и демонами." +
                "\n" +
                "\nЩит очень прочный, но невероятно тяжелый.");
        }
        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 7, 90, 0);
            item.wigth = 300;
            item.height = 300;
            item.accessory = true;

        }
    }
}