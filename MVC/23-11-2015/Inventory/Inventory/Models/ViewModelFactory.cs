using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public static class ViewModelFactory
    {
        public static ItemViewModel CreateItemViewModel(string itemId)
        {
            Item item = ItemRepository.Items.FirstOrDefault(x => x.Id == itemId);
            if (item != null)
            {
                ItemViewModel ivm = new ItemViewModel();
                ivm.ItemData = item;
                Unit unit = UnitRepository.Units.FirstOrDefault(x => x.UnitId == item.UnitId);
                if (unit != null)
                    ivm.UnitName = unit.UnitName;
                ivm.Units = UnitRepository.Units;
                return ivm;
            }
            return null;
        }

        public static List<ItemViewModel> CreateItemListViewModel()
        {
            List<ItemViewModel> list = new List<ItemViewModel>();
            ItemViewModel itemViewModel;
            Unit unit;
            foreach (Item item in ItemRepository.Items)
            {
                itemViewModel = new ItemViewModel();
                itemViewModel.ItemData = item;
                unit = UnitRepository.Units.FirstOrDefault(x => x.UnitId == item.UnitId);
                if (unit != null)
                    itemViewModel.UnitName = unit.UnitName;
                list.Add(itemViewModel);
            }
            return list;
        }

    }
}