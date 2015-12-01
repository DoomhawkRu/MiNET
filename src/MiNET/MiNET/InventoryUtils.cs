using System.Collections.Generic;
using fNbt;
using MiNET.Items;
using MiNET.Utils;

namespace MiNET
{
	public static class InventoryUtils
	{
		public static void Clear(this PlayerInventory inv)
		{
			for (int i = 0; i < inv.Slots.Count; ++i)
			{
				if (inv.Slots[i] == null || inv.Slots[i].Id != 0) inv.Slots[i] = new ItemStack();
			}

			if (inv.Helmet.Id != 0) inv.Helmet = new Item(0, 0);
			if (inv.Chest.Id != 0) inv.Chest = new Item(0, 0);
			if (inv.Leggings.Id != 0) inv.Leggings = new Item(0, 0);
			if (inv.Boots.Id != 0) inv.Boots = new Item(0, 0);

			inv.Player.SendPlayerInventory();
		}

		public static MetadataSlots GetCreativeMetadataSlots()
		{
			var slotData = new MetadataSlots();
			for (int i = 0; i < CreativeInventoryItems.Count; i++)
			{
				slotData[i] = new MetadataSlot(CreativeInventoryItems[i]);
			}

			return slotData;
		}

		// GENERATED CODE. DON'T EDIT BY HAND
		public static List<ItemStack> CreativeInventoryItems = new List<ItemStack>()
		{
			new ItemStack(66, 1, 0),
			new ItemStack(27, 1, 0),
			new ItemStack(28, 1, 0),
			new ItemStack(126, 1, 0),
			new ItemStack(4, 1, 0),
			new ItemStack(98, 1, 0),
			new ItemStack(98, 1, 1),
			new ItemStack(98, 1, 2),
			new ItemStack(98, 1, 3),
			new ItemStack(48, 1, 0),
			new ItemStack(5, 1, 0),
			new ItemStack(5, 1, 1),
			new ItemStack(5, 1, 2),
			new ItemStack(5, 1, 3),
			new ItemStack(5, 1, 4),
			new ItemStack(5, 1, 5),
			new ItemStack(45, 1, 0),
			new ItemStack(1, 1, 0),
			new ItemStack(1, 1, 1),
			new ItemStack(1, 1, 2),
			new ItemStack(1, 1, 3),
			new ItemStack(1, 1, 4),
			new ItemStack(1, 1, 5),
			new ItemStack(1, 1, 6),
			new ItemStack(3, 1, 0),
			new ItemStack(243, 1, 0),
			new ItemStack(2, 1, 0),
			new ItemStack(110, 1, 0),
			new ItemStack(82, 1, 0),
			new ItemStack(172, 1, 0),
			new ItemStack(159, 1, 0),
			new ItemStack(159, 1, 1),
			new ItemStack(159, 1, 2),
			new ItemStack(159, 1, 3),
			new ItemStack(159, 1, 4),
			new ItemStack(159, 1, 5),
			new ItemStack(159, 1, 6),
			new ItemStack(159, 1, 7),
			new ItemStack(159, 1, 8),
			new ItemStack(159, 1, 9),
			new ItemStack(159, 1, 10),
			new ItemStack(159, 1, 11),
			new ItemStack(159, 1, 12),
			new ItemStack(159, 1, 13),
			new ItemStack(159, 1, 14),
			new ItemStack(159, 1, 15),
			new ItemStack(24, 1, 0),
			new ItemStack(24, 1, 1),
			new ItemStack(24, 1, 2),
			new ItemStack(12, 1, 0),
			new ItemStack(12, 1, 1),
			new ItemStack(13, 1, 0),
			new ItemStack(139, 1, 0),
			new ItemStack(139, 1, 1),
			new ItemStack(17, 1, 0),
			new ItemStack(17, 1, 1),
			new ItemStack(17, 1, 2),
			new ItemStack(17, 1, 3),
			new ItemStack(162, 1, 0),
			new ItemStack(162, 1, 1),
			new ItemStack(112, 1, 0),
			new ItemStack(87, 1, 0),
			new ItemStack(88, 1, 0),
			new ItemStack(7, 1, 0),
			new ItemStack(67, 1, 0),
			new ItemStack(53, 1, 0),
			new ItemStack(134, 1, 0),
			new ItemStack(135, 1, 0),
			new ItemStack(136, 1, 0),
			new ItemStack(163, 1, 0),
			new ItemStack(164, 1, 0),
			new ItemStack(108, 1, 0),
			new ItemStack(128, 1, 0),
			new ItemStack(109, 1, 0),
			new ItemStack(114, 1, 0),
			new ItemStack(156, 1, 0),
			new ItemStack(44, 1, 0),
			new ItemStack(44, 1, 3),
			new ItemStack(111, 1, 0),
			new ItemStack(158, 1, 0),
			new ItemStack(158, 1, 1),
			new ItemStack(158, 1, 2),
			new ItemStack(158, 1, 3),
			new ItemStack(158, 1, 4),
			new ItemStack(158, 1, 5),
			new ItemStack(44, 1, 4),
			new ItemStack(44, 1, 1),
			new ItemStack(44, 1, 5),
			new ItemStack(44, 1, 6),
			new ItemStack(44, 1, 7),
			new ItemStack(155, 1, 0),
			new ItemStack(155, 1, 2),
			new ItemStack(155, 1, 1),
			new ItemStack(263, 1, 0),
			new ItemStack(263, 1, 1),
			new ItemStack(264, 1, 0),
			new ItemStack(265, 1, 0),
			new ItemStack(266, 1, 0),
			new ItemStack(388, 1, 0),
			new ItemStack(280, 1, 0),
			new ItemStack(281, 1, 0),
			new ItemStack(287, 1, 0),
			new ItemStack(288, 1, 0),
			new ItemStack(318, 1, 0),
			new ItemStack(334, 1, 0),
			new ItemStack(415, 1, 0),
			new ItemStack(337, 1, 0),
			new ItemStack(353, 1, 0),
			new ItemStack(16, 1, 0),
			new ItemStack(15, 1, 0),
			new ItemStack(14, 1, 0),
			new ItemStack(56, 1, 0),
			new ItemStack(21, 1, 0),
			new ItemStack(73, 1, 0),
			new ItemStack(129, 1, 0),
			new ItemStack(153, 1, 0),
			new ItemStack(41, 1, 0),
			new ItemStack(42, 1, 0),
			new ItemStack(57, 1, 0),
			new ItemStack(22, 1, 0),
			new ItemStack(173, 1, 0),
			new ItemStack(133, 1, 0),
			new ItemStack(152, 1, 0),
			new ItemStack(406, 1, 0),
			new ItemStack(49, 1, 0),
			new ItemStack(79, 1, 0),
			new ItemStack(174, 1, 0),
			new ItemStack(80, 1, 0),
			new ItemStack(78, 1, 0),
			new ItemStack(20, 1, 0),
			new ItemStack(89, 1, 0),
			new ItemStack(106, 1, 0),
			new ItemStack(65, 1, 0),
			new ItemStack(19, 1, 0),
			new ItemStack(50, 1, 0),
			new ItemStack(102, 1, 0),
			new ItemStack(325, 1, 0),
			new ItemStack(325, 1, 1),
			new ItemStack(325, 1, 8),
			new ItemStack(325, 1, 10),
			new ItemStack(339, 1, 0),
			new ItemStack(340, 1, 0),
			new ItemStack(262, 1, 0),
			new ItemStack(352, 1, 0),
			new ItemStack(324, 1, 0),
			new ItemStack(427, 1, 0),
			new ItemStack(428, 1, 0),
			new ItemStack(429, 1, 0),
			new ItemStack(430, 1, 0),
			new ItemStack(431, 1, 0),
			new ItemStack(330, 1, 0),
			new ItemStack(96, 1, 0),
			new ItemStack(167, 1, 0),
			new ItemStack(85, 1, 0),
			new ItemStack(85, 1, 1),
			new ItemStack(85, 1, 2),
			new ItemStack(85, 1, 3),
			new ItemStack(85, 1, 4),
			new ItemStack(85, 1, 5),
			new ItemStack(113, 1, 0),
			new ItemStack(107, 1, 0),
			new ItemStack(183, 1, 0),
			new ItemStack(184, 1, 0),
			new ItemStack(185, 1, 0),
			new ItemStack(187, 1, 0),
			new ItemStack(186, 1, 0),
			new ItemStack(101, 1, 0),
			new ItemStack(355, 1, 0),
			new ItemStack(47, 1, 0),
			new ItemStack(321, 1, 0),
			new ItemStack(58, 1, 0),
			new ItemStack(245, 1, 0),
			new ItemStack(54, 1, 0),
			new ItemStack(146, 1, 0),
			new ItemStack(61, 1, 0),
			new ItemStack(379, 1, 0),
			new ItemStack(25, 1, 0),
			new ItemStack(46, 1, 0),
			new ItemStack(121, 1, 0),
			new ItemStack(120, 1, 0),
			new ItemStack(145, 1, 0),
			new ItemStack(145, 1, 4),
			new ItemStack(145, 1, 8),
			new ItemStack(37, 1, 0),
			new ItemStack(38, 1, 0),
			new ItemStack(38, 1, 1),
			new ItemStack(38, 1, 2),
			new ItemStack(38, 1, 3),
			new ItemStack(38, 1, 4),
			new ItemStack(38, 1, 5),
			new ItemStack(38, 1, 6),
			new ItemStack(38, 1, 7),
			new ItemStack(38, 1, 8),
			new ItemStack(175, 1, 0),
			new ItemStack(175, 1, 1),
			new ItemStack(175, 1, 2),
			new ItemStack(175, 1, 3),
			new ItemStack(175, 1, 4),
			new ItemStack(175, 1, 5),
			new ItemStack(39, 1, 0),
			new ItemStack(40, 1, 0),
			new ItemStack(99, 1, 14),
			new ItemStack(100, 1, 14),
			new ItemStack(99, 1, 0),
			new ItemStack(99, 1, 15),
			new ItemStack(81, 1, 0),
			new ItemStack(103, 1, 0),
			new ItemStack(86, 1, 0),
			new ItemStack(91, 1, 0),
			new ItemStack(30, 1, 0),
			new ItemStack(170, 1, 0),
			new ItemStack(338, 1, 0),
			new ItemStack(296, 1, 0),
			new ItemStack(31, 1, 1),
			new ItemStack(31, 1, 2),
			new ItemStack(32, 1, 0),
			new ItemStack(6, 1, 0),
			new ItemStack(6, 1, 1),
			new ItemStack(6, 1, 2),
			new ItemStack(6, 1, 3),
			new ItemStack(6, 1, 4),
			new ItemStack(6, 1, 5),
			new ItemStack(18, 1, 0),
			new ItemStack(18, 1, 1),
			new ItemStack(18, 1, 2),
			new ItemStack(18, 1, 3),
			new ItemStack(161, 1, 0),
			new ItemStack(161, 1, 1),
			new ItemStack(295, 1, 0),
			new ItemStack(361, 1, 0),
			new ItemStack(362, 1, 0),
			new ItemStack(458, 1, 0),
			new ItemStack(344, 1, 0),
			new ItemStack(260, 1, 0),
			new ItemStack(322, 1, 0),
			new ItemStack(466, 1, 0),
			new ItemStack(349, 1, 0),
			new ItemStack(460, 1, 0),
			new ItemStack(461, 1, 0),
			new ItemStack(462, 1, 0),
			new ItemStack(350, 1, 0),
			new ItemStack(463, 1, 0),
			new ItemStack(367, 1, 0),
			new ItemStack(282, 1, 0),
			new ItemStack(297, 1, 0),
			new ItemStack(319, 1, 0),
			new ItemStack(320, 1, 0),
			new ItemStack(365, 1, 0),
			new ItemStack(366, 1, 0),
			new ItemStack(363, 1, 0),
			new ItemStack(364, 1, 0),
			new ItemStack(360, 1, 0),
			new ItemStack(391, 1, 0),
			new ItemStack(392, 1, 0),
			new ItemStack(393, 1, 0),
			new ItemStack(394, 1, 0),
			new ItemStack(354, 1, 0),
			new ItemStack(357, 1, 0),
			new ItemStack(400, 1, 0),
			new ItemStack(411, 1, 0),
			new ItemStack(412, 1, 0),
			new ItemStack(413, 1, 0),
			new ItemStack(378, 1, 0),
			new ItemStack(369, 1, 0),
			new ItemStack(371, 1, 0),
			new ItemStack(396, 1, 0),
			new ItemStack(382, 1, 0),
			new ItemStack(414, 1, 0),
			new ItemStack(370, 1, 0),
			new ItemStack(341, 1, 0),
			new ItemStack(377, 1, 0),
			new ItemStack(372, 1, 0),
			new ItemStack(289, 1, 0),
			new ItemStack(331, 1, 0),
			new ItemStack(348, 1, 0),
			new ItemStack(375, 1, 0),
			new ItemStack(376, 1, 0),
			new ItemStack(397, 1, 0),
			new ItemStack(397, 1, 1),
			new ItemStack(397, 1, 2),
			new ItemStack(397, 1, 3),
			new ItemStack(397, 1, 4),
			new ItemStack(261, 1, 0),
			new ItemStack(346, 1, 0),
			new ItemStack(259, 1, 0),
			new ItemStack(359, 1, 0),
			new ItemStack(323, 1, 0),
			new ItemStack(347, 1, 0),
			new ItemStack(345, 1, 0),
			new ItemStack(328, 1, 0),
			new ItemStack(333, 1, 0),
			new ItemStack(333, 1, 1),
			new ItemStack(333, 1, 2),
			new ItemStack(333, 1, 3),
			new ItemStack(333, 1, 4),
			new ItemStack(333, 1, 5),
			new ItemStack(390, 1, 0),
			new ItemStack(383, 1, 15),
			new ItemStack(383, 1, 10),
			new ItemStack(383, 1, 11),
			new ItemStack(383, 1, 12),
			new ItemStack(383, 1, 13),
			new ItemStack(383, 1, 14),
			new ItemStack(383, 1, 22),
			new ItemStack(383, 1, 16),
			new ItemStack(383, 1, 19),
			new ItemStack(383, 1, 18),
			new ItemStack(383, 1, 33),
			new ItemStack(383, 1, 38),
			new ItemStack(383, 1, 39),
			new ItemStack(383, 1, 34),
			new ItemStack(383, 1, 37),
			new ItemStack(383, 1, 35),
			new ItemStack(383, 1, 32),
			new ItemStack(383, 1, 36),
			new ItemStack(383, 1, 17),
			new ItemStack(383, 1, 40),
			new ItemStack(383, 1, 42),
			new ItemStack(383, 1, 41),
			new ItemStack(383, 1, 43),
			new ItemStack(384, 1, 0),
			new ItemStack(268, 1, 0),
			new ItemStack(290, 1, 0),
			new ItemStack(269, 1, 0),
			new ItemStack(270, 1, 0),
			new ItemStack(271, 1, 0),
			new ItemStack(272, 1, 0),
			new ItemStack(291, 1, 0),
			new ItemStack(273, 1, 0),
			new ItemStack(274, 1, 0),
			new ItemStack(275, 1, 0),
			new ItemStack(267, 1, 0),
			new ItemStack(292, 1, 0),
			new ItemStack(256, 1, 0),
			new ItemStack(257, 1, 0),
			new ItemStack(258, 1, 0),
			new ItemStack(276, 1, 0),
			new ItemStack(293, 1, 0),
			new ItemStack(277, 1, 0),
			new ItemStack(278, 1, 0),
			new ItemStack(279, 1, 0),
			new ItemStack(283, 1, 0),
			new ItemStack(294, 1, 0),
			new ItemStack(284, 1, 0),
			new ItemStack(285, 1, 0),
			new ItemStack(286, 1, 0),
			new ItemStack(298, 1, 0),
			new ItemStack(299, 1, 0),
			new ItemStack(300, 1, 0),
			new ItemStack(301, 1, 0),
			new ItemStack(302, 1, 0),
			new ItemStack(303, 1, 0),
			new ItemStack(304, 1, 0),
			new ItemStack(305, 1, 0),
			new ItemStack(306, 1, 0),
			new ItemStack(307, 1, 0),
			new ItemStack(308, 1, 0),
			new ItemStack(309, 1, 0),
			new ItemStack(310, 1, 0),
			new ItemStack(311, 1, 0),
			new ItemStack(312, 1, 0),
			new ItemStack(313, 1, 0),
			new ItemStack(314, 1, 0),
			new ItemStack(315, 1, 0),
			new ItemStack(316, 1, 0),
			new ItemStack(317, 1, 0),
			new ItemStack(69, 1, 0),
			new ItemStack(123, 1, 0),
			new ItemStack(76, 1, 0),
			new ItemStack(72, 1, 0),
			new ItemStack(70, 1, 0),
			new ItemStack(147, 1, 0),
			new ItemStack(148, 1, 0),
			new ItemStack(143, 1, 5),
			new ItemStack(77, 1, 5),
			new ItemStack(151, 1, 0),
			new ItemStack(131, 1, 0),
			new ItemStack(332, 1, 0),
			new ItemStack(52, 1, 0),
			new ItemStack(116, 1, 0),
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 0), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 1), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 2), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 3), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 4), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 5), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 6), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 7), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 8), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 9), new NbtShort("lvl", 5)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 10), new NbtShort("lvl", 5)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 11), new NbtShort("lvl", 5)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 12), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 12), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 13), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 13), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 14), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 15), new NbtShort("lvl", 5)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 16), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 17), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 18), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 4)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 19), new NbtShort("lvl", 5)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 20), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 20), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 21), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 22), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 23), new NbtShort("lvl", 3)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 1)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 2)}}}},
			new ItemStack(403, 1, 0) {ExtraData = new NbtCompound {new NbtList("ench") {new NbtCompound {new NbtShort("id", 24), new NbtShort("lvl", 3)}}}},
			new ItemStack(35, 1, 0),
			new ItemStack(35, 1, 8),
			new ItemStack(35, 1, 7),
			new ItemStack(35, 1, 15),
			new ItemStack(35, 1, 12),
			new ItemStack(35, 1, 14),
			new ItemStack(35, 1, 1),
			new ItemStack(35, 1, 4),
			new ItemStack(35, 1, 5),
			new ItemStack(35, 1, 13),
			new ItemStack(35, 1, 9),
			new ItemStack(35, 1, 3),
			new ItemStack(35, 1, 11),
			new ItemStack(35, 1, 10),
			new ItemStack(35, 1, 2),
			new ItemStack(35, 1, 6),
			new ItemStack(171, 1, 0),
			new ItemStack(171, 1, 8),
			new ItemStack(171, 1, 7),
			new ItemStack(171, 1, 15),
			new ItemStack(171, 1, 12),
			new ItemStack(171, 1, 14),
			new ItemStack(171, 1, 1),
			new ItemStack(171, 1, 4),
			new ItemStack(171, 1, 5),
			new ItemStack(171, 1, 13),
			new ItemStack(171, 1, 9),
			new ItemStack(171, 1, 3),
			new ItemStack(171, 1, 11),
			new ItemStack(171, 1, 10),
			new ItemStack(171, 1, 2),
			new ItemStack(171, 1, 6),
			new ItemStack(351, 1, 0),
			new ItemStack(351, 1, 8),
			new ItemStack(351, 1, 7),
			new ItemStack(351, 1, 15),
			new ItemStack(351, 1, 12),
			new ItemStack(351, 1, 14),
			new ItemStack(351, 1, 1),
			new ItemStack(351, 1, 4),
			new ItemStack(351, 1, 5),
			new ItemStack(351, 1, 13),
			new ItemStack(351, 1, 9),
			new ItemStack(351, 1, 3),
			new ItemStack(351, 1, 11),
			new ItemStack(351, 1, 10),
			new ItemStack(351, 1, 2),
			new ItemStack(351, 1, 6),
			new ItemStack(374, 1, 0),
			new ItemStack(373, 1, 0),
			new ItemStack(373, 1, 1),
			new ItemStack(373, 1, 2),
			new ItemStack(373, 1, 3),
			new ItemStack(373, 1, 4),
			new ItemStack(373, 1, 5),
			new ItemStack(373, 1, 6),
			new ItemStack(373, 1, 7),
			new ItemStack(373, 1, 8),
			new ItemStack(373, 1, 9),
			new ItemStack(373, 1, 10),
			new ItemStack(373, 1, 11),
			new ItemStack(373, 1, 12),
			new ItemStack(373, 1, 13),
			new ItemStack(373, 1, 14),
			new ItemStack(373, 1, 15),
			new ItemStack(373, 1, 16),
			new ItemStack(373, 1, 17),
			new ItemStack(373, 1, 18),
			new ItemStack(373, 1, 19),
			new ItemStack(373, 1, 20),
			new ItemStack(373, 1, 21),
			new ItemStack(373, 1, 22),
			new ItemStack(373, 1, 23),
			new ItemStack(373, 1, 24),
			new ItemStack(373, 1, 25),
			new ItemStack(373, 1, 26),
			new ItemStack(373, 1, 27),
			new ItemStack(373, 1, 28),
			new ItemStack(373, 1, 29),
			new ItemStack(373, 1, 30),
			new ItemStack(373, 1, 31),
			new ItemStack(373, 1, 32),
			new ItemStack(373, 1, 33),
			new ItemStack(373, 1, 34),
			new ItemStack(373, 1, 35),
			new ItemStack(438, 1, 0),
			new ItemStack(438, 1, 1),
			new ItemStack(438, 1, 2),
			new ItemStack(438, 1, 3),
			new ItemStack(438, 1, 4),
			new ItemStack(438, 1, 5),
			new ItemStack(438, 1, 6),
			new ItemStack(438, 1, 7),
			new ItemStack(438, 1, 8),
			new ItemStack(438, 1, 9),
			new ItemStack(438, 1, 10),
			new ItemStack(438, 1, 11),
			new ItemStack(438, 1, 12),
			new ItemStack(438, 1, 13),
			new ItemStack(438, 1, 14),
			new ItemStack(438, 1, 15),
			new ItemStack(438, 1, 16),
			new ItemStack(438, 1, 17),
			new ItemStack(438, 1, 18),
			new ItemStack(438, 1, 19),
			new ItemStack(438, 1, 20),
			new ItemStack(438, 1, 21),
			new ItemStack(438, 1, 22),
			new ItemStack(438, 1, 23),
			new ItemStack(438, 1, 24),
			new ItemStack(438, 1, 25),
			new ItemStack(438, 1, 26),
			new ItemStack(438, 1, 27),
			new ItemStack(438, 1, 28),
			new ItemStack(438, 1, 29),
			new ItemStack(438, 1, 30),
			new ItemStack(438, 1, 31),
			new ItemStack(438, 1, 32),
			new ItemStack(438, 1, 33),
			new ItemStack(438, 1, 34),
			new ItemStack(438, 1, 35),
		};
	}
}