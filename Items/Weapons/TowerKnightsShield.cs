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
            DisplayName.SetDefault("��� ������ �����");
            Tooltip.SetDefault("���� ��� �� �������� ������� ������� ����������� ������ ����� - ������ ����� ��������." +
                "\n������ ����� ������� ������ �� ��������� � ������. �� ������� ������ ����-�� ������, ����� ���� ����� ��������" +
                "\n��� ��������� �������� � ��������." +
                "\n" +
                "\n��� ����� �������, �� ���������� �������.");
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