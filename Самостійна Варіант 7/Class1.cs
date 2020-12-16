using System;
using System.Collections.Generic;
using System.Linq;

namespace sr_1
{
    class Tablets
    {
        private List<Tablet> tablets = new List<Tablet>();

        public Tablets()
        {
            string[] colors_1 = { "Red", "Blue","Black","White"};
            string[] colors_2 = { "Blue", "Black" };
            string[] colors_3 = { "White",};
            tablets.Add(new Tablet(colors_1, 2020, 12000, 2));
            tablets.Add(new Tablet(colors_1, 2020, 18000, 4));
            tablets.Add(new Tablet(colors_1, 2020, 9000, 3));
            tablets.Add(new Tablet(colors_2, 2019,6000 , 1));
            tablets.Add(new Tablet(colors_3, 2018, 3000, 512));
        }

        public void showInfoAboutTablets()
        {
            foreach (var tablet in tablets)
                tablet.show();
        }
        private void showInfoAboutTablets(in List<sbyte> index)
        {
            for (var i = 0; i < index.Count(); i++)
                tablets[index.ElementAt(i)].show();
        }
        private List<sbyte> indexWithColor(string color)
        {
            List<sbyte> listIndex = new List<sbyte>();
            color = color.ToLower();
            for (var i = 0; i <tablets.Count; i++)
                for (var j = 0; j < tablets[i].colors.Count; j++)
                    if (tablets[i].colors[j].ToLower() == color)
                        listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> indexWithYearOfMade(int yearOfMade)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (tablets[i].yearOfMade == yearOfMade)
                    listIndex.Add((sbyte)i);

            return listIndex;
        }
        private List<sbyte> indexWithPrice(int price)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (tablets[i].price == price)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> indexWithRAM(int ram)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (tablets[i].ram== ram)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> uniteListsOfIndex(in List<sbyte> lb_1, in List<sbyte> lb_2)
        {
            List<sbyte> result = new List<sbyte>();
            if (lb_1.Count != 0 || lb_2.Count != 0)
            {
                foreach (sbyte elem in lb_1)
                    result.Add(elem);
                foreach (sbyte elem in lb_2)
                    result.Add(elem);
            }
            return result;
        }
        private List<sbyte> MyDistinct(in List<sbyte> lb)
        {
            List<sbyte> result = lb;
            for (var i = 0; i < result.Count; i++)
                for (var j = 0; j < result.Count; j++)
                    if (result[i] == result[j] && i != j)
                        result.RemoveAt(j);
            return result;
        }
        private List<sbyte> createListFromDublicatesOfIndex(in List<sbyte> lb)
        {
            List<sbyte> result = new List<sbyte>();
            for (var i = 0; i < lb.Count; i++)
                for (var j = 0; j < lb.Count; j++)
                    if (lb[i] == lb[j] && i != j)
                    {
                        result.Add(lb[i]);
                        break;
                    }
            return MyDistinct(in result);
        }
        public void findTablets(byte amount, string color, int yearOfMade = 0, int price = 0, int ram = 0)
        {
            var WithColor = indexWithColor(color);
            var WithYearOfMade = indexWithYearOfMade(yearOfMade);
            var WithPrice = indexWithPrice(price);
            var WithRAM = indexWithRAM(ram);

            List<sbyte> result = uniteListsOfIndex(in WithColor, in WithYearOfMade);
            result = uniteListsOfIndex(in result, in WithPrice);
            result = uniteListsOfIndex(in result, in WithRAM);
            if (amount != 3)
                result = createListFromDublicatesOfIndex(in result);

            if (result.Count() != 0)
                showInfoAboutTablets(in result);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tНа складе нет нужного вам планшета:");
            }
        }

    }
}